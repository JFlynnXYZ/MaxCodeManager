using System;
using System.Globalization;
using System.IO;
using System.Xml;

namespace x2ac61696da69bb5f;

internal sealed class x2193eba2bfddddf7 : IDisposable
{
	private XmlWriter x5aa326f374b3d0ef;

	private TextWriter x7fdc1bfc45368624;

	public x2193eba2bfddddf7(TextWriter xbdfb620b7167944b, bool x4658008e2185b037)
		: this(xbdfb620b7167944b, x4658008e2185b037, null)
	{
	}

	public x2193eba2bfddddf7(TextWriter xbdfb620b7167944b, bool x4658008e2185b037, string x77c5a31ec0891f38)
	{
		XmlWriterSettings settings = new XmlWriterSettings
		{
			Indent = x4658008e2185b037
		};
		x7fdc1bfc45368624 = xbdfb620b7167944b;
		x5aa326f374b3d0ef = XmlWriter.Create(xbdfb620b7167944b, settings);
		x5aa326f374b3d0ef.WriteStartDocument();
		if (!string.IsNullOrEmpty(x77c5a31ec0891f38))
		{
			x5aa326f374b3d0ef.WriteComment(x77c5a31ec0891f38);
		}
		x5aa326f374b3d0ef.WriteStartElement("CodeList", "http://www.mirality.co.nz/ns/MaxCodeManager2-Encrypted1");
		x5aa326f374b3d0ef.WriteAttributeString("xsi", "schemaLocation", "http://www.w3.org/2001/XMLSchema-instance", "http://www.mirality.co.nz/ns/MaxCodeManager2-Encrypted1 http://www.mirality.co.nz/schema/MCEncrypted.xsd");
	}

	public void Dispose()
	{
		x8ffe90e7fbccfccd();
	}

	public void x8ffe90e7fbccfccd()
	{
		if (x5aa326f374b3d0ef != null)
		{
			bool indent = x5aa326f374b3d0ef.Settings.Indent;
			x5aa326f374b3d0ef.WriteEndDocument();
			x5aa326f374b3d0ef.Flush();
			if (indent)
			{
				x7fdc1bfc45368624.WriteLine();
			}
			if (x7fdc1bfc45368624 != Console.Out && x7fdc1bfc45368624 != Console.Error)
			{
				x5aa326f374b3d0ef.Close();
			}
			x7fdc1bfc45368624 = null;
		}
	}

	public void xc4305ca6c268b073(string xeaf1b27180c0557b, Codes code)
	{
		if (code == null)
		{
			throw new ArgumentNullException("code");
		}
		if (x5aa326f374b3d0ef == null)
		{
			throw new InvalidOperationException("Writer closed.");
		}
		x5aa326f374b3d0ef.WriteStartElement("Code");
		if (xeaf1b27180c0557b != null)
		{
			x5aa326f374b3d0ef.WriteAttributeString("Id", xeaf1b27180c0557b);
		}
		string[] array = code.xa9edb3b115d067da();
		string[] array2 = array;
		foreach (string value in array2)
		{
			x5aa326f374b3d0ef.WriteElementString("Line", value);
		}
		x5aa326f374b3d0ef.WriteEndElement();
	}

	public void xedd6b9ec4ab87ea1(string xeaf1b27180c0557b, string xc685eed2987781a2, int xeb28d76ef7e31289)
	{
		if (x5aa326f374b3d0ef == null)
		{
			throw new InvalidOperationException("Writer closed.");
		}
		x5aa326f374b3d0ef.WriteStartElement("Code");
		if (xeaf1b27180c0557b != null)
		{
			x5aa326f374b3d0ef.WriteAttributeString("Id", xeaf1b27180c0557b);
		}
		x5aa326f374b3d0ef.WriteStartElement("Error");
		if (xeb28d76ef7e31289 >= 0)
		{
			x5aa326f374b3d0ef.WriteAttributeString("Line", (xeb28d76ef7e31289 + 1).ToString(CultureInfo.InvariantCulture));
		}
		x5aa326f374b3d0ef.WriteString(xc685eed2987781a2);
		x5aa326f374b3d0ef.WriteEndElement();
		x5aa326f374b3d0ef.WriteEndElement();
	}
}
