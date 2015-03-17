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
using System.Windows.Navigation;
using System.Windows.Shapes;
using gtune;

namespace gtune.UC.Background
{
    /// <summary>
    /// Background_image1.xaml에 대한 상호 작용 논리
    /// </summary>
    /// 
  

    public partial class Background_image1 : UserControl
    {
        private MainWindow form;


        public Background_image1(MainWindow form)
        {
            InitializeComponent();
            this.form = form;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string myUri = "";
            myUri = openfile_dialog(myUri);

            if(myUri!=""){
            Byte[] buffer;
            buffer = System.IO.File.ReadAllBytes(myUri);
            MemoryStream ms = new MemoryStream(buffer);

            BitmapImage img = new BitmapImage();
            img.BeginInit();
            img.CacheOption = BitmapCacheOption.OnLoad;
            img.StreamSource = ms;
            img.EndInit();

            form.uc_Background_image2.Background_image.Source = img;
            img_width.Text = img.Width.ToString();
            img_height.Text = img.Height.ToString();
            }

        }

        private string openfile_dialog(string filename) //파일 다이얼로그 열기
        {

            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
            // Set filter for file extension and default file extension
            dlg.DefaultExt = ".jpeg|.png|.jpg";
            dlg.Filter = "JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif";


            // Display OpenFileDialog by calling ShowDialog method
            Nullable<bool> result = dlg.ShowDialog();


            // Get the selected file name and display in a TextBox
            if (result == true)
            {
                // Open document
                filename = dlg.FileName;
            }

            return filename;
        }
    }
}
