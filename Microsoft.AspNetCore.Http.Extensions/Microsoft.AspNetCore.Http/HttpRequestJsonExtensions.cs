using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Http
{
	public static class HttpRequestJsonExtensions
	{
		/// <summary>
		/// Read JSON from the request and deserialize to the specified type.
		/// If the request's content-type is not a known JSON type then an error will be thrown.
		/// </summary>
		/// <typeparam name="TValue">The type of object to read.</typeparam>
		/// <param name="request">The request to read from.</param>
		/// <param name="cancellationToken">A <see cref="T:System.Threading.CancellationToken" /> used to cancel the operation.</param>
		/// <returns>The task object representing the asynchronous operation.</returns>
		public static ValueTask<TValue?> ReadFromJsonAsync<TValue>(this HttpRequest request, CancellationToken cancellationToken = default(CancellationToken))
		{
			throw null;
		}

		/// <summary>
		/// Read JSON from the request and deserialize to the specified type.
		/// If the request's content-type is not a known JSON type then an error will be thrown.
		/// </summary>
		/// <typeparam name="TValue">The type of object to read.</typeparam>
		/// <param name="request">The request to read from.</param>
		/// <param name="options">The serializer options use when deserializing the content.</param>
		/// <param name="cancellationToken">A <see cref="T:System.Threading.CancellationToken" /> used to cancel the operation.</param>
		/// <returns>The task object representing the asynchronous operation.</returns>
		[AsyncStateMachine(typeof(_003CReadFromJsonAsync_003Ed__1<>))]
		[DebuggerStepThrough]
		public static ValueTask<TValue?> ReadFromJsonAsync<TValue>(this HttpRequest request, JsonSerializerOptions? options, CancellationToken cancellationToken = default(CancellationToken))
		{
			throw null;
		}

		/// <summary>
		/// Read JSON from the request and deserialize to the specified type.
		/// If the request's content-type is not a known JSON type then an error will be thrown.
		/// </summary>
		/// <param name="request">The request to read from.</param>
		/// <param name="type">The type of object to read.</param>
		/// <param name="cancellationToken">A <see cref="T:System.Threading.CancellationToken" /> used to cancel the operation.</param>
		/// <returns>The task object representing the asynchronous operation.</returns>
		public static ValueTask<object?> ReadFromJsonAsync(this HttpRequest request, Type type, CancellationToken cancellationToken = default(CancellationToken))
		{
			throw null;
		}

		/// <summary>
		/// Read JSON from the request and deserialize to the specified type.
		/// If the request's content-type is not a known JSON type then an error will be thrown.
		/// </summary>
		/// <param name="request">The request to read from.</param>
		/// <param name="type">The type of object to read.</param>
		/// <param name="options">The serializer options use when deserializing the content.</param>
		/// <param name="cancellationToken">A <see cref="T:System.Threading.CancellationToken" /> used to cancel the operation.</param>
		/// <returns>The task object representing the asynchronous operation.</returns>
		[AsyncStateMachine(typeof(_003CReadFromJsonAsync_003Ed__3))]
		[DebuggerStepThrough]
		public static ValueTask<object?> ReadFromJsonAsync(this HttpRequest request, Type type, JsonSerializerOptions? options, CancellationToken cancellationToken = default(CancellationToken))
		{
			throw null;
		}

		/// <summary>
		/// Checks the Content-Type header for JSON types.
		/// </summary>
		/// <returns>true if the Content-Type header represents a JSON content type; otherwise, false.</returns>
		public static bool HasJsonContentType(this HttpRequest request)
		{
			throw null;
		}
	}
}
