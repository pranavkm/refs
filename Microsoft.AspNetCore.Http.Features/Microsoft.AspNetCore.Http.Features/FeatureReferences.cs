using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Http.Features
{
	public struct FeatureReferences<TCache>
	{
		[AllowNull]
		[MaybeNull]
		public TCache Cache;

		public IFeatureCollection Collection
		{
			[CompilerGenerated]
			readonly get
			{
				throw null;
			}
		}

		public int Revision
		{
			[CompilerGenerated]
			readonly get
			{
				throw null;
			}
		}

		public FeatureReferences(IFeatureCollection collection)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void Initalize(IFeatureCollection collection)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void Initalize(IFeatureCollection collection, int revision)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public TFeature Fetch<TFeature, TState>([AllowNull] [MaybeNull] ref TFeature cached, TState state, Func<TState, TFeature> factory) where TFeature : class?
		{
			throw null;
		}

		public TFeature Fetch<TFeature>([AllowNull] [MaybeNull] ref TFeature cached, Func<IFeatureCollection, TFeature> factory) where TFeature : class?
		{
			throw null;
		}
	}
}
