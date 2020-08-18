using System.Runtime.CompilerServices;

namespace System.IO.Pipelines
{
	internal class DuplexPipe : IDuplexPipe
	{
		public readonly struct DuplexPipePair
		{
			public IDuplexPipe Transport
			{
				[CompilerGenerated]
				get
				{
					throw null;
				}
			}

			public IDuplexPipe Application
			{
				[CompilerGenerated]
				get
				{
					throw null;
				}
			}

			public DuplexPipePair(IDuplexPipe transport, IDuplexPipe application)
			{
				throw null;
			}
		}

		public PipeReader Input
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public PipeWriter Output
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public DuplexPipe(PipeReader reader, PipeWriter writer)
		{
			throw null;
		}

		public static DuplexPipePair CreateConnectionPair(PipeOptions inputOptions, PipeOptions outputOptions)
		{
			throw null;
		}
	}
}
