using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;

namespace Microsoft.AspNetCore.Routing.Matching
{
	/// <summary>
	/// A comparer that can order <see cref="T:Microsoft.AspNetCore.Http.Endpoint" /> instances based on implementations of
	/// <see cref="T:Microsoft.AspNetCore.Routing.Matching.IEndpointComparerPolicy" />. The implementation can be retrieved from the service
	/// provider and provided to <see cref="M:Microsoft.AspNetCore.Routing.Matching.CandidateSet.ExpandEndpoint(System.Int32,System.Collections.Generic.IReadOnlyList{Microsoft.AspNetCore.Http.Endpoint},System.Collections.Generic.IComparer{Microsoft.AspNetCore.Http.Endpoint})" />.
	/// </summary>
	public sealed class EndpointMetadataComparer : IComparer<Endpoint>
	{
		internal EndpointMetadataComparer(IServiceProvider services)
		{
			throw null;
		}

		int IComparer<Endpoint>.Compare(Endpoint? x, Endpoint? y)
		{
			throw null;
		}
	}
	/// <summary>
	/// A base class for <see cref="T:System.Collections.Generic.IComparer`1" /> implementations that use
	/// a specific type of metadata from <see cref="P:Microsoft.AspNetCore.Http.Endpoint.Metadata" /> for comparison.
	/// Useful for implementing <see cref="P:Microsoft.AspNetCore.Routing.Matching.IEndpointComparerPolicy.Comparer" />.
	/// </summary>
	/// <typeparam name="TMetadata">
	/// The type of metadata to compare. Typically this is a type of metadata related
	/// to the application concern being handled.
	/// </typeparam>
	public abstract class EndpointMetadataComparer<TMetadata> : IComparer<Endpoint> where TMetadata : class
	{
		private class DefaultComparer<T> : EndpointMetadataComparer<T> where T : class
		{
			public DefaultComparer()
			{
				throw null;
			}
		}

		public static readonly EndpointMetadataComparer<TMetadata> Default;

		/// <summary>
		/// Compares two objects and returns a value indicating whether one is less than, equal to,
		/// or greater than the other.
		/// </summary>
		/// <param name="x">The first object to compare.</param>
		/// <param name="y">The second object to compare.</param>
		/// <returns>
		/// An implementation of this method must return a value less than zero if
		/// x is less than y, zero if x is equal to y, or a value greater than zero if x is
		/// greater than y.
		/// </returns>
		public int Compare(Endpoint? x, Endpoint? y)
		{
			throw null;
		}

		/// <summary>
		/// Gets the metadata of type <typeparamref name="TMetadata" /> from the provided endpoint.
		/// </summary>
		/// <param name="endpoint">The <see cref="T:Microsoft.AspNetCore.Http.Endpoint" />.</param>
		/// <returns>The <typeparamref name="TMetadata" /> instance or <c>null</c>.</returns>
		protected virtual TMetadata? GetMetadata(Endpoint endpoint)
		{
			throw null;
		}

		/// <summary>
		/// Compares two <typeparamref name="TMetadata" /> instances.
		/// </summary>
		/// <param name="x">The first object to compare.</param>
		/// <param name="y">The second object to compare.</param>
		/// <returns>
		/// An implementation of this method must return a value less than zero if
		/// x is less than y, zero if x is equal to y, or a value greater than zero if x is
		/// greater than y.
		/// </returns>
		/// <remarks>
		/// The base-class implementation of this method will compare metadata based on whether
		/// or not they are <c>null</c>. The effect of this is that when endpoints are being
		/// compared, the endpoint that defines an instance of <typeparamref name="TMetadata" />
		/// will be considered higher priority.
		/// </remarks>
		protected virtual int CompareMetadata(TMetadata? x, TMetadata? y)
		{
			throw null;
		}

		protected EndpointMetadataComparer()
		{
			throw null;
		}
	}
}
