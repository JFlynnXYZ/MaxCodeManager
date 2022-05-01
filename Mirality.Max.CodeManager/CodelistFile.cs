using System.Xml.Serialization;
using x7fd6e610350f13fb;

namespace Mirality.Max.CodeManager;

public class CodelistFile
{
	public string Filename;

	[XmlAttribute]
	public bool Active = true;

	[XmlIgnore]
	public xc68feac946ffcf6f x06ca69422bbb7502;

	[XmlIgnore]
	public bool Dirty;

	public CodelistFile()
	{
	}

	public CodelistFile(string xb41a802ca5fde63b)
	{
		Filename = xb41a802ca5fde63b;
	}
}
