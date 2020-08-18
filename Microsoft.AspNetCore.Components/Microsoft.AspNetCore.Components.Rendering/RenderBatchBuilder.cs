using Microsoft.AspNetCore.Components.RenderTree;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Components.Rendering
{
	/// <summary>
	/// Collects the data produced by the rendering system during the course
	/// of rendering a single batch. This tracks both the final output data
	/// and the intermediate states (such as the queue of components still to
	/// be rendered).
	/// </summary>
	internal class RenderBatchBuilder : IDisposable
	{
		public ArrayBuilder<RenderTreeDiff> UpdatedComponentDiffs
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public ArrayBuilder<int> DisposedComponentIds
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public ArrayBuilder<ulong> DisposedEventHandlerIds
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public ArrayBuilder<RenderTreeEdit> EditsBuffer
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public ArrayBuilder<RenderTreeFrame> ReferenceFramesBuffer
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public Queue<RenderQueueEntry> ComponentRenderQueue
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public Queue<int> ComponentDisposalQueue
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public Dictionary<string, int> AttributeDiffSet
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public int ParameterViewValidityStamp
		{
			get
			{
				throw null;
			}
		}

		internal StackObjectPool<Dictionary<object, KeyedItemInfo>> KeyedItemInfoDictionaryPool
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public void ClearStateForCurrentBatch()
		{
			throw null;
		}

		public RenderBatch ToBatch()
		{
			throw null;
		}

		public void InvalidateParameterViews()
		{
			throw null;
		}

		public void Dispose()
		{
			throw null;
		}

		public RenderBatchBuilder()
		{
			throw null;
		}
	}
}
