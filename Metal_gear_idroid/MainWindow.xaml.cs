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
using System.Windows.Navigation;
using System.Windows.Shapes;
using WMPLib;

namespace Metal_gear_idroid
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private MessageBoxResult boxResult;

        private WindowsMediaPlayer mediaPlayer1 = new WindowsMediaPlayer();

        private WindowsMediaPlayer mediaPlayer2 = new WindowsMediaPlayer();

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            menu_metal_gear.Source = new Uri(@"http://github.com/uiDesigner00/metal_gear_idroid_files/blob/main/MGS4%20Start%20Menu%20title%20screen%20in%20HD.mp4?raw=true");

            menu_metal_gear.Play();
        }

        private void pulsante_start_Click(object sender, RoutedEventArgs e)
        {
            mediaPlayer2.URL = "https://github.com/uiDesigner00/metal_gear_idroid_files/blob/main/Metal%20Gear%20Solid%20-%20Menu%20Sound.mp3?raw=true";

            mediaPlayer2.controls.play();

            menu_metal_gear.Stop();

            mediaPlayer1.controls.stop();

            var pagina_video = new Pagina_introduttiva_video();

            pagina_video.Show();

            Close();
        }

        private void pulsante_exit_Click(object sender, RoutedEventArgs e)
        {
            mediaPlayer2.URL = "https://github.com/uiDesigner00/metal_gear_idroid_files/blob/main/Metal%20Gear%20Solid%20-%20Menu%20Sound.mp3?raw=true";

            mediaPlayer2.controls.play();

            boxResult = MessageBox.Show("Are you sure do you want exit the application?", "Metal Gear: iDroid", MessageBoxButton.YesNo, MessageBoxImage.Warning);

            if (boxResult == MessageBoxResult.Yes)
            {
                Close();
            }

            else
            {

            }
        }
    }
}
