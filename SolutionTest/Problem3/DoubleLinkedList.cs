using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3
{
	public interface DoubleLinkedListNode<T>
	{
		T Value{ get;set;}
		DoubleLinkedNode<T> Next{ get;set;}
		DoubleLinkedNode<T> Prev{ get;set;}

	}
	public class DoubleLinkedNode<T>: DoubleLinkedListNode<T>
	{
		public DoubleLinkedNode(T data)
		{
			Data = data;
		}
		public T Data{ get;set;}
		public T Value{ get;set;}
		public DoubleLinkedNode<T> Prev{ get;set;}
		public DoubleLinkedNode<T> Next{ get;set;}
	}

	public interface DoubleLinkedList<T>
	{
		DoubleLinkedNode<T> First { get;set;}
		DoubleLinkedNode<T> Last { get;set;}
		void Reverse();
		//insert new DoubleLinkedListNode with given value at the start of the list
		void AddFirst(T value);
		//insert new DoubleLinkedListNode with given value at the end of the list
		void AddLast(T value);
	}

	public class DoubleLinkedListImpl<T> : DoubleLinkedList<T>, IEnumerable<T>
	{
		public DoubleLinkedNode<T> First { get;set;}
		public DoubleLinkedNode<T> Last  { get;set;}
		int count;

		public void AddFirst(T value)
		{
			DoubleLinkedNode<T> node = new DoubleLinkedNode<T>(value);
			DoubleLinkedNode<T> temp = First;
			node.Next = temp;
			First = node;
			if (count == 0)
				Last = First;
			else
				temp.Prev = node;
			count++;
		}

		public void AddLast(T value)
		{
			var node = new DoubleLinkedNode<T>(value);
			if (First == null)
				First = node;
			else
			{
				Last.Next = node;
				node.Prev = Last;
			}
			Last = node;
			count++;			
		}

		public void Reverse()
		{
			DoubleLinkedNode<T> temp = null;
			DoubleLinkedNode<T> current = First;

			while (current != null)
			{
				temp = current.Prev;
				current.Prev = current.Next;
				current.Next = temp;
				current = current.Prev;
			}
			if (temp != null)
			{
				First = temp.Prev;
			}
		}

		public IEnumerator<T> GetEnumerator()
		{
			DoubleLinkedNode<T> node = First;
			while (node != null)
			{
				yield return node.Data;
				node = node.Next;
			}
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return ((IEnumerable)this).GetEnumerator();
		}
	}


}
