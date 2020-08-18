using Nerdbank.Streams;
using System;
using System.Runtime.CompilerServices;

namespace MessagePack
{
	/// <summary>
	/// A thread-safe, alloc-free reusable object pool.
	/// </summary>
	internal class SequencePool
	{
		internal struct Rental : IDisposable
		{
			private readonly SequencePool owner;

			/// <summary>
			/// Gets the recyclable object.
			/// </summary>
			public Sequence<byte> Value
			{
				[CompilerGenerated]
				readonly get
				{
					throw null;
				}
			}

			internal Rental(SequencePool owner, Sequence<byte> value)
			{
				throw null;
			}

			/// <summary>
			/// Returns the recyclable object to the pool.
			/// </summary>
			/// <remarks>
			/// The instance is cleaned first, if a clean delegate was provided.
			/// It is dropped instead of being returned to the pool if the pool is already at its maximum size.
			/// </remarks>
			public void Dispose()
			{
				throw null;
			}
		}

		/// <summary>
		/// A thread-safe pool of reusable <see cref="T:Nerdbank.Streams.Sequence`1" /> objects.
		/// </summary>
		/// <remarks>
		/// We use a <see cref="F:MessagePack.SequencePool.maxSize" /> that allows every processor to be involved in messagepack serialization concurrently,
		/// plus one nested serialization per processor (since LZ4 and sometimes other nested serializations may exist).
		/// </remarks>
		internal static readonly SequencePool Shared;

		/// <summary>
		/// Initializes a new instance of the <see cref="T:MessagePack.SequencePool" /> class.
		/// </summary>
		/// <param name="maxSize">The maximum size to allow the pool to grow.</param>
		internal SequencePool(int maxSize)
		{
			throw null;
		}

		/// <summary>
		/// Gets an instance of <see cref="T:Nerdbank.Streams.Sequence`1" />
		/// This is taken from the recycled pool if one is available; otherwise a new one is created.
		/// </summary>
		/// <returns>The rental tracker that provides access to the object as well as a means to return it.</returns>
		internal Rental Rent()
		{
			throw null;
		}
	}
}
