using x3a260771fe762331;

namespace x7fd6e610350f13fb;

public class xfd5dc9a89edfa955
{
	private CodeEntry _5744d14068b65123;

	private CodeEntry _7d3fbc25b599c9f7;

	public CodeEntry x5744d14068b65123 => _5744d14068b65123;

	public CodeEntry x7d3fbc25b599c9f7 => _7d3fbc25b599c9f7;

	public CodeEntry xb0b4ff1622a01d12 => x5744d14068b65123 ?? x7d3fbc25b599c9f7;

	public bool x8c84b6fad60c11f5 => x5744d14068b65123 != null;

	public bool xad1420ffae650ce4 => x7d3fbc25b599c9f7 != null;

	public bool xa157de8185757b11 => !x8c84b6fad60c11f5;

	public xfd5dc9a89edfa955(CodeEntry x73f62bac7f9e0f80, CodeEntry xc9214be88fa59013)
	{
		_5744d14068b65123 = x73f62bac7f9e0f80;
		_7d3fbc25b599c9f7 = xc9214be88fa59013;
	}

	public xfd5dc9a89edfa955(CodeEntry code)
		: this(code, null)
	{
	}
}
