using Microsoft.AspNetCore.Components.Rendering;
using System;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Components
{
	internal interface ICascadingValueComponent
	{
		object? CurrentValue
		{
			[System.Runtime.CompilerServices.NullableContext(2)]
			get;
		}

		bool CurrentValueIsFixed
		{
			get;
		}

		bool CanSupplyValue(Type valueType, string? valueName);

		void Subscribe(ComponentState subscriber);

		void Unsubscribe(ComponentState subscriber);
	}
}
