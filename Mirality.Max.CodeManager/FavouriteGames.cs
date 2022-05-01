using System.Collections;
using System.Collections.Generic;

namespace Mirality.Max.CodeManager;

public class FavouriteGames : IList<FavouriteGame>, ICollection<FavouriteGame>, IEnumerable<FavouriteGame>, IEnumerable
{
	private List<FavouriteGame> InnerList = new List<FavouriteGame>();

	bool ICollection<FavouriteGame>.IsReadOnly => false;

	public int Count => InnerList.Count;

	public FavouriteGame this[int xc0c4c459c6ccbd00]
	{
		get
		{
			return InnerList[xc0c4c459c6ccbd00];
		}
		set
		{
			InnerList[xc0c4c459c6ccbd00] = value;
		}
	}

	public FavouriteGames Clone()
	{
		FavouriteGames favouriteGames = new FavouriteGames();
		favouriteGames.InnerList.AddRange(InnerList);
		return favouriteGames;
	}

	public IEnumerator<FavouriteGame> GetEnumerator()
	{
		return InnerList.GetEnumerator();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return InnerList.GetEnumerator();
	}

	public void Clear()
	{
		InnerList.Clear();
	}

	public bool Contains(FavouriteGame xccb63ca5f63dc470)
	{
		return InnerList.Contains(xccb63ca5f63dc470);
	}

	public bool Contains(uint x28011ef2e60e6ef5)
	{
		using (IEnumerator<FavouriteGame> enumerator = GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				FavouriteGame current = enumerator.Current;
				if (current.GameId == x28011ef2e60e6ef5)
				{
					return true;
				}
			}
		}
		return false;
	}

	public int IndexOf(FavouriteGame xccb63ca5f63dc470)
	{
		return InnerList.IndexOf(xccb63ca5f63dc470);
	}

	public void Add(FavouriteGame xccb63ca5f63dc470)
	{
		if (!Contains(xccb63ca5f63dc470.GameId))
		{
			InnerList.Add(xccb63ca5f63dc470);
		}
	}

	public void Insert(int xc0c4c459c6ccbd00, FavouriteGame xccb63ca5f63dc470)
	{
		Remove(xccb63ca5f63dc470);
		InnerList.Insert(xc0c4c459c6ccbd00, xccb63ca5f63dc470);
	}

	public bool Remove(FavouriteGame xccb63ca5f63dc470)
	{
		return InnerList.Remove(xccb63ca5f63dc470);
	}

	public void Remove(uint x28011ef2e60e6ef5)
	{
		for (int num = Count - 1; num >= 0; num--)
		{
			if (this[num].GameId == x28011ef2e60e6ef5)
			{
				RemoveAt(num);
			}
		}
	}

	public void RemoveAt(int xc0c4c459c6ccbd00)
	{
		InnerList.RemoveAt(xc0c4c459c6ccbd00);
	}

	public void CopyTo(FavouriteGame[] x9d5750eb2d6373bc)
	{
		InnerList.CopyTo(x9d5750eb2d6373bc);
	}

	public void CopyTo(FavouriteGame[] x9d5750eb2d6373bc, int xdbec072306fb2e81)
	{
		InnerList.CopyTo(x9d5750eb2d6373bc, xdbec072306fb2e81);
	}

	public bool IsEquivalentTo(FavouriteGames x3b50be75884cb97e)
	{
		if (Count != x3b50be75884cb97e.Count)
		{
			return false;
		}
		using (IEnumerator<FavouriteGame> enumerator = GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				FavouriteGame current = enumerator.Current;
				if (!x3b50be75884cb97e.Contains(current.GameId))
				{
					return false;
				}
			}
		}
		return true;
	}
}
