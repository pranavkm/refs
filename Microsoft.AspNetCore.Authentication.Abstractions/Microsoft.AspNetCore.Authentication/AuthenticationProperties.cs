using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Authentication
{
	/// <summary>
	/// Dictionary used to store state values about the authentication session.
	/// </summary>
	public class AuthenticationProperties
	{
		/// <summary>
		/// State values about the authentication session.
		/// </summary>
		public IDictionary<string, string?> Items
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Collection of parameters that are passed to the authentication handler. These are not intended for
		/// serialization or persistence, only for flowing data between call sites.
		/// </summary>
		public IDictionary<string, object?> Parameters
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets or sets whether the authentication session is persisted across multiple requests.
		/// </summary>
		public bool IsPersistent
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

		/// <summary>
		/// Gets or sets the full path or absolute URI to be used as an http redirect response value.
		/// </summary>
		public string? RedirectUri
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
		/// Gets or sets the time at which the authentication ticket was issued.
		/// </summary>
		public DateTimeOffset? IssuedUtc
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

		/// <summary>
		/// Gets or sets the time at which the authentication ticket expires.
		/// </summary>
		public DateTimeOffset? ExpiresUtc
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

		/// <summary>
		/// Gets or sets if refreshing the authentication session should be allowed.
		/// </summary>
		public bool? AllowRefresh
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

		/// <summary>
		/// Initializes a new instance of the <see cref="T:Microsoft.AspNetCore.Authentication.AuthenticationProperties" /> class.
		/// </summary>
		public AuthenticationProperties()
		{
			throw null;
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="T:Microsoft.AspNetCore.Authentication.AuthenticationProperties" /> class.
		/// </summary>
		/// <param name="items">State values dictionary to use.</param>
		public AuthenticationProperties(IDictionary<string, string?> items)
		{
			throw null;
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="T:Microsoft.AspNetCore.Authentication.AuthenticationProperties" /> class.
		/// </summary>
		/// <param name="items">State values dictionary to use.</param>
		/// <param name="parameters">Parameters dictionary to use.</param>
		public AuthenticationProperties(IDictionary<string, string?>? items, IDictionary<string, object?>? parameters)
		{
			throw null;
		}

		/// <summary>
		/// Return a copy.
		/// </summary>
		/// <returns>A copy.</returns>
		public AuthenticationProperties Clone()
		{
			throw null;
		}

		/// <summary>
		/// Get a string value from the <see cref="P:Microsoft.AspNetCore.Authentication.AuthenticationProperties.Items" /> collection.
		/// </summary>
		/// <param name="key">Property key.</param>
		/// <returns>Retrieved value or <c>null</c> if the property is not set.</returns>
		public string? GetString(string key)
		{
			throw null;
		}

		/// <summary>
		/// Set a string value in the <see cref="P:Microsoft.AspNetCore.Authentication.AuthenticationProperties.Items" /> collection.
		/// </summary>
		/// <param name="key">Property key.</param>
		/// <param name="value">Value to set or <c>null</c> to remove the property.</param>
		public void SetString(string key, string? value)
		{
			throw null;
		}

		/// <summary>
		/// Get a parameter from the <see cref="P:Microsoft.AspNetCore.Authentication.AuthenticationProperties.Parameters" /> collection.
		/// </summary>
		/// <typeparam name="T">Parameter type.</typeparam>
		/// <param name="key">Parameter key.</param>
		/// <returns>Retrieved value or the default value if the property is not set.</returns>
		[return: MaybeNull]
		public T GetParameter<T>(string key)
		{
			throw null;
		}

		/// <summary>
		/// Set a parameter value in the <see cref="P:Microsoft.AspNetCore.Authentication.AuthenticationProperties.Parameters" /> collection.
		/// </summary>
		/// <typeparam name="T">Parameter type.</typeparam>
		/// <param name="key">Parameter key.</param>
		/// <param name="value">Value to set.</param>
		public void SetParameter<T>(string key, [MaybeNull] T value)
		{
			throw null;
		}

		/// <summary>
		/// Get a bool value from the <see cref="P:Microsoft.AspNetCore.Authentication.AuthenticationProperties.Items" /> collection.
		/// </summary>
		/// <param name="key">Property key.</param>
		/// <returns>Retrieved value or <c>null</c> if the property is not set.</returns>
		protected bool? GetBool(string key)
		{
			throw null;
		}

		/// <summary>
		/// Set a bool value in the <see cref="P:Microsoft.AspNetCore.Authentication.AuthenticationProperties.Items" /> collection.
		/// </summary>
		/// <param name="key">Property key.</param>
		/// <param name="value">Value to set or <c>null</c> to remove the property.</param>
		protected void SetBool(string key, bool? value)
		{
			throw null;
		}

		/// <summary>
		/// Get a DateTimeOffset value from the <see cref="P:Microsoft.AspNetCore.Authentication.AuthenticationProperties.Items" /> collection.
		/// </summary>
		/// <param name="key">Property key.</param>
		/// <returns>Retrieved value or <c>null</c> if the property is not set.</returns>
		protected DateTimeOffset? GetDateTimeOffset(string key)
		{
			throw null;
		}

		/// <summary>
		/// Set a DateTimeOffset value in the <see cref="P:Microsoft.AspNetCore.Authentication.AuthenticationProperties.Items" /> collection.
		/// </summary>
		/// <param name="key">Property key.</param>
		/// <param name="value">Value to set or <c>null</c> to remove the property.</param>
		protected void SetDateTimeOffset(string key, DateTimeOffset? value)
		{
			throw null;
		}
	}
}
