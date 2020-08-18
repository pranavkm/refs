using System.Runtime.Serialization;

namespace System.Net.Http.HPack
{
	[Serializable]
	internal class HPackDecodingException : Exception
	{
		public HPackDecodingException()
		{
			throw null;
		}

		public HPackDecodingException(string message)
		{
			throw null;
		}

		public HPackDecodingException(string message, Exception innerException)
		{
			throw null;
		}

		public HPackDecodingException(SerializationInfo info, StreamingContext context)
		{
			throw null;
		}
	}
}
