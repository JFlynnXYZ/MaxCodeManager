using System;
using System.Collections.Generic;
using System.Text;
using x2ac61696da69bb5f;

namespace x3a260771fe762331;

public static class x9e548743c3f0e895
{
	public abstract class xf370fda13822d1f9 : ICloneable
	{
		public readonly int x9f7648f40d0312e9;

		protected x047611ec9892e059.x7a274f60ab25f2b9[] _dc0e6f9257e1e0ab;

		public int x1be93eed8950d961 => _dc0e6f9257e1e0ab.Length;

		internal x047611ec9892e059.x7a274f60ab25f2b9[] xdc0e6f9257e1e0ab => _dc0e6f9257e1e0ab;

		public abstract string LongDescription { get; }

		protected xf370fda13822d1f9(int xeb28d76ef7e31289, params x047611ec9892e059.x7a274f60ab25f2b9[] xd6fa12e65cb6ec31)
		{
			x9f7648f40d0312e9 = xeb28d76ef7e31289;
			List<x047611ec9892e059.x7a274f60ab25f2b9> list = new List<x047611ec9892e059.x7a274f60ab25f2b9>();
			foreach (x047611ec9892e059.x7a274f60ab25f2b9 x7a274f60ab25f2b in xd6fa12e65cb6ec31)
			{
				list.Add(x7a274f60ab25f2b.Clone());
			}
			_dc0e6f9257e1e0ab = list.ToArray();
		}

		public IList<x047611ec9892e059.x7a274f60ab25f2b9> xfb8e025166a358a7()
		{
			return new List<x047611ec9892e059.x7a274f60ab25f2b9>(_dc0e6f9257e1e0ab).AsReadOnly();
		}

		public uint xb1b69bc3bc68b299(int x3e23af830d438b6d, bool xcd21cd52dc74d834, int xc1d66aac15ff18ea, int x5bf22067353b9e1c)
		{
			if (x3e23af830d438b6d < 0 || x3e23af830d438b6d >= _dc0e6f9257e1e0ab.Length)
			{
				throw new ArgumentOutOfRangeException("rawCommandIndex");
			}
			if (xc1d66aac15ff18ea < 0 || xc1d66aac15ff18ea > 31)
			{
				throw new ArgumentOutOfRangeException("bitStart");
			}
			if (x5bf22067353b9e1c < 1 || x5bf22067353b9e1c > 32)
			{
				throw new ArgumentOutOfRangeException("bitCount");
			}
			if (xc1d66aac15ff18ea + x5bf22067353b9e1c > 32)
			{
				throw new ArgumentOutOfRangeException("bitStart+bitCount");
			}
			uint num = (uint)((1L << x5bf22067353b9e1c) - 1 << xc1d66aac15ff18ea);
			return ((xcd21cd52dc74d834 ? _dc0e6f9257e1e0ab[x3e23af830d438b6d].xd2f68ee6f47e9dfb : _dc0e6f9257e1e0ab[x3e23af830d438b6d].x1d5cfa3bffdfb042) & num) >> xc1d66aac15ff18ea;
		}

		public void x06fca26534421e78(int x3e23af830d438b6d, bool x6ad6ac850067f6c4, int xc1d66aac15ff18ea, int x5bf22067353b9e1c, uint xed7e1b20b1a14b86)
		{
			if (x3e23af830d438b6d < 0 || x3e23af830d438b6d >= _dc0e6f9257e1e0ab.Length)
			{
				throw new ArgumentOutOfRangeException("rawCommandIndex");
			}
			if (xc1d66aac15ff18ea < 0 || xc1d66aac15ff18ea > 31)
			{
				throw new ArgumentOutOfRangeException("bitStart");
			}
			if (x5bf22067353b9e1c < 1 || x5bf22067353b9e1c > 32)
			{
				throw new ArgumentOutOfRangeException("bitCount");
			}
			if (xc1d66aac15ff18ea + x5bf22067353b9e1c > 32)
			{
				throw new ArgumentOutOfRangeException("bitStart+bitCount");
			}
			uint num = (uint)((1L << x5bf22067353b9e1c) - 1 << xc1d66aac15ff18ea);
			uint num2 = (xed7e1b20b1a14b86 << xc1d66aac15ff18ea) & num;
			if (x6ad6ac850067f6c4)
			{
				_dc0e6f9257e1e0ab[x3e23af830d438b6d].xd2f68ee6f47e9dfb = (_dc0e6f9257e1e0ab[x3e23af830d438b6d].xd2f68ee6f47e9dfb & ~num) | num2;
			}
			else
			{
				_dc0e6f9257e1e0ab[x3e23af830d438b6d].x1d5cfa3bffdfb042 = (_dc0e6f9257e1e0ab[x3e23af830d438b6d].x1d5cfa3bffdfb042 & ~num) | num2;
			}
		}

		public xf370fda13822d1f9 Clone()
		{
			xf370fda13822d1f9 xf370fda13822d1f = (xf370fda13822d1f9)MemberwiseClone();
			xf370fda13822d1f._dc0e6f9257e1e0ab = new x047611ec9892e059.x7a274f60ab25f2b9[_dc0e6f9257e1e0ab.Length];
			for (int i = 0; i < _dc0e6f9257e1e0ab.Length; i++)
			{
				xf370fda13822d1f._dc0e6f9257e1e0ab[i] = _dc0e6f9257e1e0ab[i].Clone();
			}
			return xf370fda13822d1f;
		}

		private object xc1ca9fe073d7b6d8()
		{
			return Clone();
		}

