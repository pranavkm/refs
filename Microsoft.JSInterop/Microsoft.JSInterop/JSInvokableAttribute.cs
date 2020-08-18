using System;
using System.Runtime.CompilerServices;

namespace Microsoft.JSInterop
{
	/// <summary>
	/// Identifies a .NET method as allowing invocation from JavaScript code.
	/// Any method marked with this attribute may receive arbitrary parameter values
	/// from untrusted callers. All inputs should be validated carefully.
	/// </summary>
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
	public sealed class JSInvokableAttribute : Attribute
	{
		/// <summary>
		/// Gets the identifier for the method. The identifier must be unique within the scope
		/// of an assembly.
		///
		/// If not set, the identifier is taken from the name of the method. In this case the
		/// method name must be unique within the assembly.
		/// </summary>
		public string? Identifier
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Constructs an instance of <see cref="T:Microsoft.JSInterop.JSInvokableAttribute" /> without setting
		/// an identifier for the method.
		/// </summary>
		public JSInvokableAttribute()
		{
			throw null;
		}

		/// <summary>
		/// Constructs an instance of <see cref="T:Microsoft.JSInterop.JSInvokableAttribute" /> using the specified
		/// identifier.
		/// </summary>
		/// <param name="identifier">An identifier for the method, which must be unique within the scope of the assembly.</param>
		[System.Runtime.CompilerServices.NullableContext(1)]
		public JSInvokableAttribute(string identifier)
		{
			throw null;
		}
	}
}
