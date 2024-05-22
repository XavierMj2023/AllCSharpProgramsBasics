using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllCSharpBasicsPractiseForIndecomm.Boxing
{
	public class BoxingDemoExe()
	{
		public void sendType()
		{
			int i = 10;

			object o = i;

			Console.WriteLine("Type : "+i);
		}

	}
	public class BoxingDemo
	{
		public void SendMessage()
		{
			

			Console.WriteLine("Boxing Result : ");
		}
	}
}
