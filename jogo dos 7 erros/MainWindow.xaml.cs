using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
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

namespace jogo_dos_7_erros
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int contadorClick = 0;

        public MainWindow()
        {
            InitializeComponent();
            condicoesinicias();
        }

        private void Click_1(object sender, MouseButtonEventArgs e)
        {
            erro_1.Visibility = Visibility.Visible;
            click1.Visibility = Visibility.Hidden;
            contadorClick++;
            
            if (verficar_jogo() == true)
            {
                condicoesinicias();
            }
        }

        private void Click_2(object sender, MouseButtonEventArgs e)
        {
            erro_2.Visibility = Visibility.Visible;
            click2.Visibility = Visibility.Hidden;
            contadorClick++;
           
            if (verficar_jogo() == true)
            {
                condicoesinicias();
            }
        }

        private void Click_3(object sender, MouseButtonEventArgs e)
        {
            erro_3.Visibility = Visibility.Visible;
            click3.Visibility = Visibility.Hidden;
            contadorClick++;
            
            if (verficar_jogo() == true)
            {
                condicoesinicias();
            }
        }
        private void Click_4(object sender, MouseButtonEventArgs e)
        {
            erro_4.Visibility = Visibility.Visible;
            click4.Visibility = Visibility.Hidden;
            contadorClick++;
            
            if (verficar_jogo() == true)
            {
                condicoesinicias();
            }
        }

        private void Click_5(object sender, MouseButtonEventArgs e)
        {
            erro_5.Visibility = Visibility.Visible;
            click5.Visibility = Visibility.Hidden;
            contadorClick++;
            
            if (verficar_jogo() == true)
            {
                condicoesinicias();
            }
        }

        private void Click_6(object sender, MouseButtonEventArgs e)
        {
            erro_6.Visibility = Visibility.Visible;
            click6.Visibility = Visibility.Hidden;
            contadorClick++;
           
            if (verficar_jogo() == true)
            {
                condicoesinicias();
            }
        }

        private void Click_7(object sender, MouseButtonEventArgs e)
        {
            erro_7.Visibility = Visibility.Visible;
            click7.Visibility = Visibility.Hidden;
            contadorClick++;
            
            if (verficar_jogo() == true)
            {
                condicoesinicias();
            }
        }


        private bool verficar_jogo()
        {
            if (contadorClick == 7)
            {
                MessageBox.Show("Você encontrou todos os erros Parabéns!", "Parabéns", MessageBoxButton.OK, MessageBoxImage.Information);
                return true;
            }
            else
            {
                return false;
            }
        }

        private void condicoesinicias()
        {
            erro_1.Visibility = Visibility.Hidden;
            erro_2.Visibility = Visibility.Hidden;
            erro_3.Visibility = Visibility.Hidden;
            erro_4.Visibility = Visibility.Hidden;
            erro_5.Visibility = Visibility.Hidden;
            erro_6.Visibility = Visibility.Hidden;
            erro_7.Visibility = Visibility.Hidden;

            click1.Visibility = Visibility.Visible;
            click2.Visibility = Visibility.Visible;
            click3.Visibility = Visibility.Visible;
            click4.Visibility = Visibility.Visible;
            click5.Visibility = Visibility.Visible;
            click6.Visibility = Visibility.Visible;
            click7.Visibility = Visibility.Visible;

            contadorClick = 0;
        }

        private void ClickPato(object sender, MouseButtonEventArgs e)
        {
            Stream audio = Properties.Resources.SomPato;
            SoundPlayer player = new SoundPlayer(audio);
            player.Play();
        }
    }
}
