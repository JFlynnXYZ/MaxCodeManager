using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace Mirality.Max.CodeManager.Properties;

[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "2.0.0.0")]
[CompilerGenerated]
[DebuggerNonUserCode]
internal class Resources
{
	private static ResourceManager resourceMan;

	private static CultureInfo resourceCulture;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager ResourceManager
	{
		get
		{
			if (object.ReferenceEquals(resourceMan, null))
			{
				ResourceManager resourceManager = (resourceMan = new ResourceManager("Mirality.Max.CodeManager.Properties.Resources", typeof(Resources).Assembly));
			}
			return resourceMan;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static CultureInfo Culture
	{
		get
		{
			return resourceCulture;
		}
		set
		{
			resourceCulture = value;
		}
	}

	internal static Icon CheckboxClosedFolder
	{
		get
		{
			object @object = ResourceManager.GetObject("CheckboxClosedFolder", resourceCulture);
			return (Icon)@object;
		}
	}

	internal static Icon CheckboxCode
	{
		get
		{
			object @object = ResourceManager.GetObject("CheckboxCode", resourceCulture);
			return (Icon)@object;
		}
	}

	internal static Icon CheckboxOpenFolder
	{
		get
		{
			object @object = ResourceManager.GetObject("CheckboxOpenFolder", resourceCulture);
			return (Icon)@object;
		}
	}

	internal static Icon Game
	{
		get
		{
			object @object = ResourceManager.GetObject("Game", resourceCulture);
			return (Icon)@object;
		}
	}

	internal static string MCList_xsd => ResourceManager.GetString("MCList_xsd", resourceCulture);

	internal static string MCList_xsl => ResourceManager.GetString("MCList_xsl", resourceCulture);

	internal static string MCListTable_xsl => ResourceManager.GetString("MCListTable_xsl", resourceCulture);

	internal static Bitmap OriginalListAvailable
	{
		get
		{
			object @object = ResourceManager.GetObject("OriginalListAvailable", resourceCulture);
			return (Bitmap)@object;
		}
	}

	internal static Bitmap OriginalListNtscOnly
	{
		get
		{
			object @object = ResourceManager.GetObject("OriginalListNtscOnly", resourceCulture);
			return (Bitmap)@object;
		}
	}

	internal static Bitmap OriginalListPalOnly
	{
		get
		{
			object @object = ResourceManager.GetObject("OriginalListPalOnly", resourceCulture);
			return (Bitmap)@object;
		}
	}

	internal static Bitmap OriginalListUnavailable
	{
		get
		{
			object @object = ResourceManager.GetObject("OriginalListUnavailable", resourceCulture);
			return (Bitmap)@object;
		}
	}

	internal static Icon RadioClosedFolder
	{
		get
		{
			object @object = ResourceManager.GetObject("RadioClosedFolder", resourceCulture);
			return (Icon)@object;
		}
	}

	internal static Icon RadioCode
	{
		get
		{
			object @object = ResourceManager.GetObject("RadioCode", resourceCulture);
			return (Icon)@object;
		}
	}

	internal static Icon RadioOpenFolder
	{
		get
		{
			object @object = ResourceManager.GetObject("RadioOpenFolder", resourceCulture);
			return (Icon)@object;
		}
	}

	internal static Icon UnknownCode
	{
		get
		{
			object @object = ResourceManager.GetObject("UnknownCode", resourceCulture);
			return (Icon)@object;
		}
	}

	internal static Bitmap Warning
	{
		get
		{
			object @object = ResourceManager.GetObject("Warning", resourceCulture);
			return (Bitmap)@object;
		}
	}

	internal Resources()
	{
	}
}