		object ICloneable.Clone()
		{
			//ILSpy generated this explicit interface implementation from .override directive in xc1ca9fe073d7b6d8
			return this.xc1ca9fe073d7b6d8();
		}

		public static uint xb37e931dc30b191c(xd37843060f387912 x0ceec69a97f73617)
		{
			return x0ceec69a97f73617 switch
			{
				xd37843060f387912.x7ee8c15a7fe70b04 => 1u, 
				xd37843060f387912.xfa092eb1a8142eb9 => 2u, 
				xd37843060f387912.xeb473b682e8df563 => 4u, 
				_ => 1u, 
			};
		}

		protected static string xea9be685a847b716(xd37843060f387912 x0ceec69a97f73617)
		{
			return x0ceec69a97f73617 switch
			{
				xd37843060f387912.x7ee8c15a7fe70b04 => "8-bit", 
				xd37843060f387912.xfa092eb1a8142eb9 => "16-bit", 
				xd37843060f387912.xeb473b682e8df563 => "32-bit", 
				xd37843060f387912.xd4d82c4665f71358 => "Always", 
				_ => "Unknown", 
			};
		}

		protected static string x2bfb1ed59fbae97f(xd37843060f387912 x0ceec69a97f73617, uint xbcea506a33cf9111)
		{
			return x0ceec69a97f73617 switch
			{
				xd37843060f387912.x7ee8c15a7fe70b04 => ((byte)xbcea506a33cf9111).ToString("X2"), 
				xd37843060f387912.xfa092eb1a8142eb9 => ((ushort)xbcea506a33cf9111).ToString("X4"), 
				xd37843060f387912.xeb473b682e8df563 => xbcea506a33cf9111.ToString("X8"), 
				xd37843060f387912.xd4d82c4665f71358 => "(none)", 
				_ => "Unknown", 
			};
		}

		protected static string xbe59c9f2718339cd(xd37843060f387912 x0ceec69a97f73617, uint xbcea506a33cf9111)
		{
			switch (x0ceec69a97f73617)
			{
			case xd37843060f387912.x7ee8c15a7fe70b04:
				return ((sbyte)(byte)xbcea506a33cf9111).ToString("'+'0;'-'0;0");
			case xd37843060f387912.xfa092eb1a8142eb9:
				return ((short)(ushort)xbcea506a33cf9111).ToString("'+'0;'-'0;0");
			case xd37843060f387912.xeb473b682e8df563:
			{
				int num = (int)xbcea506a33cf9111;
				return num.ToString("'+'0;'-'0;0");
			}
			case xd37843060f387912.xd4d82c4665f71358:
				return "(none)";
			default:
				return "Unknown";
			}
		}
	}

	public class x95af7b2efc150589 : xf370fda13822d1f9
	{
		public xaad797ea5cf783ca x3aa89c51588c7466
		{
			get
			{
				return new xaad797ea5cf783ca((byte)(_dc0e6f9257e1e0ab[0].x1d5cfa3bffdfb042 >> 24));
			}
			set
			{
				_dc0e6f9257e1e0ab[0].x1d5cfa3bffdfb042 = (uint)(value.xd2f68ee6f47e9dfb << 24) | (_dc0e6f9257e1e0ab[0].x1d5cfa3bffdfb042 & 0x1FFFFFFu);
			}
		}

		public uint x1d5cfa3bffdfb042
		{
			get
			{
				return _dc0e6f9257e1e0ab[0].x1d5cfa3bffdfb042 & 0x1FFFFFFu;
			}
			set
			{
				_dc0e6f9257e1e0ab[0].x1d5cfa3bffdfb042 = (_dc0e6f9257e1e0ab[0].x1d5cfa3bffdfb042 & 0xFE000000u) | (value & 0x1FFFFFFu);
			}
		}

		public uint xd2f68ee6f47e9dfb
		{
			get
			{
				return _dc0e6f9257e1e0ab[0].xd2f68ee6f47e9dfb;
			}
			set
			{
				_dc0e6f9257e1e0ab[0].xd2f68ee6f47e9dfb = value;
			}
		}

