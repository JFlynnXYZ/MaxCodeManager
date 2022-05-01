using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace xca7bfd2e2e8437c4;

[TypeConverter(typeof(x9b13aa2ecbe649f5))]
public class x0bc7d5c84e62d912 : IList<x95fcf261e3011b00>, ICollection<x95fcf261e3011b00>, IEnumerable<x95fcf261e3011b00>, IEnumerable, ICollection, IList
{
	private List<x95fcf261e3011b00> _63b0f7fed3f5bd88 = new List<x95fcf261e3011b00>();

	private x95fcf261e3011b00 _9ce35bc295da5a81;

	[CompilerGenerated]
	private static Comparison<x95fcf261e3011b00> xb253dfacb3fc4c89;

	public int Count => _63b0f7fed3f5bd88.Count;

	bool ICollection<x95fcf261e3011b00>.IsReadOnly => false;

	protected bool IsReadOnly => false;

	bool IList.IsReadOnly => IsReadOnly;

	protected bool IsFixedSize => false;

	bool IList.IsFixedSize => IsFixedSize;

	public x95fcf261e3011b00 this[int xc0c4c459c6ccbd00]
	{
		get
		{
			return _63b0f7fed3f5bd88[xc0c4c459c6ccbd00];
		}
		set
		{
			if (_9ce35bc295da5a81.x62e86f2fb9e3a57b != null && _9ce35bc295da5a81.x62e86f2fb9e3a57b.x65ae7187ad9944b4)
			{
				throw new InvalidOperationException("Cannot reassign node in sorted tree.");
			}
			if (value.x332a8eedb847940d != null || value.x62e86f2fb9e3a57b != null)
			{
				throw new ArgumentException("Node has already been added elsewhere.");
			}
			xb8ce62321f41fcd9(_63b0f7fed3f5bd88[xc0c4c459c6ccbd00]);
			_63b0f7fed3f5bd88[xc0c4c459c6ccbd00] = value;
			xe014cc494bbbb1d4(_63b0f7fed3f5bd88[xc0c4c459c6ccbd00]);
			xcbc511030aa1eefb();
		}
	}

	object IList.this[int xc0c4c459c6ccbd00]
	{
		get
		{
			return this[xc0c4c459c6ccbd00];
		}
		set
		{
			this[xc0c4c459c6ccbd00] = (x95fcf261e3011b00)value;
		}
	}

	protected object SyncRoot => _63b0f7fed3f5bd88;

	object ICollection.SyncRoot => SyncRoot;

	protected bool IsSynchronized => false;

	bool ICollection.IsSynchronized => IsSynchronized;

	public event EventHandler<x495ca8a85eccbead> x6b30bb6c5f41e32f;

	public event EventHandler<x495ca8a85eccbead> x25302ae69cf01877;

	public event EventHandler<x8f674b723ab8cda2> x7757e023237c7679;

	public event EventHandler<x8f674b723ab8cda2> x8f530dd9a6341bae;

	protected virtual void OnExpanding(x495ca8a85eccbead xfbf34718e704c6bc)
	{
		if (this.x6b30bb6c5f41e32f != null)
		{
			this.x6b30bb6c5f41e32f(this, xfbf34718e704c6bc);
		}
	}

	protected virtual void OnCollapsing(x495ca8a85eccbead xfbf34718e704c6bc)
	{
		if (this.x25302ae69cf01877 != null)
		{
			this.x25302ae69cf01877(this, xfbf34718e704c6bc);
		}
	}

	protected virtual void OnExpanded(x8f674b723ab8cda2 xfbf34718e704c6bc)
	{
		if (this.x7757e023237c7679 != null)
		{
			this.x7757e023237c7679(this, xfbf34718e704c6bc);
		}
	}

	protected virtual void OnCollapsed(x8f674b723ab8cda2 xfbf34718e704c6bc)
	{
		if (this.x8f530dd9a6341bae != null)
		{
			this.x8f530dd9a6341bae(this, xfbf34718e704c6bc);
		}
	}

	internal x0bc7d5c84e62d912(x95fcf261e3011b00 x071bde1041617fce)
	{
		_9ce35bc295da5a81 = x071bde1041617fce;
	}

	private void x31e52814f0febd6d(object xe0292b9ed559da7d, x495ca8a85eccbead xfbf34718e704c6bc)
	{
		OnExpanding(xfbf34718e704c6bc);
	}

