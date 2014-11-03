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

namespace POD_Szyfr_Playfair
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Instrukcja : Window
    {
        public Instrukcja()
        {
            InitializeComponent();
        }

        private void Close(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Minimalize(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void Play(object sender, RoutedEventArgs e)
        {
            video.Play();
            video.IsEnabled = true;

        }

        private void Stop(object sender, RoutedEventArgs e)
        {
            video.Pause();
            video.IsEnabled = false;

        }
    }
}
