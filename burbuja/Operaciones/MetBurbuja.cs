﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace burbuja.Operaciones
{
    internal class MetBurbuja
    {
        public void ordenarBurbuja(int[] arreglo)
        { 
            for (int i = 0; i < arreglo.Length; i++)
            {
                for (int j = i+1; j < arreglo.Length; j++)
                {
                    if (arreglo[j] < arreglo[i])
                    {
                        int tempo = arreglo[j];
                        arreglo[j] = arreglo[i];
                        arreglo[i] = tempo;

                    }
                }
            }


        }
    }
}
