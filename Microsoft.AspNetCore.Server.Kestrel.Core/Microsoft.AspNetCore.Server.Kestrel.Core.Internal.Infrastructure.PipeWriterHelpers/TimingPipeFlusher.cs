using Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http;
using System.IO.Pipelines;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Infrastructure.PipeWriterHelpers
{
	/// <summary>
	/// This wraps PipeWriter.FlushAsync() in a way that allows multiple awaiters making it safe to call from publicly
	/// exposed Stream implementations while also tracking response data rate.
	/// </summary>
	internal class TimingPipeFlusher
	{
		[System.Runtime.CompilerServices.NullableContext(1)]
		public TimingPipeFlusher(PipeWriter writer, ITimeoutControl timeoutControl, IKestrelTrace log)
		{
			throw null;
		}

		public ValueTask<FlushResult> FlushAsync()
		{
			throw null;
		}

		public ValueTask<FlushResult> FlushAsync(IHttpOutputAborter? outputAborter, CancellationToken cancellationToken)
		{
			throw null;
		}

		public ValueTask<FlushResult> FlushAsync(MinDataRate? minRate, long count)
		{
			throw null;
		}

		public ValueTask<FlushResult> FlushAsync(MinDataRate? minRate, long count, IHttpOutputAborter? outputAborter, CancellationToken cancellationToken)
		{
			throw null;
		}
	}
}
