using System;
using System.ComponentModel;
using System.Globalization;

namespace xca7bfd2e2e8437c4;

internal class x9b13aa2ecbe649f5 : CollectionConverter
{
	public override object ConvertTo(ITypeDescriptorContext x0f7b23d1c393aed9, CultureInfo xb37daae42e1995c9, object xbcea506a33cf9111, Type destinationType)
	{
		if (destinationType == null)
		{
			throw new ArgumentNullException("destinationType");
		}
		x0bc7d5c84e62d912 x0bc7d5c84e62d913 = xbcea506a33cf9111 as x0bc7d5c84e62d912;
		if (destinationType == typeof(string) && x0bc7d5c84e62d913 != null)
		{
			return string.Format(CultureInfo.CurrentCulture, "({0} nodes)", x0bc7d5c84e62d913.Count);
		}
		return base.ConvertTo(x0f7b23d1c393aed9, xb37daae42e1995c9, xbcea506a33cf9111, destinationType);
	}
}
