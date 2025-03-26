using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Pointer_based_crud
{

    class Node
    {
        public int? Data;
        public Node? Next;

        public Node(int data)
        {
            Data = data;
            Next = null;
        }
    }

    class Pointer_Based_Operations
    {
        private Node head;

        public Pointer_Based_Operations()
        {
            head = null;
        }

        // İnsert İşlemleri

        public void InsertAtHead(int data) // Başa Ekleme (O(1))
        {
            Node newNode = new Node(data);
            newNode.Next = head;
            head = newNode;
        }

        public void InsertAtEnd(int data)        // Sona Ekleme (O(n))
        {
            Node newNode = new Node(data);
            if (head == null)
            {
                head = newNode;
                return;
            }

            Node temp = head;
            while (temp.Next != null)
            {
                temp = temp.Next;
            }

            temp.Next = newNode;
        }

        //-----------read işlemleri 
        public void ReadList()   // read işlemi o(n) karmaşıklığa sahiptir  WORST CASE
        {
            Node temp = head;
            while (temp != null)
            {
                Console.Write(temp.Data + " -> ");
                temp = temp.Next;
            }
            Console.WriteLine("null");
        }

        // --------------UPDATE İŞLEMLERİ
        public void UpdateNode(int oldValue, int newValue)  // WORST CASE YİNE O(N)  ÖRNEĞİN SON ELEMAN İSE
        {
            Node temp = head;
            while (temp != null)
            {
                if (temp.Data == oldValue)
                {
                    temp.Data = newValue;
                    return;
                }
                temp = temp.Next;
            }
        }

        //-------------- DELETE İŞLEMLERİ karmaşıklığa sahiptir


        // Baştan Silme (O(1))
        public void DeleteFromHead()
        {
            if (head != null)
                head = head.Next;
        }

        // Belirli Bir Değeri Silme (O(n))  karmaşıklığa sahiptir
        public void DeleteByValue(int value)
        {
            if (head == null)
                return;

            if (head.Data == value)
            {
                head = head.Next;
                return;
            }

            Node temp = head;
            while (temp.Next != null && temp.Next.Data != value)
            {
                temp = temp.Next;
            }

            if (temp.Next != null)
                temp.Next = temp.Next.Next;
        }

























    }
}
