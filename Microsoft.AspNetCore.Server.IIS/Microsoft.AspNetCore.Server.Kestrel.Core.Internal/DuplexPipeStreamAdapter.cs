using System;
using System.Diagnostics;
using System.IO;
using System.IO.Pipelines;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Server.Kestrel.Core.Internal
{
	/// <summary>
	/// A helper for wrapping a Stream decorator from an <see cref="T:System.IO.Pipelines.IDuplexPipe" />.
	/// </summary>
	/// <typeparam name="TStream"></typeparam>
	internal class DuplexPipeStreamAdapter<TStream> : DuplexPipeStream, IDuplexPipe where TStream : Stream
	{
		public TStream Stream
		{
			[CompilerGenerated]
			get
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

		public DuplexPipeStreamAdapter(IDuplexPipe duplexPipe, Func<Stream, TStream> createStream)
		{
			throw null;
		}

		public DuplexPipeStreamAdapter(IDuplexPipe duplexPipe, StreamPipeReaderOptions readerOptions, StreamPipeWriterOptions writerOptions, Func<Stream, TStream> createStream)
		{
			throw null;
		}

		[AsyncStateMachine(typeof(DuplexPipeStreamAdapter<>._003CDisposeAsync_003Ed__13))]
		[DebuggerStepThrough]
		public override ValueTask DisposeAsync()
		{
			throw null;
		}

		protected override void Dispose(bool disposing)
		{
			throw null;
		}
	}
}
