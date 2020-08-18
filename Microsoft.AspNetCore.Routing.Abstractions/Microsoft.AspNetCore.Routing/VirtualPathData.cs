using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Routing
{
	/// <summary>
	/// Represents information about the route and virtual path that are the result of
	/// generating a URL with the ASP.NET routing middleware.
	/// </summary>
	public class VirtualPathData
	{
		/// <summary>
		/// Gets the collection of custom values for the <see cref="P:Microsoft.AspNetCore.Routing.VirtualPathData.Router" />.
		/// </summary>
		public RouteValueDictionary DataTokens
		{
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets or sets the <see cref="T:Microsoft.AspNetCore.Routing.IRouter" /> that was used to generate the URL.
		/// </summary>
		public IRouter Router
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			set
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets or sets the URL that was generated from the <see cref="P:Microsoft.AspNetCore.Routing.VirtualPathData.Router" />.
		/// </summary>
		public string VirtualPath
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
		///  Initializes a new instance of the <see cref="T:Microsoft.AspNetCore.Routing.VirtualPathData" /> class.
		/// </summary>
		/// <param name="router">The object that is used to generate the URL.</param>
		/// <param name="virtualPath">The generated URL.</param>
		public VirtualPathData(IRouter router, string virtualPath)
		{
			throw null;
		}

		/// <summary>
		///  Initializes a new instance of the <see cref="T:Microsoft.AspNetCore.Routing.VirtualPathData" /> class.
		/// </summary>
		/// <param name="router">The object that is used to generate the URL.</param>
		/// <param name="virtualPath">The generated URL.</param>
		/// <param name="dataTokens">The collection of custom values.</param>
		public VirtualPathData(IRouter router, string virtualPath, RouteValueDictionary dataTokens)
		{
			throw null;
		}
	}
}
