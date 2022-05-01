using Mirality.Max.MaxCodes;
using x3a260771fe762331;

namespace x7fd6e610350f13fb;

public struct x131eae80bdcb392e
{
	public static readonly x131eae80bdcb392e x45260ad4b94166f2 = default(x131eae80bdcb392e);

	private Codelist x48ba31883363a74d;

	private Codelist xe5419d2bfb9d8f67;

	private Codelist _32866930416901c3;

	public Codelist x32866930416901c3 => _32866930416901c3;

	public bool xc4d326c7b2d73aa6 => x48ba31883363a74d != null;

	public bool x09d3019ea043c710 => xe5419d2bfb9d8f67 != null;

	public bool xe60cad9a2d565735
	{
		get
		{
			if (!xc4d326c7b2d73aa6)
			{
				return x09d3019ea043c710;
			}
			return true;
		}
	}

	public x131eae80bdcb392e(Codelist xcbac40a09f61fedb, Codelist xf21973aee6cb64fb)
	{
		x48ba31883363a74d = xcbac40a09f61fedb;
		xe5419d2bfb9d8f67 = xf21973aee6cb64fb;
		_32866930416901c3 = null;
		xbbec9f370125b395();
	}

	public override bool Equals(object xa59bff7708de3a18)
	{
		if (xa59bff7708de3a18 is x131eae80bdcb392e x3b50be75884cb97e)
		{
			return Equals(x3b50be75884cb97e);
		}
		return false;
	}

	public bool Equals(x131eae80bdcb392e x3b50be75884cb97e)
	{
		if (x48ba31883363a74d == x3b50be75884cb97e.x48ba31883363a74d)
		{
			return xe5419d2bfb9d8f67 == x3b50be75884cb97e.xe5419d2bfb9d8f67;
		}
		return false;
	}

	public override int GetHashCode()
	{
		return x48ba31883363a74d.GetHashCode() ^ xe5419d2bfb9d8f67.GetHashCode();
	}

	public static bool operator ==(x131eae80bdcb392e x363a1f6e92149df5, x131eae80bdcb392e xd6efc2d6e891a521)
	{
		return x363a1f6e92149df5.Equals(xd6efc2d6e891a521);
	}

	public static bool operator !=(x131eae80bdcb392e x363a1f6e92149df5, x131eae80bdcb392e xd6efc2d6e891a521)
	{
		return !x363a1f6e92149df5.Equals(xd6efc2d6e891a521);
	}

	public Codelist x38758cbbee49e4cb(RegionCode xa4d52e34b62b5495)
	{
		return xa4d52e34b62b5495 switch
		{
			RegionCode.PAL => x48ba31883363a74d, 
			RegionCode.NTSC => xe5419d2bfb9d8f67, 
			_ => null, 
		};
	}

	public void x90fda48194fc6b9a(RegionCode xa4d52e34b62b5495, Codelist list)
	{
		switch (xa4d52e34b62b5495)
		{
		case RegionCode.PAL:
			x48ba31883363a74d = list;
			break;
		case RegionCode.NTSC:
			xe5419d2bfb9d8f67 = list;
			break;
		}
		xbbec9f370125b395();
	}

	private void xbbec9f370125b395()
	{
		if (xc4d326c7b2d73aa6 && x09d3019ea043c710)
		{
			_32866930416901c3 = new Codelist();
			_32866930416901c3.xd5da23b762ce52a2(x48ba31883363a74d);
			_32866930416901c3.xd5da23b762ce52a2(xe5419d2bfb9d8f67);
		}
		else if (x09d3019ea043c710)
		{
			_32866930416901c3 = xe5419d2bfb9d8f67;
		}
		else
		{
			_32866930416901c3 = x48ba31883363a74d;
		}
	}
}
