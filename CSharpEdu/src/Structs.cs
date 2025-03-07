namespace CSharpEdu.src
{
	internal class Structs
	{
		private struct MyStruct
		{
			public int numValue;
			public string Name;
		}

		public Structs TestStructsModification()
		{
			Console.WriteLine($"Running {nameof(TestStructsModification)}:");

			var s = new MyStruct() { numValue = 5 };
			int newValue = 10;
			Console.WriteLine($"Struct initialized with value {s.numValue}");

			PassByValue(s, newValue);
			Console.WriteLine($"After trying to set new value {newValue} with passing by value {s.numValue}");
			PassByRef(ref s, newValue);
			Console.WriteLine($"After trying to set new value {newValue} with passing by reference {s.numValue}");

			return this;
		}

		public Structs TestComparison()
		{
			var s1 = new MyStruct { Name = "User", numValue = 5 };
			var s2 = new MyStruct { Name = "User", numValue = 5 };

			Console.WriteLine("Structs don't have a == comparison default implementation, you should implement it yourself.");
			Console.WriteLine("To have structural equality comparison out-of-the-box use record struct.");
			Console.WriteLine("Two different instances of struct with the same values are euqal: " + s1.Equals(s2));
			return this;
		}

		private void PassByValue(MyStruct s, int newValue)
		{
			s.numValue = newValue;
		}


		private void PassByRef(ref MyStruct s, int newValue)
		{
			s.numValue = newValue;
		}
	}
}
