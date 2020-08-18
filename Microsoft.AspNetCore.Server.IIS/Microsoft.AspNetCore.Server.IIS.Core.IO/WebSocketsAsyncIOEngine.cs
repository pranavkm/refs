using Microsoft.AspNetCore.HttpSys.Internal;
using System;
using System.Buffers;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Server.IIS.Core.IO
{
	internal class WebSocketsAsyncIOEngine : IAsyncIOEngine
	{
		internal class AsyncInitializeOperation : AsyncIOOperation
		{
			public AsyncInitializeOperation(WebSocketsAsyncIOEngine engine)
			{
				throw null;
			}

			public void Initialize(NativeSafeHandle requestHandler)
			{
				throw null;
			}

			protected override bool InvokeOperation(out int hr, out int bytes)
			{
				throw null;
			}

			protected override void ResetOperation()
			{
				throw null;
			}
		}

		internal class WebSocketReadOperation : AsyncIOOperation
		{
			public static readonly NativeMethods.PFN_WEBSOCKET_ASYNC_COMPLETION ReadCallback;

			public WebSocketReadOperation(WebSocketsAsyncIOEngine engine)
			{
				throw null;
			}

			protected override bool InvokeOperation(out int hr, out int bytes)
			{
				throw null;
			}

			public void Initialize(NativeSafeHandle requestHandler, Memory<byte> memory)
			{
				throw null;
			}

			public override void FreeOperationResources(int hr, int bytes)
			{
				throw null;
			}

			protected override void ResetOperation()
			{
				throw null;
			}

			protected override bool IsSuccessfulResult(int hr)
			{
				throw null;
			}
		}

		internal sealed class WebSocketWriteOperation : AsyncWriteOperationBase
		{
			public WebSocketWriteOperation(WebSocketsAsyncIOEngine engine)
			{
				throw null;
			}

			protected unsafe override int WriteChunks(NativeSafeHandle requestHandler, int chunkCount, HttpApiTypes.HTTP_DATA_CHUNK* dataChunks, out bool completionExpected)
			{
				throw null;
			}

			protected override void ResetOperation()
			{
				throw null;
			}
		}

		public WebSocketsAsyncIOEngine(object contextLock, NativeSafeHandle handler)
		{
			throw null;
		}

		public ValueTask<int> ReadAsync(Memory<byte> memory)
		{
			throw null;
		}

		public ValueTask<int> WriteAsync(ReadOnlySequence<byte> data)
		{
			throw null;
		}

		public ValueTask FlushAsync(bool moreData)
		{
			throw null;
		}

		public void NotifyCompletion(int hr, int bytes)
		{
			throw null;
		}

		public void Complete()
		{
			throw null;
		}
	}
}