		public override string LongDescription
		{
			get
			{
				StringBuilder stringBuilder = new StringBuilder();
				if (x3aa89c51588c7466.xca0517fe66f52202 == x8f1a4272515df03b.xa160b1c73a8f9d06)
				{
					switch (x3aa89c51588c7466.xa160b1c73a8f9d06)
					{
					case x87ce8e5fd3e61101.xab1eafcbb736ac9f:
					{
						uint num;
						uint xbcea506a33cf;
						switch (x3aa89c51588c7466.x437e3b626c0fdd43)
						{
						case xd37843060f387912.x7ee8c15a7fe70b04:
							num = (xd2f68ee6f47e9dfb & 0xFFFFFF00u) >> 8;
							xbcea506a33cf = xd2f68ee6f47e9dfb & 0xFFu;
							break;
						case xd37843060f387912.xfa092eb1a8142eb9:
							num = (xd2f68ee6f47e9dfb & 0xFFFF0000u) >> 16;
							xbcea506a33cf = xd2f68ee6f47e9dfb & 0xFFFFu;
							break;
						case xd37843060f387912.xeb473b682e8df563:
							num = 0u;
							xbcea506a33cf = xd2f68ee6f47e9dfb;
							break;
						case xd37843060f387912.xd4d82c4665f71358:
							return "Invalid command: 'Always' cannot be used with 'Write'";
						default:
							return "Unrecognised command size.";
						}
						if (num == 0)
						{
							stringBuilder.AppendFormat("Write {0} to address {1:X8}", xf370fda13822d1f9.x2bfb1ed59fbae97f(x3aa89c51588c7466.x437e3b626c0fdd43, xbcea506a33cf), x1d5cfa3bffdfb042);
						}
						else
						{
							stringBuilder.AppendFormat("Write {0} to addresses {1:X8}-{2:X8}", xf370fda13822d1f9.x2bfb1ed59fbae97f(x3aa89c51588c7466.x437e3b626c0fdd43, xbcea506a33cf), x1d5cfa3bffdfb042, x1d5cfa3bffdfb042 + num * xf370fda13822d1f9.xb37e931dc30b191c(x3aa89c51588c7466.x437e3b626c0fdd43));
						}
						break;
					}
					case x87ce8e5fd3e61101.x4943ee58ed48c029:
					{
						uint num;
						uint xbcea506a33cf;
						switch (x3aa89c51588c7466.x437e3b626c0fdd43)
						{
						case xd37843060f387912.x7ee8c15a7fe70b04:
							num = (xd2f68ee6f47e9dfb & 0xFFFFFF00u) >> 8;
							xbcea506a33cf = xd2f68ee6f47e9dfb & 0xFFu;
							break;
						case xd37843060f387912.xfa092eb1a8142eb9:
							num = ((xd2f68ee6f47e9dfb & 0xFFFF0000u) >> 16) * 2;
							xbcea506a33cf = xd2f68ee6f47e9dfb & 0xFFFFu;
							break;
						case xd37843060f387912.xeb473b682e8df563:
							num = 0u;
							xbcea506a33cf = xd2f68ee6f47e9dfb;
							break;
						case xd37843060f387912.xd4d82c4665f71358:
							return "Invalid command: 'Always' cannot be used with 'Pointer Write'";
						default:
							return "Unrecognised command size.";
						}
						if (num == 0)
						{
							stringBuilder.AppendFormat("Write {0} to address stored at address {1:X8}", xf370fda13822d1f9.x2bfb1ed59fbae97f(x3aa89c51588c7466.x437e3b626c0fdd43, xbcea506a33cf), x1d5cfa3bffdfb042);
						}
						else
						{
							stringBuilder.AppendFormat("Write {0} to (address stored at address {1:X8}) + {2:X8}", xf370fda13822d1f9.x2bfb1ed59fbae97f(x3aa89c51588c7466.x437e3b626c0fdd43, xbcea506a33cf), x1d5cfa3bffdfb042, num);
						}
						break;
					}
					case x87ce8e5fd3e61101.x5561649b370c7ba5:
						stringBuilder.AppendFormat("Add {0} to address {1:X8}", xf370fda13822d1f9.x2bfb1ed59fbae97f(x3aa89c51588c7466.x437e3b626c0fdd43, xd2f68ee6f47e9dfb), x1d5cfa3bffdfb042);
						break;
					case x87ce8e5fd3e61101.x77f5ace14d6d006a:
						stringBuilder.AppendFormat("Master Command ({0}): hook {1:X8}, {2} codes per call, cfg1 = {3}, cfg2 = {4}", xf370fda13822d1f9.xea9be685a847b716(x3aa89c51588c7466.x437e3b626c0fdd43), x1d5cfa3bffdfb042, (xd2f68ee6f47e9dfb & 0xFF00) >> 8, (xd2f68ee6f47e9dfb & 0xF0000) >> 16, xd2f68ee6f47e9dfb & 0xFu);
						break;
					default:
						return "Unknown Action";
					}
				}
				else
				{
					stringBuilder.AppendFormat("If value at {0:X8} ", x1d5cfa3bffdfb042);
					switch (x3aa89c51588c7466.xca0517fe66f52202)
					{
					case x8f1a4272515df03b.xc95c17c43c95f175:
						stringBuilder.AppendFormat("== {0} then ", xf370fda13822d1f9.x2bfb1ed59fbae97f(x3aa89c51588c7466.x437e3b626c0fdd43, xd2f68ee6f47e9dfb));
						break;
					case x8f1a4272515df03b.x555fdb0468a0a1c8:
						stringBuilder.AppendFormat("!= {0} then ", xf370fda13822d1f9.x2bfb1ed59fbae97f(x3aa89c51588c7466.x437e3b626c0fdd43, xd2f68ee6f47e9dfb));
						break;
					case x8f1a4272515df03b.x3536a9319fe1275e:
						stringBuilder.AppendFormat("< {0} then ", xf370fda13822d1f9.xbe59c9f2718339cd(x3aa89c51588c7466.x437e3b626c0fdd43, xd2f68ee6f47e9dfb));
						break;
					case x8f1a4272515df03b.x1bfe74ccfcf211b4:
						stringBuilder.AppendFormat("> {0} then ", xf370fda13822d1f9.xbe59c9f2718339cd(x3aa89c51588c7466.x437e3b626c0fdd43, xd2f68ee6f47e9dfb));
						break;
					case x8f1a4272515df03b.x468d037dd021d79e:
						stringBuilder.AppendFormat("< {0} then ", xf370fda13822d1f9.x2bfb1ed59fbae97f(x3aa89c51588c7466.x437e3b626c0fdd43, xd2f68ee6f47e9dfb));
						break;
					case x8f1a4272515df03b.xea4e05260546a848:
						stringBuilder.AppendFormat("> {0} then ", xf370fda13822d1f9.x2bfb1ed59fbae97f(x3aa89c51588c7466.x437e3b626c0fdd43, xd2f68ee6f47e9dfb));
						break;
					case x8f1a4272515df03b.x022e0f90b981e5e5:
						stringBuilder.AppendFormat("& {0} != 0 then ", xf370fda13822d1f9.x2bfb1ed59fbae97f(x3aa89c51588c7466.x437e3b626c0fdd43, xd2f68ee6f47e9dfb));
						break;
					default:
						return "Unrecognised test operation.";
					}
					switch (x3aa89c51588c7466.xd663ff321c322be2)
					{
					case x680523c0e011c5b8.xfb2ecf1342682c59:
						stringBuilder.Append("execute next line; otherwise skip it");
						break;
					case x680523c0e011c5b8.xed1527f9b08bd991:
						stringBuilder.Append("execute next two lines; otherwise skip them");
						break;
					case x680523c0e011c5b8.x82b94dd34c559efc:
						stringBuilder.Append("execute all following lines; otherwise skip them");
						break;
					case x680523c0e011c5b8.xb84af20ae19acd13:
						stringBuilder.Append("continue; otherwise pause until it is");
						break;
					default:
						return "Unrecognised test action.";
					}
				}
				return stringBuilder.ToString();
			}
		}

