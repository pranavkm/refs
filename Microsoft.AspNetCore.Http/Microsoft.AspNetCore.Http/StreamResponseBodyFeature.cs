using Microsoft.AspNetCore.Http.Features;
using System.Diagnostics;
using System.IO;
using System.IO.Pipelines;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Http
{
	/// <summary>
	/// An implementation of <see cref="T:Microsoft.AspNetCore.Http.Features.IHttpResponseBodyFeature" /> that aproximates all of the APIs over the given Stream.
	/// </summary>
	public class StreamResponseBodyFeature : IHttpResponseBodyFeature
	{
		/// <summary>
		/// The original response body stream.
		/// </summary>
		public Stream Stream
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// The prior feature, if any.
		/// </summary>
		public IHttpResponseBodyFeature? PriorFeature
		{
			[System.Runtime.CompilerServices.NullableContext(2)]
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// A PipeWriter adapted over the given stream.
		/// </summary>
		public PipeWriter Writer
		{
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Wraps the given stream.
		/// </summary>
		/// <param name="stream"></param>
		public StreamResponseBodyFeature(Stream stream)
		{
			throw null;
		}

		/// <summary>
		/// Wraps the given stream and tracks the prior feature instance.
		/// </summary>
		/// <param name="stream"></param>
		/// <param name="priorFeature"></param>
		public StreamResponseBodyFeature(Stream stream, IHttpResponseBodyFeature priorFeature)
		{
			throw null;
		}

		/// <summary>
		/// Not supported.
		/// </summary>
		public virtual void DisableBuffering()
		{
			throw null;
		}

		/// <summary>
		/// Copies the specified file segment to the given response stream.
		/// This calls StartAsync if it has not previoulsy been called.
		/// </summary>
		/// <param name="path">The full disk path to the file.</param>
		/// <param name="offset">The offset in the file to start at.</param>
		/// <param name="count">The number of bytes to send, or null to send the remainder of the file.</param>
		/// <param name="cancellationToken">A <see cref="T:System.Threading.CancellationToken" /> used to abort the transmission.</param>
		/// <returns></returns>
		[AsyncStateMachine(typeof(_003CSendFileAsync_003Ed__15))]
		[DebuggerStepThrough]
		public virtual Task SendFileAsync(string path, long offset, long? count, CancellationToken cancellationToken)
		{
			throw null;
		}

		/// <summary>
		/// Flushes the given stream if this has not previously been called.
		/// </summary>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public virtual Task StartAsync(CancellationToken cancellationToken = default(CancellationToken))
		{
			throw null;
		}

		/// <summary>
		/// This calls StartAsync if it has not previously been called.
		/// It will complete the adapted pipe if it exists.
		/// </summary>
		/// <returns></returns>
		[AsyncStateMachine(typeof(_003CCompleteAsync_003Ed__17))]
		[DebuggerStepThrough]
		public virtual Task CompleteAsync()
		{
			throw null;
		}

		/// <summary>
		/// Prevents CompleteAsync from operating.
		/// </summary>
		public void Dispose()
		{
			throw null;
		}
	}
}
