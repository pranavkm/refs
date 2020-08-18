using Microsoft.Extensions.Internal;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Routing
{
	/// <summary>
	/// An <see cref="T:System.Collections.Generic.IDictionary`2" /> type for route values.
	/// </summary>
	public class RouteValueDictionary : IDictionary<string, object?>, ICollection<KeyValuePair<string, object?>>, IEnumerable<KeyValuePair<string, object?>>, IEnumerable, IReadOnlyDictionary<string, object?>, IReadOnlyCollection<KeyValuePair<string, object?>>
	{
		public struct Enumerator : IEnumerator<KeyValuePair<string, object?>>, IEnumerator, IDisposable
		{
			private readonly RouteValueDictionary _dictionary;

			private int _index;

			public KeyValuePair<string, object?> Current
			{
				[CompilerGenerated]
				readonly get
				{
					throw null;
				}
			}

			object IEnumerator.Current
			{
				get
				{
					throw null;
				}
			}

			public Enumerator(RouteValueDictionary dictionary)
			{
				throw null;
			}

			public void Dispose()
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public bool MoveNext()
			{
				throw null;
			}

			public void Reset()
			{
				throw null;
			}
		}

		internal class PropertyStorage
		{
			public readonly object Value;

			public readonly PropertyHelper[] Properties;

			public PropertyStorage(object value)
			{
				throw null;
			}
		}

		internal KeyValuePair<string, object?>[] _arrayStorage;

		internal PropertyStorage? _propertyStorage;

		/// <inheritdoc />
		public object? this[string key]
		{
			get
			{
				throw null;
			}
			set
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets the comparer for this dictionary.
		/// </summary>
		/// <remarks>
		/// This will always be a reference to <see cref="P:System.StringComparer.OrdinalIgnoreCase" />
		/// </remarks>
		public IEqualityComparer<string> Comparer
		{
			get
			{
				throw null;
			}
		}

		/// <inheritdoc />
		public int Count
		{
			get
			{
				throw null;
			}
		}

		/// <inheritdoc />
		bool ICollection<KeyValuePair<string, object>>.IsReadOnly
		{
			get
			{
				throw null;
			}
		}

		/// <inheritdoc />
		public ICollection<string> Keys
		{
			get
			{
				throw null;
			}
		}

		IEnumerable<string> IReadOnlyDictionary<string, object>.Keys
		{
			get
			{
				throw null;
			}
		}

		/// <inheritdoc />
		public ICollection<object?> Values
		{
			get
			{
				throw null;
			}
		}

		IEnumerable<object?> IReadOnlyDictionary<string, object>.Values
		{
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Creates a new <see cref="T:Microsoft.AspNetCore.Routing.RouteValueDictionary" /> from the provided array.
		/// The new instance will take ownership of the array, and may mutate it.
		/// </summary>
		/// <param name="items">The items array.</param>
		/// <returns>A new <see cref="T:Microsoft.AspNetCore.Routing.RouteValueDictionary" />.</returns>
		public static RouteValueDictionary FromArray(KeyValuePair<string, object?>[] items)
		{
			throw null;
		}

		/// <summary>
		/// Creates an empty <see cref="T:Microsoft.AspNetCore.Routing.RouteValueDictionary" />.
		/// </summary>
		public RouteValueDictionary()
		{
			throw null;
		}

		/// <summary>
		/// Creates a <see cref="T:Microsoft.AspNetCore.Routing.RouteValueDictionary" /> initialized with the specified <paramref name="values" />.
		/// </summary>
		/// <param name="values">An object to initialize the dictionary. The value can be of type
		/// <see cref="T:System.Collections.Generic.IDictionary`2" /> or <see cref="T:System.Collections.Generic.IReadOnlyDictionary`2" />
		/// or an object with public properties as key-value pairs.
		/// </param>
		/// <remarks>
		/// If the value is a dictionary or other <see cref="T:System.Collections.Generic.IEnumerable`1" /> of <see cref="T:System.Collections.Generic.KeyValuePair`2" />,
		/// then its entries are copied. Otherwise the object is interpreted as a set of key-value pairs where the
		/// property names are keys, and property values are the values, and copied into the dictionary.
		/// Only public instance non-index properties are considered.
		/// </remarks>
		[System.Runtime.CompilerServices.NullableContext(2)]
		public RouteValueDictionary(object? values)
		{
			throw null;
		}

		/// <inheritdoc />
		void ICollection<KeyValuePair<string, object>>.Add(KeyValuePair<string, object?> item)
		{
			throw null;
		}

		/// <inheritdoc />
		public void Add(string key, object? value)
		{
			throw null;
		}

		/// <inheritdoc />
		public void Clear()
		{
			throw null;
		}

		/// <inheritdoc />
		bool ICollection<KeyValuePair<string, object>>.Contains(KeyValuePair<string, object?> item)
		{
			throw null;
		}

		/// <inheritdoc />
		public bool ContainsKey(string key)
		{
			throw null;
		}

		/// <inheritdoc />
		void ICollection<KeyValuePair<string, object>>.CopyTo(KeyValuePair<string, object?>[] array, int arrayIndex)
		{
			throw null;
		}

		/// <inheritdoc />
		public Enumerator GetEnumerator()
		{
			throw null;
		}

		/// <inheritdoc />
		IEnumerator<KeyValuePair<string, object?>> IEnumerable<KeyValuePair<string, object>>.GetEnumerator()
		{
			throw null;
		}

		/// <inheritdoc />
		IEnumerator IEnumerable.GetEnumerator()
		{
			throw null;
		}

		/// <inheritdoc />
		bool ICollection<KeyValuePair<string, object>>.Remove(KeyValuePair<string, object?> item)
		{
			throw null;
		}

		/// <inheritdoc />
		public bool Remove(string key)
		{
			throw null;
		}

		/// <summary>
		/// Attempts to remove and return the value that has the specified key from the <see cref="T:Microsoft.AspNetCore.Routing.RouteValueDictionary" />.
		/// </summary>
		/// <param name="key">The key of the element to remove and return.</param>
		/// <param name="value">When this method returns, contains the object removed from the <see cref="T:Microsoft.AspNetCore.Routing.RouteValueDictionary" />, or <c>null</c> if key does not exist.</param>
		/// <returns>
		/// <c>true</c> if the object was removed successfully; otherwise, <c>false</c>.
		/// </returns>
		public bool Remove(string key, out object? value)
		{
			throw null;
		}

		/// <summary>
		/// Attempts to the add the provided <paramref name="key" /> and <paramref name="value" /> to the dictionary.
		/// </summary>
		/// <param name="key">The key.</param>
		/// <param name="value">The value.</param>
		/// <returns>Returns <c>true</c> if the value was added. Returns <c>false</c> if the key was already present.</returns>
		public bool TryAdd(string key, object value)
		{
			throw null;
		}

		/// <inheritdoc />
		public bool TryGetValue(string key, out object? value)
		{
			throw null;
		}
	}
}
