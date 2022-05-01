using System.Collections;
using System.Collections.Generic;
using xca7bfd2e2e8437c4;

namespace Mirality.Max.CodeManager;

public class CodelistFileCollection : IList<CodelistFile>, ICollection<CodelistFile>, IEnumerable<CodelistFile>, IEnumerable
{
	private List<CodelistFile> InnerList = new List<CodelistFile>();

	bool ICollection<CodelistFile>.IsReadOnly => false;

	public int Count => InnerList.Count;

	public CodelistFile this[int xc0c4c459c6ccbd00]
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

	public CodelistFileCollection Clone()
	{
		CodelistFileCollection codelistFileCollection = new CodelistFileCollection();
		codelistFileCollection.InnerList.AddRange(InnerList);
		return codelistFileCollection;
	}

	public IEnumerator<CodelistFile> GetEnumerator()
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

	public bool Contains(CodelistFile item)
	{
		return InnerList.Contains(item);
	}

	public bool Contains(string xb41a802ca5fde63b)
	{
		using (IEnumerator<CodelistFile> enumerator = GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				CodelistFile current = enumerator.Current;
				if (x289f1a0ee2f795a7.x4f90d54847434178(xb41a802ca5fde63b, current.Filename))
				{
					return true;
				}
			}
		}
		return false;
	}

	public int IndexOf(CodelistFile item)
	{
		return InnerList.IndexOf(item);
	}

	public void Add(CodelistFile item)
	{
		if (!Contains(item))
		{
			InnerList.Add(item);
		}
	}

	public void Insert(int xc0c4c459c6ccbd00, CodelistFile item)
	{
		Remove(item);
		InnerList.Insert(xc0c4c459c6ccbd00, item);
	}

	public bool Remove(CodelistFile item)
	{
		return InnerList.Remove(item);
	}

	public void RemoveAt(int xc0c4c459c6ccbd00)
	{
		InnerList.RemoveAt(xc0c4c459c6ccbd00);
	}

	public void CopyTo(CodelistFile[] x9d5750eb2d6373bc)
	{
		InnerList.CopyTo(x9d5750eb2d6373bc);
	}

	public void CopyTo(CodelistFile[] x9d5750eb2d6373bc, int xdbec072306fb2e81)
	{
		InnerList.CopyTo(x9d5750eb2d6373bc, xdbec072306fb2e81);
	}
}
