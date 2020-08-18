using Microsoft.AspNetCore.Components.RenderTree;
using Microsoft.Extensions.Internal;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Concurrent;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Components.Server.Circuits
{
	internal class RemoteRenderer : Renderer
	{
		internal readonly struct UnacknowledgedRenderBatch
		{
			public long BatchId
			{
				[CompilerGenerated]
				get
				{
					throw null;
				}
			}

			public ArrayBuilder<byte> Data
			{
				[CompilerGenerated]
				get
				{
					throw null;
				}
			}

			public TaskCompletionSource<object> CompletionSource
			{
				[CompilerGenerated]
				get
				{
					throw null;
				}
			}

			public Microsoft.Extensions.Internal.ValueStopwatch ValueStopwatch
			{
				[CompilerGenerated]
				get
				{
					throw null;
				}
			}

			public UnacknowledgedRenderBatch(long batchId, ArrayBuilder<byte> data, TaskCompletionSource<object> completionSource, Microsoft.Extensions.Internal.ValueStopwatch valueStopwatch)
			{
				throw null;
			}
		}

		private static class Log
		{
			private static class EventIds
			{
				public static readonly EventId UnhandledExceptionRenderingComponent;

				public static readonly EventId BeginUpdateDisplayAsync;

				public static readonly EventId SkipUpdateDisplayAsync;

				public static readonly EventId SendBatchDataFailed;

				public static readonly EventId CompletingBatchWithError;

				public static readonly EventId CompletingBatchWithoutError;

				public static readonly EventId ReceivedDuplicateBatchAcknowledgement;

				public static readonly EventId FullUnacknowledgedRenderBatchesQueue;
			}

			public static void SendBatchDataFailed(ILogger logger, Exception exception)
			{
				throw null;
			}

			public static void UnhandledExceptionRenderingComponent(ILogger logger, Exception exception)
			{
				throw null;
			}

			public static void BeginUpdateDisplayAsync(ILogger logger, string connectionId, long batchId, int dataLength)
			{
				throw null;
			}

			public static void BufferingRenderDisconnectedClient(ILogger logger, string connectionId)
			{
				throw null;
			}

			public static void CompletingBatchWithError(ILogger logger, long batchId, string errorMessage, TimeSpan elapsedTime)
			{
				throw null;
			}

			public static void CompletingBatchWithoutError(ILogger logger, long batchId, TimeSpan elapsedTime)
			{
				throw null;
			}

			public static void ReceivedDuplicateBatchAck(ILogger logger, long incomingBatchId)
			{
				throw null;
			}

			public static void FullUnacknowledgedRenderBatchesQueue(ILogger logger)
			{
				throw null;
			}
		}

		internal readonly ConcurrentQueue<UnacknowledgedRenderBatch> _unacknowledgedRenderBatches;

		public override Dispatcher Dispatcher
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Notifies when a rendering exception occurred.
		/// </summary>
		public event EventHandler<Exception> UnhandledException
		{
			[CompilerGenerated]
			add
			{
				throw null;
			}
			[CompilerGenerated]
			remove
			{
				throw null;
			}
		}

		/// <summary>
		/// Creates a new <see cref="T:Microsoft.AspNetCore.Components.Server.Circuits.RemoteRenderer" />.
		/// </summary>
		public RemoteRenderer(IServiceProvider serviceProvider, ILoggerFactory loggerFactory, CircuitOptions options, CircuitClientProxy client, ILogger logger, ElementReferenceContext? elementReferenceContext)
		{
			throw null;
		}

		/// <summary>
		/// Associates the <see cref="T:Microsoft.AspNetCore.Components.IComponent" /> with the <see cref="T:Microsoft.AspNetCore.Components.Server.Circuits.RemoteRenderer" />,
		/// causing it to be displayed in the specified DOM element.
		/// </summary>
		/// <param name="componentType">The type of the component.</param>
		/// <param name="domElementSelector">A CSS selector that uniquely identifies a DOM element.</param>
		public Task AddComponentAsync(Type componentType, string domElementSelector)
		{
			throw null;
		}

		/// <summary>
		/// Associates the <see cref="T:Microsoft.AspNetCore.Components.IComponent" /> with the <see cref="T:Microsoft.AspNetCore.Components.Server.Circuits.RemoteRenderer" />,
		/// causing it to be displayed in the specified DOM element.
		/// </summary>
		/// <param name="componentType">The type of the component.</param>
		/// <param name="parameters">The parameters for the component.</param>
		/// <param name="domElementSelector">A CSS selector that uniquely identifies a DOM element.</param>
		public Task AddComponentAsync(Type componentType, ParameterView parameters, string domElementSelector)
		{
			throw null;
		}

		protected override void ProcessPendingRender()
		{
			throw null;
		}

		/// <inheritdoc />
		protected override void HandleException(Exception exception)
		{
			throw null;
		}

		/// <inheritdoc />
		protected override void Dispose(bool disposing)
		{
			throw null;
		}

		/// <inheritdoc />
		protected override Task UpdateDisplayAsync(in RenderBatch batch)
		{
			throw null;
		}

		public Task ProcessBufferedRenderBatches()
		{
			throw null;
		}

		public Task OnRenderCompletedAsync(long incomingBatchId, string errorMessageOrNull)
		{
			throw null;
		}
	}
}
