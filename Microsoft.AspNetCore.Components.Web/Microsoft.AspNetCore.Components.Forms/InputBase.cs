using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Components.Forms
{
	/// <summary>
	/// A base class for form input components. This base class automatically
	/// integrates with an <see cref="T:Microsoft.AspNetCore.Components.Forms.EditContext" />, which must be supplied
	/// as a cascading parameter.
	/// </summary>
	public abstract class InputBase<TValue> : ComponentBase, IDisposable
	{
		/// <summary>
		/// Gets or sets a collection of additional attributes that will be applied to the created element.
		/// </summary>
		[Parameter(CaptureUnmatchedValues = true)]
		public IReadOnlyDictionary<string, object>? AdditionalAttributes
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
		/// Gets or sets the value of the input. This should be used with two-way binding.
		/// </summary>
		/// <example>
		/// @bind-Value="model.PropertyName"
		/// </example>
		[Parameter]
		public TValue Value
		{
			[CompilerGenerated]
			[return: MaybeNull]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[param: AllowNull]
			set
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets or sets a callback that updates the bound value.
		/// </summary>
		[Parameter]
		public EventCallback<TValue> ValueChanged
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
		/// Gets or sets an expression that identifies the bound value.
		/// </summary>
		[Parameter]
		public Expression<Func<TValue>>? ValueExpression
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
		/// Gets or sets the display name for this field.
		/// <para>This value is used when generating error messages when the input value fails to parse correctly.</para>
		/// </summary>
		[Parameter]
		public string? DisplayName
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
		/// Gets the associated <see cref="T:Microsoft.AspNetCore.Components.Forms.EditContext" />.
		/// </summary>
		protected EditContext EditContext
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
		/// Gets the <see cref="P:Microsoft.AspNetCore.Components.Forms.InputBase`1.FieldIdentifier" /> for the bound value.
		/// </summary>
		protected internal FieldIdentifier FieldIdentifier
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
		/// Gets or sets the current value of the input.
		/// </summary>
		protected TValue CurrentValue
		{
			[return: MaybeNull]
			get
			{
				throw null;
			}
			[param: AllowNull]
			set
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets or sets the current value of the input, represented as a string.
		/// </summary>
		protected string? CurrentValueAsString
		{
			[System.Runtime.CompilerServices.NullableContext(2)]
			get
			{
				throw null;
			}
			[System.Runtime.CompilerServices.NullableContext(2)]
			set
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets a CSS class string that combines the <c>class</c> attribute and <see cref="P:Microsoft.AspNetCore.Components.Forms.InputBase`1.FieldClass" />
		/// properties. Derived components should typically use this value for the primary HTML element's
		/// 'class' attribute.
		/// </summary>
		protected string CssClass
		{
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Constructs an instance of <see cref="T:Microsoft.AspNetCore.Components.Forms.InputBase`1" />.
		/// </summary>
		protected InputBase()
		{
			throw null;
		}

		/// <summary>
		/// Formats the value as a string. Derived classes can override this to determine the formating used for <see cref="P:Microsoft.AspNetCore.Components.Forms.InputBase`1.CurrentValueAsString" />.
		/// </summary>
		/// <param name="value">The value to format.</param>
		/// <returns>A string representation of the value.</returns>
		protected virtual string? FormatValueAsString([AllowNull] TValue value)
		{
			throw null;
		}

		/// <summary>
		/// Parses a string to create an instance of <typeparamref name="TValue" />. Derived classes can override this to change how
		/// <see cref="P:Microsoft.AspNetCore.Components.Forms.InputBase`1.CurrentValueAsString" /> interprets incoming values.
		/// </summary>
		/// <param name="value">The string value to be parsed.</param>
		/// <param name="result">An instance of <typeparamref name="TValue" />.</param>
		/// <param name="validationErrorMessage">If the value could not be parsed, provides a validation error message.</param>
		/// <returns>True if the value could be parsed; otherwise false.</returns>
		protected abstract bool TryParseValueFromString(string? value, [MaybeNull] out TValue result, [NotNullWhen(false)] out string? validationErrorMessage);

		/// <inheritdoc />
		public override Task SetParametersAsync(ParameterView parameters)
		{
			throw null;
		}

		protected virtual void Dispose(bool disposing)
		{
			throw null;
		}

		void IDisposable.Dispose()
		{
			throw null;
		}
	}
}
