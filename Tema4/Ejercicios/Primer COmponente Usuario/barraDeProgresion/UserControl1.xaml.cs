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

namespace barraDeProgresion
{
    public partial class UserControl1 : UserControl
    {
        int maximo;
        public UserControl1()
        {
            InitializeComponent();
            maximo = (int) barraCarga.Width;
        }

        public void rellenarBarra(int valor)
        {
            int valorNum = valor;

            if (valorNum < 0 )
            {
                valorNum = 0;
            }

            if (valorNum > 100)
            {
                valorNum = 100;
            }
            groupPorcentaje.Header = valorNum.ToString();

            int valorPorcentaje = valorNum * maximo / 100;
            barraCarga.Width = valorPorcentaje;

        }

        public int porcentaje { get => int.Parse(groupPorcentaje.Header.ToString()); set => rellenarBarra(value);}

    }
}