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
    /// Interaction logic for Pagina_personaggi.xaml
    /// </summary>
    public partial class Pagina_personaggi : Window
    {
        public Pagina_personaggi()
        {
            InitializeComponent();
        }

        private MessageBoxResult boxResult;

        private Contenuti_multimediali contenuti_Multimediali = new Contenuti_multimediali();

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

        #region lista personaggi selection changed

        private void lista_personaggi_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (lista_personaggi.SelectedIndex)
            {
                case 0:
                    descrizione_personaggi.Text = "Punished Venom Snake, also known as Big Boss, Ahab, V, or Big Boss' phantom, was a combat medic for Militaires Sans Frontières (MSF), who would later become the mercenary commander of Diamond Dogs and Outer Heaven as one of Big Boss' most trusted lieutenants.";
                    break;
                case 1:
                    descrizione_personaggi.Text = "Kazuhira Miller (カズヒラ・ミラー Kazuhira Mirā?), also known as Kaz, McDonell Benedict Miller and Master Miller, was the subcommander of both the Militaires Sans Frontières and Diamond Dogs, and the survival trainer of FOXHOUND. He was well-read and possessed a vast array of scientific knowledge.";
                    break;
                case 2:
                    descrizione_personaggi.Text = "Revolver Ocelot, real name Adamska (Russian: Адамска) or simply Adam (Russian: Адам), and also known as ADAM, Shalashaska (Russian: Шалашаска), or most commonly Ocelot (Russian: Оцелот), was a Russian-American[2] operative of FOXHOUND and an agent of the Patriots. A master of interrogation and a formidable gunfighter, he was often referred to as a ricochet genius in regards to his gun fighting skills. A fanatic, he was known for his affinity towards Spaghetti Westerns, as evidenced by his choice of weapon and his clothing, duster and spurs, the traditional garb of cowboys. His weapon of choice was the Colt Single Action Army Revolver, which he regarded as the greatest handgun ever made.";
                    break;
                case 3:
                    descrizione_personaggi.Text = "Dr. Huey Emmerich was a mechanical engineer responsible for developing bipedal locomotion technology for the Peace Walker Project in 1974 and later served as the chief engineer of Metal Gear Sahelanthropus in 1984. He was the biological father of Hal Otacon Emmerich and the stepfather of Emma E.E. Emmerich. ";
                    break;
                case 4:
                    descrizione_personaggi.Text = "Liquid Snake, real name Eli, also known as White Mamba (Kikongo: Nyoka ya Mpembe), McDonell/Master Miller, or simply Liquid, was the leader of FOXHOUND during the Shadow Moses Incident. He was cloned from Big Boss's DNA as part of the Les Enfants Terribles project, along with his brothers Solid Snake and Solidus Snake. Liquid was led to believe that he had been created in order to express Big Boss's recessive genetic traits, and as such, was inferior to Solid Snake who supposedly had received Big Boss's dominant genes. Liquid therefore held a strong resentment towards Solid and wished to defeat him in combat, reclaiming what he felt was his birthright, and thus proving his superiority.";
                    break;
                case 5:
                    descrizione_personaggi.Text = "Yevgeny Borisovitch Volgin (Russian: Евгений Борисович Волгин), also known as Thunderbolt, was a Soviet GRU colonel, who conspired with the Brezhnev faction and the military in the 1960s to overthrow Nikita Khrushchev and seize power.";
                    break;
                case 6:
                    descrizione_personaggi.Text = "Psycho Mantis was a psychic member of FOXHOUND, who participated in the armed takeover of Shadow Moses Island in 2005. He wore a special gas mask to help prevent people's thoughts from forcing their way into his mind.[3] ";
                    break;
                case 7:
                    descrizione_personaggi.Text = "Quiet, known to the Soviet forces as Tixij (Russian: Тихий, Quiet),[Note][1] was a female assassin during the 1980s. Originally an assassin for XOF, Quiet later defected to Diamond Dogs after being defeated by Venom Snake. Quiet wore a minimal amount of clothing at all times because she could only drink or breathe through her skin following parasite-treatment due to the serious injuries she had sustained while trying to kill Big Boss during the hospital raid; wearing too much clothing would lead to suffocation.";
                    break;
                case 8:
                    descrizione_personaggi.Text = "Code Talker was an elderly Diné (Navajo) biologist who specialized in parasitology that Venom Snake encountered during the 1980s. He was contracted by Skull Face to modify the vocal cord parasite to be used as biological weapons by targeting the languages spoken by ethnic groups. Skull Face then intended to use the parasites to kill Cipher and transform the world in his image by completely eliminating the English language.";
                    break;
                case 9:
                    descrizione_personaggi.Text = "Skull Face was the heavily scarred commander of the paramilitary unit XOF. He secretly commanded XOF from the 1960s up until his death in 1984, at first acting as a covert ally of Naked Snake during the Virtuous Mission and Operation Snake Eater, and later as Cipher's elite strike force until he finally took control of the organization away from Zero. Skull Face also created the Parasite Unit, a group of parasite-enhanced super soldiers that would act as his chief enforcers and high-level operatives for XOF during the 1980s. He suffered extensive injuries in his youth which caused his characteristic facial scars, burns, and discolorations (most notably a Glasgow smile).";
                    break;
                case 10:
                    descrizione_personaggi.Text = "Paz Ortega Andrade, real name Pacifica Ocean, was a Cipher agent who infiltrated the Militaires Sans Frontières during the Peace Walker Incident in 1974.";
                    break;
                case 11:
                    descrizione_personaggi.Text = "Zero (real name David Oh, and formerly known as O, Major Tom, Major Zero and Cipher) was the original commander of CIA Special Forces Unit FOX (Force Operation X) as well as Cipher. His relationship with Big Boss started as a friendship, but later developed into a bitter enmity.";
                    break;
                case 12:
                    descrizione_personaggi.Text = "Big Boss, real name John,[3] also known as Jack, and formerly known as Naked Snake, Vic Boss,[4][5][6] Ishmael, Saladin, or simply Snake, was a renowned special forces operative and mercenary commander. He founded U.S. Army Special Forces Unit FOXHOUND, along with the mercenary company Militaires Sans Frontières, and was one of the founding members of the Patriots. Big Boss later established the military states of Outer Heaven and Zanzibar Land as bases for his companies, in order to realize his ambitions of creating a nation for soldiers. Considered by some as The Greatest Warrior of the 20th Century, he earned such monikers as the Legendary Soldier[7] and the Legendary Mercenary,[8] feared in combat by both friend and foe as a hero and a madman.[9]";
                    break;
            }
        }

        #endregion
    }
}
