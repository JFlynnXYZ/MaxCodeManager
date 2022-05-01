using System.Windows.Forms;

namespace xca7bfd2e2e8437c4;

internal class x03a477b12104a885
{
	private bool _3aad9a5e69aaba05 = true;

	private ImageList _7bc501a48fc6524b;

	private int _d1bdf42207dd3638 = -1;

	private string _b66f90d7e750b49e = string.Empty;

	public virtual ImageList ImageList
	{
		get
		{
			return _7bc501a48fc6524b;
		}
		set
		{
			_7bc501a48fc6524b = value;
		}
	}

	public virtual int Index
	{
		get
		{
			return _d1bdf42207dd3638;
		}
		set
		{
			_d1bdf42207dd3638 = value;
			_b66f90d7e750b49e = string.Empty;
			_3aad9a5e69aaba05 = true;
		}
	}

	public virtual int ActualIndex
	{
		get
		{
			if (_3aad9a5e69aaba05)
			{
				return Index;
			}
			if (ImageList != null)
			{
				return ImageList.Images.IndexOfKey(Key);
			}
			return -1;
		}
	}

	public virtual string Key
	{
		get
		{
			return _b66f90d7e750b49e;
		}
		set
		{
			_b66f90d7e750b49e = ((value == null) ? string.Empty : value);
			_d1bdf42207dd3638 = -1;
			_3aad9a5e69aaba05 = false;
		}
	}
}