		public x95af7b2efc150589(int xeb28d76ef7e31289, x047611ec9892e059.x7a274f60ab25f2b9 xcb6a7cde2ad0d08d)
			: base(xeb28d76ef7e31289, xcb6a7cde2ad0d08d)
		{
		}
	}

	public class x9f51b856a6c0aa70 : xf370fda13822d1f9
	{
		public xd37843060f387912 x437e3b626c0fdd43
		{
			get
			{
				return (xd37843060f387912)((_dc0e6f9257e1e0ab[0].xd2f68ee6f47e9dfb & 0x6000000) >> 25);
			}
			set
			{
				_dc0e6f9257e1e0ab[0].xd2f68ee6f47e9dfb = (_dc0e6f9257e1e0ab[0].xd2f68ee6f47e9dfb & 0xF9FFFFFFu) | ((uint)value << 25);
			}
		}

		public uint x1d5cfa3bffdfb042
		{
			get
			{
				return _dc0e6f9257e1e0ab[0].xd2f68ee6f47e9dfb & 0x1FFFFFFu;
			}
			set
			{
				_dc0e6f9257e1e0ab[0].xd2f68ee6f47e9dfb = (_dc0e6f9257e1e0ab[0].xd2f68ee6f47e9dfb & 0xFE000000u) | (value & 0x1FFFFFFu);
			}
		}

		public uint xd2f68ee6f47e9dfb
		{
			get
			{
				return _dc0e6f9257e1e0ab[1].x1d5cfa3bffdfb042;
			}
			set
			{
				_dc0e6f9257e1e0ab[1].x1d5cfa3bffdfb042 = value;
			}
		}

		public uint x49cdc23fc7583d96
		{
			get
			{
				return (_dc0e6f9257e1e0ab[1].xd2f68ee6f47e9dfb & 0xFFFF) * xf370fda13822d1f9.xb37e931dc30b191c(x437e3b626c0fdd43);
			}
			set
			{
				_dc0e6f9257e1e0ab[1].xd2f68ee6f47e9dfb = (_dc0e6f9257e1e0ab[1].xd2f68ee6f47e9dfb & 0xFFFF0000u) | ((value / xf370fda13822d1f9.xb37e931dc30b191c(x437e3b626c0fdd43)) & 0xFFFFu);
			}
		}

		public sbyte x69ab31c0e0042650
		{
			get
			{
				return (sbyte)(byte)((_dc0e6f9257e1e0ab[1].xd2f68ee6f47e9dfb & 0xFF000000u) >> 24);
			}
			set
			{
				_dc0e6f9257e1e0ab[1].xd2f68ee6f47e9dfb = (_dc0e6f9257e1e0ab[1].xd2f68ee6f47e9dfb & 0xFFFFFFu) | (uint)(value << 24);
			}
		}

		public byte xd44988f225497f3a
		{
			get
			{
				return (byte)((_dc0e6f9257e1e0ab[1].xd2f68ee6f47e9dfb & 0xFF0000) >> 16);
			}
			set
			{
				_dc0e6f9257e1e0ab[1].xd2f68ee6f47e9dfb = (_dc0e6f9257e1e0ab[1].xd2f68ee6f47e9dfb & 0xFF00FFFFu) | (uint)(value << 16);
			}
		}

		public override string LongDescription
		{
			get
			{
				if (xd44988f225497f3a == 0)
				{
					return "Zero-size 'Slide': no-op.";
				}
				StringBuilder stringBuilder = new StringBuilder();
				stringBuilder.AppendFormat("{0} Slide Write: Addresses {1:X8}-{2:X8}; ", xf370fda13822d1f9.xea9be685a847b716(x437e3b626c0fdd43), x1d5cfa3bffdfb042, x1d5cfa3bffdfb042 + x49cdc23fc7583d96 * xd44988f225497f3a - 1);
				if (xd44988f225497f3a <= 1 || x69ab31c0e0042650 == 0)
				{
					stringBuilder.AppendFormat("value {0}", xf370fda13822d1f9.x2bfb1ed59fbae97f(x437e3b626c0fdd43, xd2f68ee6f47e9dfb));
				}
				else
				{
					stringBuilder.AppendFormat("initial value {0}, increment {1}", xf370fda13822d1f9.x2bfb1ed59fbae97f(x437e3b626c0fdd43, xd2f68ee6f47e9dfb), x69ab31c0e0042650);
				}
				return stringBuilder.ToString();
			}
		}

		public x9f51b856a6c0aa70(int xeb28d76ef7e31289, x047611ec9892e059.x7a274f60ab25f2b9 x7f5704d71690aff8, x047611ec9892e059.x7a274f60ab25f2b9 xef563966899b6b32)
			: base(xeb28d76ef7e31289, x7f5704d71690aff8, xef563966899b6b32)
		{
		}
	}

