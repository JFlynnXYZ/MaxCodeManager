using System;
using System.Globalization;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using Mirality.Max.MaxCodes;
using Mirality.Max.MaxCodes.Properties;

namespace x2ac61696da69bb5f;

internal sealed class x51b2a3ee6460788d : IDisposable
{
	private XmlReader xf86de1bd2f396938;

	private TextReader xad23438fa23654dc;

	private static bool _b9077bf2adec63c7;

	public x51b2a3ee6460788d(TextReader reader)
	{
		XmlReaderSettings xmlReaderSettings = new XmlReaderSettings();
		xmlReaderSettings.IgnoreComments = true;
		xmlReaderSettings.IgnoreProcessingInstructions = true;
		xmlReaderSettings.IgnoreWhitespace = true;
		xmlReaderSettings.ValidationType = ValidationType.Schema;
		xmlReaderSettings.ValidationEventHandler += x00897d9fff75fbb8;
		xmlReaderSettings.ValidationFlags |= XmlSchemaValidationFlags.ReportValidationWarnings;
		xmlReaderSettings.Schemas.Add(xe0178b3cb76b6574());
		xmlReaderSettings.Schemas.Compile();
		xad23438fa23654dc = reader;
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
		}
	}

	private static XmlSchema xe0178b3cb76b6574()
	{
		using StringReader reader = new StringReader(Resources.MCDecrypted);
		return XmlSchema.Read(reader, null);
	}

	private static uint x9a16efbffdb71769(string xc15bd84e01929885, string xb41faee6912a2313)
	{
		if (string.IsNullOrEmpty(xb41faee6912a2313))
		{
			throw new FormatException(xc15bd84e01929885 + ": missing or empty.");
		}
		if ((!xb41faee6912a2313.StartsWith("0x") && !xb41faee6912a2313.StartsWith("0X")) ? uint.TryParse(xb41faee6912a2313, NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite, CultureInfo.InvariantCulture, out var result) : uint.TryParse(xb41faee6912a2313.Substring(2), NumberStyles.HexNumber, CultureInfo.InvariantCulture, out result))
		{
			return result;
		}
		throw new FormatException(((xc15bd84e01929885 == null) ? "" : (xc15bd84e01929885 + ": ")) + "'" + xb41faee6912a2313 + "' is not a valid HexableDword.");
	}

	public xff029f749c7f2d1b x45a68e2bd45abecf()
	{
		_b9077bf2adec63c7 = false;
		if (xf86de1bd2f396938 == null)
		{
			throw new InvalidOperationException("Reader closed.");
		}
		if (!xf86de1bd2f396938.IsStartElement("Code"))
		{
			return null;
		}
		string attribute = xf86de1bd2f396938.GetAttribute("Id");
		string attribute2 = xf86de1bd2f396938.GetAttribute("Master");
		string attribute3 = xf86de1bd2f396938.GetAttribute("Reserved");
		int depth = xf86de1bd2f396938.Depth;
		xf86de1bd2f396938.ReadStartElement();
		try
		{
			if (xf86de1bd2f396938.IsStartElement("Error"))
			{
				string attribute4 = xf86de1bd2f396938.GetAttribute("Line");
				string text = xf86de1bd2f396938.ReadElementString().Trim();
				if (attribute4 == null)
				{
					return new xff029f749c7f2d1b(attribute, text);
				}
				if (int.TryParse(attribute4, out var result))
				{
					return new xff029f749c7f2d1b(attribute, text, result - 1);
				}
				_b9077bf2adec63c7 = true;
				return new xff029f749c7f2d1b(attribute, "Cannot parse error line (line=\"" + attribute4 + "\", error=\"" + text + "\").");
			}
			x047611ec9892e059 x047611ec9892e60 = new x047611ec9892e059();
			if (!string.IsNullOrEmpty(attribute2) && !bool.TryParse(attribute2, out x047611ec9892e60.xda8f238d1a051872))
			{
				_b9077bf2adec63c7 = true;
				return new xff029f749c7f2d1b(attribute, "Master attribute is not a boolean.");
			}
			if (!string.IsNullOrEmpty(attribute3) && !bool.TryParse(attribute3, out x047611ec9892e60.xd0431a295f2ed35f))
			{
				_b9077bf2adec63c7 = true;
				return new xff029f749c7f2d1b(attribute, "Reserved attribute is not a boolean.");
			}
			try
			{
				x94831055fe55580e(x047611ec9892e60, xf86de1bd2f396938);
			}
			catch (Exception ex)
			{
				_b9077bf2adec63c7 = true;
				return new xff029f749c7f2d1b(attribute, ex.Message);
			}
			_b9077bf2adec63c7 = true;
			return new xff029f749c7f2d1b(attribute, x047611ec9892e60);
		}
		catch (Exception ex2)
		{
			_b9077bf2adec63c7 = true;
			return new xff029f749c7f2d1b(attribute, "Uncaught top level error: " + ex2.Message);
		}
		finally
		{
			while (!xf86de1bd2f396938.EOF && xf86de1bd2f396938.Depth > depth)
			{
				try
				{
					if (xf86de1bd2f396938.NodeType == XmlNodeType.EndElement)
					{
						xf86de1bd2f396938.ReadEndElement();
					}
					else
					{
						xf86de1bd2f396938.Skip();
					}
				}
				catch (Exception ex3)
				{
					if (!_b9077bf2adec63c7)
					{
						Console.Error.WriteLine("Parse Error: " + ex3.Message);
						_b9077bf2adec63c7 = true;
					}
				}
			}
			try
			{
				if (xf86de1bd2f396938.NodeType == XmlNodeType.EndElement)
				{
					xf86de1bd2f396938.ReadEndElement();
				}
			}
			catch (Exception ex4)
			{
				if (!_b9077bf2adec63c7)
				{
					Console.Error.WriteLine("Parse Error: " + ex4.Message);
				}
			}
			_b9077bf2adec63c7 = false;
		}
	}

	private static void x94831055fe55580e(x047611ec9892e059 code, XmlReader reader)
	{
		while (!reader.EOF && reader.NodeType != XmlNodeType.EndElement)
		{
			string localName = reader.LocalName;
			try
			{
				switch (localName)
				{
				case "GameId":
					code.x52b8174788d367f9 = x9a16efbffdb71769(null, reader.ReadElementContentAsString());
					break;
				case "CodeId":
					code.xb3efee94cf138f44 = x9a16efbffdb71769(null, reader.ReadElementContentAsString());
					break;
				case "Region":
				{
					string text = reader.ReadElementContentAsString();
					if (Enum.IsDefined(typeof(RegionCode), text))
					{
						code.x4b94e58155458175 = (RegionCode)Enum.Parse(typeof(RegionCode), text);
						break;
					}
					throw new FormatException("'" + text + "' is not a valid region code.");
				}
				case "Extension":
				{
					byte x43163d22e8cd5a = byte.Parse(reader.GetAttribute("Type"), CultureInfo.InvariantCulture);
					string attribute = reader.GetAttribute("Value");
					if (attribute == null)
					{
						code.xa54a49b4cb11c6d1.Add(new x047611ec9892e059.x8f4d4d97dd0fc840(x43163d22e8cd5a, 0u));
					}
					else
					{
						code.xa54a49b4cb11c6d1.Add(new x047611ec9892e059.x8f4d4d97dd0fc840(x43163d22e8cd5a, x9a16efbffdb71769("Value", attribute)));
					}
					reader.Skip();
					break;
				}
				case "Commands":
					if (reader.IsEmptyElement)
					{
						reader.Skip();
						break;
					}
					try
					{
						reader.ReadStartElement();
						xc4acc6d39a6e0c05(code, reader);
						if (reader.NodeType == XmlNodeType.EndElement)
						{
							reader.ReadEndElement();
						}
					}
					catch (XmlSchemaException ex)
					{
						throw new FormatException(ex.Message, ex);
					}
					break;
				default:
					throw new FormatException("Unrecognised element.");
				}
			}
			catch (XmlSchemaException)
			{
				throw;
			}
			catch (Exception ex3)
			{
				throw new FormatException(localName + ": " + ex3.Message, ex3);
			}
		}
	}

	private static void xc4acc6d39a6e0c05(x047611ec9892e059 code, XmlReader reader)
	{
		while (reader.IsStartElement("Command"))
		{
			uint x179bb663e71b1f = x9a16efbffdb71769("Address", reader.GetAttribute("Address"));
			uint xbcea506a33cf = x9a16efbffdb71769("Value", reader.GetAttribute("Value"));
			code.xea84056d876cd25a.Add(new x047611ec9892e059.x7a274f60ab25f2b9(x179bb663e71b1f, xbcea506a33cf));
			reader.Skip();
		}
	}

	private static void x00897d9fff75fbb8(object xe0292b9ed559da7d, ValidationEventArgs xfbf34718e704c6bc)
	{
		if (!_b9077bf2adec63c7)
		{
			Console.Error.WriteLine("Validation {0}: {1}", xfbf34718e704c6bc.Severity, xfbf34718e704c6bc.Message);
			if (xfbf34718e704c6bc.Exception != null)
			{
				throw xfbf34718e704c6bc.Exception;
			}
		}
	}
}
