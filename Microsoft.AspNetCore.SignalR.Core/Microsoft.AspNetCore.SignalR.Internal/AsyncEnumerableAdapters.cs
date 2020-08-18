using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.SignalR.Internal
{
	internal static class AsyncEnumerableAdapters
	{
		private class CancelableTypedAsyncEnumerable<TResult> : IAsyncEnumerable<TResult>
		{
			private class CancelableEnumerator<T> : IAsyncEnumerator<T>, IAsyncDisposable
			{
				public T Current
				{
					get
					{
						throw null;
					}
				}

				public CancelableEnumerator(IAsyncEnumerator<T> asyncEnumerator, CancellationTokenRegistration registration)
				{
					throw null;
				}

				public ValueTask<bool> MoveNextAsync()
				{
					throw null;
				}

				public ValueTask DisposeAsync()
				{
					throw null;
				}
			}

			public CancelableTypedAsyncEnumerable(IAsyncEnumerable<TResult> asyncEnumerable, CancellationTokenSource cts)
			{
				throw null;
			}

			public IAsyncEnumerator<TResult> GetAsyncEnumerator(CancellationToken cancellationToken = default(CancellationToken))
			{
				throw null;
			}
		}

		/// <summary>Converts an IAsyncEnumerable of T to an IAsyncEnumerable of object.</summary>
		private class CancelableAsyncEnumerable<T> : IAsyncEnumerable<object>
		{
			private class BoxedAsyncEnumerator : IAsyncEnumerator<object>, IAsyncDisposable
			{
				public object Current
				{
					get
					{
						throw null;
					}
				}

				public BoxedAsyncEnumerator(IAsyncEnumerator<T> asyncEnumerator)
				{
					throw null;
				}

				public ValueTask<bool> MoveNextAsync()
				{
					throw null;
				}

				public ValueTask DisposeAsync()
				{
					throw null;
				}
			}

			public CancelableAsyncEnumerable(IAsyncEnumerable<T> asyncEnumerable, CancellationToken cancellationToken)
			{
				throw null;
			}

			public IAsyncEnumerator<object> GetAsyncEnumerator(CancellationToken cancellationToken = default(CancellationToken))
			{
				throw null;
			}
		}

		public static IAsyncEnumerable<object> MakeCancelableAsyncEnumerable<T>(IAsyncEnumerable<T> asyncEnumerable, CancellationToken cancellationToken = default(CancellationToken))
		{
			throw null;
		}

		public static IAsyncEnumerable<T> MakeCancelableTypedAsyncEnumerable<T>(IAsyncEnumerable<T> asyncEnumerable, CancellationTokenSource cts)
		{
			throw null;
		}

		[AsyncIteratorStateMachine(typeof(_003CMakeAsyncEnumerableFromChannel_003Ed__2<>))]
		public static IAsyncEnumerable<object> MakeAsyncEnumerableFromChannel<T>(ChannelReader<T> channel, [EnumeratorCancellation] CancellationToken cancellationToken = default(CancellationToken))
		{
			throw null;
		}
	}
}
