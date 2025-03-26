using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Algoritma_Analizi
{
   
    internal class Sort_Functions
    {


      

        public static void Bubble_Sort(int[] A)
        { 
            Stopwatch sw = Stopwatch.StartNew();    

            int temp;
            if (A.Length == 0 || A is null) return;

            // algoirtma start
            sw.Start(); 
            for (int i = 0; i < A.Length; i++)
            {

                for (int j = A.Length - 1; j > i; j--)
                {
                    if (A[j] < A[j-1])
                    {
                        //küçük indisle büyük indisi yer değiştir eğer büyükse küçük indisli olan
                        temp = A[j - 1];
                        A[j-1] = A[j];  
                        A[j] = temp;        

                    }
                }

            } sw.Stop(); // algoritma end

            Console.WriteLine($"Buuble Sort Summaries : for {A.Length} lenghts  {sw.ElapsedMilliseconds} ms ");

        }


        public static int[] one_dimension_Random_array(int length) { 
        
            int[] array = new int[length];
            Random rnd = new Random();  
            for (int i = 0;i<length; i++)
            {
                array[i]= rnd.Next(0,1000);
            }

            return array;   

        }

        public static void İnsertion_Sort(int[] A)
        {
            Stopwatch sw = Stopwatch.StartNew();
            int i, j = 0;
            int temp;
            if (A.Length == 0 || A is null) return;

            

            sw.Start();
            for (i = 1; i < A.Length; i++)
            {
                int deger = A[i];
                j = i - 1;

                while (j >= 0 && A[j] > deger)
                {
                    A[j + 1] = A[j];
                    j--;
                }
                A[j + 1] = deger;
            }
            sw.Stop();
            Console.WriteLine($"İnsertion Sort Summaries : for {A.Length} lenghts  {sw.ElapsedMilliseconds} ms ");
        }

        public static int Find_eleman_K(int[] A,int k)
        {
            Stopwatch sw = Stopwatch.StartNew();

            sw.Start();
            int[] copy =  (int []) (A.Clone()); 
            Array.Sort(copy);
            sw.Stop() ;
            Console.WriteLine($"Find element  K. item Summaries : for {A.Length} lenghts  {sw.ElapsedMilliseconds} ms ");

            return copy[k - 1];


        }

        public static int Find_element_K_insertion_sort(int[] A,int k)
        {
            int[] temp_Array = (int[]) (A.Clone()); 
            Stopwatch sw = Stopwatch.StartNew();
            int i, j = 0;
            int temp;
            if (temp_Array.Length == 0 || temp_Array is null) return 0;

            

            sw.Start();
            for (i = 1; i < temp_Array.Length; i++)
            {
                int deger = temp_Array[i];
                j = i - 1;

                while (j >= 0 && temp_Array[j] > deger)
                {
                    temp_Array[j + 1] = temp_Array[j];
                    j--;
                }
                temp_Array[j + 1] = deger;
            }
            sw.Stop();
            Console.WriteLine($"Find Element K İnsertion Sort Summaries : for {temp_Array.Length} lenghts  {sw.ElapsedMilliseconds} ms ");
            return temp_Array[k - 1];       
        }
    }
}
