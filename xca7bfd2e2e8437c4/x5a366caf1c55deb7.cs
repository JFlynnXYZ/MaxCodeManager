using System;
using System.ComponentModel;
using System.Threading;

namespace xca7bfd2e2e8437c4;

internal abstract class x5a366caf1c55deb7 : x1cc976ec1727390f
{
	private class x3d58dd59db12db24 : xa593855140ea9af2
	{
		private readonly x5a366caf1c55deb7 x97f9c5601511630c;

		private bool _a6183d3298319b6a;

		private bool _868a32060451dd2e;

		public bool xa6183d3298319b6a
		{
			get
			{
				return _a6183d3298319b6a;
			}
			internal set
			{
				_a6183d3298319b6a = value;
			}
		}

		public bool x868a32060451dd2e => _868a32060451dd2e;

		public x3d58dd59db12db24(x5a366caf1c55deb7 x801bd3a7d5412d70)
		{
			x97f9c5601511630c = x801bd3a7d5412d70;
		}

		public void x17996fbebb8db644()
		{
			if (!x97f9c5601511630c.x25e3ad2b132958d4)
			{
				throw new InvalidOperationException("Not running.");
			}
			_868a32060451dd2e = true;
		}

		public void x35579b297303ed43()
		{
			if (!x97f9c5601511630c.x25e3ad2b132958d4)
			{
				throw new InvalidOperationException("Not running.");
			}
			x97f9c5601511630c._ca0517fe66f52202.Post(x97f9c5601511630c.x8d1f4441bba97114, true);
		}

		public void x5486e0b5e830d25c()
		{
			if (!x97f9c5601511630c.x25e3ad2b132958d4)
			{
				throw new InvalidOperationException("Not running.");
			}
			x97f9c5601511630c._ca0517fe66f52202.Post(x97f9c5601511630c.x8d1f4441bba97114, false);
		}

		public void x0c8a59ac3e2be908(string x5786461d089b10a0, params object[] xce8d8c7e3c2c2426)
		{
			x97f9c5601511630c.OnLog(new xdd5ac28490ab132e(string.Format(x5786461d089b10a0, xce8d8c7e3c2c2426)));
		}

		public void Message(string xb41faee6912a2313)
		{
			if (!x97f9c5601511630c.x25e3ad2b132958d4)
			{
				throw new InvalidOperationException("Not running.");
			}
			x97f9c5601511630c._ca0517fe66f52202.Post(x97f9c5601511630c.x0e0c23e8237da14e, xb41faee6912a2313);
		}

		public void xefaf3c086735b687(int xc196721e130d135a, double x0fbedfe2f1bb9bd6)
		{
			if (!x97f9c5601511630c.x25e3ad2b132958d4)
			{
				throw new InvalidOperationException("Not running.");
			}
			x97f9c5601511630c._ca0517fe66f52202.Post(x97f9c5601511630c.x1ecac925b82ecd7a, new x48c112b540538df3(xc196721e130d135a, x0fbedfe2f1bb9bd6));
		}

		public void x6e8d7b0c676d4103(int xc196721e130d135a, double x24018070e057ac8e)
		{
			if (!x97f9c5601511630c.x25e3ad2b132958d4)
			{
				throw new InvalidOperationException("Not running.");
			}
			x97f9c5601511630c._ca0517fe66f52202.Post(x97f9c5601511630c.x1c71307406a44ce2, new x48c112b540538df3(xc196721e130d135a, x24018070e057ac8e));
		}

		public void x728cb2b1f18d1925(object x4a3f0a05c02f235f)
		{
			if (!x97f9c5601511630c.x25e3ad2b132958d4)
			{
				throw new InvalidOperationException("Not running.");
			}
			x97f9c5601511630c._ca0517fe66f52202.Post(x97f9c5601511630c.x499642fd45e5f784, x4a3f0a05c02f235f);
		}
	}

	private class x48c112b540538df3
	{
		public readonly int x504f3d4040b356d7;

		public readonly double xd2f68ee6f47e9dfb;

		public x48c112b540538df3(int x66bbd7ed8c65740d, double xbcea506a33cf9111)
		{
			x504f3d4040b356d7 = x66bbd7ed8c65740d;
			xd2f68ee6f47e9dfb = xbcea506a33cf9111;
		}
	}

	private AsyncOperation _ca0517fe66f52202;

	private bool _4b35c2a03ad84fdf;

	private x3d58dd59db12db24 _a3804f4d987a3845;

	private ParameterizedThreadStart _356882ad8f141ffb;

	private SendOrPostCallback _fb21296af0351c10;

	public bool x25e3ad2b132958d4 => _4b35c2a03ad84fdf;

	public event EventHandler<x366c5bb7f378f5b7> x063dbd29ee696b79;

	public event RunWorkerCompletedEventHandler xc236b23da7f61ea5;

	public static event EventHandler<xdd5ac28490ab132e> x16668035f59b0295;

	protected virtual void OnDoWork(x366c5bb7f378f5b7 xfbf34718e704c6bc)
	{
		this.x063dbd29ee696b79?.Invoke(this, xfbf34718e704c6bc);
	}

