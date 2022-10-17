using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Threading;
using WMPLib;

namespace Metal_gear_idroid
{
    /// <summary>
    /// Interaction logic for Pagina_menu_start.xaml
    /// </summary>
    public partial class Pagina_menu_start : Window
    {
        public Pagina_menu_start()
        {
            InitializeComponent();
        }

        private MessageBoxResult boxResult;

        private WindowsMediaPlayer mediaPlayer1 = new WindowsMediaPlayer();

        private WindowsMediaPlayer mediaPlayer2 = new WindowsMediaPlayer();

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            mediaPlayer1.URL = "https://github.com/uiDesigner00/metal_gear_idroid_files/blob/main/Metal%20Gear%20Solid%20Peace%20Walker%20(MOTHER%20BASE%20OST%20EXTENDED).mp3?raw=true";

            mediaPlayer1.controls.play();

            voce_soundtracks.IsEnabled = false;

            voce_places.IsEnabled = false;
        }

        #region elenco voci menu preview mouse down

        private void elenco_voci_menu_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            mediaPlayer2.URL = "https://github.com/uiDesigner00/metal_gear_idroid_files/blob/main/Metal%20Gear%20Solid%20-%20Menu%20Sound.mp3?raw=true";

            mediaPlayer2.controls.play();

            switch (elenco_voci_menu.SelectedIndex)
            {
                case 0:
                    mediaPlayer1.controls.stop();
                    var menu_cassette = new Pagina_cassette();
                    menu_cassette.Show();
                    Close();
                    break;
                case 1:
                    mediaPlayer1.controls.stop();
                    var menu_soundtracks = new Pagina_soundtracks();
                    menu_soundtracks.Show();
                    Close();
                    break;
                case 2:
                    mediaPlayer1.controls.stop();
                    var menu_personaggi = new Pagina_personaggi();
                    menu_personaggi.Show();
                    Close();
                    break;
                case 3:
                    mediaPlayer1.controls.stop();
                    var menu_luoghi = new Pagina_luoghi();
                    menu_luoghi.Show();
                    Close();
                    break;
                case 4:
                    boxResult = MessageBox.Show("Are you sure do you want install additional contents?", "Metal Gear: iDroid", MessageBoxButton.YesNo, MessageBoxImage.Warning);

                    if (boxResult == MessageBoxResult.Yes)
                    {
                        mediaPlayer1.controls.stop();

                        installazione_metal_gear.Source = new Uri(@"http://github.com/uiDesigner00/metal_gear_idroid_files/blob/main/Metal%20Gear%20Solid%204%20-%20Old%20Snake%20Smoking.mp4?raw=true");

                        installazione_metal_gear.Play();
                    }

                    else
                    {

                    }

                    break;
                case 5:
                    boxResult = MessageBox.Show("Are you sure do you want return to the start screen?", "Metal Gear: iDroid", MessageBoxButton.YesNo, MessageBoxImage.Warning);

                    if (boxResult == MessageBoxResult.Yes)
                    {
                        mediaPlayer1.controls.stop();

                        var menu_start = new MainWindow();

                        menu_start.Show();

                        Close();
                    }

                    else
                    {

                    }

                    break;
            }
        }


        #endregion

        private void installazione_metal_gear_MediaEnded(object sender, RoutedEventArgs e)
        {
            voce_soundtracks.IsEnabled = true;

            voce_characters.IsEnabled = true;

            voce_places.IsEnabled = true;
        }
    }
}
