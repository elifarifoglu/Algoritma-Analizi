
using Array_Pointer_based_crud;
//------------ ARRAY PROCESSİNG

/*
//int[] a = { 1, 2, 3, 4 };



//foreach (int i in a)
//{
//    Console.WriteLine(i);   
//}

Array_Operations aop = new Array_Operations(5);

aop.Insert(12);
aop.Insert(13);
aop.Insert(72);
aop.Insert(5);
aop.Insert(52);
aop.Insert(122);

//aop.Remove_last_item();

//Console.WriteLine(aop.array[aop.array.Length - 1]); 

aop.update_item(72, 172);

aop.Display();



aop.Display_fixed_read(2);

*/

// ---------------------------------- POİNTER PROCESSİNG
Pointer_Based_Operations pbo = new Pointer_Based_Operations();


pbo.InsertAtHead(10);
pbo.InsertAtHead(20);
pbo.InsertAtEnd(100);

//pbo.DeleteByValue(10);


pbo.UpdateNode(20, 120);

pbo.ReadList(); 