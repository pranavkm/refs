using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Server.HttpSys
{
	internal static class Helpers
	{
		internal static readonly byte[] ChunkTerminator;

		internal static readonly byte[] CRLF;

		internal static ConfiguredTaskAwaitable SupressContext(this Task task)
		{
			throw null;
		}

		internal static ConfiguredTaskAwaitable<T> SupressContext<T>(this Task<T> task)
		{
			throw null;
		}

		internal static IAsyncResult ToIAsyncResult(this Task task, AsyncCallback callback, object state)
		{
			throw null;
		}

		internal static ArraySegment<byte> GetChunkHeader(long size)
		{
			throw null;
		}

		/// <summary>
		/// A private utility routine to convert an integer to a chunk header,
		/// which is an ASCII hex number followed by a CRLF.The header is returned
		/// as a byte array.
		/// Generates a right-aligned hex string and returns the start offset.
		/// </summary>
		/// <param name="size">Chunk size to be encoded</param>
		/// <returns>A byte array with the header in int.</returns>
		internal static ArraySegment<byte> GetChunkHeader(int size)
		{
			throw null;
		}
	}
}
