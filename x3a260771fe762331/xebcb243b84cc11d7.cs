using System;
using System.Collections.Generic;

namespace x3a260771fe762331;

internal class xebcb243b84cc11d7
{
	private Codelist _0364c07ad4dcfe0c;

	private Codelist _851fcfc17df82b1b;

	private Dictionary<uint, GameEntry> _5a80eb62c0d7189e = new Dictionary<uint, GameEntry>();

	private Dictionary<uint, GameEntry> _6a78f14f880171ac = new Dictionary<uint, GameEntry>();

	private Dictionary<x934fb9524f0d460a, CodeEntry> _a429dc87a24d0add = new Dictionary<x934fb9524f0d460a, CodeEntry>();

	private Dictionary<x934fb9524f0d460a, CodeEntry> _2cfdf86cc34b50ca = new Dictionary<x934fb9524f0d460a, CodeEntry>();

	private Dictionary<x934fb9524f0d460a, CodeEntry> _c09d675434303723 = new Dictionary<x934fb9524f0d460a, CodeEntry>();

	private Dictionary<uint, GameEntry> _ac7b02fee8234bcf = new Dictionary<uint, GameEntry>();

	public Codelist x0364c07ad4dcfe0c => _0364c07ad4dcfe0c;

	public Codelist x851fcfc17df82b1b => _851fcfc17df82b1b;

	public ICollection<GameEntry> x5a80eb62c0d7189e => _5a80eb62c0d7189e.Values;

	public ICollection<GameEntry> x6a78f14f880171ac => _6a78f14f880171ac.Values;

	public ICollection<CodeEntry> xa429dc87a24d0add => _a429dc87a24d0add.Values;

	public ICollection<CodeEntry> x2cfdf86cc34b50ca => _2cfdf86cc34b50ca.Values;

	public ICollection<CodeEntry> xc09d675434303723 => _c09d675434303723.Values;

	public ICollection<GameEntry> xac7b02fee8234bcf => _ac7b02fee8234bcf.Values;

	public xebcb243b84cc11d7(Codelist x6b161b1ae41c1651, Codelist x0e990edf4549ee50)
	{
		_0364c07ad4dcfe0c = x6b161b1ae41c1651;
		_851fcfc17df82b1b = x0e990edf4549ee50;
		x20fc82162f3b2043();
	}

	public bool xc50b25ead802c791(GameEntry game)
	{
		if (game == null)
		{
			throw new ArgumentNullException("game");
		}
		return _5a80eb62c0d7189e.ContainsKey(game.x52b8174788d367f9);
	}

	public bool x201282ef5b887ec3(GameEntry game)
	{
		if (game == null)
		{
			throw new ArgumentNullException("game");
		}
		return _6a78f14f880171ac.ContainsKey(game.x52b8174788d367f9);
	}

	public bool xc50b25ead802c791(CodeEntry code)
	{
		if (code == null)
		{
			throw new ArgumentNullException("code");
		}
		return _a429dc87a24d0add.ContainsKey(new x934fb9524f0d460a(code.GameEntry.x52b8174788d367f9, code.xb3efee94cf138f44));
	}

	public bool xc4e77da306e0ec75(CodeEntry code)
	{
		if (code == null)
		{
			throw new ArgumentNullException("code");
		}
		return _2cfdf86cc34b50ca.ContainsKey(new x934fb9524f0d460a(code.GameEntry.x52b8174788d367f9, code.xb3efee94cf138f44));
	}

	public bool x201282ef5b887ec3(CodeEntry code)
	{
		if (code == null)
		{
			throw new ArgumentNullException("code");
		}
		return _c09d675434303723.ContainsKey(new x934fb9524f0d460a(code.GameEntry.x52b8174788d367f9, code.xb3efee94cf138f44));
	}

	private void x20fc82162f3b2043()
	{
		_5a80eb62c0d7189e.Clear();
		_6a78f14f880171ac.Clear();
		_a429dc87a24d0add.Clear();
		_2cfdf86cc34b50ca.Clear();
		_c09d675434303723.Clear();
		foreach (GameEntry item in x0364c07ad4dcfe0c)
		{
			_6a78f14f880171ac.Add(item.x52b8174788d367f9, item);
			foreach (CodeEntry item2 in item)
			{
				_c09d675434303723.Add(new x934fb9524f0d460a(item.x52b8174788d367f9, item2.xb3efee94cf138f44), item2);
			}
		}
		foreach (GameEntry item3 in x851fcfc17df82b1b)
		{
			if (_6a78f14f880171ac.ContainsKey(item3.x52b8174788d367f9))
			{
				_6a78f14f880171ac.Remove(item3.x52b8174788d367f9);
			}
			else
			{
				_5a80eb62c0d7189e.Add(item3.x52b8174788d367f9, item3);
			}
			foreach (CodeEntry item4 in item3)
			{
				x934fb9524f0d460a key = new x934fb9524f0d460a(item4.GameEntry.x52b8174788d367f9, item4.xb3efee94cf138f44);
				if (_c09d675434303723.ContainsKey(key))
				{
					CodeEntry xbabc9feec6f641db2 = _c09d675434303723[key];
					_c09d675434303723.Remove(key);
					if (string.Join(" ", xbabc9feec6f641db2.CheatCodes.xa9edb3b115d067da()) != string.Join(" ", item4.CheatCodes.xa9edb3b115d067da()))
					{
						_2cfdf86cc34b50ca.Add(key, item4);
					}
				}
				else
				{
					_a429dc87a24d0add.Add(key, item4);
				}
			}
		}
		_ac7b02fee8234bcf.Clear();
		x382e93f903a35665(xc09d675434303723);
		x382e93f903a35665(xa429dc87a24d0add);
		x382e93f903a35665(x2cfdf86cc34b50ca);
	}

	private void x382e93f903a35665(IEnumerable<CodeEntry> codes)
	{
		foreach (CodeEntry item in codes)
		{
			if (!xc50b25ead802c791(item.GameEntry) && !x201282ef5b887ec3(item.GameEntry))
			{
				_ac7b02fee8234bcf[item.GameEntry.x52b8174788d367f9] = item.GameEntry;
			}
		}
	}
}
