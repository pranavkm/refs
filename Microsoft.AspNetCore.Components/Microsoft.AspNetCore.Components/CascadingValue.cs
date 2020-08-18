using Microsoft.AspNetCore.Components.Rendering;
using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Components
{
	/// <summary>
	/// A component that provides a cascading value to all descendant components.
	/// </summary>
	public class CascadingValue<TValue> : ICascadingValueComponent, IComponent
	{
		/// <summary>
		/// The content to which the value should be provided.
		/// </summary>
		[Parameter]
		public RenderFragment ChildContent
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
		/// The value to be provided.
		/// </summary>
		[Parameter]
		public TValue Value
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
		/// Optionally gives a name to the provided value. Descendant components
		/// will be able to receive the value by specifying this name.
		///
		/// If no name is specified, then descendant components will receive the
		/// value based the type of value they are requesting.
		/// </summary>
		[Parameter]
		public string? Name
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
		/// If true, indicates that <see cref="P:Microsoft.AspNetCore.Components.CascadingValue`1.Value" /> will not change. This is a
		/// performance optimization that allows the framework to skip setting up
		/// change notifications. Set this flag only if you will not change
		/// <see cref="P:Microsoft.AspNetCore.Components.CascadingValue`1.Value" /> during the component's lifetime.
		/// </summary>
		[Parameter]
		public bool IsFixed
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

		object ICascadingValueComponent.CurrentValue
		{
			get
			{
				throw null;
			}
		}

		bool ICascadingValueComponent.CurrentValueIsFixed
		{
			get
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
		public Task SetParametersAsync(ParameterView parameters)
		{
			throw null;
		}

		bool ICascadingValueComponent.CanSupplyValue(Type requestedType, string requestedName)
		{
			throw null;
		}

		void ICascadingValueComponent.Subscribe(ComponentState subscriber)
		{
			throw null;
		}

		void ICascadingValueComponent.Unsubscribe(ComponentState subscriber)
		{
			throw null;
		}

		public CascadingValue()
		{
			throw null;
		}
	}
}
