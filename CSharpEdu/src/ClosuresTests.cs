namespace CSharpEdu.src
{
	internal class ClosuresTests
	{
		private event Action intPrintingEvent;
		private event Action anotherIntPrintingEvent;

		public ClosuresTests TestIteratorValueClosure()
		{
			Console.WriteLine($"Running {nameof(TestIteratorValueClosure)}:");

			Console.WriteLine("Using iteration counter from 'for' loop ('i' variable) inside the lambda function, which assigned to the event, creates a closure of that variable and when the event invoked," +
				" not the copy of 'i' value at an assignation time is used, but the current value of that variable, even though that's a value type (int) and the loop seems kind of 'dead' (ended long time ago)");
			if (intPrintingEvent == null)
			{
				for (int i = 0; i < 5; i++)
				{
					intPrintingEvent += () => { Console.WriteLine(i); };
				}
			}

			intPrintingEvent?.Invoke();

			Console.WriteLine("So to create a copy of 'i' value at the moment of assignation, you should create a local variable inside the loop, assign 'i' to it and make a closure on that variable:");
			if (anotherIntPrintingEvent == null)
			{
				for (int i = 0; i < 5; i++)
				{
					int copy = i;
					anotherIntPrintingEvent += () => { Console.WriteLine(copy); };
				}
			}

			anotherIntPrintingEvent?.Invoke();

			return this;
		}
	}
}
