using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Http.Features
{
	public class FeatureCollection : IFeatureCollection, IEnumerable<KeyValuePair<Type, object>>, IEnumerable
	{
		private class KeyComparer : IEqualityComparer<KeyValuePair<Type, object>>
		{
			public bool Equals(KeyValuePair<Type, object> x, KeyValuePair<Type, object> y)
			{
				throw null;
			}

			public int GetHashCode(KeyValuePair<Type, object> obj)
			{
				throw null;
			}

			public KeyComparer()
			{
				throw null;
			}
		}

		public virtual int Revision
		{
			get
			{
				throw null;
			}
		}

		public bool IsReadOnly
		{
			get
			{
				throw null;
			}
		}

		public object? this[Type key]
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

		public FeatureCollection()
		{
			throw null;
		}

		public FeatureCollection(IFeatureCollection defaults)
		{
			throw null;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			throw null;
		}

		[IteratorStateMachine(typeof(_003CGetEnumerator_003Ed__14))]
		public IEnumerator<KeyValuePair<Type, object>> GetEnumerator()
		{
			throw null;
		}

		[return: MaybeNull]
		public TFeature Get<TFeature>()
		{
			throw null;
		}

		public void Set<TFeature>(TFeature instance)
		{
			throw null;
		}
	}
}
