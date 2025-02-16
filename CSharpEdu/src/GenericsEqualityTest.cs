namespace CSharpEdu.src
{
	internal static class GenericsEqualityTest
	{
		public static void TestStringsEquality()
		{
			Console.WriteLine($"Running {nameof(TestStringsEquality)}:");

			string s1 = "target";
			string s2 = "target"; // Reference the same string as s1
			string s3 = new System.String("target"); // Really a new string in the memory
			System.Text.StringBuilder sb = new System.Text.StringBuilder("target");
			string s4 = sb.ToString(); // Also a new string
			OpEqualsTest<string>(s1, s2); // True
			OpEqualsTest<string>(s1, s3);
			OpEqualsTest<string>(s1, s4);
		}

		// Does only references comparison even though == is overriden for strings
		// because for generics the compiler only knows that T is a reference type at compile time and must use the default operators that are valid for all reference types
		private static void OpEqualsTest<T>(T s, T t) where T : class
		{
			System.Console.WriteLine(s == t);
		}
	}
}
