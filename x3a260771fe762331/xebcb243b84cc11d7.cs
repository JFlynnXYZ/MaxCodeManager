using System;
using System.Collections.Generic;

namespace x3a260771fe762331;

internal class xebcb243b84cc11d7
{
	private x33636090f73cdcbf _0364c07ad4dcfe0c;

	private x33636090f73cdcbf _851fcfc17df82b1b;

	private Dictionary<uint, xa0380078f0b6cbb7> _5a80eb62c0d7189e = new Dictionary<uint, xa0380078f0b6cbb7>();

	private Dictionary<uint, xa0380078f0b6cbb7> _6a78f14f880171ac = new Dictionary<uint, xa0380078f0b6cbb7>();

	private Dictionary<x934fb9524f0d460a, xbabc9feec6f641db> _a429dc87a24d0add = new Dictionary<x934fb9524f0d460a, xbabc9feec6f641db>();

	private Dictionary<x934fb9524f0d460a, xbabc9feec6f641db> _2cfdf86cc34b50ca = new Dictionary<x934fb9524f0d460a, xbabc9feec6f641db>();

	private Dictionary<x934fb9524f0d460a, xbabc9feec6f641db> _c09d675434303723 = new Dictionary<x934fb9524f0d460a, xbabc9feec6f641db>();

	private Dictionary<uint, xa0380078f0b6cbb7> _ac7b02fee8234bcf = new Dictionary<uint, xa0380078f0b6cbb7>();

	public x33636090f73cdcbf x0364c07ad4dcfe0c => _0364c07ad4dcfe0c;

	public x33636090f73cdcbf x851fcfc17df82b1b => _851fcfc17df82b1b;

	public ICollection<xa0380078f0b6cbb7> x5a80eb62c0d7189e => _5a80eb62c0d7189e.Values;

	public ICollection<xa0380078f0b6cbb7> x6a78f14f880171ac => _6a78f14f880171ac.Values;

	public ICollection<xbabc9feec6f641db> xa429dc87a24d0add => _a429dc87a24d0add.Values;

	public ICollection<xbabc9feec6f641db> x2cfdf86cc34b50ca => _2cfdf86cc34b50ca.Values;

	public ICollection<xbabc9feec6f641db> xc09d675434303723 => _c09d675434303723.Values;

	public ICollection<xa0380078f0b6cbb7> xac7b02fee8234bcf => _ac7b02fee8234bcf.Values;

	public xebcb243b84cc11d7(x33636090f73cdcbf x6b161b1ae41c1651, x33636090f73cdcbf x0e990edf4549ee50)
	{
		_0364c07ad4dcfe0c = x6b161b1ae41c1651;
		_851fcfc17df82b1b = x0e990edf4549ee50;
		x20fc82162f3b2043();
	}

	public bool xc50b25ead802c791(xa0380078f0b6cbb7 x6849540e228fbc76)
	{
		if (x6849540e228fbc76 == null)
		{
			throw new ArgumentNullException("game");
		}
		return _5a80eb62c0d7189e.ContainsKey(x6849540e228fbc76.x52b8174788d367f9);
	}

	public bool x201282ef5b887ec3(xa0380078f0b6cbb7 x6849540e228fbc76)
	{
		if (x6849540e228fbc76 == null)
		{
			throw new ArgumentNullException("game");
		}
		return _6a78f14f880171ac.ContainsKey(x6849540e228fbc76.x52b8174788d367f9);
	}

	public bool xc50b25ead802c791(xbabc9feec6f641db x9035cf16181332fc)
	{
		if (x9035cf16181332fc == null)
		{
			throw new ArgumentNullException("code");
		}
		return _a429dc87a24d0add.ContainsKey(new x934fb9524f0d460a(x9035cf16181332fc.xa0380078f0b6cbb7.x52b8174788d367f9, x9035cf16181332fc.xb3efee94cf138f44));
	}

	public bool xc4e77da306e0ec75(xbabc9feec6f641db x9035cf16181332fc)
	{
		if (x9035cf16181332fc == null)
		{
			throw new ArgumentNullException("code");
		}
		return _2cfdf86cc34b50ca.ContainsKey(new x934fb9524f0d460a(x9035cf16181332fc.xa0380078f0b6cbb7.x52b8174788d367f9, x9035cf16181332fc.xb3efee94cf138f44));
	}

	public bool x201282ef5b887ec3(xbabc9feec6f641db x9035cf16181332fc)
	{
		if (x9035cf16181332fc == null)
		{
			throw new ArgumentNullException("code");
		}
		return _c09d675434303723.ContainsKey(new x934fb9524f0d460a(x9035cf16181332fc.xa0380078f0b6cbb7.x52b8174788d367f9, x9035cf16181332fc.xb3efee94cf138f44));
	}

	private void x20fc82162f3b2043()
	{
		_5a80eb62c0d7189e.Clear();
		_6a78f14f880171ac.Clear();
		_a429dc87a24d0add.Clear();
		_2cfdf86cc34b50ca.Clear();
		_c09d675434303723.Clear();
		foreach (xa0380078f0b6cbb7 item in x0364c07ad4dcfe0c)
		{
			_6a78f14f880171ac.Add(item.x52b8174788d367f9, item);
			foreach (xbabc9feec6f641db item2 in item)
			{
				_c09d675434303723.Add(new x934fb9524f0d460a(item.x52b8174788d367f9, item2.xb3efee94cf138f44), item2);
			}
		}
		foreach (xa0380078f0b6cbb7 item3 in x851fcfc17df82b1b)
		{
			if (_6a78f14f880171ac.ContainsKey(item3.x52b8174788d367f9))
			{
				_6a78f14f880171ac.Remove(item3.x52b8174788d367f9);
			}
			else
			{
				_5a80eb62c0d7189e.Add(item3.x52b8174788d367f9, item3);
			}
			foreach (xbabc9feec6f641db item4 in item3)
			{
				x934fb9524f0d460a key = new x934fb9524f0d460a(item4.xa0380078f0b6cbb7.x52b8174788d367f9, item4.xb3efee94cf138f44);
				if (_c09d675434303723.ContainsKey(key))
				{
					xbabc9feec6f641db xbabc9feec6f641db2 = _c09d675434303723[key];
					_c09d675434303723.Remove(key);
					if (string.Join(" ", xbabc9feec6f641db2.x7e5b09fa2269d9a5.xa9edb3b115d067da()) != string.Join(" ", item4.x7e5b09fa2269d9a5.xa9edb3b115d067da()))
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

	private void x382e93f903a35665(IEnumerable<xbabc9feec6f641db> xcdff170dbac909bf)
	{
		foreach (xbabc9feec6f641db item in xcdff170dbac909bf)
		{
			if (!xc50b25ead802c791(item.xa0380078f0b6cbb7) && !x201282ef5b887ec3(item.xa0380078f0b6cbb7))
			{
				_ac7b02fee8234bcf[item.xa0380078f0b6cbb7.x52b8174788d367f9] = item.xa0380078f0b6cbb7;
			}
		}
	}
}
