using System;
using System.Globalization;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace Mirality.Max.MaxCodes;

[Serializable]
internal class CodeLineException : Exception
{
	private int _LineIndex;

	private string _Line;

	public int LineIndex => _LineIndex;

	public string Line => _Line;

	public CodeLineException(int xeb28d76ef7e31289, string x311e7a92306d7199, Exception xb35f79a43e184314)
		: base(string.Format(CultureInfo.CurrentCulture, "Error in code line {0} ({1})" + ((xb35f79a43e184314 == null) ? "" : (": " + xb35f79a43e184314.Message)), xeb28d76ef7e31289 + 1, x311e7a92306d7199), xb35f79a43e184314)
	{
		_LineIndex = xeb28d76ef7e31289;
		_Line = x311e7a92306d7199;
	}

	public CodeLineException()
	{
	}

	[SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.SerializationFormatter)]
	protected CodeLineException(SerializationInfo x8d3f74e5f925679c, StreamingContext x0f7b23d1c393aed9)
		: base(x8d3f74e5f925679c, x0f7b23d1c393aed9)
	{
		if (x8d3f74e5f925679c == null)
		{
			throw new ArgumentNullException("info");
		}
		_LineIndex = x8d3f74e5f925679c.GetInt32("LineIndex");
		_Line = x8d3f74e5f925679c.GetString("Line");
	}

	[SecurityPermission(SecurityAction.Demand, SerializationFormatter = true)]
	public override void GetObjectData(SerializationInfo x8d3f74e5f925679c, StreamingContext x0f7b23d1c393aed9)
	{
		base.GetObjectData(x8d3f74e5f925679c, x0f7b23d1c393aed9);
		if (x8d3f74e5f925679c == null)
		{
			throw new ArgumentNullException("info");
		}
		x8d3f74e5f925679c.AddValue("LineIndex", LineIndex);
		x8d3f74e5f925679c.AddValue("Line", Line);
	}
}
