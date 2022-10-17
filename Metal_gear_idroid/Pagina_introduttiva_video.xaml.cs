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
    /// Interaction logic for Pagina_introduttiva_video.xaml
    /// </summary>
    public partial class Pagina_introduttiva_video : Window
    {
        public Pagina_introduttiva_video()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            sigla_metal_gear.Source = new Uri(@"http://github.com/uiDesigner00/metal_gear_idroid_files/blob/main/mgs_peacewalker_intro_ufficiale.mp4?raw=true");

            sigla_metal_gear.Play();
        }

        private void sigla_metal_gear_MediaEnded(object sender, RoutedEventArgs e)
        {
            var menu_start = new Pagina_menu_start();

            menu_start.Show();

            Close();
        }

        private void salta_filmato_Click(object sender, RoutedEventArgs e)
        {
            sigla_metal_gear.Stop();

            var menu_start = new Pagina_menu_start();

            menu_start.Show();

            Close();
        }
    }
}
