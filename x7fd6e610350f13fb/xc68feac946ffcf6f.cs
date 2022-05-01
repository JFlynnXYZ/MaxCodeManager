using System;
using System.IO;
using System.IO.Compression;
using System.Text;
using System.Xml;
using x3a260771fe762331;

namespace x7fd6e610350f13fb;

public class xc68feac946ffcf6f
{
	private Codelist _9425d7602dc80ff4 = new Codelist();

	public Codelist x9425d7602dc80ff4
	{
		get
		{
			return _9425d7602dc80ff4;
		}
		set
		{
			_9425d7602dc80ff4 = value;
		}
	}

	public static xc68feac946ffcf6f x5d95f5f98c940295(string xb41a802ca5fde63b)
	{
		using FileStream stream = new FileStream(xb41a802ca5fde63b, FileMode.Open, FileAccess.Read, FileShare.Read);
		using GZipStream xcf18e5243f8d5fd = new GZipStream(stream, CompressionMode.Decompress);
		return x5d95f5f98c940295(xcf18e5243f8d5fd);
	}

	public static xc68feac946ffcf6f x5d95f5f98c940295(Stream xcf18e5243f8d5fd3)
	{
		XmlDocument xmlDocument = new XmlDocument();
		xmlDocument.Load(xcf18e5243f8d5fd3);
		xc68feac946ffcf6f xc68feac946ffcf6f2 = new xc68feac946ffcf6f();
		using MemoryStream input = new MemoryStream(Convert.FromBase64String(xmlDocument.DocumentElement["Codes"].InnerText));
		using BinaryReader xe134235b3526fa = new BinaryReader(input);
		xc68feac946ffcf6f2._9425d7602dc80ff4 = Codelist.x5d95f5f98c940295(xe134235b3526fa);
		return xc68feac946ffcf6f2;
	}

	public void Write(string xb41a802ca5fde63b)
	{
		using FileStream stream = new FileStream(xb41a802ca5fde63b, FileMode.Create, FileAccess.Write, FileShare.None);
		using GZipStream xcf18e5243f8d5fd = new GZipStream(stream, CompressionMode.Compress);
		Write(xcf18e5243f8d5fd);
	}

	public void Write(Stream xcf18e5243f8d5fd3)
	{
		byte[] array;
		using (MemoryStream memoryStream = new MemoryStream())
		{
			x9425d7602dc80ff4.ExportCodelistBinary(memoryStream);
			array = memoryStream.ToArray();
		}
		XmlWriterSettings xmlWriterSettings = new XmlWriterSettings();
		xmlWriterSettings.Encoding = Encoding.UTF8;
		xmlWriterSettings.Indent = true;
		using XmlWriter xmlWriter = XmlWriter.Create(xcf18e5243f8d5fd3, xmlWriterSettings);
		xmlWriter.WriteStartDocument();
		xmlWriter.WriteComment("Generator: Mirality Systems MAX Code Manager v" + x867eb3246b182488.x77fa6322561797a0.ToString(2));
		xmlWriter.WriteStartElement("CodeList", "http://www.mirality.co.nz/ns/MaxCodeManager2-UserList1");
		xmlWriter.WriteStartElement("Codes");
		xmlWriter.WriteBase64(array, 0, array.Length);
		xmlWriter.WriteEndElement();
		xmlWriter.WriteEndElement();
		xmlWriter.WriteEndDocument();
	}
}
