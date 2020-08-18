using System.Runtime.Serialization;

namespace System.Net.Http.HPack
{
	[Serializable]
	internal class HuffmanDecodingException : Exception, ISerializable
	{
		public HuffmanDecodingException()
		{
			throw null;
		}

		public HuffmanDecodingException(string message)
		{
			throw null;
		}

		protected HuffmanDecodingException(SerializationInfo info, StreamingContext context)
		{
			throw null;
		}

		void ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
			throw null;
		}

		public override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
			throw null;
		}
	}
}
