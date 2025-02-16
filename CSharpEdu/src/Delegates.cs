namespace CSharpEdu.src
{
	internal class Delegates
	{
		private delegate void MyActionDelegate();

		public Delegates TestDelegates()
		{
			Console.WriteLine($"Running {nameof(TestDelegates)}:");

			MyActionDelegate del = delegate { Console.WriteLine("Default implementation"); };
			del += DoNothing;
			del += WriteALine;

			del();

			return this;
		}

		private void DoNothing()
		{
			Console.WriteLine("I did nothing");
		}

		private void WriteALine()
		{
			Console.WriteLine("I wrote a line");
		}
	}
}
