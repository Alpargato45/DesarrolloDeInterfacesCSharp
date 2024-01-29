using System;
using System.Collections;
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

namespace PruebaComponentes
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, RoutedEventArgs e)
        {
            List<string> lista = personalizado.DevolverLista;
            string elementoConMasLetras = lista.OrderByDescending(s => s.Length).First();
            txtBox.Text = elementoConMasLetras;
            //No me ha dado tiempo ha hacer el timer pero se haria con Task.Delay(2000)
            
        }
    }
}
