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
using System.Windows.Threading;

namespace WpfApp7
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public Thermostat Talonlampo = new Thermostat();
        public Lights Olohuone = new Lights();
        public Lights Keittio = new Lights();
        public Sauna talo = new Sauna();

        public char Astemerkki;

        public MainWindow()
        {
            InitializeComponent();
            Astemerkki = Convert.ToChar(176);
        }




        private void BtnOloHimm_Click(object sender, RoutedEventArgs e)
        {
            Olohuone.Valot33(33);
            TxtOloNayta.Text = Olohuone.Dimmer + "%";

        }

        private void BtnOloPuoli_Click(object sender, RoutedEventArgs e)
        {
            Olohuone.Valot66(66);
            TxtOloNayta.Text = Olohuone.Dimmer + "%";
        }

        private void BtnOloKirkas_Click(object sender, RoutedEventArgs e)
        {
            Olohuone.Valot100(100);
            TxtOloNayta.Text = Olohuone.Dimmer + "%";
        }

        private void BtnOloKatk_Click(object sender, RoutedEventArgs e)
        {
            Olohuone.Dimmer = "0";
            TxtOloNayta.Text = "Valot pois päältä";
        }

        private void BtnKeHimm_Click(object sender, RoutedEventArgs e)
        {

            Keittio.Valot33(33);
            TxtKeNayta.Text = Keittio.Dimmer + "%";
        }

        private void BtnKePuoli_Click(object sender, RoutedEventArgs e)
        {
            Keittio.Valot66(66);
            TxtKeNayta.Text = Keittio.Dimmer + "%";
        }

        private void BtnKeKirkas_Click(object sender, RoutedEventArgs e)
        {
            Keittio.Valot100(100);
            TxtKeNayta.Text = Keittio.Dimmer + "%";
        }

        private void BtnKeKatk_Click(object sender, RoutedEventArgs e)
        {
            Keittio.Dimmer = "0";
            TxtKeNayta.Text = "Valot pois päältä";
        }

        private void BtnTalonLamp_Click(object sender, RoutedEventArgs e)
        {
            int Tavoitelampotila;
            try
            {
                Tavoitelampotila = Int32.Parse(TxtTaloAsetLamp.Text);
                Talonlampo.AsetaLampotila(Tavoitelampotila);
                TxtTaloLampo.Text = Talonlampo.Temperature.ToString() + Astemerkki;
                TxtTaloAsetLamp.Text = "";
            }
            catch
            {
                TxtTaloAsetLamp.Text = "Anna numero";
            }
        }

        private void RbutSaunaOff_Checked(object sender, RoutedEventArgs e)
        {

            {

            }
        }

        private void BtnSaunaOn_Click(object sender, RoutedEventArgs e)
        {
            if (talo.Switched == true)
            {
                TxtSauna.Text = "Sauna päällä";
            }
            if (talo.Switched == false)
            {
                talo.SaunaPaalle();
                TxtSauna.Text = "Sauna päällä";
            }

            else
            {
                talo.SaunaPois();
                TxtSauna.Text = "Sauna pois päältä";
            }

               
            
        
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void BtnSaunaOn_Copy_Click(object sender, RoutedEventArgs e)
        {
            if (talo.Switched == true)
            {
                talo.SaunaPois();
                TxtSauna.Text = "Sauna pois päältä";
            }
            if(talo.Switched== false)
            {
                TxtSauna.Text = "Sauna pois päältä";
            }
        }
    }
}
        

       
        

                     
    
