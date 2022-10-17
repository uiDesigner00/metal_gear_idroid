using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Metal_gear_idroid
{
    /// <summary>
    /// Interaction logic for Pagina_soundtracks.xaml
    /// </summary>
    public partial class Pagina_soundtracks : Window
    {
        public Pagina_soundtracks()
        {
            InitializeComponent();
        }

        private MessageBoxResult boxResult;

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void pulsante_menu_Click(object sender, RoutedEventArgs e)
        {
            boxResult = MessageBox.Show("Are you sure do you want return to the main menu?", "Metal Gear: iDroid", MessageBoxButton.YesNo, MessageBoxImage.Information);

            if (boxResult == MessageBoxResult.Yes)
            {
                var menu_principale = new Pagina_menu_start();
                
                menu_principale.Show();
                
                Close();
            }

            else
            {

            }
        }
    }
}
