using System;

namespace CSharpEdu.src
{
	internal class EnumsTest
	{
		[Flags]
		private enum Abilities
		{
			None = 0,
			Sprint = 1 << 0,
			Jump = 1 << 1,
			Fly = 1 << 2,
			Crawl = 1 << 3,
			Shoot = 1 << 4,
		}

		public static void TestEnumFlags()
		{
			Console.WriteLine($"Running {nameof(TestEnumFlags)}:");

			Abilities abilities = Abilities.None;
			
			AddAbilities(ref abilities, Abilities.Sprint | Abilities.Shoot);
			RemoveAbilities(ref abilities, Abilities.Shoot | Abilities.Crawl);
		}

		private static void AddAbilities(ref Abilities abilities, Abilities abilitiesToAdd)
		{
			Console.WriteLine($"Adding '{abilitiesToAdd}' abilities to '{abilities}'");
			abilities |= abilitiesToAdd;
			Console.WriteLine("Now we have " + abilities);
		}

		private static void RemoveAbilities(ref Abilities abilities, Abilities abilitiesToAdd)
		{
			Console.WriteLine($"Removing '{abilitiesToAdd}' abilities from '{abilities}'");
			abilities &= ~abilitiesToAdd;
			Console.WriteLine("Now we have " + abilities);
		}
	}
}
