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
    /// Interaction logic for Pagina_cassette.xaml
    /// </summary>
    public partial class Pagina_cassette : Window
    {
        public Pagina_cassette()
        {
            InitializeComponent();
        }

        private Contenuti_multimediali contenuti_Multimediali = new Contenuti_multimediali();

        private MessageBoxResult boxResult;

        private bool isdragging = false;

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            tempo_cassetta.Text = "0.00 / 0.00";
        }

        #region elenco cassette preview mouse down

        private void elenco_cassette_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            
        }

        #endregion

        #region elenco cassette selection changed

        private void elenco_cassette_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (elenco_cassette.SelectedIndex)
            {
                case 0:
                    cassetta_prodotta.Source = new Uri(contenuti_Multimediali.ob1);
                    avviso_cassetta.Text = $"REPRODUCING: {elenco_cassette.SelectedItem}";
                    break;
                case 1:
                    cassetta_prodotta.Source = new Uri(contenuti_Multimediali.ob2);
                    avviso_cassetta.Text = $"REPRODUCING: {elenco_cassette.SelectedItem}";
                    break;
                case 2:
                    cassetta_prodotta.Source = new Uri(contenuti_Multimediali.ob3);
                    avviso_cassetta.Text = $"REPRODUCING: {elenco_cassette.SelectedItem}";
                    break;
                case 3:
                    cassetta_prodotta.Source = new Uri(contenuti_Multimediali.at1);
                    avviso_cassetta.Text = $"REPRODUCING: {elenco_cassette.SelectedItem}";
                    break;
                case 4:
                    cassetta_prodotta.Source = new Uri(contenuti_Multimediali.tmof1);
                    avviso_cassetta.Text = $"REPRODUCING: {elenco_cassette.SelectedItem}";
                    break;
                case 5:
                    cassetta_prodotta.Source = new Uri(contenuti_Multimediali.amb1);
                    avviso_cassetta.Text = $"REPRODUCING: {elenco_cassette.SelectedItem}";
                    break;
                case 6:
                    cassetta_prodotta.Source = new Uri(contenuti_Multimediali.at2);
                    avviso_cassetta.Text = $"REPRODUCING: {elenco_cassette.SelectedItem}";
                    break;
                case 7:
                    cassetta_prodotta.Source = new Uri(contenuti_Multimediali.amb2);
                    avviso_cassetta.Text = $"REPRODUCING: {elenco_cassette.SelectedItem}";
                    break;
                case 8:
                    cassetta_prodotta.Source = new Uri(contenuti_Multimediali.watombm);
                    avviso_cassetta.Text = $"REPRODUCING: {elenco_cassette.SelectedItem}";
                    break;
                case 9:
                    cassetta_prodotta.Source = new Uri(contenuti_Multimediali.amb3);
                    avviso_cassetta.Text = $"REPRODUCING: {elenco_cassette.SelectedItem}";
                    break;
                case 10:
                    cassetta_prodotta.Source = new Uri(contenuti_Multimediali.at3);
                    avviso_cassetta.Text = $"REPRODUCING: {elenco_cassette.SelectedItem}";
                    break;
                case 11:
                    cassetta_prodotta.Source = new Uri(contenuti_Multimediali.amb4);
                    avviso_cassetta.Text = $"REPRODUCING: {elenco_cassette.SelectedItem}";
                    break;
                case 12:
                    cassetta_prodotta.Source = new Uri(contenuti_Multimediali.q1);
                    avviso_cassetta.Text = $"REPRODUCING: {elenco_cassette.SelectedItem}";
                    break;
                case 13:
                    cassetta_prodotta.Source = new Uri(contenuti_Multimediali.amb5);
                    avviso_cassetta.Text = $"REPRODUCING: {elenco_cassette.SelectedItem}";
                    break;
                case 14:
                    cassetta_prodotta.Source = new Uri(contenuti_Multimediali.q2);
                    avviso_cassetta.Text = $"REPRODUCING: {elenco_cassette.SelectedItem}";
                    break;
                case 15:
                    cassetta_prodotta.Source = new Uri(contenuti_Multimediali.qh1);
                    avviso_cassetta.Text = $"REPRODUCING: {elenco_cassette.SelectedItem}";
                    break;
                case 16:
                    cassetta_prodotta.Source = new Uri(contenuti_Multimediali.aft1);
                    avviso_cassetta.Text = $"REPRODUCING: {elenco_cassette.SelectedItem}";
                    break;
                case 17:
                    cassetta_prodotta.Source = new Uri(contenuti_Multimediali.q3);
                    avviso_cassetta.Text = $"REPRODUCING: {elenco_cassette.SelectedItem}";
                    break;
                case 18:
                    cassetta_prodotta.Source = new Uri(contenuti_Multimediali.q4);
                    avviso_cassetta.Text = $"REPRODUCING: {elenco_cassette.SelectedItem}";
                    break;
                case 19:
                    cassetta_prodotta.Source = new Uri(contenuti_Multimediali.qh2);
                    avviso_cassetta.Text = $"REPRODUCING: {elenco_cassette.SelectedItem}";
                    break;
                case 20:
                    cassetta_prodotta.Source = new Uri(contenuti_Multimediali.aft2);
                    avviso_cassetta.Text = $"REPRODUCING: {elenco_cassette.SelectedItem}";
                    break;
                case 21:
                    cassetta_prodotta.Source = new Uri(contenuti_Multimediali.q5); 
                    avviso_cassetta.Text = $"REPRODUCING: {elenco_cassette.SelectedItem}";
                    break;
                case 22:
                    cassetta_prodotta.Source = new Uri(contenuti_Multimediali.cpcr1);
                    avviso_cassetta.Text = $"REPRODUCING: {elenco_cassette.SelectedItem}";
                    break;
                case 23:
                    cassetta_prodotta.Source = new Uri(contenuti_Multimediali.aft3);
                    avviso_cassetta.Text = $"REPRODUCING: {elenco_cassette.SelectedItem}";
                    break;
                case 24:
                    cassetta_prodotta.Source = new Uri(contenuti_Multimediali.cpcr2);
                    avviso_cassetta.Text = $"REPRODUCING: {elenco_cassette.SelectedItem}";
                    break;
                case 25:
                    cassetta_prodotta.Source = new Uri(contenuti_Multimediali.aft4);
                    avviso_cassetta.Text = $"REPRODUCING: {elenco_cassette.SelectedItem}";
                    break;
                case 26:
                    cassetta_prodotta.Source = new Uri(contenuti_Multimediali.pdc1);
                    avviso_cassetta.Text = $"REPRODUCING: {elenco_cassette.SelectedItem}";
                    break;
                case 27:
                    cassetta_prodotta.Source = new Uri(contenuti_Multimediali.tfotd);
                    avviso_cassetta.Text = $"REPRODUCING: {elenco_cassette.SelectedItem}";
                    break;
                case 28:
                    cassetta_prodotta.Source = new Uri(contenuti_Multimediali.twm1);
                    avviso_cassetta.Text = $"REPRODUCING: {elenco_cassette.SelectedItem}";
                    break;
                case 29:
                    cassetta_prodotta.Source = new Uri(contenuti_Multimediali.twm2);
                    avviso_cassetta.Text = $"REPRODUCING: {elenco_cassette.SelectedItem}";
                    break;
                case 30:
                    cassetta_prodotta.Source = new Uri(contenuti_Multimediali.pdc2);
                    avviso_cassetta.Text = $"REPRODUCING: {elenco_cassette.SelectedItem}";
                    break;
                case 31:
                    cassetta_prodotta.Source = new Uri(contenuti_Multimediali.ambs1);
                    avviso_cassetta.Text = $"REPRODUCING: {elenco_cassette.SelectedItem}";
                    break;
                case 32:
                    cassetta_prodotta.Source = new Uri(contenuti_Multimediali.ambs2);
                    avviso_cassetta.Text = $"REPRODUCING: {elenco_cassette.SelectedItem}";
                    break;
                case 33:
                    cassetta_prodotta.Source = new Uri(contenuti_Multimediali.vcp1);
                    avviso_cassetta.Text = $"REPRODUCING: {elenco_cassette.SelectedItem}";
                    break;
                case 34:
                    cassetta_prodotta.Source = new Uri(contenuti_Multimediali.vcp2);
                    avviso_cassetta.Text = $"REPRODUCING: {elenco_cassette.SelectedItem}";
                    break;
                case 35:
                    cassetta_prodotta.Source = new Uri(contenuti_Multimediali.ma1);
                    avviso_cassetta.Text = $"REPRODUCING: {elenco_cassette.SelectedItem}";
                    break;
                case 36:
                    cassetta_prodotta.Source = new Uri(contenuti_Multimediali.ma2);
                    avviso_cassetta.Text = $"REPRODUCING: {elenco_cassette.SelectedItem}";
                    break;
                case 37:
                    cassetta_prodotta.Source = new Uri(contenuti_Multimediali.s1);
                    avviso_cassetta.Text = $"REPRODUCING: {elenco_cassette.SelectedItem}";
                    break;
                case 38:
                    cassetta_prodotta.Source = new Uri(contenuti_Multimediali.s2);
                    avviso_cassetta.Text = $"REPRODUCING: {elenco_cassette.SelectedItem}";
                    break;
                case 39:
                    cassetta_prodotta.Source = new Uri(contenuti_Multimediali.s3);
                    avviso_cassetta.Text = $"REPRODUCING: {elenco_cassette.SelectedItem}";
                    break;
                case 40:
                    cassetta_prodotta.Source = new Uri(contenuti_Multimediali.ma3);
                    avviso_cassetta.Text = $"REPRODUCING: {elenco_cassette.SelectedItem}";
                    break;
                case 50:
                    cassetta_prodotta.Source = new Uri(contenuti_Multimediali.ctahr1);
                    avviso_cassetta.Text = $"REPRODUCING: {elenco_cassette.SelectedItem}";
                    break;
                case 51:
                    cassetta_prodotta.Source = new Uri(contenuti_Multimediali.sfo1);
                    avviso_cassetta.Text = $"REPRODUCING: {elenco_cassette.SelectedItem}";
                    break;
                case 52:
                    cassetta_prodotta.Source = new Uri(contenuti_Multimediali.pdc3);
                    avviso_cassetta.Text = $"REPRODUCING: {elenco_cassette.SelectedItem}";
                    break;
                case 53:
                    cassetta_prodotta.Source = new Uri(contenuti_Multimediali.tmof2);
                    avviso_cassetta.Text = $"REPRODUCING: {elenco_cassette.SelectedItem}";
                    break;
                case 54:
                    cassetta_prodotta.Source = new Uri(contenuti_Multimediali.ma4);
                    avviso_cassetta.Text = $"REPRODUCING: {elenco_cassette.SelectedItem}";
                    break;
                case 55:
                    cassetta_prodotta.Source = new Uri(contenuti_Multimediali.ctahr2);
                    avviso_cassetta.Text = $"REPRODUCING: {elenco_cassette.SelectedItem}";
                    break;
                case 56:
                    cassetta_prodotta.Source = new Uri(contenuti_Multimediali.sfo2);
                    avviso_cassetta.Text = $"REPRODUCING: {elenco_cassette.SelectedItem}";
                    break;
                case 57:
                    cassetta_prodotta.Source = new Uri(contenuti_Multimediali.thokm1);
                    avviso_cassetta.Text = $"REPRODUCING: {elenco_cassette.SelectedItem}";
                    break;
                case 58:
                    cassetta_prodotta.Source = new Uri(contenuti_Multimediali.ctahr3); // code talker and his research 3
                    avviso_cassetta.Text = $"REPRODUCING: {elenco_cassette.SelectedItem}";
                    break;
            }
        }

        #endregion

        #region media player cassette

        private void cassetta_prodotta_MediaOpened(object sender, RoutedEventArgs e)
        {
            // aggiornare lo slider e il tempo

            metraggio_cassetta.Value = 0;

            tempo_cassetta.Text = $"{cassetta_prodotta.Position} / {cassetta_prodotta.NaturalDuration}";
        }

        private void cassetta_prodotta_MediaEnded(object sender, RoutedEventArgs e)
        {
            metraggio_cassetta.Value = 0;

            tempo_cassetta.Text = "0.00 / 0.00";

            avviso_cassetta.Text = "SELECT A TAPE";
        }

        #endregion

        #region slider cassette

        private void metraggio_cassetta_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            cassetta_prodotta.Position = TimeSpan.FromMinutes(metraggio_cassetta.Value);

            if (isdragging)
            {
                tempo_cassetta.Text = $"{cassetta_prodotta.Position} / {cassetta_prodotta.NaturalDuration}";
            }

            if (cassetta_prodotta.Position > cassetta_prodotta.NaturalDuration)
            {
                cassetta_prodotta.Stop();

                tempo_cassetta.Text = $"0 / {cassetta_prodotta.NaturalDuration}";
            }

            else
            {
                tempo_cassetta.Text = $"{cassetta_prodotta.Position} / {cassetta_prodotta.NaturalDuration}";

                cassetta_prodotta.Play();
            }
        }

        private void metraggio_cassetta_DragStarted(object sender, System.Windows.Controls.Primitives.DragStartedEventArgs e)
        {
            isdragging = true;
        }

        private void metraggio_cassetta_DragCompleted(object sender, System.Windows.Controls.Primitives.DragCompletedEventArgs e)
        {
            isdragging = false;
        }

        #endregion

        private void cassetta_precedente_Click(object sender, RoutedEventArgs e)
        {
            elenco_cassette.SelectedIndex--;
        }

        private void cassetta_pausa_Click(object sender, RoutedEventArgs e)
        {
            cassetta_prodotta.SpeedRatio = 0;
        }

        private void cassetta_riprendi_Click(object sender, RoutedEventArgs e)
        {
            cassetta_prodotta.SpeedRatio = 1;
        }

        private void casssetta_successiva_Click(object sender, RoutedEventArgs e)
        {
            elenco_cassette.SelectedIndex++;
        }

        private void torna_menu_principale_Click(object sender, RoutedEventArgs e)
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
