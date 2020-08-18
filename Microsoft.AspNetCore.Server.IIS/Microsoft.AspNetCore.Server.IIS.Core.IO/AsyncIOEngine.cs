using Microsoft.AspNetCore.HttpSys.Internal;
using System;
using System.Buffers;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Server.IIS.Core.IO
{
	internal class AsyncIOEngine : IAsyncIOEngine
	{
		internal class AsyncFlushOperation : AsyncIOOperation
		{
			public AsyncFlushOperation(AsyncIOEngine engine)
			{
				throw null;
			}

			public void Initialize(NativeSafeHandle requestHandler, bool moreData)
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

		internal class AsyncReadOperation : AsyncIOOperation
		{
			public AsyncReadOperation(AsyncIOEngine engine)
			{
				throw null;
			}

			public void Initialize(NativeSafeHandle requestHandler, Memory<byte> memory)
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

			public override void FreeOperationResources(int hr, int bytes)
			{
				throw null;
			}

			protected override bool IsSuccessfulResult(int hr)
			{
				throw null;
			}
		}

		private class AsyncWriteOperation : AsyncWriteOperationBase
		{
			public AsyncWriteOperation(AsyncIOEngine engine)
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

		public AsyncIOEngine(object contextSync, NativeSafeHandle handler)
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
