using Microsoft.AspNetCore.HttpSys.Internal;
using System.Buffers;

namespace Microsoft.AspNetCore.Server.IIS.Core.IO
{
	internal abstract class AsyncWriteOperationBase : AsyncIOOperation
	{
		public void Initialize(NativeSafeHandle requestHandler, ReadOnlySequence<byte> buffer)
		{
			throw null;
		}

		protected override bool InvokeOperation(out int hr, out int bytes)
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

		protected unsafe abstract int WriteChunks(NativeSafeHandle requestHandler, int chunkCount, HttpApiTypes.HTTP_DATA_CHUNK* dataChunks, out bool completionExpected);

		protected AsyncWriteOperationBase()
		{
			throw null;
		}
	}
}
