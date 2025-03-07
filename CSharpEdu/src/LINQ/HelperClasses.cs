using System.Collections;

namespace CSharpEdu.src.LINQ
{
	internal enum Team { red, blue };


	internal record class Player(string name, Team team);


	internal class ListToEnumerable : IEnumerable<Player>
	{
		private List<Player> _list;

		public ListToEnumerable(List<Player> list)
		{
			_list = list;
		}

		public IEnumerator<Player> GetEnumerator()
		{
			return new PlayersEnumerator(_list);
			//for (int i = 0; i < _list.Count; i++)
			//{
			//	Console.WriteLine($"{nameof(IEnumerable<Player>.GetEnumerator)} [{i}]:");
			//	yield return _list[i];
			//}
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		internal class PlayersEnumerator : IEnumerator<Player>
		{
			private List<Player> _list;
			int index = -1;

			public object Current => Current;

			Player IEnumerator<Player>.Current
			{
				get
				{
					Console.WriteLine($"{nameof(Current)} [{index}]:");
					return _list[index];
				}
			}

			public PlayersEnumerator(List<Player> list)
			{
				_list = list;
			}

			public bool MoveNext()
			{
				index++;
				return index < _list.Count;
			}

			public void Reset()
			{
				index = -1;
			}

			public void Dispose()
			{
				throw new NotImplementedException();
			}
		}
	}
}
