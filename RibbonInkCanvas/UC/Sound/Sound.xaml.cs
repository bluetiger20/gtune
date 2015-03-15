using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace gtune.UC.Sound
{
    /// <summary>
    /// Sound.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Sound : UserControl
    {
        string filename = "";
        BackgroundWorker _backgroundWorker = new BackgroundWorker();
        MediaPlayer player = new MediaPlayer();
        public Sound()
        {
            InitializeComponent();
         //   edita.Text="asdgdsg";

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            
          
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
            // Set filter for file extension and default file extension
          //  dlg.DefaultExt = ".jpeg|.png|.jpg";
          //  dlg.Filter = "JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif";


            // Display OpenFileDialog by calling ShowDialog method
            Nullable<bool> result = dlg.ShowDialog();


            // Get the selected file name and display in a TextBox
            if (result == true)
            {
                // Open document
                filename = dlg.FileName;
            }

      




        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            //_backgroundWorker.DoWork += player.Play;
                if (filename != "")
            {
                player.Open(new Uri(filename));
            }
                player.Play();
       
        }
    }
}
