using Microsoft.AspNetCore.Http.Features;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Server.HttpSys
{
	internal sealed class StandardFeatureCollection : IFeatureCollection, IEnumerable<KeyValuePair<Type, object>>, IEnumerable
	{
		public bool IsReadOnly
		{
			get
			{
				throw null;
			}
		}

		public int Revision
		{
			get
			{
				throw null;
			}
		}

		public object this[Type key]
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

		public StandardFeatureCollection(FeatureContext featureContext)
		{
			throw null;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			throw null;
		}

		[IteratorStateMachine(typeof(_003CSystem_002DCollections_002DGeneric_002DIEnumerable_003CSystem_002DCollections_002DGeneric_002DKeyValuePair_003CSystem_002DType_005C))]
		IEnumerator<KeyValuePair<Type, object>> IEnumerable<KeyValuePair<Type, object>>.GetEnumerator()
		{
			throw null;
		}

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
