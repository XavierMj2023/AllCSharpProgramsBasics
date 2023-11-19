using System.Collections;
using Collections.Chap01ArrayList;
using Collections.List;

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
			}
		}
	}
}