	public class x0f0906c583e29b6b : xf370fda13822d1f9
	{
		public override string LongDescription => "Do not execute any more codes";

		public x0f0906c583e29b6b(int xeb28d76ef7e31289, x047611ec9892e059.x7a274f60ab25f2b9 xcb6a7cde2ad0d08d)
			: base(xeb28d76ef7e31289, xcb6a7cde2ad0d08d)
		{
		}

		public x0f0906c583e29b6b(int xeb28d76ef7e31289)
			: base(xeb28d76ef7e31289, new x047611ec9892e059.x7a274f60ab25f2b9(0u, 0u))
		{
		}
	}

	public class xe948cf6a9cb0be5f : xf370fda13822d1f9
	{
		public override string LongDescription => "End of 'Execute/Skip All' block";

		public xe948cf6a9cb0be5f(int xeb28d76ef7e31289, x047611ec9892e059.x7a274f60ab25f2b9 xcb6a7cde2ad0d08d)
			: base(xeb28d76ef7e31289, xcb6a7cde2ad0d08d)
		{
		}

		public xe948cf6a9cb0be5f(int xeb28d76ef7e31289)
			: base(xeb28d76ef7e31289, new x047611ec9892e059.x7a274f60ab25f2b9(0u, 1073741824u))
		{
		}
	}

	public class xf8be28f9144c5748 : xf370fda13822d1f9
	{
		public override string LongDescription => "Unrecognised command type.";

		public xf8be28f9144c5748(int xeb28d76ef7e31289, x047611ec9892e059.x7a274f60ab25f2b9 xcb6a7cde2ad0d08d)
			: base(xeb28d76ef7e31289, xcb6a7cde2ad0d08d)
		{
		}
	}

	public enum xd37843060f387912 : byte
	{
		x7ee8c15a7fe70b04,
		xfa092eb1a8142eb9,
		xeb473b682e8df563,
		xd4d82c4665f71358
	}

	public struct xaad797ea5cf783ca : IEquatable<xaad797ea5cf783ca>
	{
		private byte _d2f68ee6f47e9dfb;

		public byte xd2f68ee6f47e9dfb => _d2f68ee6f47e9dfb;

		public xd37843060f387912 x437e3b626c0fdd43 => (xd37843060f387912)((xd2f68ee6f47e9dfb & 6) >> 1);

		public x8f1a4272515df03b xca0517fe66f52202 => (x8f1a4272515df03b)((xd2f68ee6f47e9dfb & 0x38) >> 3);

		public x680523c0e011c5b8 xd663ff321c322be2 => (x680523c0e011c5b8)((xd2f68ee6f47e9dfb & 0xC0) >> 6);

		public x87ce8e5fd3e61101 xa160b1c73a8f9d06 => (x87ce8e5fd3e61101)((xd2f68ee6f47e9dfb & 0xC0) >> 6);

		public xaad797ea5cf783ca(byte xbcea506a33cf9111)
		{
			_d2f68ee6f47e9dfb = (byte)(xbcea506a33cf9111 & 0xFEu);
		}

		public xaad797ea5cf783ca(xd37843060f387912 x0ceec69a97f73617, x87ce8e5fd3e61101 xab8fe3cd8c5556fb)
			: this(x8885d1fc1e00dd5c(x0ceec69a97f73617, x8f1a4272515df03b.xa160b1c73a8f9d06, (byte)xab8fe3cd8c5556fb))
		{
		}

		public xaad797ea5cf783ca(xd37843060f387912 x0ceec69a97f73617, x8f1a4272515df03b x1437816edeb48c46, x680523c0e011c5b8 x9060f041842efb3c)
			: this(x8885d1fc1e00dd5c(x0ceec69a97f73617, x1437816edeb48c46, (byte)x9060f041842efb3c))
		{
		}

		private static byte x8885d1fc1e00dd5c(xd37843060f387912 x0ceec69a97f73617, x8f1a4272515df03b x1437816edeb48c46, byte xe0de5225dc515233)
		{
			byte b = (byte)(x0ceec69a97f73617 & xd37843060f387912.xd4d82c4665f71358);
			byte b2 = (byte)(x1437816edeb48c46 & x8f1a4272515df03b.x022e0f90b981e5e5);
			byte b3 = (byte)(xe0de5225dc515233 & 3u);
			return (byte)((b3 << 6) | (b2 << 3) | (b << 1));
		}

		public override bool Equals(object xa59bff7708de3a18)
		{
			if (xa59bff7708de3a18 is xaad797ea5cf783ca)
			{
				return Equals((xaad797ea5cf783ca)xa59bff7708de3a18);
			}
			return false;
		}

		public bool Equals(xaad797ea5cf783ca x3b50be75884cb97e)
		{
			return xd2f68ee6f47e9dfb.Equals(x3b50be75884cb97e.xd2f68ee6f47e9dfb);
		}

		public override int GetHashCode()
		{
			return xd2f68ee6f47e9dfb.GetHashCode();
		}

		public override string ToString()
		{
			return "{" + $"{x437e3b626c0fdd43} {xca0517fe66f52202} {((xca0517fe66f52202 == x8f1a4272515df03b.xa160b1c73a8f9d06) ? xa160b1c73a8f9d06.ToString() : xd663ff321c322be2.ToString())}" + "}";
		}
	}

	public enum x87ce8e5fd3e61101 : byte
	{
		xab1eafcbb736ac9f,
		x4943ee58ed48c029,
		x5561649b370c7ba5,
		x77f5ace14d6d006a
	}

