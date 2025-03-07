using System.Reflection;
using System.Runtime.CompilerServices;

namespace CSharpEdu.src
{
    internal static class AnonimousTypeVSRecord
    {
        private class UserClass()
        {
            public string Name { get; }
            public int Age { get; }
        }

        private record UserRecordClass(string Name, int Age);



        public static void TestAnonimousTypeVSRecord()
        {
			Console.WriteLine($"Running {nameof(TestAnonimousTypeVSRecord)}:");

			var data = new { Name = "MyName", Age = 35 };
            var dataType = data.GetType();

			Console.WriteLine(IsCompilerGenerated(typeof(UserClass).GetMethod("ToString")));  // False
			Console.WriteLine(IsCompilerGenerated(typeof(UserRecordClass).GetMethod("ToString"))); // True
			Console.WriteLine(IsCompilerGenerated(dataType.GetMethod("ToString")));  // False

            var data2 = data with { Age = 35 };
			Console.WriteLine("Anon class instances equality after creating a copy with the same age: " + (data == data2)); // False

            var r1 = new UserRecordClass("UserName", 33);
            var r2 = r1 with { Age = 33 };
			Console.WriteLine("Records equality after creating a copy with the same age:" + (r1 == r2)); // True
            // All this above means the Anonimous Type is not a Record even though it behaves very similar
		}

		static bool IsCompilerGenerated(MethodInfo method)
		{
            var isCompilerGenerated = method?.IsDefined(typeof(CompilerGeneratedAttribute), false) ?? false;
            var substr = isCompilerGenerated ? "is" : "is not";
			Console.WriteLine($"Method {method.Name} of type {method.DeclaringType.Name} { substr } compiler-generated");
			return isCompilerGenerated;
		}
	}
}
