using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritma_Analizi
{
    internal class Exponent_Algorithm
    {



        public static double classic_method(int Base, int exponent)
        {
            double temp = 1;

            for (int i = 0; i < exponent; i++)
            {
                temp *= Base;

            }

            return temp; 
        }


        public static double Exponentiation_by_Squaring(double Base, int Exponent)
        {
            double result = 1;
            while (Exponent > 0)
            {
                if ((Exponent & 1) == 1) // Üs tekse, sonucu çarp
                    result *= Base;

                Base *= Base; // Karesini al
                Exponent >>= 1; // Üssü ikiye böl
            }
            return result;
        }


    }
}
