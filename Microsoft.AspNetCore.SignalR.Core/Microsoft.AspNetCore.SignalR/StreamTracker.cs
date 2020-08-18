using Microsoft.AspNetCore.SignalR.Protocol;
using System;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.SignalR
{
	internal class StreamTracker
	{
		private interface IStreamConverter
		{
			Type GetItemType();

			object GetReaderAsObject(Type type);

			Task WriteToStream(object item);

			void TryComplete(Exception ex);
		}

		private class ChannelConverter<T> : IStreamConverter
		{
			public ChannelConverter(int streamBufferCapacity)
			{
				throw null;
			}

			public Type GetItemType()
			{
				throw null;
			}

			public object GetReaderAsObject(Type type)
			{
				throw null;
			}

			public Task WriteToStream(object o)
			{
				throw null;
			}

			public void TryComplete(Exception ex)
			{
				throw null;
			}
		}

		public StreamTracker(int streamBufferCapacity)
		{
			throw null;
		}

		/// <summary>
		/// Creates a new stream and returns the ChannelReader for it as an object.
		/// </summary>
		public object AddStream(string streamId, Type itemType, Type targetType)
		{
			throw null;
		}

		public bool TryProcessItem(StreamItemMessage message, out Task task)
		{
			throw null;
		}

		public Type GetStreamItemType(string streamId)
		{
			throw null;
		}

		public bool TryComplete(CompletionMessage message)
		{
			throw null;
		}

		public void CompleteAll(Exception ex)
		{
			throw null;
		}
	}
}
