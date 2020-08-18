using System;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.DataProtection
{
	/// <summary>
	/// Represents a secret value stored in memory.
	/// </summary>
	public sealed class Secret : IDisposable, ISecret
	{
		/// <summary>
		/// The length (in bytes) of the secret value.
		/// </summary>
		public int Length
		{
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Creates a new Secret from the provided input value, where the input value
		/// is specified as an array segment.
		/// </summary>
		public Secret(ArraySegment<byte> value)
		{
			throw null;
		}

		/// <summary>
		/// Creates a new Secret from the provided input value, where the input value
		/// is specified as an array.
		/// </summary>
		[System.Runtime.CompilerServices.NullableContext(1)]
		public Secret(byte[] value)
		{
			throw null;
		}

		/// <summary>
		/// Creates a new Secret from the provided input value, where the input value
		/// is specified as a pointer to unmanaged memory.
		/// </summary>
		public unsafe Secret(byte* secret, int secretLength)
		{
			throw null;
		}

		/// <summary>
		/// Creates a new Secret from another secret object.
		/// </summary>
		[System.Runtime.CompilerServices.NullableContext(1)]
		public Secret(ISecret secret)
		{
			throw null;
		}

		/// <summary>
		/// Wipes the secret from memory.
		/// </summary>
		public void Dispose()
		{
			throw null;
		}

		/// <summary>
		/// Returns a Secret made entirely of random bytes retrieved from
		/// a cryptographically secure RNG.
		/// </summary>
		public static Secret Random(int numBytes)
		{
			throw null;
		}

		/// <summary>
		/// Writes the secret value to the specified buffer.
		/// </summary>
		/// <remarks>
		/// The buffer size must exactly match the length of the secret value.
		/// </remarks>
		public void WriteSecretIntoBuffer(ArraySegment<byte> buffer)
		{
			throw null;
		}

		/// <summary>
		/// Writes the secret value to the specified buffer.
		/// </summary>
		/// <param name="buffer">The buffer into which to write the secret value.</param>
		/// <param name="bufferLength">The size (in bytes) of the provided buffer.</param>
		/// <remarks>
		/// The 'bufferLength' parameter must exactly match the length of the secret value.
		/// </remarks>
		public unsafe void WriteSecretIntoBuffer(byte* buffer, int bufferLength)
		{
			throw null;
		}
	}
}