	public enum x8f1a4272515df03b : byte
	{
		xa160b1c73a8f9d06,
		xc95c17c43c95f175,
		x555fdb0468a0a1c8,
		x3536a9319fe1275e,
		x1bfe74ccfcf211b4,
		x468d037dd021d79e,
		xea4e05260546a848,
		x022e0f90b981e5e5
	}

	public enum x680523c0e011c5b8 : byte
	{
		xfb2ecf1342682c59,
		xed1527f9b08bd991,
		x82b94dd34c559efc,
		xb84af20ae19acd13
	}

	public static List<xf370fda13822d1f9> xb4638aac69d75ced(IList<x047611ec9892e059.x7a274f60ab25f2b9> xd6fa12e65cb6ec31, List<string> x68415805ef2e3525)
	{
		if (xd6fa12e65cb6ec31 == null || xd6fa12e65cb6ec31.Count == 0)
		{
			return new List<xf370fda13822d1f9>();
		}
		List<xf370fda13822d1f9> list = xdb8b9656fc3dfa78(xd6fa12e65cb6ec31, x68415805ef2e3525);
		x30f11b62808214b9(list, x68415805ef2e3525);
		return list;
	}

	private static List<xf370fda13822d1f9> xdb8b9656fc3dfa78(IList<x047611ec9892e059.x7a274f60ab25f2b9> xd6fa12e65cb6ec31, List<string> x68415805ef2e3525)
	{
		List<xf370fda13822d1f9> list = new List<xf370fda13822d1f9>();
		for (int i = 0; i < xd6fa12e65cb6ec31.Count; i++)
		{
			x047611ec9892e059.x7a274f60ab25f2b9 x7a274f60ab25f2b = xd6fa12e65cb6ec31[i];
			if (x7a274f60ab25f2b.x1d5cfa3bffdfb042 == 0)
			{
				if (x7a274f60ab25f2b.xd2f68ee6f47e9dfb == 0)
				{
					list.Add(new x0f0906c583e29b6b(i, x7a274f60ab25f2b));
					continue;
				}
				byte b = (byte)((x7a274f60ab25f2b.xd2f68ee6f47e9dfb & 0xFE000000u) >> 24);
				switch (b)
				{
				case 128:
				case 130:
				case 132:
					if (i + 1 >= xd6fa12e65cb6ec31.Count)
					{
						xbbf9a1ead81dd3a1(x68415805ef2e3525, i, "Appears to be a multi-line command, but has no following line.");
						list.Add(new xf8be28f9144c5748(i, x7a274f60ab25f2b));
					}
					else
					{
						x047611ec9892e059.x7a274f60ab25f2b9 xef563966899b6b = xd6fa12e65cb6ec31[i + 1];
						list.Add(new x9f51b856a6c0aa70(i, x7a274f60ab25f2b, xef563966899b6b));
						i++;
					}
					break;
				case 64:
					list.Add(new xe948cf6a9cb0be5f(i, x7a274f60ab25f2b));
					break;
				default:
					xbbf9a1ead81dd3a1(x68415805ef2e3525, i, "Unrecognised special code type 0x{0:X2}", b);
					list.Add(new xf8be28f9144c5748(i, x7a274f60ab25f2b));
					break;
				}
			}
			else
			{
				list.Add(new x95af7b2efc150589(i, x7a274f60ab25f2b));
			}
		}
		return list;
	}

	private static void xbbf9a1ead81dd3a1(List<string> x68415805ef2e3525, int xeb28d76ef7e31289, string x8ff0877118142d1a, params object[] xce8d8c7e3c2c2426)
	{
		x68415805ef2e3525.Add("Line " + (xeb28d76ef7e31289 + 1) + ": " + string.Format(x8ff0877118142d1a, xce8d8c7e3c2c2426));
	}

	private static void x106eedab11fee438(List<string> x68415805ef2e3525, int xeb28d76ef7e31289, uint x4b8b317913377903)
	{
		if (x4b8b317913377903 != 0)
		{
			xbbf9a1ead81dd3a1(x68415805ef2e3525, xeb28d76ef7e31289, "Data present in reserved or unknown portion of command.");
		}
	}

	private static void x0b6e8b2c228a5ddc(List<string> x68415805ef2e3525, int xeb28d76ef7e31289, xd37843060f387912 x0ceec69a97f73617, uint x4b8b317913377903, bool xecb91aca3799e84b)
	{
		switch (x0ceec69a97f73617)
		{
		case xd37843060f387912.x7ee8c15a7fe70b04:
			x106eedab11fee438(x68415805ef2e3525, xeb28d76ef7e31289, x4b8b317913377903 & 0xFFFFFF00u);
			break;
		case xd37843060f387912.xfa092eb1a8142eb9:
			x106eedab11fee438(x68415805ef2e3525, xeb28d76ef7e31289, x4b8b317913377903 & 0xFFFF0000u);
			break;
		case xd37843060f387912.xd4d82c4665f71358:
			if (!xecb91aca3799e84b)
			{
				xbbf9a1ead81dd3a1(x68415805ef2e3525, xeb28d76ef7e31289, "Command requires specific data size.");
			}
			break;
		default:
			xbbf9a1ead81dd3a1(x68415805ef2e3525, xeb28d76ef7e31289, "Unexpected data size in command.");
			break;
		case xd37843060f387912.xeb473b682e8df563:
			break;
		}
	}

