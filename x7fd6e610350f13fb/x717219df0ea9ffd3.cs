using System;
using System.Collections;
using System.Collections.Generic;
using x3a260771fe762331;

namespace x7fd6e610350f13fb;

public class x717219df0ea9ffd3 : IEnumerable<xfd5dc9a89edfa955>, IEnumerable
{
	private xa0380078f0b6cbb7 _cde1799d3b83bb92;

	private xa0380078f0b6cbb7 _34ec3a293021c833;

	private List<xfd5dc9a89edfa955> _9425d7602dc80ff4;

	public xa0380078f0b6cbb7 xcde1799d3b83bb92 => _cde1799d3b83bb92;

	public xa0380078f0b6cbb7 x34ec3a293021c833 => _34ec3a293021c833;

	public List<xfd5dc9a89edfa955> x9425d7602dc80ff4 => _9425d7602dc80ff4;

	public x717219df0ea9ffd3(xa0380078f0b6cbb7 xa016673621ddfed9, xa0380078f0b6cbb7 x44f5de605a235763)
	{
		_cde1799d3b83bb92 = xa016673621ddfed9;
		_34ec3a293021c833 = x44f5de605a235763;
		xf00ec3a0a012caa0();
	}

	public x717219df0ea9ffd3(xa0380078f0b6cbb7 x6849540e228fbc76)
		: this(x6849540e228fbc76, null)
	{
	}

	public IEnumerator<xfd5dc9a89edfa955> GetEnumerator()
	{
		return _9425d7602dc80ff4.GetEnumerator();
	}

	private IEnumerator x05b0b83b5e6c5de6()
	{
		return GetEnumerator();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		//ILSpy generated this explicit interface implementation from .override directive in x05b0b83b5e6c5de6
		return this.x05b0b83b5e6c5de6();
	}

	public void xf00ec3a0a012caa0()
	{
		_9425d7602dc80ff4 = new List<xfd5dc9a89edfa955>();
		foreach (xbabc9feec6f641db item in xcde1799d3b83bb92)
		{
			xbabc9feec6f641db xc9214be88fa = ((x34ec3a293021c833 == null) ? null : x34ec3a293021c833.x13d95bb225c01867(item.xb3efee94cf138f44));
			_9425d7602dc80ff4.Add(new xfd5dc9a89edfa955(item, xc9214be88fa));
		}
		if (x34ec3a293021c833 == null)
		{
			return;
		}
		foreach (xbabc9feec6f641db item2 in x34ec3a293021c833)
		{
			if (xcde1799d3b83bb92.x13d95bb225c01867(item2.xb3efee94cf138f44) == null)
			{
				_9425d7602dc80ff4.Add(new xfd5dc9a89edfa955(null, item2));
			}
		}
	}

	public List<xbabc9feec6f641db> xfd788c2d21a2ecf6(Predicate<xbabc9feec6f641db> x0a7c6450dfaa2f9a)
	{
		List<xbabc9feec6f641db> list = new List<xbabc9feec6f641db>();
		foreach (xbabc9feec6f641db item in xcde1799d3b83bb92)
		{
			if (x0a7c6450dfaa2f9a(item))
			{
				list.Add(item);
			}
		}
		if (x34ec3a293021c833 != null)
		{
			foreach (xbabc9feec6f641db item2 in x34ec3a293021c833)
			{
				if (x0a7c6450dfaa2f9a(item2))
				{
					list.Add(item2);
				}
			}
			return list;
		}
		return list;
	}
}
