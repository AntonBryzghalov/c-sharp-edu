namespace CSharpEdu.src
{
    internal static class TuplesTest
    {
		// Here you can find comparison info between ValueTuple, Tuple and anonymous classes:
		// https://learn.microsoft.com/en-us/dotnet/standard/base-types/choosing-between-anonymous-and-tuple
		public static void TestTuples()
        {
			Console.WriteLine($"Running {nameof(TestTuples)}:");
			// 3 ways to declare/assign a tuple with the same fields
			// 1
			var myTuple = (userName: "User", age: 34);

			// 2
            var userName = "User";
            var age = 34;
            var myTuple2 = (userName, age);

			// 3
            (string userName, int age) myTuple3 = ("User", 34);


			Console.WriteLine("Content of tuple 1: " + myTuple);
			Console.WriteLine("Content of tuple 2: " + myTuple2);
			Console.WriteLine("Content of tuple 3: " + myTuple3);

			var tupleType = myTuple.GetType();
			Console.WriteLine($"Tuple 1 type == Tuple 2 type == Tuple 3 type: " + (tupleType == myTuple2.GetType() && tupleType == myTuple3.GetType()));
			Console.WriteLine($"Tuple 1 == Tuple 2: " + (myTuple == myTuple2));
			Console.WriteLine($"Tuple 1 == Tuple 3: " + (myTuple == myTuple2));
			Console.WriteLine($"Tuple type is a class: " + myTuple.GetType().IsClass);
			Console.WriteLine("Tuples were defined in a different way, but they got the same type and they are value types like structs, but have a == comparison implemented by default.");
			Console.WriteLine("Actually they have a ValueTuple<T1, T2> type: " + tupleType);

			// Assigning to local variables from tuples:
			(string playerName, int playerAge) = myTuple;
			var (player2Name, player2Age) = myTuple2;
		}
    }
}
