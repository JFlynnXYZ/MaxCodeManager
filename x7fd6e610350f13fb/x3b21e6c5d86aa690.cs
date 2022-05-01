using System;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Xsl;
using Mirality.Max.CodeManager.Properties;
using x3a260771fe762331;

namespace x7fd6e610350f13fb;

public static class x3b21e6c5d86aa690
{
	public static void xe0fbb350f1c86030(string x1b18a3a0e8682b51, xc68feac946ffcf6f codeList, string xb41a802ca5fde63b)
	{
		using StreamWriter streamWriter = new StreamWriter(xb41a802ca5fde63b, append: false, Encoding.Default);
		streamWriter.WriteLine("############################################");
		streamWriter.WriteLine("# Exported codelist: {0}", x1b18a3a0e8682b51);
		streamWriter.WriteLine("# Version: {0}   Region: {1}", codeList.x9425d7602dc80ff4.x77fa6322561797a0, codeList.x9425d7602dc80ff4.Region);
		streamWriter.WriteLine("# {0:s}", DateTime.Now);
		streamWriter.WriteLine("############################################");
		streamWriter.WriteLine();
		streamWriter.WriteLine();
		foreach (GameEntry item in codeList.x9425d7602dc80ff4)
		{
			streamWriter.WriteLine("* {0}", item.Name);
			if (!string.IsNullOrEmpty(item.x4e020dae918bd2ce))
			{
				streamWriter.WriteLine(item.x4e020dae918bd2ce);
			}
			streamWriter.WriteLine();
			foreach (CodeEntry item2 in item)
			{
				streamWriter.WriteLine(item2.Name);
				if (!string.IsNullOrEmpty(item2.x4e020dae918bd2ce))
				{
					streamWriter.WriteLine(item2.x4e020dae918bd2ce);
				}
				string[] array = item2.CheatCodes.xa9edb3b115d067da();
				string[] array2 = array;
				foreach (string value in array2)
				{
					streamWriter.WriteLine(value);
				}
				streamWriter.WriteLine();
			}
			streamWriter.WriteLine();
		}
	}

	public static void xee53a77bb6ce3bd7(string x1b18a3a0e8682b51, xc68feac946ffcf6f codeList, string xb41a802ca5fde63b)
	{
		using FileStream xcf18e5243f8d5fd = new FileStream(xb41a802ca5fde63b, FileMode.Create, FileAccess.Write, FileShare.None);
		xb10a7180e3ae07cc(x1b18a3a0e8682b51, codeList, xcf18e5243f8d5fd);
	}

	private static void xb10a7180e3ae07cc(string x1b18a3a0e8682b51, xc68feac946ffcf6f codeList, Stream xcf18e5243f8d5fd3)
	{
		XmlWriterSettings xmlWriterSettings = new XmlWriterSettings();
		xmlWriterSettings.Encoding = Encoding.UTF8;
		xmlWriterSettings.Indent = true;
		using XmlWriter xmlWriter = XmlWriter.Create(xcf18e5243f8d5fd3, xmlWriterSettings);
		xmlWriter.WriteStartDocument();
		xmlWriter.WriteProcessingInstruction("xml-stylesheet", "type=\"text/xsl\" title=\"Linear\" href=\"http://www.mirality.co.nz/xsl/MCList.xsl\"");
		xmlWriter.WriteProcessingInstruction("xml-stylesheet", "type=\"text/xsl\" title=\"Tabular\" alternate=\"yes\" href=\"http://www.mirality.co.nz/xsl/MCListTable.xsl\"");
		xmlWriter.WriteComment("Generator: Mirality Systems MAX Code Manager v" + x867eb3246b182488.x77fa6322561797a0.ToString(2));
		xmlWriter.WriteStartElement("CodeList", "http://www.mirality.co.nz/ns/MaxCodeManager2-List1");
		xmlWriter.WriteAttributeString("xsi", "schemaLocation", "http://www.w3.org/2001/XMLSchema-instance", "http://www.mirality.co.nz/ns/MaxCodeManager2-List1 http://www.mirality.co.nz/schema/MCList.xsd");
		xmlWriter.WriteElementString("Name", x1b18a3a0e8682b51);
		xmlWriter.WriteElementString("Version", codeList.x9425d7602dc80ff4.x77fa6322561797a0.ToString(CultureInfo.InvariantCulture));
		xmlWriter.WriteElementString("Region", codeList.x9425d7602dc80ff4.Region.ToString());
		foreach (GameEntry item in codeList.x9425d7602dc80ff4)
		{
			xmlWriter.WriteStartElement("Game");
			xmlWriter.WriteAttributeString("Id", item.x52b8174788d367f9.ToString(CultureInfo.InvariantCulture));
			xmlWriter.WriteElementString("Name", item.Name);
			xmlWriter.WriteElementString("Comments", item.x4e020dae918bd2ce);
			foreach (CodeEntry item2 in item)
			{
				xmlWriter.WriteStartElement("Code");
				xmlWriter.WriteAttributeString("Id", item2.xb3efee94cf138f44.ToString(CultureInfo.InvariantCulture));
				xmlWriter.WriteElementString("Name", item2.Name);
				xmlWriter.WriteElementString("Comments", item2.x4e020dae918bd2ce);
				xmlWriter.WriteElementString("Region", item2.xb1d0737e4174a713.ToString());
				string[] array = item2.CheatCodes.xa9edb3b115d067da();
				foreach (string value in array)
				{
					xmlWriter.WriteElementString("Line", value);
				}
				xmlWriter.WriteEndElement();
			}
			xmlWriter.WriteEndElement();
		}
		xmlWriter.WriteEndElement();
		xmlWriter.WriteEndDocument();
	}

	public static void x7d1fb3e819ed7b11(string x1b18a3a0e8682b51, xc68feac946ffcf6f codeList, string xb41a802ca5fde63b)
	{
		using MemoryStream memoryStream = new MemoryStream();
		xb10a7180e3ae07cc(x1b18a3a0e8682b51, codeList, memoryStream);
		memoryStream.SetLength(memoryStream.Position);
		memoryStream.Seek(0L, SeekOrigin.Begin);
		XslCompiledTransform xslCompiledTransform = new XslCompiledTransform();
		using (StringReader input = new StringReader(Resources.MCList_xsl))
		{
			using XmlReader stylesheet = XmlReader.Create(input);
			xslCompiledTransform.Load(stylesheet);
		}
		using XmlReader input2 = XmlReader.Create(memoryStream);
		using XmlWriter results = XmlWriter.Create(xb41a802ca5fde63b, xslCompiledTransform.OutputSettings);
		xslCompiledTransform.Transform(input2, results);
	}

	public static void x8db8994c865b7964(string x1b18a3a0e8682b51, xc68feac946ffcf6f codeList, string xb41a802ca5fde63b)
	{
		if (codeList == null)
		{
			throw new ArgumentNullException("codeList");
		}
		codeList.x9425d7602dc80ff4.ExportCodelist(xb41a802ca5fde63b);
	}
}
