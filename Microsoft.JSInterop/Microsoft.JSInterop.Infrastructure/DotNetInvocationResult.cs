using System;
using System.Runtime.CompilerServices;

namespace Microsoft.JSInterop.Infrastructure
{
	/// <summary>
	/// Result of a .NET invocation that is returned to JavaScript.
	/// </summary>
	public readonly struct DotNetInvocationResult
	{
		/// <summary>
		/// Gets the <see cref="T:System.Exception" /> that caused the failure.
		/// </summary>
		public Exception? Exception
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets the error kind.
		/// </summary>
		public string? ErrorKind
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets the result of a successful invocation.
		/// </summary>
		public object? Result
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// <see langword="true" /> if the invocation succeeded, otherwise <see langword="false" />.
		/// </summary>
		public bool Success
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Constructor for a failed invocation.
		/// </summary>
		/// <param name="exception">The <see cref="T:System.Exception" /> that caused the failure.</param>
		/// <param name="errorKind">The error kind.</param>
		[System.Runtime.CompilerServices.NullableContext(1)]
		public DotNetInvocationResult(Exception exception, string? errorKind)
		{
			throw null;
		}

		/// <summary>
		/// Constructor for a successful invocation.
		/// </summary>
		/// <param name="result">The result.</param>
		public DotNetInvocationResult(object? result)
		{
			throw null;
		}
	}
}
