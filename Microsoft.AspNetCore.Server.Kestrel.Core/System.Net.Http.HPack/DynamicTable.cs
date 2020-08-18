namespace System.Net.Http.HPack
{
	internal class DynamicTable
	{
		public int Count
		{
			get
			{
				throw null;
			}
		}

		public int Size
		{
			get
			{
				throw null;
			}
		}

		public int MaxSize
		{
			get
			{
				throw null;
			}
		}

		public ref readonly HeaderField this[int index]
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

		public void Insert(ReadOnlySpan<byte> name, ReadOnlySpan<byte> value)
		{
			throw null;
		}

		public void Resize(int maxSize)
		{
			throw null;
		}
	}
}
