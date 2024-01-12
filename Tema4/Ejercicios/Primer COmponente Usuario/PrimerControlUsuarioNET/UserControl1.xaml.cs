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
        }
        public string getTextView { get => textBox.Text; set => textBox.Text = value; }
        public string getLabel { get => label.Content.ToString(); set => label.Content = value; }
        public string getMaximoNumero { get => labelMaximoNumero.Content.ToString(); set => labelMaximoNumero.Content = value; }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            textBox.MaxLength = int.Parse(labelMaximoNumero.Content.ToString());
            labelCuentaNumero.Content = textBox.Text.Length.ToString();
            if (int.Parse(labelCuentaNumero.Content.ToString()) >= 0 && int.Parse(labelCuentaNumero.Content.ToString()) < 20)
            {
                labelCuentaNumero.Foreground = Brushes.Green;
                labelBarra.Foreground = Brushes.Green;
                labelMaximoNumero.Foreground = Brushes.Green;
            }
            if (int.Parse(labelCuentaNumero.Content.ToString()) >= 20 && int.Parse(labelCuentaNumero.Content.ToString()) < 35)
            {
                labelCuentaNumero.Foreground = Brushes.Yellow;
                labelBarra.Foreground = Brushes.Yellow;
                labelMaximoNumero.Foreground = Brushes.Yellow;
            }
            if (int.Parse(labelCuentaNumero.Content.ToString()) >= 35 && int.Parse(labelCuentaNumero.Content.ToString()) < 45)
            {
                labelCuentaNumero.Foreground = Brushes.Orange;
                labelBarra.Foreground = Brushes.Orange;
                labelMaximoNumero.Foreground = Brushes.Orange;
            }
            if (int.Parse(labelCuentaNumero.Content.ToString()) >= 45)
            {
                labelCuentaNumero.Foreground = Brushes.Red;
                labelBarra.Foreground = Brushes.Red;
                labelMaximoNumero.Foreground = Brushes.Red;
            }
        }
    }
}
