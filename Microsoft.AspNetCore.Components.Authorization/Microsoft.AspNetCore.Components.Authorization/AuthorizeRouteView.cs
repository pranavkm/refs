using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Components.Rendering;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Components.Authorization
{
	/// <summary>
	/// Combines the behaviors of <see cref="T:Microsoft.AspNetCore.Components.Authorization.AuthorizeView" /> and <see cref="T:Microsoft.AspNetCore.Components.RouteView" />,
	/// so that it displays the page matching the specified route but only if the user
	/// is authorized to see it.
	///
	/// Additionally, this component supplies a cascading parameter of type <see cref="T:System.Threading.Tasks.Task`1" />,
	/// which makes the user's current authentication state available to descendants.
	/// </summary>
	public sealed class AuthorizeRouteView : RouteView
	{
		private class AuthorizeRouteViewCore : AuthorizeViewCore
		{
			[Parameter]
			public RouteData RouteData
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

			protected override IAuthorizeData[] GetAuthorizeData()
			{
				throw null;
			}

			public AuthorizeRouteViewCore()
			{
				throw null;
			}
		}

		/// <summary>
		/// The content that will be displayed if the user is not authorized.
		/// </summary>
		[Parameter]
		public RenderFragment<AuthenticationState> NotAuthorized
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
		/// The content that will be displayed while asynchronous authorization is in progress.
		/// </summary>
		[Parameter]
		public RenderFragment Authorizing
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
		/// The resource to which access is being controlled.
		/// </summary>
		[Parameter]
		public object Resource
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

		public AuthorizeRouteView()
		{
			throw null;
		}

		/// <inheritdoc />
		protected override void Render(RenderTreeBuilder builder)
		{
			throw null;
		}
	}
}
