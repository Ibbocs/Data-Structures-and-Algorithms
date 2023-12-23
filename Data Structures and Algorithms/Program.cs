// See https://aka.ms/new-console-template for more information
using Algorithms;
using Data_Structures_and_Algorithms;

Console.WriteLine("Hello, World!");

//Arrays arrays = new Arrays();
//var arrayim = new[] { 3, 2, 1, 4, 10000, 167 };

//string a = arrays.ReverseArray("salam");

//var data = arrays.MinMaxOfArray(new[] { 3, 2, 1, 56, 10000, 167 });

//var data = arrays.PeekArray(new[] { 3, 2, 1, 56, 10000, 167 }, 54);
//var data = arrays.Sort2(arrayim);

//var data = arrays.KthElement(arrayim, 4);

//arrays.Rota(arrayim);

//SinglyLinkedList<int> singlyLinkedList = new SinglyLinkedList<int>();

////singlyLinkedList.InsertAtBegin(1);
////singlyLinkedList.InsertAtBegin(11);
////singlyLinkedList.InsertAtBegin(111);

//singlyLinkedList.InsertAtEnd(2);
//singlyLinkedList.InsertAtEnd(22);

//singlyLinkedList.PrintList();
//singlyLinkedList.PrintTail();

//var data = singlyLinkedList.MyNext;

//LeetCode leetCode = new LeetCode();


//Console.WriteLine(leetCode.FractionToDecimal(4,8) );

int[] ints = { 1, 2, 6, 4, 5, 6, 3, 8, 0 };
SelectionSort sort = new SelectionSort();
sort.RecursiveSelectionSort( ints);

Console.WriteLine($"{ints[0]}, {ints[1]}, {ints[8]}" );

//var data = sort.SelectionSortForNumber(ints);
var data1 = sort.SelectionSortForString("Baki, baki. bizimsen");
var data2 = sort.SelectionSortForChar("Baki, baki. bizimsen");



Console.ReadLine();
