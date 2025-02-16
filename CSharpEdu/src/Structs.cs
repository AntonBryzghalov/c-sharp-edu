namespace CSharpEdu.src
{
	internal class Structs
	{
		private struct MyStruct
		{
			public int numValue;
			public string Name;
		}

		public Structs TestStructs()
		{
			Console.WriteLine($"Running {nameof(TestStructs)}:");

			var s = new MyStruct() { numValue = 5 };
			int newValue = 10;
			Console.WriteLine($"Struct initialized with value {s.numValue}");

			PassByValue(s, newValue);
			Console.WriteLine($"After trying to set new value {newValue} with passing by value {s.numValue}");
			PassByRef(ref s, newValue);
			Console.WriteLine($"After trying to set new value {newValue} with passing by reference {s.numValue}");

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
