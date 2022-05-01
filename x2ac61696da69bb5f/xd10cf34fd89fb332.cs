using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using Mirality.Max.MaxCodes;
using Mirality.Max.MaxCodes.Properties;

namespace x2ac61696da69bb5f;

internal sealed class xd10cf34fd89fb332 : IDisposable
{
	private XmlReader xf86de1bd2f396938;

	private TextReader xad23438fa23654dc;

	public xd10cf34fd89fb332(TextReader xe134235b3526fa75)
	{
		XmlReaderSettings xmlReaderSettings = new XmlReaderSettings();
		xmlReaderSettings.IgnoreComments = true;
		xmlReaderSettings.IgnoreProcessingInstructions = true;
		xmlReaderSettings.IgnoreWhitespace = true;
		xmlReaderSettings.ValidationType = ValidationType.Schema;
		xmlReaderSettings.Schemas.Add(xe0178b3cb76b6574());
		xmlReaderSettings.Schemas.Compile();
		xad23438fa23654dc = xe134235b3526fa75;
		xf86de1bd2f396938 = XmlReader.Create(xad23438fa23654dc, xmlReaderSettings);
		xf86de1bd2f396938.ReadStartElement("CodeList");
	}

	public void Dispose()
	{
		x8ffe90e7fbccfccd();
	}

	public void x8ffe90e7fbccfccd()
	{
		if (xf86de1bd2f396938 != null)
		{
			if (xad23438fa23654dc != Console.In)
			{
				xf86de1bd2f396938.Close();
			}
			xf86de1bd2f396938 = null;
			xad23438fa23654dc = null;
		}
	}

	private static XmlSchema xe0178b3cb76b6574()
	{
		using StringReader reader = new StringReader(Resources.MCEncrypted);
		return XmlSchema.Read(reader, null);
	}

	public x41b0bc8b458547c2 x45a68e2bd45abecf()
	{
		if (xf86de1bd2f396938 == null)
		{
			throw new InvalidOperationException("Reader closed.");
		}
		if (!xf86de1bd2f396938.IsStartElement("Code"))
		{
			return null;
		}
		string attribute = xf86de1bd2f396938.GetAttribute("Id");
		if (xf86de1bd2f396938.IsEmptyElement)
		{
			xf86de1bd2f396938.Skip();
			return new x41b0bc8b458547c2(attribute, "No code lines.");
		}
		xf86de1bd2f396938.ReadStartElement();
		if (xf86de1bd2f396938.IsStartElement("Error"))
		{
			string xc685eed2987781a = xf86de1bd2f396938.ReadElementString().Trim();
			xf86de1bd2f396938.ReadEndElement();
			return new x41b0bc8b458547c2(attribute, xc685eed2987781a);
		}
		List<string> list = new List<string>();
		while (xf86de1bd2f396938.IsStartElement("Line"))
		{
			list.Add(xf86de1bd2f396938.ReadElementString().Trim());
		}
		xf86de1bd2f396938.ReadEndElement();
		try
		{
			return new x41b0bc8b458547c2(attribute, new xf6e5c5e1901f893f(list.ToArray()));
		}
		catch (CodeLineException ex)
		{
			return new x41b0bc8b458547c2(attribute, ex.Message, ex.LineIndex);
		}
		catch (Exception ex2)
		{
			return new x41b0bc8b458547c2(attribute, ex2.Message);
		}
	}
}
