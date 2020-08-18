namespace System.Buffers
{
	internal class BuffersThrowHelper
	{
		internal enum ExceptionArgument
		{
			length
		}

		public static void ThrowArgumentOutOfRangeException(ExceptionArgument argument)
		{
			throw null;
		}

		public BuffersThrowHelper()
		{
			throw null;
		}
	}
}
