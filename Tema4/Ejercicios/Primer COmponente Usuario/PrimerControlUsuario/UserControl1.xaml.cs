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

namespace PrimerControlUsuario
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        public string getTextView {  get => textBox.Text; set => textBox.Text = value; }
        public string getLabel { get => label.Content.ToString(); set => label.Content = value; }
        public string getMaximoNumero { get => labelMaximoNumero.Content.ToString(); set => labelMaximoNumero.Content = value; }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            textBox.MaxLength = int.Parse(textBox.Text);
            labelCuentaNumero.Content = textBox.Text.Length.ToString();
        }
    }
}