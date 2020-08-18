using Microsoft.JSInterop.Infrastructure;
using System;
using System.Runtime.CompilerServices;

namespace Microsoft.JSInterop
{
	/// <summary>
	/// Provides convenience methods to produce a <see cref="T:Microsoft.JSInterop.DotNetObjectReference`1" />.
	/// </summary>
	public static class DotNetObjectReference
	{
		/// <summary>
		/// Creates a new instance of <see cref="T:Microsoft.JSInterop.DotNetObjectReference`1" />.
		/// </summary>
		/// <param name="value">The reference type to track.</param>
		/// <returns>An instance of <see cref="T:Microsoft.JSInterop.DotNetObjectReference`1" />.</returns>
		public static DotNetObjectReference<TValue> Create<TValue>(TValue value) where TValue : class
		{
			throw null;
		}
	}
	/// <summary>
	/// Wraps a JS interop argument, indicating that the value should not be serialized as JSON
	/// but instead should be passed as a reference.
	///
	/// To avoid leaking memory, the reference must later be disposed by JS code or by .NET code.
	/// </summary>
	/// <typeparam name="TValue">The type of the value to wrap.</typeparam>
	public sealed class DotNetObjectReference<TValue> : IDotNetObjectReference, IDisposable where TValue : class
	{
		/// <summary>
		/// Gets the object instance represented by this wrapper.
		/// </summary>
		public TValue Value
		{
			get
			{
				throw null;
			}
		}

		internal long ObjectId
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

		internal JSRuntime? JSRuntime
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

		object IDotNetObjectReference.Value
		{
			get
			{
				throw null;
			}
		}

		internal bool Disposed
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Initializes a new instance of <see cref="T:Microsoft.JSInterop.DotNetObjectReference`1" />.
		/// </summary>
		/// <param name="value">The value to pass by reference.</param>
		internal DotNetObjectReference(TValue value)
		{
			throw null;
		}

		/// <summary>
		/// Stops tracking this object reference, allowing it to be garbage collected
		/// (if there are no other references to it). Once the instance is disposed, it
		/// can no longer be used in interop calls from JavaScript code.
		/// </summary>
		public void Dispose()
		{
			throw null;
		}

		internal void ThrowIfDisposed()
		{
			throw null;
		}
	}
}