	private static void x30f11b62808214b9(List<xf370fda13822d1f9> xc8e5edc888efe6f5, List<string> x68415805ef2e3525)
	{
		for (int i = 0; i < xc8e5edc888efe6f5.Count; i++)
		{
			xf370fda13822d1f9 xf370fda13822d1f = xc8e5edc888efe6f5[i];
			if (xf370fda13822d1f is xf8be28f9144c5748)
			{
				continue;
			}
			if (xf370fda13822d1f is x9f51b856a6c0aa70)
			{
				x9f51b856a6c0aa70 x9f51b856a6c0aa = (x9f51b856a6c0aa70)xf370fda13822d1f;
				x0b6e8b2c228a5ddc(x68415805ef2e3525, x9f51b856a6c0aa.x9f7648f40d0312e9, x9f51b856a6c0aa.x437e3b626c0fdd43, x9f51b856a6c0aa.xdc0e6f9257e1e0ab[1].x1d5cfa3bffdfb042, xecb91aca3799e84b: false);
				if (x9f51b856a6c0aa.xd44988f225497f3a == 0)
				{
					xbbf9a1ead81dd3a1(x68415805ef2e3525, x9f51b856a6c0aa.x9f7648f40d0312e9, "Slide code has zero count, making it a no-op.");
				}
			}
			else if (xf370fda13822d1f is x0f0906c583e29b6b)
			{
				if (i >= xc8e5edc888efe6f5.Count - 1)
				{
					xbbf9a1ead81dd3a1(x68415805ef2e3525, xf370fda13822d1f.x9f7648f40d0312e9, "'End of codelist' command is redundant when used as the final command.");
				}
			}
			else if (xf370fda13822d1f is xe948cf6a9cb0be5f)
			{
				x106eedab11fee438(x68415805ef2e3525, xf370fda13822d1f.x9f7648f40d0312e9, xf370fda13822d1f.xdc0e6f9257e1e0ab[0].xd2f68ee6f47e9dfb & 0x1FFFFFFu);
			}
			else if (xf370fda13822d1f is x95af7b2efc150589)
			{
				x9901277d72449341(xc8e5edc888efe6f5, i, (x95af7b2efc150589)xf370fda13822d1f, x68415805ef2e3525);
			}
			else
			{
				xbbf9a1ead81dd3a1(x68415805ef2e3525, xf370fda13822d1f.x9f7648f40d0312e9, "Conversion phase returned unhandled command type; please tell Mirality Systems!");
			}
		}
	}

	private static void x9901277d72449341(List<xf370fda13822d1f9> xc8e5edc888efe6f5, int x53ac6256933a4123, x95af7b2efc150589 xfd6dd6e53b1a26d5, List<string> x68415805ef2e3525)
	{
		if (xfd6dd6e53b1a26d5.x3aa89c51588c7466.x437e3b626c0fdd43 == xd37843060f387912.xd4d82c4665f71358)
		{
			xbbf9a1ead81dd3a1(x68415805ef2e3525, xfd6dd6e53b1a26d5.x9f7648f40d0312e9, "'Always' commands haven't been seen in the wild; not sure if they work.");
		}
		if (xfd6dd6e53b1a26d5.x3aa89c51588c7466.xca0517fe66f52202 == x8f1a4272515df03b.xa160b1c73a8f9d06)
		{
			switch (xfd6dd6e53b1a26d5.x3aa89c51588c7466.xa160b1c73a8f9d06)
			{
			case x87ce8e5fd3e61101.x5561649b370c7ba5:
				x0b6e8b2c228a5ddc(x68415805ef2e3525, xfd6dd6e53b1a26d5.x9f7648f40d0312e9, xfd6dd6e53b1a26d5.x3aa89c51588c7466.x437e3b626c0fdd43, xfd6dd6e53b1a26d5.xd2f68ee6f47e9dfb, xecb91aca3799e84b: false);
				break;
			case x87ce8e5fd3e61101.x77f5ace14d6d006a:
				x106eedab11fee438(x68415805ef2e3525, xfd6dd6e53b1a26d5.x9f7648f40d0312e9, xfd6dd6e53b1a26d5.xd2f68ee6f47e9dfb & 0xFFF000F0u);
				if (xfd6dd6e53b1a26d5.x3aa89c51588c7466.x437e3b626c0fdd43 != xd37843060f387912.xeb473b682e8df563)
				{
					xbbf9a1ead81dd3a1(x68415805ef2e3525, xfd6dd6e53b1a26d5.x9f7648f40d0312e9, "Master commands are normally 32-bit.");
				}
				break;
			}
		}
		else
		{
			x2c8bc15338566b37(xc8e5edc888efe6f5, x53ac6256933a4123, xfd6dd6e53b1a26d5, x68415805ef2e3525);
		}
	}

