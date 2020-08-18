using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Components.Routing
{
	/// <summary>
	/// A component that supplies route data corresponding to the current navigation state.
	/// </summary>
	public class Router : IComponent, IHandleAfterRender, IDisposable
	{
		private static class Log
		{
			internal static void DisplayingNotFound(ILogger logger, string path, string baseUri)
			{
				throw null;
			}

			internal static void NavigatingToComponent(ILogger logger, Type componentType, string path, string baseUri)
			{
				throw null;
			}

			internal static void NavigatingToExternalUri(ILogger logger, string externalUri, string path, string baseUri)
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets or sets the assembly that should be searched for components matching the URI.
		/// </summary>
		[Parameter]
		public Assembly AppAssembly
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
		/// Gets or sets a collection of additional assemblies that should be searched for components
		/// that can match URIs.
		/// </summary>
		[Parameter]
		public IEnumerable<Assembly> AdditionalAssemblies
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
		/// Gets or sets the content to display when no match is found for the requested route.
		/// </summary>
		[Parameter]
		public RenderFragment NotFound
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
		/// Gets or sets the content to display when a match is found for the requested route.
		/// </summary>
		[Parameter]
		public RenderFragment<RouteData> Found
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
		/// Get or sets the content to display when asynchronous navigation is in progress.
		/// </summary>
		[Parameter]
		public RenderFragment? Navigating
		{
			[System.Runtime.CompilerServices.NullableContext(2)]
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[System.Runtime.CompilerServices.NullableContext(2)]
			[CompilerGenerated]
			set
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets or sets a handler that should be called before navigating to a new page.
		/// </summary>
		[Parameter]
		public Func<NavigationContext, Task>? OnNavigateAsync
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
		public void Attach(RenderHandle renderHandle)
		{
			throw null;
		}

		/// <inheritdoc />
		[AsyncStateMachine(typeof(_003CSetParametersAsync_003Ed__52))]
		[DebuggerStepThrough]
		public Task SetParametersAsync(ParameterView parameters)
		{
			throw null;
		}

		/// <inheritdoc />
		public void Dispose()
		{
			throw null;
		}

		internal virtual void Refresh(bool isNavigationIntercepted)
		{
			throw null;
		}

		[AsyncStateMachine(typeof(_003CRunOnNavigateWithRefreshAsync_003Ed__58))]
		[DebuggerStepThrough]
		internal Task RunOnNavigateWithRefreshAsync(string path, bool isNavigationIntercepted)
		{
			throw null;
		}

		Task IHandleAfterRender.OnAfterRenderAsync()
		{
			throw null;
		}

		public Router()
		{
			throw null;
		}
	}
}
