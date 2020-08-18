using System;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Http
{
	public static class HttpResponseJsonExtensions
	{
		/// <summary>
		/// Write the specified value as JSON to the response body. The response content-type will be set to
		/// <c>application/json; charset=utf-8</c> and the status code set to <c>200</c>.
		/// </summary>
		/// <typeparam name="TValue">The type of object to write.</typeparam>
		/// <param name="response">The response to write JSON to.</param>
		/// <param name="value">The value to write as JSON.</param>
		/// <param name="cancellationToken">A <see cref="T:System.Threading.CancellationToken" /> used to cancel the operation.</param>
		/// <returns>The task object representing the asynchronous operation.</returns>
		public static Task WriteAsJsonAsync<TValue>(this HttpResponse response, [AllowNull] TValue value, CancellationToken cancellationToken = default(CancellationToken))
		{
			throw null;
		}

		/// <summary>
		/// Write the specified value as JSON to the response body. The response content-type will be set to
		/// <c>application/json; charset=utf-8</c> and the status code set to <c>200</c>.
		/// </summary>
		/// <typeparam name="TValue">The type of object to write.</typeparam>
		/// <param name="response">The response to write JSON to.</param>
		/// <param name="value">The value to write as JSON.</param>
		/// <param name="options">The serializer options use when serializing the value.</param>
		/// <param name="cancellationToken">A <see cref="T:System.Threading.CancellationToken" /> used to cancel the operation.</param>
		/// <returns>The task object representing the asynchronous operation.</returns>
		public static Task WriteAsJsonAsync<TValue>(this HttpResponse response, [AllowNull] TValue value, JsonSerializerOptions? options, CancellationToken cancellationToken = default(CancellationToken))
		{
			throw null;
		}

		/// <summary>
		/// Write the specified value as JSON to the response body. The response content-type will be set to
		/// the specified content-type and the status code set to <c>200</c>.
		/// </summary>
		/// <typeparam name="TValue">The type of object to write.</typeparam>
		/// <param name="response">The response to write JSON to.</param>
		/// <param name="value">The value to write as JSON.</param>
		/// <param name="options">The serializer options use when serializing the value.</param>
		/// <param name="contentType">The content-type to set on the response.</param>
		/// <param name="cancellationToken">A <see cref="T:System.Threading.CancellationToken" /> used to cancel the operation.</param>
		/// <returns>The task object representing the asynchronous operation.</returns>
		public static Task WriteAsJsonAsync<TValue>(this HttpResponse response, [AllowNull] TValue value, JsonSerializerOptions? options, string? contentType, CancellationToken cancellationToken = default(CancellationToken))
		{
			throw null;
		}

		/// <summary>
		/// Write the specified value as JSON to the response body. The response content-type will be set to
		/// <c>application/json; charset=utf-8</c> and the status code set to <c>200</c>.
		/// </summary>
		/// <param name="response">The response to write JSON to.</param>
		/// <param name="value">The value to write as JSON.</param>
		/// <param name="type">The type of object to write.</param>
		/// <param name="cancellationToken">A <see cref="T:System.Threading.CancellationToken" /> used to cancel the operation.</param>
		/// <returns>The task object representing the asynchronous operation.</returns>
		public static Task WriteAsJsonAsync(this HttpResponse response, object? value, Type type, CancellationToken cancellationToken = default(CancellationToken))
		{
			throw null;
		}

		/// <summary>
		/// Write the specified value as JSON to the response body. The response content-type will be set to
		/// <c>application/json; charset=utf-8</c> and the status code set to <c>200</c>.
		/// </summary>
		/// <param name="response">The response to write JSON to.</param>
		/// <param name="value">The value to write as JSON.</param>
		/// <param name="type">The type of object to write.</param>
		/// <param name="options">The serializer options use when serializing the value.</param>
		/// <param name="cancellationToken">A <see cref="T:System.Threading.CancellationToken" /> used to cancel the operation.</param>
		/// <returns>The task object representing the asynchronous operation.</returns>
		public static Task WriteAsJsonAsync(this HttpResponse response, object? value, Type type, JsonSerializerOptions? options, CancellationToken cancellationToken = default(CancellationToken))
		{
			throw null;
		}

		/// <summary>
		/// Write the specified value as JSON to the response body. The response content-type will be set to
		/// the specified content-type and the status code set to <c>200</c>.
		/// </summary>
		/// <param name="response">The response to write JSON to.</param>
		/// <param name="value">The value to write as JSON.</param>
		/// <param name="type">The type of object to write.</param>
		/// <param name="options">The serializer options use when serializing the value.</param>
		/// <param name="contentType">The content-type to set on the response.</param>
		/// <param name="cancellationToken">A <see cref="T:System.Threading.CancellationToken" /> used to cancel the operation.</param>
		/// <returns>The task object representing the asynchronous operation.</returns>
		public static Task WriteAsJsonAsync(this HttpResponse response, object? value, Type type, JsonSerializerOptions? options, string? contentType, CancellationToken cancellationToken = default(CancellationToken))
		{
			throw null;
		}
	}
}
