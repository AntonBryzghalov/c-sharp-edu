using System.Collections;

namespace CSharpEdu.src.LINQ
{
    internal class LINQTest
    {
        private static List<Player> _players = new List<Player> {
            new Player("Tony", Team.red),
			new Player("Sophia", Team.blue),
			new Player("Hanna", Team.red),
			new Player("Nicole", Team.blue),
			new Player("Vladimir", Team.red),
			new Player("Irina", Team.blue),
		};

		

        private LINQTest() { }

        public static void RunAllLINQTests()
        {
            var (redTeam, blueTeam) = TestWhereSelectionForTeams();
            TestLinqDefferedExecution();
            TestOtherMethods(redTeam, blueTeam);
        }

		private static (IEnumerable<Player> redTeam, IEnumerable<Player> blueTeam) TestWhereSelectionForTeams()
        {
			Console.WriteLine($"Running {nameof(TestWhereSelectionForTeams)}:");

			// GetRedTeam and GetBlueTeam has different syntax of doing the same thing
			var redTeam = GetRedTeam(_players);
            var blueTeam = GetBlueTeam(_players);

			LogEnumerable("Red Team:", redTeam);
            LogEnumerable("Blue Team:", blueTeam);

            return (redTeam, blueTeam);
        }

        private static IEnumerable<Player> GetRedTeam(IEnumerable<Player> players)
        {
			Console.WriteLine($"Running {nameof(GetRedTeam)}:");
			return players.Where(player => player.team == Team.red);
		}

		private static IEnumerable<Player> GetBlueTeam(IEnumerable<Player> players)
		{
			Console.WriteLine($"Running {nameof(GetBlueTeam)}:");
			return from player in players where player.team == Team.blue select player;
		}

		private static void TestLinqDefferedExecution()
		{
			Console.WriteLine($"Running {nameof(TestLinqDefferedExecution)}:");

			var converter = new ListToEnumerable(_players);
			var redTeam = GetRedTeam(converter);
			LogEnumerable("Deffered reading:", redTeam);
		}

		private static void TestOtherMethods(IEnumerable<Player> redTeam, IEnumerable<Player> blueTeam)
        {
			Console.WriteLine($"Running {nameof(TestOtherMethods)}:");

			var redList = redTeam.ToList();
            redList.Add(new Player(redList[0].name, redList[0].team));
            LogEnumerable("Red Team List has a duplicate", redList);

            var distinct = redTeam.Distinct();
            LogEnumerable("Distinct values from Red Team List:", distinct);
        }

        private static void LogEnumerable<T>(string caption, IEnumerable<T> values)
        {
			Console.WriteLine("\n" + caption);
            foreach (T val in values)
				Console.WriteLine(val);
        }
    }
}
