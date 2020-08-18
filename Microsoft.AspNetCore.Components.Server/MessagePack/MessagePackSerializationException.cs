using System;
using System.Runtime.Serialization;

namespace MessagePack
{
	/// <summary>
	/// An exception thrown during serializing an object graph or deserializing a messagepack sequence.
	/// </summary>
	[Serializable]
	internal class MessagePackSerializationException : Exception
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="T:MessagePack.MessagePackSerializationException" /> class.
		/// </summary>
		public MessagePackSerializationException()
		{
			throw null;
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="T:MessagePack.MessagePackSerializationException" /> class.
		/// </summary>
		/// <param name="message">The exception message.</param>
		public MessagePackSerializationException(string message)
		{
			throw null;
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="T:MessagePack.MessagePackSerializationException" /> class.
		/// </summary>
		/// <param name="message">The exception message.</param>
		/// <param name="inner">The inner exception.</param>
		public MessagePackSerializationException(string message, Exception inner)
		{
			throw null;
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="T:MessagePack.MessagePackSerializationException" /> class.
		/// </summary>
		/// <param name="info">Serialization info.</param>
		/// <param name="context">Serialization context.</param>
		protected MessagePackSerializationException(SerializationInfo info, StreamingContext context)
		{
			throw null;
		}
	}
}