	private void x180ac33b1a48b2c8(object xe0292b9ed559da7d, x495ca8a85eccbead xfbf34718e704c6bc)
	{
		OnCollapsing(xfbf34718e704c6bc);
	}

	private void x4e143c28e5d82e32(object xe0292b9ed559da7d, x8f674b723ab8cda2 xfbf34718e704c6bc)
	{
		OnExpanded(xfbf34718e704c6bc);
	}

	private void xb1d822a60e722420(object xe0292b9ed559da7d, x8f674b723ab8cda2 xfbf34718e704c6bc)
	{
		OnCollapsed(xfbf34718e704c6bc);
	}

	private void xe014cc494bbbb1d4(x95fcf261e3011b00 xda5bf54deb817e37)
	{
		xda5bf54deb817e37.x332a8eedb847940d = _9ce35bc295da5a81;
		xda5bf54deb817e37.x6b30bb6c5f41e32f += x31e52814f0febd6d;
		xda5bf54deb817e37.x25302ae69cf01877 += x180ac33b1a48b2c8;
		xda5bf54deb817e37.x7757e023237c7679 += x4e143c28e5d82e32;
		xda5bf54deb817e37.x8f530dd9a6341bae += xb1d822a60e722420;
	}

	private void xb8ce62321f41fcd9(x95fcf261e3011b00 xda5bf54deb817e37)
	{
		xda5bf54deb817e37.x332a8eedb847940d = null;
		xda5bf54deb817e37.x6b30bb6c5f41e32f -= x31e52814f0febd6d;
		xda5bf54deb817e37.x25302ae69cf01877 -= x180ac33b1a48b2c8;
		xda5bf54deb817e37.x7757e023237c7679 -= x4e143c28e5d82e32;
		xda5bf54deb817e37.x8f530dd9a6341bae -= xb1d822a60e722420;
	}

	public virtual x95fcf261e3011b00 Add(string xb41faee6912a2313)
	{
		x95fcf261e3011b00 x95fcf261e3011b = new x95fcf261e3011b00(xb41faee6912a2313);
		Add(x95fcf261e3011b);
		return x95fcf261e3011b;
	}

	public virtual int Add(x95fcf261e3011b00 xda5bf54deb817e37)
	{
		return x2252c77099794fa9(xda5bf54deb817e37);
	}

	private void x20908faacd2592f9(x95fcf261e3011b00 xccb63ca5f63dc470)
	{
		Add(xccb63ca5f63dc470);
	}

	void ICollection<x95fcf261e3011b00>.Add(x95fcf261e3011b00 xccb63ca5f63dc470)
	{
		//ILSpy generated this explicit interface implementation from .override directive in x20908faacd2592f9
		this.x20908faacd2592f9(xccb63ca5f63dc470);
	}

	private int xae8b83d75f3358b9(object xbcea506a33cf9111)
	{
		return Add((x95fcf261e3011b00)xbcea506a33cf9111);
	}

	int IList.Add(object xbcea506a33cf9111)
	{
		//ILSpy generated this explicit interface implementation from .override directive in xae8b83d75f3358b9
		return this.xae8b83d75f3358b9(xbcea506a33cf9111);
	}

	public virtual x95fcf261e3011b00 Add(string xb41faee6912a2313, int xc931041ff8b5600b)
	{
		x95fcf261e3011b00 x95fcf261e3011b = new x95fcf261e3011b00(xb41faee6912a2313);
		x95fcf261e3011b.xaa7785f730d8dd15 = xc931041ff8b5600b;
		Add(x95fcf261e3011b);
		return x95fcf261e3011b;
	}

	public virtual x95fcf261e3011b00 Add(string xb41faee6912a2313, string x0b5f80e1d4d474bd)
	{
		x95fcf261e3011b00 x95fcf261e3011b = new x95fcf261e3011b00(xb41faee6912a2313);
		x95fcf261e3011b.xc439cbba6c00a3a0 = x0b5f80e1d4d474bd;
		Add(x95fcf261e3011b);
		return x95fcf261e3011b;
	}

	private void xcbc511030aa1eefb()
	{
		if (_9ce35bc295da5a81.x62e86f2fb9e3a57b != null)
		{
			_9ce35bc295da5a81.x62e86f2fb9e3a57b.x7facab8f46b5857c();
		}
	}

