using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Routing.Tree
{
	/// <summary>
	/// A tree part of a <see cref="T:Microsoft.AspNetCore.Routing.Tree.TreeRouter" />.
	/// </summary>
	public class UrlMatchingTree
	{
		/// <summary>
		/// Gets the order of the routes associated with this <see cref="T:Microsoft.AspNetCore.Routing.Tree.UrlMatchingTree" />.
		/// </summary>
		public int Order
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets the root of the <see cref="T:Microsoft.AspNetCore.Routing.Tree.UrlMatchingTree" />.
		/// </summary>
		public UrlMatchingNode Root
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Initializes a new instance of <see cref="T:Microsoft.AspNetCore.Routing.Tree.UrlMatchingTree" />.
		/// </summary>
		/// <param name="order">The order associated with routes in this <see cref="T:Microsoft.AspNetCore.Routing.Tree.UrlMatchingTree" />.</param>
		public UrlMatchingTree(int order)
		{
			throw null;
		}

		internal void AddEntry(InboundRouteEntry entry)
		{
			throw null;
		}
	}
}
