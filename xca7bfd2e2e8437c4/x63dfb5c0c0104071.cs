using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace xca7bfd2e2e8437c4;

internal class x63dfb5c0c0104071 : ScrollableControlDesigner
{
	public override void Initialize(IComponent x7f976b7a7a87b378)
	{
		base.Initialize(x7f976b7a7a87b378);
		EnableDragDrop(value: false);
	}

	public override bool CanParent(Control x43bec302f92080b9)
	{
		return false;
	}

	protected override bool GetHitTest(Point x2f7096dac971d6ec)
	{
		if (base.GetHitTest(x2f7096dac971d6ec))
		{
			return true;
		}
		xea5e4be807a4597b xea5e4be807a4597b2 = (xea5e4be807a4597b)Control;
		x95fcf261e3011b00 xb814177533985e8d;
		return xea5e4be807a4597b2.x68c86e2f125c51ea(xea5e4be807a4597b2.PointToClient(x2f7096dac971d6ec), out xb814177533985e8d) == x96bed71d06f031fe.xd774dfd2741655e5;
	}
}
