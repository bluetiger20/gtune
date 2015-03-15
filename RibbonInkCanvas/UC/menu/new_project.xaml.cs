using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using Path = System.Windows.Shapes.Path;

namespace RibbonInkCanvas.UC.menu
{
    /// <summary>
    /// new_project.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class new_project : Window
    {
        public new_project()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            create_new_project();
        }


        void create_new_project()                                           //프로젝트 만들기
        {   
            string project_root = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments);
            project_root = project_root + "\\" + project_name.Text;
            Console.WriteLine("path : "+project_root);
          //  path1 = path1 + "\\temp";
            // Create drectory temp1 if it doesn't exist
            DirectoryInfo di = new DirectoryInfo(project_root);  //Create Directoryinfo value by sDirPath  

            if (di.Exists == false)   //If New Folder not exits  
            {
                di.Create();             //create Folder  
                

                                                                                                            //서브 디렉토리 만들기
                string sprite= project_root + "\\sprite";
                Directory.CreateDirectory(sprite);
                string background= project_root + "\\background";
                Directory.CreateDirectory(background);
            }  
        }
    }
}
