using System;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Globalization;
using System.Reflection;

namespace xca7bfd2e2e8437c4;

internal class xdd6bd945f9b82610 : TypeConverter
{
	public override bool CanConvertTo(ITypeDescriptorContext x0f7b23d1c393aed9, Type destinationType)
	{
		if (destinationType == typeof(InstanceDescriptor))
		{
			return true;
		}
		return base.CanConvertTo(x0f7b23d1c393aed9, destinationType);
	}

	public override object ConvertTo(ITypeDescriptorContext x0f7b23d1c393aed9, CultureInfo xb37daae42e1995c9, object xbcea506a33cf9111, Type destinationType)
	{
		if (destinationType == null)
		{
			throw new ArgumentNullException("destinationType");
		}
		x95fcf261e3011b00 x95fcf261e3011b = xbcea506a33cf9111 as x95fcf261e3011b00;
		if (destinationType == typeof(InstanceDescriptor) && x95fcf261e3011b != null)
		{
			object[] arguments = null;
			ConstructorInfo constructor;
			if (string.IsNullOrEmpty(x95fcf261e3011b.x759aa16c2016a289))
			{
				constructor = typeof(x95fcf261e3011b00).GetConstructor(Type.EmptyTypes);
			}
			else
			{
				constructor = typeof(x95fcf261e3011b00).GetConstructor(new Type[2]
				{
					typeof(string),
					typeof(string)
				});
				arguments = new object[2] { "", x95fcf261e3011b.x759aa16c2016a289 };
			}
			if (constructor != null)
			{
				return new InstanceDescriptor(constructor, arguments, isComplete: false);
			}
		}
		return base.ConvertTo(x0f7b23d1c393aed9, xb37daae42e1995c9, xbcea506a33cf9111, destinationType);
	}
}
