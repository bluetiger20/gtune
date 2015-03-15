using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using RibbonInkCanvas.UC;
using RibbonInkCanvas.UC.Sprite;
using RibbonInkCanvas.UC.Sound;
using RibbonInkCanvas.UC.Background;
using System.Diagnostics;
using DockingLibraryDemo;
using DockingLibrary;
namespace RibbonInkCanvas
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int tab_index = 0;
        public TreeViewItem tree_sprite;
        private PropertyWindow propertyWindow = new PropertyWindow();
        private ExplorerWindow explorerWindow = new ExplorerWindow();
        private ListWindow listWindow = new ListWindow();
        DocWindow doc = new DocWindow();
        List<DocWindow> doclist = new List<DocWindow>();

        private int i = 1;
        internal static RecentFiles files = new RecentFiles();
        StackPanel window_panel1 ;
        StackPanel window_panel2 ;
        StackPanel window_panel3 ;
        StackPanel window_panel4;
        public MainWindow()
        {

            

            InitializeComponent();


             window_panel1 = doc.window_panel1;
             window_panel2 = doc.window_panel2;
             window_panel3 = doc.window_panel3;
             window_panel4 = doc.window_panel4;
            #region treeview  //트리뷰에 기본 아이템 추가

            my_treeview_panel sprite = new my_treeview_panel("스프라이트", 1);
            my_treeview_panel background = new my_treeview_panel("백그라운드", 1);
            my_treeview_panel objecta = new my_treeview_panel("오브젝트", 1);
            my_treeview_panel room = new my_treeview_panel("룸", 1);
            my_treeview_panel sound = new my_treeview_panel("사운드", 1);
            my_treeview_panel game_info = new my_treeview_panel("게임 정보", 1);

            tree_sprite = new TreeViewItem();
            TreeViewItem tree_background = new TreeViewItem();
            TreeViewItem tree_objecta = new TreeViewItem();
            TreeViewItem tree_room = new TreeViewItem();
            TreeViewItem tree_sound = new TreeViewItem();
            TreeViewItem tree_game_info = new TreeViewItem();
            TreeView treeView1 = explorerWindow.treeView1;
            tree_sprite.Header = sprite.item;
            tree_background.Header = background.item;
            tree_objecta.Header = objecta.item;
            tree_room.Header = room.item;
            tree_sound.Header = sound.item;
            tree_game_info.Header = game_info.item;
            treeView1.Items.Add(tree_sprite);
            treeView1.Items.Add(tree_background);
            treeView1.Items.Add(tree_objecta);
            treeView1.Items.Add(tree_room);
            treeView1.Items.Add(tree_sound);
            treeView1.Items.Add(tree_game_info);

            #endregion

            #region ADD_contextMenu //  콘텍스트 메뉴에 아이템 추가
            ContextMenu Sprite_ContextMenu = new ContextMenu();
            //Sprite_ContextMenu.Items.Add();
            Contextmenu_Add(Sprite_ContextMenu, tree_sprite, "스프라이트 만들기", "make_sprite_window");
            Contextmenu_Add(Sprite_ContextMenu, tree_sprite, "스프라이트 수정하기", "modify_sprite_window");
            ContextMenu SoundContextMenu = new ContextMenu();
            Contextmenu_Add(SoundContextMenu, tree_sound, "사운드 추가", "new_sound");
            ContextMenu BackgroundContextMenu = new ContextMenu();
            Contextmenu_Add(BackgroundContextMenu, tree_background, "백그라운드 이미지", "background_image");

            #endregion
           

        
        }



        #region dockpanel_manager

        private void OnLoaded(object sender, EventArgs e)
        {
            dockManager.ParentWindow = this;

            //if (!string.IsNullOrEmpty(Properties.Settings.Default.DockingLayoutState))
            //    dockManager2.RestoreLayoutFromXml(Properties.Settings.Default.DockingLayoutState,
            //        new DockingLibrary.GetContentFromTypeString(this.GetContentFromTypeString));
            //else
            {
                //Show PropertyWindow docked to the top border
                propertyWindow.DockManager = dockManager;
                propertyWindow.Show();

                //Show ExplorerWindow docked to the right border as default
                explorerWindow.DockManager = dockManager;
                explorerWindow.Show(Dock.Left);

                //Show ListWindow in documents pane
                listWindow.DockManager = dockManager;
                listWindow.Show();
            }
        }

        private void OnClosing(object sender, EventArgs e)
        {
            Properties.Settings.Default.DockingLayoutState = dockManager.GetLayoutAsXml();
            Properties.Settings.Default.Save();
        }


        private void ShowExplorerWindow(object sender, EventArgs e)
        {
            explorerWindow.Show();
            //dockManager.Show(explorerWindow);
        }

        private void ShowOutputWindow(object sender, EventArgs e)
        {
            //dockManager.Show(outputWindow);
        }

        private void ShowPropertyWindow(object sender, EventArgs e)
        {
            propertyWindow.Show();
            //dockManager.Show(propertyWindow);
        }

        private void ShowListWindow(object sender, EventArgs e)
        {
            listWindow.Show();
            //dockManager.Show(listWindow);
        }

        bool ContainsDocument(string title)
        {
            foreach (DockingLibrary.DocumentContent doc in dockManager.Documents)
                if (string.Compare(doc.Title, title, true) == 0)
                    return true;
            return false;
        }

        private void NewDocument(string title)
        {
            //string title = name;
            //string title = "Document";
            //while (ContainsDocument(title + i.ToString()))
                //i++;
            DocWindow doc = new DocWindow();
            doc.DockManager = dockManager;
            doc.Title = title+(++tab_index).ToString();
            i = tab_index;
            //doc.Title = title + i.ToString();
            
            doc.Show();
           doclist.Add(doc);


            //files.Add(new RecentFile(doc.Title, "PATH" + doc.Title, doc.Title.Length * i));
        }


        private void ExitApplication(object sender, EventArgs e)
        {
            Application.Current.Shutdown();
        }


        private DockingLibrary.DockableContent GetContentFromTypeString(string type)
        {
            if (type == typeof(PropertyWindow).ToString())
                return propertyWindow;
            else if (type == typeof(ExplorerWindow).ToString())
                return explorerWindow;
            else if (type == typeof(ListWindow).ToString())
                return listWindow;

            return null;
        }

        #endregion











        void Contextmenu_Add( ContextMenu mnuContextMenu, TreeViewItem tree_item , string Text, string method)  // 콘텍스트 메뉴 추가하기
        {
            MenuItem a = new MenuItem();
            a.Header = Text;
            switch (method)
            {
                case "modify_sprite_window":
                    a.PreviewMouseLeftButtonDown += modify_sprite_window;
                    break;
                case "make_sprite_window":
                    a.PreviewMouseLeftButtonDown += make_sprite_window;
                    break;
                case "new_sound":
                    a.PreviewMouseLeftButtonDown += new_sound;
                    break;
                case "background_image":
                    a.PreviewMouseLeftButtonDown += background_image;
                    break;
            }

            mnuContextMenu.Items.Add(a);
            tree_item.ContextMenu = mnuContextMenu;

        }



        void new_sound(object sender, MouseButtonEventArgs e)        // 스프라이트 만들기 화면 그리기
        {
           // Clear_stackpanel();
            NewDocument("Sound");

            window_panel1 = doclist[i-1].window_panel1;
            window_panel1.Children.Add(new Sound());

        }

        void make_sprite_window(object sender, MouseButtonEventArgs e)          // 스프라이트 만들기 화면 그리기
        {
            //Clear_stackpanel();

            NewDocument("make_Sprite");


            window_panel1 = doclist[i - 1].window_panel1;
            window_panel2 = doclist[i - 1].window_panel2;
            window_panel3 = doclist[i - 1].window_panel3;

            window_panel1.Children.Add(new UserControl1());
            window_panel2.Children.Add(new UserControl2());
            window_panel3.Children.Add(new UserControl3());
            Grid.SetColumn(window_panel3, 2);
            Grid.SetColumnSpan(window_panel3, 3);

        }

        void modify_sprite_window(object sender, MouseButtonEventArgs e)          // 스프라이트 수정하기 화면 그리기
        {
           // Clear_stackpanel();
            NewDocument("modify_Sprite");
            window_panel1 = doclist[i - 1].window_panel1;
            window_panel2 = doclist[i - 1].window_panel2;

            window_panel1.Children.Add(new Modify_Sprite1());
            window_panel2.Children.Add(new Modify_Sprite2());
            Grid.SetColumn(window_panel2, 1);
            Grid.SetColumnSpan(window_panel2, 3);

        }

        void background_image(object sender, MouseButtonEventArgs e)          // 백그라운드 이미지 화면 그리기
        {
            // Clear_stackpanel();
            NewDocument("background_image");
            window_panel1 = doclist[i - 1].window_panel1;
            window_panel2 = doclist[i - 1].window_panel2;

            window_panel1.Children.Add(new Background_image1());
            window_panel2.Children.Add(new Background_image2());
            Grid.SetColumn(window_panel2, 1);
            Grid.SetColumnSpan(window_panel2, 3);

        }

/*        void Clear_stackpanel()                                      // 오른쪽 화면 모두 지우기
        {
            window_panel1.Children.Clear();
            window_panel2.Children.Clear();
            window_panel3.Children.Clear();
            window_panel4.Children.Clear();

        }*/


        #region command

        private void CloseCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }



        private void SaveCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void NewCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void EraserCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void BrushCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void ColorCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void TwitterCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void FacebookCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void CircleShapeCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void StarShapeCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void CloseCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
        }

        private void SaveCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
        }

        private void NewCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
        }

        private void BrushCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
        }

        private void EraserCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
        }

        private void ColorCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
        }

        private void TwitterCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
        }

        private void FacebookCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
        }

        private void CircleShapeCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
        }

        private void StarShapeCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
        }
        

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            tree_sprite.Items.Add(" ");

        }

        private void RibbonButton_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void RibbonButton_Click_2(object sender, RoutedEventArgs e)
        {
            NewDocument("RibbonBUtton");
        }
        #endregion
    }
}