	private static void x2c8bc15338566b37(List<xf370fda13822d1f9> xc8e5edc888efe6f5, int x53ac6256933a4123, x95af7b2efc150589 xfd6dd6e53b1a26d5, List<string> x68415805ef2e3525)
	{
		switch (xfd6dd6e53b1a26d5.x3aa89c51588c7466.xd663ff321c322be2)
		{
		case x680523c0e011c5b8.xfb2ecf1342682c59:
		{
			x0b6e8b2c228a5ddc(x68415805ef2e3525, xfd6dd6e53b1a26d5.x9f7648f40d0312e9, xfd6dd6e53b1a26d5.x3aa89c51588c7466.x437e3b626c0fdd43, xfd6dd6e53b1a26d5.xd2f68ee6f47e9dfb, xecb91aca3799e84b: true);
			if (x53ac6256933a4123 >= xc8e5edc888efe6f5.Count - 1)
			{
				xbbf9a1ead81dd3a1(x68415805ef2e3525, xfd6dd6e53b1a26d5.x9f7648f40d0312e9, "Expecting another command following a single-line test command.");
				break;
			}
			xf370fda13822d1f9 xf370fda13822d1f3 = xc8e5edc888efe6f5[x53ac6256933a4123 + 1];
			if (xf370fda13822d1f3 is x9f51b856a6c0aa70)
			{
				xbbf9a1ead81dd3a1(x68415805ef2e3525, xf370fda13822d1f3.x9f7648f40d0312e9, "Command following single-line test is a multi-line command; this will lead to incorrect behaviour.");
			}
			else if (xf370fda13822d1f3 is x95af7b2efc150589)
			{
				x95af7b2efc150589 x95af7b2efc3 = (x95af7b2efc150589)xf370fda13822d1f3;
				if (x95af7b2efc3.x3aa89c51588c7466.xca0517fe66f52202 != 0 && (x95af7b2efc3.x3aa89c51588c7466.xd663ff321c322be2 == x680523c0e011c5b8.xfb2ecf1342682c59 || x95af7b2efc3.x3aa89c51588c7466.xd663ff321c322be2 != x680523c0e011c5b8.xed1527f9b08bd991))
				{
					xbbf9a1ead81dd3a1(x68415805ef2e3525, xf370fda13822d1f3.x9f7648f40d0312e9, "Command following single-line test is another test, not an action; this may lead to incorrect behaviour.");
				}
			}
			break;
		}
		case x680523c0e011c5b8.xed1527f9b08bd991:
		{
			x0b6e8b2c228a5ddc(x68415805ef2e3525, xfd6dd6e53b1a26d5.x9f7648f40d0312e9, xfd6dd6e53b1a26d5.x3aa89c51588c7466.x437e3b626c0fdd43, xfd6dd6e53b1a26d5.xd2f68ee6f47e9dfb, xecb91aca3799e84b: true);
			if (x53ac6256933a4123 >= xc8e5edc888efe6f5.Count - 1)
			{
				xbbf9a1ead81dd3a1(x68415805ef2e3525, xfd6dd6e53b1a26d5.x9f7648f40d0312e9, "Expecting two commands following a double-line test command.");
				break;
			}
			xf370fda13822d1f9 xf370fda13822d1f = xc8e5edc888efe6f5[x53ac6256933a4123 + 1];
			if (xf370fda13822d1f is x9f51b856a6c0aa70)
			{
				break;
			}
			if (x53ac6256933a4123 >= xc8e5edc888efe6f5.Count - 2)
			{
				xbbf9a1ead81dd3a1(x68415805ef2e3525, xfd6dd6e53b1a26d5.x9f7648f40d0312e9, "Expecting one more command following a double-line test command.");
				break;
			}
			xf370fda13822d1f9 xf370fda13822d1f2 = xc8e5edc888efe6f5[x53ac6256933a4123 + 2];
			if (xf370fda13822d1f2 is x9f51b856a6c0aa70)
			{
				xbbf9a1ead81dd3a1(x68415805ef2e3525, xf370fda13822d1f2.x9f7648f40d0312e9, "Second command after double-line test command is a multi-line command; this will lead to incorrect behaviour.");
				break;
			}
			if (xf370fda13822d1f is x95af7b2efc150589)
			{
				x95af7b2efc150589 x95af7b2efc = (x95af7b2efc150589)xf370fda13822d1f;
				if (x95af7b2efc.x3aa89c51588c7466.xca0517fe66f52202 != 0 && x95af7b2efc.x3aa89c51588c7466.xd663ff321c322be2 == x680523c0e011c5b8.xed1527f9b08bd991)
				{
					xbbf9a1ead81dd3a1(x68415805ef2e3525, x95af7b2efc.x9f7648f40d0312e9, "Embedding a double-line test command within another double-line test command will lead to incorrect behaviour.");
					break;
				}
			}
			if (xf370fda13822d1f2 is x95af7b2efc150589)
			{
				x95af7b2efc150589 x95af7b2efc2 = (x95af7b2efc150589)xf370fda13822d1f2;
				if (x95af7b2efc2.x3aa89c51588c7466.xca0517fe66f52202 != 0 && (x95af7b2efc2.x3aa89c51588c7466.xd663ff321c322be2 == x680523c0e011c5b8.xfb2ecf1342682c59 || x95af7b2efc2.x3aa89c51588c7466.xd663ff321c322be2 == x680523c0e011c5b8.xed1527f9b08bd991))
				{
					xbbf9a1ead81dd3a1(x68415805ef2e3525, x95af7b2efc2.x9f7648f40d0312e9, "Second command after double-line test is another test, not an action; this may lead to incorrect behaviour.");
				}
			}
			break;
		}
		case x680523c0e011c5b8.x82b94dd34c559efc:
			x0b6e8b2c228a5ddc(x68415805ef2e3525, xfd6dd6e53b1a26d5.x9f7648f40d0312e9, xfd6dd6e53b1a26d5.x3aa89c51588c7466.x437e3b626c0fdd43, xfd6dd6e53b1a26d5.xd2f68ee6f47e9dfb, xecb91aca3799e84b: true);
			break;
		case x680523c0e011c5b8.xb84af20ae19acd13:
			x0b6e8b2c228a5ddc(x68415805ef2e3525, xfd6dd6e53b1a26d5.x9f7648f40d0312e9, xfd6dd6e53b1a26d5.x3aa89c51588c7466.x437e3b626c0fdd43, xfd6dd6e53b1a26d5.xd2f68ee6f47e9dfb, xecb91aca3799e84b: false);
			xbbf9a1ead81dd3a1(x68415805ef2e3525, xfd6dd6e53b1a26d5.x9f7648f40d0312e9, "'Pause' commands haven't been seen in the wild; not sure if they work.");
			break;
		}
	}
}
