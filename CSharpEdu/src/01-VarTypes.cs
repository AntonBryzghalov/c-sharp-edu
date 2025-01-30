using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEdu.src
{
	// https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/built-in-types
	internal class VarTypes
	{
		// Numeric types

		// Integral https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/integral-numeric-types
		sbyte sbyteVar = -100; // Signed 8-bit integer, -128..127
		byte byteVar = 255; // Unsigned 8-bit integer, 0..255
		short shortVar = -32_000; // Signed 16-bit integer, -32,768 .. 32,767
		ushort ushortVar = 64_000; // Unsigned 16-bit integer, 0 .. 65,535
		int intVar = 2_147_483_647; // Signed 32-bit integer, -2,147,483,648 .. 2,147,483,647
		uint uintVar = 4_294_967_295u; // Unsigned 32-bit integer, 0 to 4,294,967,295
		long longVar = -9_223_372_036_854_775_808L; // Signed 64-bit integer, -9,223,372,036,854,775,808 .. 9,223,372,036,854,775,807
		ulong ulongVar = 18_446_744_073_709_551_615UL; // Unsigned 64-bit integer, 0 .. 18,446,744,073,709,551,615
													   //Also there are
													   //nint and nuint types, which are pointer types and are much more advanced topic
													   //their size is respectively to the platform you're using: 32 or 64 bit

		public VarTypes TestIntegers()
		{
			int one = 1;
			int ten = 10;
			Console.WriteLine($"Integers: one / ten = {one / ten}"); // = 0, because result of operations between integers is also an integer, everything after the point is discarded
			Console.WriteLine($"1 / 10 = {1 / 10}"); // = 0. The same, because implicitly numeric values without type specification endings (like f, d, u, etc.) are considered as int-s

			byte byteMax = byte.MaxValue; // 255
			Console.WriteLine($"Maximum byte value (255) + 1 = {(byte)(byteMax + 1)}"); // = 0 (minimal byte value), because then integer values exceeding their maximum, they loop from own minimum
			Console.WriteLine($"Maximum byte value (255) + 2 = {(byte)(byteMax + 2)}"); // = 1 for the same reason

			return this;
		}


		// Floating-point numeric types https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/floating-point-numeric-types
		float floatVar = 255f; // 32-bit, precision 6-9 digits
		double doubleVar = 123.456789d; // 64-bit, precision 15-17 digits
		decimal decimalVar = 123.456789M; // 128-bit values, precision 28-29 digits

		public VarTypes TestFloats()
		{
			Console.WriteLine($"(float) 1 / 10 = {(float)1 / 10}"); // = 0.1, when one of the int operands is explicitly converted to a float or a double, then all operands implicitly converted to the same float/double
			Console.WriteLine($"10f / 3f = {10f / 3f}"); // 3.33333.... with some deviation in the end due to the supported precision and problem of representing decimal values with binary code

			return this;
		}


		// Literals
		char singleCharacter = 'A'; // 16 bit, unicode symbols from U+0000 to U+FFFF
		public VarTypes TestChars()
		{
			var chars = new[]
			{
				'j',
				'\u006A',
				'\x006A',
				(char)106,
			};

			Console.WriteLine(string.Join(" ", chars));  // output: j j j j

			return this;
		}


		// Boolean
		public bool boolVar = false; // we can change it on instance of the class
		public VarTypes TestBools()
		{
			if (boolVar)
				Console.WriteLine("boolVar is TRUE");
			else
				Console.WriteLine("boolVar is FALSE");

			Console.WriteLine("Booleans don't have implicit or explicit conversion of other built-in types to it");

			return this;
		}

		// How we can define implicit conversion of the instance of this class to the boolean value (to use as bool value elsewhere in conditions):
		public static bool operator true(VarTypes x) => x.boolVar; // if boolVar == true, then this instance of the class is also implicitly converts to TRUE value
		public static bool operator false(VarTypes x) => !x.boolVar; // if boolVar == false, then this instance of the class is also implicitly converts to FALSE value
	}
}
