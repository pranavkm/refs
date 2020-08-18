using Microsoft.AspNetCore.Components.Rendering;
using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Components
{
	/// <summary>
	/// Displays the specified page component, rendering it inside its layout
	/// and any further nested layouts.
	/// </summary>
	public class RouteView : IComponent
	{
		/// <summary>
		/// Gets or sets the route data. This determines the page that will be
		/// displayed and the parameter values that will be supplied to the page.
		/// </summary>
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

		/// <summary>
		/// Gets or sets the type of a layout to be used if the page does not
		/// declare any layout. If specified, the type must implement <see cref="T:Microsoft.AspNetCore.Components.IComponent" />
		/// and accept a parameter named <see cref="P:Microsoft.AspNetCore.Components.LayoutComponentBase.Body" />.
		/// </summary>
		[Parameter]
		public Type DefaultLayout
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

		public RouteView()
		{
			throw null;
		}

		/// <inheritdoc />
		public void Attach(RenderHandle renderHandle)
		{
			throw null;
		}

		/// <inheritdoc />
		public Task SetParametersAsync(ParameterView parameters)
		{
			throw null;
		}

		/// <summary>
		/// Renders the component.
		/// </summary>
		/// <param name="builder">The <see cref="T:Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder" />.</param>
		protected virtual void Render(RenderTreeBuilder builder)
		{
			throw null;
		}
	}
}
