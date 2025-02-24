using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEdu.src
{
	internal class SpanTest
	{
		public SpanTest RunSpanTests() {
			Console.WriteLine($"Running {nameof(RunSpanTests)}:");

			int[] intArr = { 8, 0, 12, 46, 6567, 456, 33, 75, -74, 53, 14, 67, 64565, 633, 7223, 53 };
			var span = new Span<int>(intArr, 1, intArr.Length - 2); // Take all elements except first and last ones
			span.Sort();
			foreach (int number in intArr) {
				Console.WriteLine(number);
			}

			return this;
		}
	}
}
