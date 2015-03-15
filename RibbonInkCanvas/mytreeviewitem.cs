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
using gtune.UC;



namespace gtune
{

    public class my_treeview_panel
    {

        private string title;
        Image image;                                          
        public StackPanel item;
        public my_treeview_panel(string title, int image_src)
        {
            this.title = title;
            item = new StackPanel { Orientation = Orientation.Horizontal };

            switch (image_src)
            {
                    
                case 1:
                    image = new Image();
                    image.Source = new BitmapImage(new Uri(@"\Images\Transfer.png", UriKind.Relative));
                    image.Width = 10;
                    image.Height = 10;
                    break;
                default:
                    break;
            }
            item.Children.Add(image);
            item.Children.Add(new TextBlock { Text = title });

        }
    }


}
