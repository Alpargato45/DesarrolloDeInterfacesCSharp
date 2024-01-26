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

namespace relojDigital
{
    public partial class UserControl1 : UserControl
    {
        private int hora;
        private int minuto;
        private List<Rectangle> horaDecena;
        private List<Rectangle> horaUnidad;
        private List<Rectangle> minutoDecena;
        private List<Rectangle> minutoUnidad;
        public UserControl1()
        {
            InitializeComponent();
            horaDecena = new List<Rectangle>() {A0,A1,A2,A3,A4,A5,A6};
            horaUnidad = new List<Rectangle>() {B0,B1,B2,B3,B4,B5,B6};
            minutoDecena = new List<Rectangle>() {C0,C1,C2,C3,C4,C5,C6};
            minutoUnidad = new List<Rectangle>() {D0,D1,D2,D3,D4,D5,D6};
        }

        private void iluminarHoras(int h)
        {
            if (h < 0 || h > 99)
            {
                h = 0;
                horas = 0;
            }
            int unidad = h % 10;
            int decena = h / 10;
            cambiarNumero(horaDecena, decena);
            cambiarNumero(horaUnidad, unidad);
        }

        private void iluminarMinutos(int min)
        {
            if (min < 0 || min > 99)
            {
                min = 0;
                minutos = 0;
            }
            int unidad = min % 10;
            int decena = min / 10;
            cambiarNumero(minutoDecena, decena);
            cambiarNumero(minutoUnidad, unidad);
        }

        private void resetearColores(List<Rectangle> lista)
        {
            SolidColorBrush gris = new SolidColorBrush(Colors.Gray);
            lista[0].Fill = gris;
            lista[1].Fill = gris;
            lista[2].Fill = gris;
            lista[3].Fill = gris;
            lista[4].Fill = gris;
            lista[5].Fill = gris;
            lista[6].Fill = gris;
        }

        private void cambiarNumero(List<Rectangle> lista,int num)
        {
            resetearColores(lista);
            SolidColorBrush rojo = new SolidColorBrush(Colors.Red);
            switch (num)
            {
                case 0:
                    lista[0].Fill = rojo;
                    lista[1].Fill = rojo;
                    lista[2].Fill = rojo;
                    lista[4].Fill = rojo;
                    lista[5].Fill = rojo;
                    lista[6].Fill = rojo;
                    break;
                case 1:
                    lista[2].Fill = rojo;
                    lista[5].Fill = rojo;
                    break;
                case 2:
                    lista[0].Fill = rojo;
                    lista[2].Fill = rojo;
                    lista[3].Fill = rojo;
                    lista[4].Fill = rojo;
                    lista[6].Fill = rojo;
                    break;
                case 3:
                    lista[0].Fill = rojo;
                    lista[2].Fill = rojo;
                    lista[3].Fill = rojo;
                    lista[5].Fill = rojo;
                    lista[6].Fill = rojo;
                    break;
                case 4:
                    lista[1].Fill = rojo;
                    lista[2].Fill = rojo;
                    lista[3].Fill = rojo;
                    lista[5].Fill = rojo;
                    break;
                case 5:
                    lista[0].Fill = rojo;
                    lista[1].Fill = rojo;
                    lista[3].Fill = rojo;
                    lista[5].Fill = rojo;
                    lista[6].Fill = rojo;
                    break;
                case 6:
                    lista[0].Fill = rojo;
                    lista[1].Fill = rojo;
                    lista[3].Fill = rojo;
                    lista[4].Fill = rojo;
                    lista[5].Fill = rojo;
                    lista[6].Fill = rojo;
                    break;
                case 7:
                    lista[0].Fill = rojo;
                    lista[2].Fill = rojo;
                    lista[5].Fill = rojo;
                    break;
                case 8:
                    lista[0].Fill = rojo;
                    lista[1].Fill = rojo;
                    lista[2].Fill = rojo;
                    lista[3].Fill = rojo;
                    lista[4].Fill = rojo;
                    lista[5].Fill = rojo;
                    lista[6].Fill = rojo;

                    break;
                case 9:
                    lista[0].Fill = rojo;
                    lista[1].Fill = rojo;
                    lista[2].Fill = rojo;
                    lista[3].Fill = rojo;
                    lista[5].Fill = rojo;
                    lista[6].Fill = rojo;
                    break;
                default:

                    break;
            }
        }

        public int horas { get => hora; set => iluminarHoras(value); }
        public int minutos { get => minuto; set => iluminarMinutos(value); }
        

        }
    }
