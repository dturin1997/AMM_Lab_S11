using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace AMM_Lab_S11.ViewModels
{
    public class ViewModelOperaciones: ViewModelBase
    {
        #region  Atributos
        double valorA;
        public double ValorA
        {
            get { return valorA; }
            set
            {
                if (valorA != value)
                {
                    valorA = value;
                    OnPropertyChanged();
                }
            }
        }

        double valorB;
        public double ValorB
        {
            get { return valorB; }
            set
            {
                if (valorB != value)
                {
                    valorB = value;
                    OnPropertyChanged();
                }
            }
        }

        string resultado;

        public string Resultado
        {
            get { return resultado; }
            set
            {
                if (resultado != value)
                {
                    resultado = value;
                    OnPropertyChanged();
                }
            }
        }

        #endregion

        public ICommand Sumar { protected set; get; }
        public ICommand Restar { protected set; get; }
        public ICommand Multiplicar { protected set; get; }
        public ICommand Dividir { protected set; get; }


        public ViewModelOperaciones()
        {
            Sumar = new Command(() =>
            {           
                Resultado = $"{ValorA + ValorB} ";
            });

            Restar = new Command(() =>
            {
                Resultado = $"{ValorA - ValorB} ";
            });

            Multiplicar = new Command(() =>
            {
                Resultado = $"{ValorA * ValorB} ";
            });

            Dividir = new Command(() =>
            {
                if (ValorB == 0)
                {
                    Resultado = "No se puede dividir entre 0";
                }
                else
                {
                    Resultado = $"{ValorA / ValorB} ";
                }
            });

        }
    }
}
