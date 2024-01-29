using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Common;
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

namespace ComponenteExamen
{
    public partial class UserControl1 : UserControl
    {
        private SolidColorBrush color = new SolidColorBrush();
        private int maxListBox = 10;
        public UserControl1()
        {
            InitializeComponent();
            sliderComponente.Maximum = numeroMaximoListBox;
            textBoxComponente.KeyDown += TextBox_KeyDown;
            listBoxComponente.KeyDown += TextBox_KeyDown;

        }

        private void cambiarColor(SolidColorBrush valor)
        {
            color = valor;
            sliderComponente.Background = color;
        }

        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                string text = textBoxComponente.Text.Trim();
                if (!string.IsNullOrEmpty(text))
                {
                    sliderComponente.Maximum = (numeroMaximoListBox+1);
                    enterTextBox();
                }
            }
            if (e.Key == Key.B)
            {
                listBoxComponente.Items.Remove(listBoxComponente.SelectedItem);
            }
        }

        private void enterTextBox()
        {
            if (listBoxComponente.Items.Count <= maxListBox)
            {
                listBoxComponente.Items.Add(textBoxComponente.Text.ToString());
                sliderComponente.Value = listBoxComponente.Items.Count;
                textBoxComponente.Clear();
                textBoxComponente.Background = new SolidColorBrush(Colors.White);
            } else
            {
                textBoxComponente.Background = new SolidColorBrush(Colors.Red);
            }
        }

        [Category("Personalizado")]
        public int numeroMaximoListBox { get => maxListBox; set => maxListBox = (value-1); }
        [Category("Personalizado")]
        public int numeroMaximoTextBox { get => textBoxComponente.MaxLength; set => textBoxComponente.MaxLength = value; }
        [Category("Personalizado")]
        public SolidColorBrush darColor { get => color; set => cambiarColor(value); }
        public List<string> DevolverLista
        {
            get
            {
                List<string> lista = new List<string>();
                foreach (var item in listBoxComponente.Items)
                {
                    lista.Add(item.ToString());
                }
                return lista;
            }
        }

        public event SelectionChangedEventHandler ListBoxSelectionChanged;
        public SelectionChangedEventHandler ListBoxSelectionChangedHandler
        {
            set { listBoxComponente.SelectionChanged += value; }
        }

        private void listBoxComponente_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            sliderComponente.Value = listBoxComponente.Items.Count;
            textBoxComponente.Background = new SolidColorBrush(Colors.White);
        }
    }
}
