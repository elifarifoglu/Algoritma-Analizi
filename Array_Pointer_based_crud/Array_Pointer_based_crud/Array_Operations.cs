using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Pointer_based_crud
{
    class Array_Operations
    {
        public int[] array;
        private int size;

        public Array_Operations(int capacity)
        {
            array = new int[capacity];
            size = 0;
        }

        // Create (Diziye Eleman Ekleme) - O(1) veya O(n)       NOT : O(n) Olan Insert İşlemi (Başa veya Ortaya Ekleme) OLUYOR.  sona ekleme = o(1)
        public void Insert(int value)
        {
            if (size == array.Length)   //eğer doluysa
            {
                Array.Resize(ref array, array.Length * 2); // O(n) maliyetli genişletme
            }
            array[size] = value;
            size++;
        }




        // Read (Dizi Elemanlarını Okuma) - O(n)
        public void Display()  // sırasıyla n eleman okunur         // eğer linear search ile arama yapıyorsak  0(n)
        {
            for (int i = 0; i < size; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }

        public void Display_fixed_read(int index)
        {
            Console.WriteLine(array[index]);  // karmaşıklık 0(1) olur bu halde 
        }


        //-----------------------------------  DELETE

        public void Remove_last_item()    // Karmaşıklık = o(1)
        {                                 
            size--;  // gerçek anlamda silme olmaz sabit dizilerde  görmezden geldik  
        }
        

        public void Remove_indexed_item(int deleted_index) {

            for (int i = deleted_index; i < size - 1; i++)
            {
                array[i] = array[i + 1];
            }

            size--;
        }

        // ------------------------------------update işlemleri


        public void update_indexed_item(int target_index,int new_Value)  // işlem karmaşıklığı o(1) olur
        {
            array[target_index] = new_Value;        
        }

        public void update_item(int old_value,int new_value)
        {
                 for (int i=0; i<array.Length; i++)     // o (n) karmaşıklığa sahiptir
            {

                if (array[i] == old_value)
                    array[i] = new_value; 

            }
        }




    }
}
