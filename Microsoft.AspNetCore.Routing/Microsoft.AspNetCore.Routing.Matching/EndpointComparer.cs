using Microsoft.AspNetCore.Http;
using System.Collections.Generic;

namespace Microsoft.AspNetCore.Routing.Matching
{
	internal class EndpointComparer : IComparer<Endpoint>, IEqualityComparer<Endpoint>
	{
		private class OrderComparer : IComparer<Endpoint>
		{
			public static readonly IComparer<Endpoint> Instance;

			public int Compare(Endpoint? x, Endpoint? y)
			{
				throw null;
			}

			public OrderComparer()
			{
				throw null;
			}
		}

		private class PrecedenceComparer : IComparer<Endpoint>
		{
			public static readonly IComparer<Endpoint> Instance;

			public int Compare(Endpoint? x, Endpoint? y)
			{
				throw null;
			}

			public PrecedenceComparer()
			{
				throw null;
			}
		}

		public EndpointComparer(IEndpointComparerPolicy[] policies)
		{
			throw null;
		}

		public int Compare(Endpoint? x, Endpoint? y)
		{
			throw null;
		}

		public bool Equals(Endpoint? x, Endpoint? y)
		{
			throw null;
		}

		public int GetHashCode(Endpoint obj)
		{
			throw null;
		}
	}
}
