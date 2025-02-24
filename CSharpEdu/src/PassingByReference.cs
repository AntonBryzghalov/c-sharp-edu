namespace CSharpEdu.src
{
	internal static class PassingByReference
	{
		public static void TestPassingByReference()
		{
			Console.WriteLine($"Running {nameof(TestPassingByReference)}:");

			List<string> list = null;
			AddString(list);
			Console.WriteLine("Is list null after assigment inside another function as an argument to that function: " + (list is null));
			AddString(ref list);
			Console.WriteLine("Is list null after assigment inside another function as an REF argument to that function: " + (list is null));
		}


		private static void AddString(List<string> strings)
		{
			strings ??= new List<string>();
			strings.Add("A string");
		}

		private static void AddString(ref List<string> strings)
		{
			strings ??= new List<string>();
			strings.Add("A string");
		}
	}
}
