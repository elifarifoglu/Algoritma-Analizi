using Algoritma_Analizi;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

int[] a = { 1, 44, 30, 24, 4 }; // example Array 
int[] b = Sort_Functions.one_dimension_Random_array(25);


//Sort_Functions.Bubble_Sort(b);
//Sort_Functions.İnsertion_Sort(b);
int resut = Sort_Functions.Find_element_K_insertion_sort(b, 5);

Sort_Functions.İnsertion_Sort(b);
//Console.WriteLine("\n \nApplied Bubble Sort } \n");

foreach (int i in b)
{
    Console.Write(i + "  ");
    
}
Console.WriteLine("\n");
//int rslt= Sort_Functions.Find_eleman_K(b, 102);
Console.WriteLine(resut);


