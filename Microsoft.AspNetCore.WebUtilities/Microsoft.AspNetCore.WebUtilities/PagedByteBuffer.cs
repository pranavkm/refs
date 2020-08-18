using System;
using System.Buffers;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.IO.Pipelines;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.WebUtilities
{
	internal sealed class PagedByteBuffer : IDisposable
	{
		internal const int PageSize = 1024;

		public int Length
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		internal bool Disposed
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		internal List<byte[]> Pages
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public PagedByteBuffer(ArrayPool<byte> arrayPool)
		{
			throw null;
		}

		public void Add(byte[] buffer, int offset, int count)
		{
			throw null;
		}

		public void MoveTo(Stream stream)
		{
			throw null;
		}

		[AsyncStateMachine(typeof(_003CMoveToAsync_003Ed__20))]
		[DebuggerStepThrough]
		public Task MoveToAsync(PipeWriter writer, CancellationToken cancellationToken)
		{
			throw null;
		}

		[AsyncStateMachine(typeof(_003CMoveToAsync_003Ed__21))]
		[DebuggerStepThrough]
		public Task MoveToAsync(Stream stream, CancellationToken cancellationToken)
		{
			throw null;
		}

		public void Dispose()
		{
			throw null;
		}
	}
}