	private int x2252c77099794fa9(x95fcf261e3011b00 xda5bf54deb817e37)
	{
		if (xda5bf54deb817e37 == null)
		{
			throw new ArgumentNullException("node");
		}
		xea5e4be807a4597b view = _9ce35bc295da5a81.x62e86f2fb9e3a57b;
		if (xda5bf54deb817e37.x332a8eedb847940d != null || xda5bf54deb817e37.x62e86f2fb9e3a57b != null)
		{
			throw new ArgumentException("Node has already been added elsewhere.", "node");
		}
		xe014cc494bbbb1d4(xda5bf54deb817e37);
		if (view != null && view.x65ae7187ad9944b4)
		{
			int num = _63b0f7fed3f5bd88.FindIndex((x95fcf261e3011b00 x3bd62873fafa6252) => (view.x97ebca14fccfbefa == null) ? (StringComparer.CurrentCulture.Compare(xda5bf54deb817e37.xf9ad6fb78355fe13, x3bd62873fafa6252.xf9ad6fb78355fe13) > 0) : (view.x97ebca14fccfbefa.Compare(xda5bf54deb817e37, x3bd62873fafa6252) > 0));
			if (num >= 0)
			{
				_63b0f7fed3f5bd88.Insert(num, xda5bf54deb817e37);
				xcbc511030aa1eefb();
				return num;
			}
		}
		_63b0f7fed3f5bd88.Add(xda5bf54deb817e37);
		xcbc511030aa1eefb();
		return _63b0f7fed3f5bd88.Count - 1;
	}

	public virtual void AddRange(x95fcf261e3011b00[] xa955664f4f50999d)
	{
		if (xa955664f4f50999d == null)
		{
			throw new ArgumentNullException("nodes");
		}
		if (xa955664f4f50999d.Length <= 0)
		{
			return;
		}
		xea5e4be807a4597b x62e86f2fb9e3a57b = _9ce35bc295da5a81.x62e86f2fb9e3a57b;
		x62e86f2fb9e3a57b?.x5577363cc650aaeb();
		try
		{
			foreach (x95fcf261e3011b00 xda5bf54deb817e in xa955664f4f50999d)
			{
				Add(xda5bf54deb817e);
			}
		}
		finally
		{
			x62e86f2fb9e3a57b?.x3ae2e4d73c7847ae();
		}
	}

	public void Insert(int xc0c4c459c6ccbd00, x95fcf261e3011b00 xccb63ca5f63dc470)
	{
		if (xccb63ca5f63dc470 == null)
		{
			throw new ArgumentNullException("item");
		}
		xea5e4be807a4597b x62e86f2fb9e3a57b = _9ce35bc295da5a81.x62e86f2fb9e3a57b;
		if (xccb63ca5f63dc470.x332a8eedb847940d != null || xccb63ca5f63dc470.x62e86f2fb9e3a57b != null)
		{
			throw new ArgumentException("Node has already been added elsewhere.", "item");
		}
		if (x62e86f2fb9e3a57b != null && x62e86f2fb9e3a57b.x65ae7187ad9944b4)
		{
			throw new InvalidOperationException("Cannot insert into sorted tree.");
		}
		xe014cc494bbbb1d4(xccb63ca5f63dc470);
		_63b0f7fed3f5bd88.Insert(xc0c4c459c6ccbd00, xccb63ca5f63dc470);
		xcbc511030aa1eefb();
	}

	private void x87c211383e3062d5(int xc0c4c459c6ccbd00, object xbcea506a33cf9111)
	{
		Insert(xc0c4c459c6ccbd00, (x95fcf261e3011b00)xbcea506a33cf9111);
	}

	void IList.Insert(int xc0c4c459c6ccbd00, object xbcea506a33cf9111)
	{
		//ILSpy generated this explicit interface implementation from .override directive in x87c211383e3062d5
		this.x87c211383e3062d5(xc0c4c459c6ccbd00, xbcea506a33cf9111);
	}

	public virtual void Clear()
	{
		foreach (x95fcf261e3011b00 item in _63b0f7fed3f5bd88)
		{
			xb8ce62321f41fcd9(item);
		}
		_63b0f7fed3f5bd88.Clear();
		xcbc511030aa1eefb();
	}

	public int IndexOf(x95fcf261e3011b00 xccb63ca5f63dc470)
	{
		return _63b0f7fed3f5bd88.IndexOf(xccb63ca5f63dc470);
	}

	private int x104b91678c6b7dff(object xbcea506a33cf9111)
	{
		return IndexOf((x95fcf261e3011b00)xbcea506a33cf9111);
	}

	int IList.IndexOf(object xbcea506a33cf9111)
	{
		//ILSpy generated this explicit interface implementation from .override directive in x104b91678c6b7dff
		return this.x104b91678c6b7dff(xbcea506a33cf9111);
	}

