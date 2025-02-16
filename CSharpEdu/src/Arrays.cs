namespace CSharpEdu.src
{
	internal class Arrays
	{
		private int[][] arr;

		public Arrays TestArrays()
		{
			Console.WriteLine($"Running {nameof(TestArrays)}:");

			var random = new Random();
			arr = new int[4][];
			for (int i = 0; i < arr.Length; i++)
			{
				arr[i] = new int[random.Next(3, 7)];
			}

			for (int i = 0;i < arr.Length; i++)
				Console.WriteLine($"Length of subarray {i} is {arr[i].Length}");

			return this;
		}
	}
}
