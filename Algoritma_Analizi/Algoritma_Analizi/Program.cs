using Algoritma_Analizi;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

//---------      Sort , Search algroithms

/*
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

*/

//-----------------------------------------   EXPONENT İŞLEMLERİ
Stopwatch sw1 = Stopwatch.StartNew();
Stopwatch sw2 = Stopwatch.StartNew();

sw2.Start();
Console.WriteLine(Exponent_Algorithm.Exponentiation_by_Squaring(2, 1000));
sw2.Stop();

Console.WriteLine($" Faster Method için Geçen zaman : {sw2.ElapsedMilliseconds} ms ");



sw1.Start();
Console.WriteLine(Exponent_Algorithm.classic_method(2, 1000));
sw1.Stop();  //classic metodun  analizi bitir

Console.WriteLine($" Classic Method için Geçen zaman : {sw1.ElapsedMilliseconds} ms ");



