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
using System.Media;
using Wpf_PrimeraApp.Class;

namespace Wpf_PrimeraApp
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        carro carrito;

        

        public MainWindow()
        {
            carrito = new carro("Prado", 2015, "Corinto", 250);
            InitializeComponent();
        }
        

        //BUTTON_ENCENDER
        private void buttonencender_Click(object sender, RoutedEventArgs e)
        {
            Labelencender.Content = carrito.EncendidoMotor();
        }


        //BUTTON_ACELERAR
        private void buttonacelarar_Click(object sender, RoutedEventArgs e)
        {

            Labelacelerar.Content = carrito.acelerar();
        }

        //BUTTON_FRENAR
        private void buttonfrenar_Click(object sender, RoutedEventArgs e)
        {
            Labelfreno.Content= carrito.desacelerar();
        }


        //BUTON_BOCINA
        private void buttonBocina_Click(object sender, RoutedEventArgs e)
        {
            SoundPlayer simplsound = new SoundPlayer();
            simplsound.Play();
            MessageBox.Show("pi piiiiiiip");
        }

        //BUTTON_RADIO
        private void buttonradio_Click(object sender, RoutedEventArgs e)
        {
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = "C:/Users/dell/Downloads/Te Conocí en Japón.wav";
            player.Play();

        }

        //BUTTON_APAGAR
        private void buttonapagar_Click(object sender, RoutedEventArgs e)
        {
            Labelapagar.Content = carrito.apagarmotor(); 
        }
    }
}