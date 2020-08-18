using System.Diagnostics.CodeAnalysis;

namespace Microsoft.AspNetCore.Http.Features
{
	public struct FeatureReference<T>
	{
		private T _feature;

		private int _revision;

		public static readonly FeatureReference<T> Default;

		[return: MaybeNull]
		public T Fetch(IFeatureCollection features)
		{
			throw null;
		}

		public T Update(IFeatureCollection features, T feature)
		{
			throw null;
		}
	}
}
