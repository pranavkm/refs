using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Components
{
	/// <summary>
	/// Optional base class for components that represent a layout.
	/// Alternatively, components may implement <see cref="T:Microsoft.AspNetCore.Components.IComponent" /> directly
	/// and declare their own parameter named <see cref="P:Microsoft.AspNetCore.Components.LayoutComponentBase.Body" />.
	/// </summary>
	public abstract class LayoutComponentBase : ComponentBase
	{
		internal const string BodyPropertyName = "Body";

		/// <summary>
		/// Gets the content to be rendered inside the layout.
		/// </summary>
		[Parameter]
		public RenderFragment? Body
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

		protected LayoutComponentBase()
		{
			throw null;
		}
	}
}
