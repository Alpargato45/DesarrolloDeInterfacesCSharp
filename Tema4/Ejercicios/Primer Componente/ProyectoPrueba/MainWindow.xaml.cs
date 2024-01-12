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

namespace ProyectoPrueba
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

        private void btnCalcular_Click(object sender, RoutedEventArgs e)
        {
            Primer_Componente.Calculadora calculadora = new Primer_Componente.Calculadora();
            int num1 = 0;
            int num2 = 0;
            try
            {

            
            num1 = int.Parse(textBox1.Text);
            num2 = int.Parse(textBox2.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, introduce valores numéricos válidos en ambos TextBoxes.");
                textBox1.Text = string.Empty;
                textBox2.Text = string.Empty;
            }
            textBlock.Text = "Tu suma es: " + calculadora.Suma(num1, num2);
        }
    }
}
