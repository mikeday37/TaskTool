using System;
using System.Text.Json;

namespace AdHoc
{
	class Program
	{
		public class TestClass
		{
			public string Message {get;set;}
			public int Number {get;set;}
			public bool Flag {get;set;}
		}

		static void Main(string[] args)
		{
			var tc = new TestClass{Message = "Hello!", Number = 31337, Flag = true};
			var s = JsonSerializer.Serialize(tc);
			Console.WriteLine(s);
			
			Console.ReadLine();
		}
	}
}
