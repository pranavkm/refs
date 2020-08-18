using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Components.Rendering;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Components.Authorization
{
	/// <summary>
	/// A base class for components that display differing content depending on the user's authorization status.
	/// </summary>
	public abstract class AuthorizeViewCore : ComponentBase
	{
		/// <summary>
		/// The content that will be displayed if the user is authorized.
		/// </summary>
		[Parameter]
		public RenderFragment<AuthenticationState> ChildContent
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
		/// The content that will be displayed if the user is authorized.
		/// If you specify a value for this parameter, do not also specify a value for <see cref="P:Microsoft.AspNetCore.Components.Authorization.AuthorizeViewCore.ChildContent" />.
		/// </summary>
		[Parameter]
		public RenderFragment<AuthenticationState> Authorized
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

		/// <inheritdoc />
		protected override void BuildRenderTree(RenderTreeBuilder builder)
		{
			throw null;
		}

		/// <inheritdoc />
		[AsyncStateMachine(typeof(_003COnParametersSetAsync_003Ed__35))]
		[DebuggerStepThrough]
		protected override Task OnParametersSetAsync()
		{
			throw null;
		}

		/// <summary>
		/// Gets the data required to apply authorization rules.
		/// </summary>
		protected abstract IAuthorizeData[] GetAuthorizeData();

		protected AuthorizeViewCore()
		{
			throw null;
		}
	}
}
