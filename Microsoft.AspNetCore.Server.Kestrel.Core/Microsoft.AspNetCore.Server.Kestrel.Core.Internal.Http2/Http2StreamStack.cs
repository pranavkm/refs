namespace Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http2
{
	internal struct Http2StreamStack
	{
		internal readonly struct Http2StreamAsValueType
		{
			private readonly Http2Stream _value;

			public static implicit operator Http2StreamAsValueType(Http2Stream s)
			{
				throw null;
			}

			public static implicit operator Http2Stream(Http2StreamAsValueType s)
			{
				throw null;
			}
		}

		internal Http2StreamAsValueType[] _array;

		private int _size;

		public int Count
		{
			get
			{
				throw null;
			}
		}

		public Http2StreamStack(int size)
		{
			throw null;
		}

		public bool TryPop(out Http2Stream result)
		{
			throw null;
		}

		public bool TryPeek(out Http2Stream result)
		{
			throw null;
		}

		public void Push(Http2Stream item)
		{
			throw null;
		}

		public void RemoveExpired(long now)
		{
			throw null;
		}
	}
}
