using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Реализовать двусвязный список и написать функцию, 
 * переворачивающую его, т.е. изменяющую порядок элементов на обратный.
public interface DoubleLinkedListNode<T>
{
T Value { get; set; }
DoubleLinkedNode<T> Next { get; set; }
DoubleLinkedNode<T> Prev { get; set; }

}

public interface DoubleLinkedList<T>
{
DoubleLinkedNode<T> First { get; set; }
DoubleLinkedNode<T> Last { get; set; }
void Reverse();
//insert new DoubleLinkedListNode with given value at the start of the list
void AddFirst(T value);
//insert new DoubleLinkedListNode with given value at the end of the list
void AddLast(T value);
}
 */
namespace Problem3
{
	public class Program
	{
		static void Main(string[] args)
		{
			DoubleLinkedListImpl<int> doubleLinkedListImpl = new DoubleLinkedListImpl<int>();
			doubleLinkedListImpl.AddLast(1);
			doubleLinkedListImpl.AddLast(2);
			doubleLinkedListImpl.AddLast(3);

			doubleLinkedListImpl.AddFirst(5);
			doubleLinkedListImpl.AddFirst(7);


			Action<DoubleLinkedListImpl<int>> Print = (list) =>
			{
				foreach (var item in list)
					Console.Write(item + " ");
				Console.WriteLine("");
			};

			Print(doubleLinkedListImpl);

			doubleLinkedListImpl.Reverse();

			Print(doubleLinkedListImpl);

			Console.ReadKey();
		}

	}
}
