using System;
using System.Buffers;

namespace Microsoft.AspNetCore.Components.Server.BlazorPack
{
	internal sealed class ArrayBufferWriter<T> : IBufferWriter<T>, IDisposable
	{
		public ReadOnlyMemory<T> WrittenMemory
		{
			get
			{
				throw null;
			}
		}

		public int WrittenCount
		{
			get
			{
				throw null;
			}
		}

		public int Capacity
		{
			get
			{
				throw null;
			}
		}

		public int FreeCapacity
		{
			get
			{
				throw null;
			}
		}

		public ArrayBufferWriter()
		{
			throw null;
		}

		public ArrayBufferWriter(int initialCapacity)
		{
			throw null;
		}

		public void Clear()
		{
			throw null;
		}

		public void Dispose()
		{
			throw null;
		}

		public void Advance(int count)
		{
			throw null;
		}

		public Memory<T> GetMemory(int sizeHint = 0)
		{
			throw null;
		}

		public Span<T> GetSpan(int sizeHint = 0)
		{
			throw null;
		}
	}
}
