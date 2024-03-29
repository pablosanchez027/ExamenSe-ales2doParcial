﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraficadorDeSeñales
{
    class SeñalSenoidal : Señal
    {
        public double Amplitud { get; set; }
        public double Fase { get; set; }
        public double Frecuencia { get; set; }

        public SeñalSenoidal()
        {
            Fase = Fase;
            Frecuencia = Frecuencia;
            Muestras = new List<Muestra>();
            AmplitudMaxima = 0.0;
        }

        public SeñalSenoidal(double amplitud,
            double fase, double frecuencia)
        {
            Amplitud = amplitud;
            Fase = fase;
            Frecuencia = frecuencia;
            Muestras = new List<Muestra>();
        }

        override public double evaluar(double tiempo)
        {
            double resultado;
            resultado =
                Amplitud * Math.Sin(
                    ((2 * Math.PI * Frecuencia) *
                    tiempo) + Fase);
            return resultado;
        }
    }
}