	public bool Contains(x95fcf261e3011b00 xccb63ca5f63dc470)
	{
		return _63b0f7fed3f5bd88.Contains(xccb63ca5f63dc470);
	}

	private bool x6532c18338cc2620(object xbcea506a33cf9111)
	{
		return Contains((x95fcf261e3011b00)xbcea506a33cf9111);
	}

	bool IList.Contains(object xbcea506a33cf9111)
	{
		//ILSpy generated this explicit interface implementation from .override directive in x6532c18338cc2620
		return this.x6532c18338cc2620(xbcea506a33cf9111);
	}

	public bool Remove(x95fcf261e3011b00 xccb63ca5f63dc470)
	{
		if (_63b0f7fed3f5bd88.Remove(xccb63ca5f63dc470))
		{
			xb8ce62321f41fcd9(xccb63ca5f63dc470);
			xcbc511030aa1eefb();
			return true;
		}
		return false;
	}

	private void x7d6f7f540d2a814d(object xbcea506a33cf9111)
	{
		Remove((x95fcf261e3011b00)xbcea506a33cf9111);
	}

	void IList.Remove(object xbcea506a33cf9111)
	{
		//ILSpy generated this explicit interface implementation from .override directive in x7d6f7f540d2a814d
		this.x7d6f7f540d2a814d(xbcea506a33cf9111);
	}

	public void RemoveAt(int xc0c4c459c6ccbd00)
	{
		xb8ce62321f41fcd9(_63b0f7fed3f5bd88[xc0c4c459c6ccbd00]);
		_63b0f7fed3f5bd88.RemoveAt(xc0c4c459c6ccbd00);
		xcbc511030aa1eefb();
	}

	public void xee9aac96ed24c7f9()
	{
		xe0547d4dd67e3884();
		xcbc511030aa1eefb();
	}

	private void xe0547d4dd67e3884()
	{
		xea5e4be807a4597b x62e86f2fb9e3a57b = _9ce35bc295da5a81.x62e86f2fb9e3a57b;
		if (x62e86f2fb9e3a57b == null || x62e86f2fb9e3a57b.x97ebca14fccfbefa == null)
		{
			_63b0f7fed3f5bd88.Sort((x95fcf261e3011b00 x19218ffab70283ef, x95fcf261e3011b00 xe7ebe10fa44d8d49) => StringComparer.CurrentCulture.Compare(x19218ffab70283ef.xf9ad6fb78355fe13, xe7ebe10fa44d8d49.xf9ad6fb78355fe13));
		}
		else
		{
			_63b0f7fed3f5bd88.Sort(x62e86f2fb9e3a57b.x97ebca14fccfbefa);
		}
		using IEnumerator<x95fcf261e3011b00> enumerator = GetEnumerator();
		while (enumerator.MoveNext())
		{
			x95fcf261e3011b00 current = enumerator.Current;
			current.x63b0f7fed3f5bd88.xe0547d4dd67e3884();
		}
	}

	public IEnumerator<x95fcf261e3011b00> GetEnumerator()
	{
		return _63b0f7fed3f5bd88.GetEnumerator();
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

	public void CopyTo(x95fcf261e3011b00[] x9d5750eb2d6373bc, int xdbec072306fb2e81)
	{
		_63b0f7fed3f5bd88.CopyTo(x9d5750eb2d6373bc, xdbec072306fb2e81);
	}

	private void x21912c843ee261be(Array x9d5750eb2d6373bc, int xc0c4c459c6ccbd00)
	{
		Array.Copy(_63b0f7fed3f5bd88.ToArray(), 0, x9d5750eb2d6373bc, xc0c4c459c6ccbd00, _63b0f7fed3f5bd88.Count);
	}

	void ICollection.CopyTo(Array x9d5750eb2d6373bc, int xc0c4c459c6ccbd00)
	{
		//ILSpy generated this explicit interface implementation from .override directive in x21912c843ee261be
		this.x21912c843ee261be(x9d5750eb2d6373bc, xc0c4c459c6ccbd00);
	}

	[CompilerGenerated]
	private static int xabaab862a3152f5a(x95fcf261e3011b00 x19218ffab70283ef, x95fcf261e3011b00 xe7ebe10fa44d8d49)
	{
		return StringComparer.CurrentCulture.Compare(x19218ffab70283ef.xf9ad6fb78355fe13, xe7ebe10fa44d8d49.xf9ad6fb78355fe13);
	}
}
