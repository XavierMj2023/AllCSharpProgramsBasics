using System.Collections;
using Collections.Chap01ArrayList;
using Collections.Dictonary;
using Collections.HashTable;
using Collections.List;
using Collections.SortedList;
using Collections.Stack;

public class Program
{
	public static void Main(string[] args)
	{
		while (true) 
		{
			Console.WriteLine("Enter the Option to execute operation");
			string option = Console.ReadLine();
			if (option.ToLower() == "done")
			{
				break;
			}
			switch (option.ToLower())
			{
				case "arraylist":
					Chap01ArrayList.ArrayListswitch();
					break;

				case "list":
					ListOps listOps = new ListOps();
					listOps.ListOpsSwitch();
					break;

				case "sortlist":
					SortedListOps sl = new SortedListOps();
					sl.SortedListSwitch();
					break;

				case "dict":
					DictonaryOps dictOps = new DictonaryOps();
					dictOps.DictonarySwitch();
					break;

				case "hashtable":
					HashTableOps hops = new HashTableOps();
					hops.HashTableSwitch();
					break;

				case "stack":
					 StackOps sops = new StackOps();
					 sops.StackSwitch();
					 break;
			}
		}
	}
}