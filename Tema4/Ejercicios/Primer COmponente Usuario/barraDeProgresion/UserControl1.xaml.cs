using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
        private int maximo;
        private int tiempoActual;

        public UserControl1()
        {
            InitializeComponent();
            maximo = (int)barraCarga.Width;
            tiempoActual = 0;
        }

        //Hacer que la barra avanze
        public void RellenarBarra(int valor)
        {
            int valorNum = valor;

            if (valorNum < 0)
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

        //Animar la barra con el tiempo
        private async void AnimarBarra()
        {
            int valorInicial = porcentaje;
            int valorObjetivo = 100;

            if (valorInicial >= valorObjetivo || tiempoActual <= 0)
            {
                return;
            }

            double incrementoPorSegundo = (double)(valorObjetivo - valorInicial) / tiempoActual;

            for (int i = valorInicial; i < valorObjetivo; i++)
            {
                await Task.Delay((int)(1000 / incrementoPorSegundo));
                Dispatcher.Invoke(() => porcentaje = i);
                ActualizarColorBarra();
            }
        }

        //Parte de los colores (lógica de cambio)
        private void ActualizarColorBarra()
        {
            double porcentajeCompletado = (double)porcentaje / 100;

            Color color;

            if (porcentajeCompletado <= 0.25)
            {
                // Verde a Amarillo
                color = InterpolateColors(Colors.Green, Colors.Yellow, porcentajeCompletado * 4);
            }
            else if (porcentajeCompletado <= 0.5)
            {
                // Amarillo a Naranja
                color = InterpolateColors(Colors.Yellow, Colors.Orange, (porcentajeCompletado - 0.25) * 4);
            }
            else if (porcentajeCompletado <= 0.75)
            {
                // Naranja a Rojo
                color = InterpolateColors(Colors.Orange, Colors.Red, (porcentajeCompletado - 0.5) * 4);
            }
            else
            {
                // Rojo
                color = Colors.Red;
            }

            SolidColorBrush brush = new SolidColorBrush(color);
            barraCarga.Fill = brush;
        }

        //Parte de los colores (lógica del gradiente)
        private Color InterpolateColors(Color colorInicio, Color colorFin, double porcentaje)
        {
            byte r = (byte)(colorInicio.R + (colorFin.R - colorInicio.R) * porcentaje);
            byte g = (byte)(colorInicio.G + (colorFin.G - colorInicio.G) * porcentaje);
            byte b = (byte)(colorInicio.B + (colorFin.B - colorInicio.B) * porcentaje);

            return Color.FromRgb(r, g, b);
        }

        private int _porcentaje;
        public int porcentaje
        {
            get => _porcentaje;
            set
            {
                _porcentaje = value;
                RellenarBarra(value);
            }
        }

        public int tiempo
        {
            get => tiempoActual;
            set
            {
                tiempoActual = value;
                AnimarBarra();
            }
        }
    }
}