using System;
using System.Globalization;
using System.IO;
using System.Xml;

namespace x2ac61696da69bb5f;

internal sealed class xed601ddc3e643870 : IDisposable
{
	private XmlWriter x5aa326f374b3d0ef;

	private TextWriter x7fdc1bfc45368624;

	public xed601ddc3e643870(TextWriter xbdfb620b7167944b, bool x4658008e2185b037)
		: this(xbdfb620b7167944b, x4658008e2185b037, null)
	{
	}

	public xed601ddc3e643870(TextWriter xbdfb620b7167944b, bool x4658008e2185b037, string x77c5a31ec0891f38)
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
		x5aa326f374b3d0ef.WriteStartElement("CodeList", "http://www.mirality.co.nz/ns/MaxCodeManager2-Decrypted1");
		x5aa326f374b3d0ef.WriteAttributeString("xsi", "schemaLocation", "http://www.w3.org/2001/XMLSchema-instance", "http://www.mirality.co.nz/ns/MaxCodeManager2-Decrypted1 http://www.mirality.co.nz/schema/MCDecrypted.xsd");
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
			x5aa326f374b3d0ef = null;
			x7fdc1bfc45368624 = null;
		}
	}

	public void xc4305ca6c268b073(string xeaf1b27180c0557b, x047611ec9892e059 code)
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
		if (code.xda8f238d1a051872)
		{
			x5aa326f374b3d0ef.WriteAttributeString("Master", "true");
		}
		if (code.xd0431a295f2ed35f)
		{
			x5aa326f374b3d0ef.WriteAttributeString("Reserved", "true");
		}
		x5aa326f374b3d0ef.WriteElementString("GameId", code.x52b8174788d367f9.ToString(CultureInfo.InvariantCulture));
		x5aa326f374b3d0ef.WriteElementString("CodeId", code.xb3efee94cf138f44.ToString(CultureInfo.InvariantCulture));
		x5aa326f374b3d0ef.WriteElementString("Region", code.x4b94e58155458175.ToString());
		foreach (x047611ec9892e059.x8f4d4d97dd0fc840 item in code.xa54a49b4cb11c6d1)
		{
			x5aa326f374b3d0ef.WriteStartElement("Extension");
			x5aa326f374b3d0ef.WriteAttributeString("Type", item.x3146d638ec378671.ToString(CultureInfo.InvariantCulture));
			if (item.x6b73aa01aa019d3a != 0)
			{
				x5aa326f374b3d0ef.WriteAttributeString("Value", item.x6b73aa01aa019d3a.ToString(CultureInfo.InvariantCulture));
			}
			x5aa326f374b3d0ef.WriteEndElement();
		}
		x5aa326f374b3d0ef.WriteStartElement("Commands");
		foreach (x047611ec9892e059.x7a274f60ab25f2b9 item2 in code.xea84056d876cd25a)
		{
			x5aa326f374b3d0ef.WriteStartElement("Command");
			x5aa326f374b3d0ef.WriteAttributeString("Address", item2.x1d5cfa3bffdfb042.ToString(CultureInfo.InvariantCulture));
			x5aa326f374b3d0ef.WriteAttributeString("Value", item2.xd2f68ee6f47e9dfb.ToString(CultureInfo.InvariantCulture));
			x5aa326f374b3d0ef.WriteEndElement();
		}
		x5aa326f374b3d0ef.WriteEndElement();
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
