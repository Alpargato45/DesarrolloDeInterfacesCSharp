using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
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

namespace PrimerControlUsuarioNET
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
            if (!System.ComponentModel.DesignerProperties.GetIsInDesignMode(this))
            {
                textBox.MaxLength = 50;
                labelMaximoNumero.Content = "50";
            }
        }
        public string textoTexBox { get => textBox.Text; set => textBox.Text = value; }
        public string textoLabel { get => label.Content.ToString(); set => label.Content = value; }
        public string numeroMaximoLabel { get => textBox.MaxLength.ToString(); set => textBox.MaxLength = int.Parse(value); }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            labelMaximoNumero.Content = numeroMaximoLabel.ToString();
            labelCuentaNumero.Visibility = Visibility.Visible;
            labelBarra.Visibility = Visibility.Visible;
            labelMaximoNumero.Visibility = Visibility.Visible;

            int numPorcentaje = (int)((int)int.Parse(numeroMaximoLabel) * 0.25);

            labelCuentaNumero.Content = textBox.Text.Length.ToString();
            if (int.Parse(labelCuentaNumero.Content.ToString()) >= 0 && int.Parse(labelCuentaNumero.Content.ToString()) < numPorcentaje)
            {
                labelCuentaNumero.Foreground = Brushes.Green;
                labelBarra.Foreground = Brushes.Green;
                labelMaximoNumero.Foreground = Brushes.Green;
            } else if (int.Parse(labelCuentaNumero.Content.ToString()) >= numPorcentaje && int.Parse(labelCuentaNumero.Content.ToString()) < numPorcentaje*2)
            {
                labelCuentaNumero.Foreground = Brushes.Yellow;
                labelBarra.Foreground = Brushes.Yellow;
                labelMaximoNumero.Foreground = Brushes.Yellow;
            } else if (int.Parse(labelCuentaNumero.Content.ToString()) >= numPorcentaje*2 && int.Parse(labelCuentaNumero.Content.ToString()) < numPorcentaje*3)
            {
                labelCuentaNumero.Foreground = Brushes.Orange;
                labelBarra.Foreground = Brushes.Orange;
                labelMaximoNumero.Foreground = Brushes.Orange;
            } else if (int.Parse(labelCuentaNumero.Content.ToString()) >= numPorcentaje*3)
            {
                labelCuentaNumero.Foreground = Brushes.Red;
                labelBarra.Foreground = Brushes.Red;
                labelMaximoNumero.Foreground = Brushes.Red;
            }
        }
    }
}
