using System;
using System.Net.Http.QPack;

namespace Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http3.QPack
{
	internal class DynamicTable
	{
		public HeaderField this[int index]
		{
			get
			{
				throw null;
			}
		}

		public DynamicTable(int maxSize)
		{
			throw null;
		}

		public void Insert(Span<byte> name, Span<byte> value)
		{
			throw null;
		}

		public void Resize(int maxSize)
		{
			throw null;
		}

		internal void Duplicate(int index)
		{
			throw null;
		}
	}
}
