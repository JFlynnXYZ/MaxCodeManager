using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace xca7bfd2e2e8437c4;

internal class x94a6cdfb7e9c9552 : x5a366caf1c55deb7
{
	public class x21635fd6064678df : EventArgs
	{
		public readonly object x6b73aa01aa019d3a;

		public x21635fd6064678df(object x4a3f0a05c02f235f)
		{
			x6b73aa01aa019d3a = x4a3f0a05c02f235f;
		}
	}

	private Form _9ce35bc295da5a81;

	private x7a6ebf463a24aa8f _658c509a55e4e71a;

	private List<x7a6ebf463a24aa8f.x7ea5d7f562ca5f90> _a3804f4d987a3845 = new List<x7a6ebf463a24aa8f.x7ea5d7f562ca5f90>();

	private bool _6e0c1407bb8e8c32;

	public event EventHandler<x21635fd6064678df> x48c112b540538df3;

	protected virtual void OnProgressData(x21635fd6064678df xfbf34718e704c6bc)
	{
		this.x48c112b540538df3?.Invoke(this, xfbf34718e704c6bc);
	}

	public x94a6cdfb7e9c9552(Form x071bde1041617fce)
	{
		if (x071bde1041617fce == null)
		{
			throw new ArgumentNullException("owner");
		}
		_9ce35bc295da5a81 = x071bde1041617fce;
	}

	protected override void DoBeginRun(string x399bfb4377fa76d2, bool xfb54ea78556e1909)
	{
		if (_a3804f4d987a3845 == null)
		{
			throw new InvalidOperationException("Already completed.");
		}
		if (!_9ce35bc295da5a81.IsHandleCreated)
		{
			throw new InvalidOperationException("Owner form not loaded.");
		}
		_658c509a55e4e71a = new x7a6ebf463a24aa8f(_9ce35bc295da5a81, x399bfb4377fa76d2, xfb54ea78556e1909);
		_658c509a55e4e71a.xd674415062c2b55f += delegate
		{
			xd674415062c2b55f();
		};
		_658c509a55e4e71a.Show();
		_6e0c1407bb8e8c32 = _9ce35bc295da5a81.Enabled;
		_9ce35bc295da5a81.Enabled = false;
	}

	protected override void OnComplete(RunWorkerCompletedEventArgs xfbf34718e704c6bc)
	{
		_a3804f4d987a3845 = null;
		_9ce35bc295da5a81.Enabled = _6e0c1407bb8e8c32;
		_658c509a55e4e71a.Dispose();
		_658c509a55e4e71a = null;
		base.OnComplete(xfbf34718e704c6bc);
	}

	private void x28259b6ffea0cf1c()
	{
		if (_658c509a55e4e71a.InvokeRequired)
		{
			throw new InvalidOperationException("Called from non-UI thread.");
		}
	}

	protected override void DoShowHide(bool x789c645a15deb49b)
	{
		x28259b6ffea0cf1c();
		if (x789c645a15deb49b)
		{
			_658c509a55e4e71a.Show();
		}
		else
		{
			_658c509a55e4e71a.Hide();
		}
	}

	protected override void DoSetMessage(string x1f25abf5fb75e795)
	{
		x28259b6ffea0cf1c();
		_658c509a55e4e71a.xd397bb1e465ce45e = x1f25abf5fb75e795;
	}

	protected override void DoSetupProgress(int xc196721e130d135a, double x0fbedfe2f1bb9bd6)
	{
		x28259b6ffea0cf1c();
		if (xc196721e130d135a > _a3804f4d987a3845.Count)
		{
			throw new ArgumentOutOfRangeException("progressLevel", xc196721e130d135a, "Can only add one progress level at a time.");
		}
		if (xc196721e130d135a == _a3804f4d987a3845.Count)
		{
			_a3804f4d987a3845.Add(_658c509a55e4e71a.xcf539de674423889());
		}
		_a3804f4d987a3845[xc196721e130d135a].x2c167a39cabc8d00 = (int)Math.Round(x0fbedfe2f1bb9bd6 * 1000.0);
	}

	protected override void DoReportProgress(int xc196721e130d135a, double x24018070e057ac8e)
	{
		x28259b6ffea0cf1c();
		if (xc196721e130d135a >= _a3804f4d987a3845.Count)
		{
			throw new ArgumentOutOfRangeException("progressLevel", xc196721e130d135a, "Cannot report progress for a nonexistent level.");
		}
		_a3804f4d987a3845[xc196721e130d135a].xd2f68ee6f47e9dfb = (int)Math.Round(x24018070e057ac8e * 1000.0);
	}

	protected override void DoReportData(object x4a3f0a05c02f235f)
	{
		x28259b6ffea0cf1c();
		OnProgressData(new x21635fd6064678df(x4a3f0a05c02f235f));
	}

	[CompilerGenerated]
	private void x344cbd5b8dcc2fa6(object xb72547492e7e1901, EventArgs x2214ef6e3d238e98)
	{
		xd674415062c2b55f();
	}
}
