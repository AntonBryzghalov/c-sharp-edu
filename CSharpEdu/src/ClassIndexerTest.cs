using System.Text;

namespace CSharpEdu.src
{
	internal class ClassIndexerTest
	{
		private enum Stat
		{
			Strength,
			Dexterity,
			MeleeWeapons,
			RangedWeapons
		}

		private class Stats {
			private int Strength { get; }
			private int Dexterity { get; }
			private int MeleeWeapons { get; }
			private int RangedWeapons { get; }

			public Stats() {
				Strength = 5;
				Dexterity = 8;
				MeleeWeapons = 12;
				RangedWeapons = 15;
			}

			public override string ToString()
			{
				return new StringBuilder()
					.AppendLine("Stats object:")
					.AppendLine($"{nameof(Strength)}: {Strength}")
					.AppendLine($"{nameof(Dexterity)}: {Dexterity}")
					.AppendLine($"{nameof(MeleeWeapons)}: {MeleeWeapons}")
					.AppendLine($"{nameof(RangedWeapons)}: {RangedWeapons}")
					.ToString();
			}

			public int this[int index] {
				get {
					switch (index) {
						case 0: return Strength;
						case 1: return Dexterity;
						case 2: return MeleeWeapons;
						case 3: return RangedWeapons;
						default: throw new ArgumentOutOfRangeException(nameof(index));
					};
				}
			}

			public int this[Stat stat]
			{
				get
				{
					switch (stat)
					{
						case Stat.Strength: return Strength;
						case Stat.Dexterity: return Dexterity;
						case Stat.MeleeWeapons: return MeleeWeapons;
						case Stat.RangedWeapons: return RangedWeapons;
						default: throw new ArgumentOutOfRangeException(nameof(stat));
					};
				}
			}

			public int this[string key]
			{
				get
				{
					switch (key)
					{
						case "Strength": return Strength;
						case "Dexterity": return Dexterity;
						case "Melee Weapons": return MeleeWeapons;
						case "Ranged Weapons": return RangedWeapons;
						default: throw new ArgumentOutOfRangeException(nameof(key));
					};
				}
			}
		}

		public static void TestDifferentIndexing()
		{
			Console.WriteLine($"Running {nameof(TestDifferentIndexing)}:");
			var stats = new Stats();
			Console.WriteLine(stats);
			Console.WriteLine($"Access Strength by int index: {stats[0]}");
			Console.WriteLine($"Access Dexterity by Stat enum index: {stats[Stat.Dexterity]}");
			Console.WriteLine($"Access RangedWeapons by string index: {stats["Ranged Weapons"]}");
		}
	}
}
