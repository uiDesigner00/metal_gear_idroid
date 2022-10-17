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
    /// Interaction logic for Pagina_luoghi.xaml
    /// </summary>
    public partial class Pagina_luoghi : Window
    {
        public Pagina_luoghi()
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

        #region lista luoghi selection changed

        private void lista_luoghi_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (lista_luoghi.SelectedIndex)
            {
                case 0:
                    descrizione_luoghi.Text = "The Aerial Command Center was a mobile chopper used by the private military company Diamond Dogs during the 1980s. The ACC acted as an immediate base outside of Mother Base and also ferried Venom Snake and other operatives to various locations.";
                    break;
                case 1:
                    descrizione_luoghi.Text = "Afghanistan, officially known as the Islamic Emirate of Afghanistan, is a land-locked mountainous country located in Central and South Asia, bordered by Pakistan in the east and south, Iran in the west, Turkmenistan, Uzbekistan and Tajikistan in the north, and Zanzibar Land and China in the northeast. As a mountainous region with high elevation, the landscape is dynamic and includes farmland, deserts and valleys.";
                    break;
                case 2:
                    descrizione_luoghi.Text = "Angola-Zaire border region was one of the locations Venom Snake visited in 1984. Three major PFs operated in the area, Contract Forces of Africa, Rogue Coyote and Zero Risk Security. In 1984, a civil war was ongoing in the region between UNITA rebels (backed by western powers and South Africa) and the MPLA government (backed by Cuba and the Soviet Union). Ethnic conflict between Mbele and Buta was a part of the civil war, with Mbele siding with the rebels and Buta with the government.[1] The ethnic conflicts in the region ultimately had their root in the 1884 Berlin Conference where both Angola and Zaire, and presumably the rest of the countries in Africa, had borders drawn by the various European colonial powers with little regard for the inhabitants.[2] It also had prevalent acid rain, which was largely the result of the Mfinda Oilfield emitting smoke containing high concentrations of sulfides while burning impurities.[3][4]";
                    break;
                case 3:
                    descrizione_luoghi.Text = "It was first visible during the March 11, 1984, horseback sequence where Venom Snake fought off the man on fire. The second appearance is seen in the background during one of the final cutscenes in the game with Big Boss and Ocelot, revealing that the player has been playing a body double.";
                    break;
                case 4:
                    descrizione_luoghi.Text = "Dhekelia SBA Memorial Hospital was a military hospital in Cyprus. It was situated, as the name would suggest, in the British Sovereign Base Area of Dhekelia, one of two sovereign base areas created in southern Cyprus in the year 1960.";
                    break;
                case 5:
                    descrizione_luoghi.Text = "A Forward Operating Base (FOB) is any secured forward military position, commonly a military base, that is used to support tactical operations. They may or may not contain an airfield, hospital, or other facilities, and are generally separate from a main operating base by being temporary stations rather than permanent.";
                    break;
                case 6:
                    descrizione_luoghi.Text = "Mother Base was the base of operations for Diamond Dogs, a mercenary unit originally composed of surviving members of the Militaires Sans Frontières and later expanded to include thousands of personnel of various backgrounds. Like the MSF before them, Diamond Dogs' Mother Base was an offshore plant comprised of several connected struts. It was located near the Seychelles off the eastern coast of Africa.";
                    break;
            }
        }
        
        #endregion
    }
}
