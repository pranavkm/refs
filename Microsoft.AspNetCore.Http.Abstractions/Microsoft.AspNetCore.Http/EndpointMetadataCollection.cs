using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Http
{
	/// <summary>
	/// A collection of arbitrary metadata associated with an endpoint.
	/// </summary>
	/// <remarks>
	/// <see cref="T:Microsoft.AspNetCore.Http.EndpointMetadataCollection" /> instances contain a list of metadata items
	/// of arbitrary types. The metadata items are stored as an ordered collection with
	/// items arranged in ascending order of precedence.
	/// </remarks>
	public sealed class EndpointMetadataCollection : IReadOnlyList<object>, IEnumerable<object>, IEnumerable, IReadOnlyCollection<object>
	{
		/// <summary>
		/// Enumerates the elements of an <see cref="T:Microsoft.AspNetCore.Http.EndpointMetadataCollection" />.
		/// </summary>
		public struct Enumerator : IEnumerator<object?>, IEnumerator, IDisposable
		{
			private object[] _items;

			private int _index;

			/// <summary>
			/// Gets the element at the current position of the enumerator
			/// </summary>
			public object? Current
			{
				[CompilerGenerated]
				readonly get
				{
					throw null;
				}
			}

			[System.Runtime.CompilerServices.NullableContext(1)]
			internal Enumerator(EndpointMetadataCollection collection)
			{
				throw null;
			}

			/// <summary>
			/// Releases all resources used by the <see cref="T:Microsoft.AspNetCore.Http.EndpointMetadataCollection.Enumerator" />.
			/// </summary>
			public void Dispose()
			{
				throw null;
			}

			/// <summary>
			/// Advances the enumerator to the next element of the <see cref="T:Microsoft.AspNetCore.Http.EndpointMetadataCollection.Enumerator" />.
			/// </summary>
			/// <returns>
			/// <c>true</c> if the enumerator was successfully advanced to the next element;
			/// <c>false</c> if the enumerator has passed the end of the collection.
			/// </returns>
			public bool MoveNext()
			{
				throw null;
			}

			/// <summary>
			/// Sets the enumerator to its initial position, which is before the first element in the collection.
			/// </summary>
			public void Reset()
			{
				throw null;
			}
		}

		/// <summary>
		/// An empty <see cref="T:Microsoft.AspNetCore.Http.EndpointMetadataCollection" />.
		/// </summary>
		public static readonly EndpointMetadataCollection Empty;

		/// <summary>
		/// Gets the item at <paramref name="index" />.
		/// </summary>
		/// <param name="index">The index of the item to retrieve.</param>
		/// <returns>The item at <paramref name="index" />.</returns>
		public object this[int index]
		{
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets the count of metadata items.
		/// </summary>
		public int Count
		{
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Creates a new <see cref="T:Microsoft.AspNetCore.Http.EndpointMetadataCollection" />.
		/// </summary>
		/// <param name="items">The metadata items.</param>
		public EndpointMetadataCollection(IEnumerable<object> items)
		{
			throw null;
		}

		/// <summary>
		/// Creates a new <see cref="T:Microsoft.AspNetCore.Http.EndpointMetadataCollection" />.
		/// </summary>
		/// <param name="items">The metadata items.</param>
		public EndpointMetadataCollection(params object[] items)
		{
			throw null;
		}

		/// <summary>
		/// Gets the most significant metadata item of type <typeparamref name="T" />.
		/// </summary>
		/// <typeparam name="T">The type of metadata to retrieve.</typeparam>
		/// <returns>
		/// The most significant metadata of type <typeparamref name="T" /> or <c>null</c>.
		/// </returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public T? GetMetadata<T>() where T : class
		{
			throw null;
		}

		/// <summary>
		/// Gets the metadata items of type <typeparamref name="T" /> in ascending
		/// order of precedence.
		/// </summary>
		/// <typeparam name="T">The type of metadata.</typeparam>
		/// <returns>A sequence of metadata items of <typeparamref name="T" />.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public IReadOnlyList<T> GetOrderedMetadata<T>() where T : class
		{
			throw null;
		}

		/// <summary>
		/// Gets an <see cref="T:System.Collections.IEnumerator" /> of all metadata items.
		/// </summary>
		/// <returns>An <see cref="T:System.Collections.IEnumerator" /> of all metadata items.</returns>
		public Enumerator GetEnumerator()
		{
			throw null;
		}

		/// <summary>
		/// Gets an <see cref="T:System.Collections.Generic.IEnumerator`1" /> of all metadata items.
		/// </summary>
		/// <returns>An <see cref="T:System.Collections.Generic.IEnumerator`1" /> of all metadata items.</returns>
		IEnumerator<object> IEnumerable<object>.GetEnumerator()
		{
			throw null;
		}

		/// <summary>
		/// Gets an <see cref="T:System.Collections.IEnumerator" /> of all metadata items.
		/// </summary>
		/// <returns>An <see cref="T:System.Collections.IEnumerator" /> of all metadata items.</returns>
		IEnumerator IEnumerable.GetEnumerator()
		{
			throw null;
		}
	}
}