	protected virtual void OnComplete(RunWorkerCompletedEventArgs xfbf34718e704c6bc)
	{
		this.xc236b23da7f61ea5?.Invoke(this, xfbf34718e704c6bc);
	}

	protected virtual void OnLog(xdd5ac28490ab132e xfbf34718e704c6bc)
	{
		x5a366caf1c55deb7.x16668035f59b0295?.Invoke(this, xfbf34718e704c6bc);
	}

	public x5a366caf1c55deb7()
	{
		_356882ad8f141ffb = xf4a6ee4299bf6c59;
		_fb21296af0351c10 = x4dc75e4e72ba76f7;
	}

	public void xd674415062c2b55f()
	{
		if (!_4b35c2a03ad84fdf)
		{
			throw new InvalidOperationException("Not running.");
		}
		_a3804f4d987a3845.xa6183d3298319b6a = true;
	}

	public void x160a0bf4de8f6bd0(string x399bfb4377fa76d2)
	{
		x160a0bf4de8f6bd0(x399bfb4377fa76d2, xfb54ea78556e1909: false);
	}

	public void x160a0bf4de8f6bd0(string x399bfb4377fa76d2, bool xfb54ea78556e1909)
	{
		x160a0bf4de8f6bd0(x399bfb4377fa76d2, xfb54ea78556e1909, null);
	}

	public void x160a0bf4de8f6bd0(string x399bfb4377fa76d2, bool xfb54ea78556e1909, object xf6fec61b61cb58a0)
	{
		if (_4b35c2a03ad84fdf)
		{
			throw new InvalidOperationException("Already running.");
		}
		_4b35c2a03ad84fdf = true;
		_ca0517fe66f52202 = AsyncOperationManager.CreateOperation(null);
		_a3804f4d987a3845 = new x3d58dd59db12db24(this);
		DoBeginRun(x399bfb4377fa76d2, xfb54ea78556e1909);
		_356882ad8f141ffb.BeginInvoke(xf6fec61b61cb58a0, null, null);
	}

	private void x8d1f4441bba97114(object x4a3f0a05c02f235f)
	{
		DoShowHide((bool)x4a3f0a05c02f235f);
	}

	private void x0e0c23e8237da14e(object x4a3f0a05c02f235f)
	{
		DoSetMessage((string)x4a3f0a05c02f235f);
	}

	private void x1ecac925b82ecd7a(object x4a3f0a05c02f235f)
	{
		x48c112b540538df3 x48c112b540538df = (x48c112b540538df3)x4a3f0a05c02f235f;
		DoSetupProgress(x48c112b540538df.x504f3d4040b356d7, x48c112b540538df.xd2f68ee6f47e9dfb);
	}

	private void x1c71307406a44ce2(object x4a3f0a05c02f235f)
	{
		x48c112b540538df3 x48c112b540538df = (x48c112b540538df3)x4a3f0a05c02f235f;
		DoReportProgress(x48c112b540538df.x504f3d4040b356d7, x48c112b540538df.xd2f68ee6f47e9dfb);
	}

	private void x499642fd45e5f784(object x4a3f0a05c02f235f)
	{
		DoReportData(x4a3f0a05c02f235f);
	}

	protected virtual void DoShowHide(bool x789c645a15deb49b)
	{
	}

	protected virtual void DoBeginRun(string x399bfb4377fa76d2, bool xfb54ea78556e1909)
	{
	}

	protected abstract void DoSetMessage(string x1f25abf5fb75e795);

	protected abstract void DoSetupProgress(int xc196721e130d135a, double x0fbedfe2f1bb9bd6);

	protected abstract void DoReportProgress(int xc196721e130d135a, double x24018070e057ac8e);

	protected virtual void DoReportData(object x4a3f0a05c02f235f)
	{
	}

	private void xf4a6ee4299bf6c59(object xf6fec61b61cb58a0)
	{
		object result = null;
		Exception error = null;
		bool cancelled = false;
		try
		{
			x366c5bb7f378f5b7 x366c5bb7f378f5b8 = new x366c5bb7f378f5b7(_a3804f4d987a3845, xf6fec61b61cb58a0);
			OnDoWork(x366c5bb7f378f5b8);
			if (x366c5bb7f378f5b8.Cancel || _a3804f4d987a3845.x868a32060451dd2e)
			{
				cancelled = true;
			}
			else
			{
				result = x366c5bb7f378f5b8.Result;
			}
		}
		catch (Exception ex)
		{
			error = ex;
		}
		_ca0517fe66f52202.PostOperationCompleted(_fb21296af0351c10, new RunWorkerCompletedEventArgs(result, error, cancelled));
	}

	private void x4dc75e4e72ba76f7(object x2a5db75ce3baf60f)
	{
		_4b35c2a03ad84fdf = false;
		_a3804f4d987a3845 = null;
		_ca0517fe66f52202 = null;
		OnComplete((RunWorkerCompletedEventArgs)x2a5db75ce3baf60f);
	}
}
