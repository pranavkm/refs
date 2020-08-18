using Microsoft.AspNetCore.Components.Rendering;
using System.Collections.Generic;

namespace Microsoft.AspNetCore.Components.RenderTree
{
	internal static class RenderTreeDiffBuilder
	{
		private enum DiffAction
		{
			Match,
			Insert,
			Delete
		}

		/// <summary>
		/// Exists only so that the various methods in this class can call each other without
		/// constantly building up long lists of parameters. Is private to this class, so the
		/// fact that it's a mutable struct is manageable.
		///
		/// Always pass by ref to avoid copying, and because the 'SiblingIndex' is mutable.
		/// </summary>
		private struct DiffContext
		{
			public readonly Renderer Renderer;

			public readonly RenderBatchBuilder BatchBuilder;

			public readonly RenderTreeFrame[] OldTree;

			public readonly RenderTreeFrame[] NewTree;

			public readonly ArrayBuilder<RenderTreeEdit> Edits;

			public readonly ArrayBuilder<RenderTreeFrame> ReferenceFrames;

			public readonly Dictionary<string, int> AttributeDiffSet;

			public readonly StackObjectPool<Dictionary<object, KeyedItemInfo>> KeyedItemInfoDictionaryPool;

			public readonly int ComponentId;

			public int SiblingIndex;

			public DiffContext(Renderer renderer, RenderBatchBuilder batchBuilder, int componentId, RenderTreeFrame[] oldTree, RenderTreeFrame[] newTree)
			{
				throw null;
			}
		}

		public const int SystemAddedAttributeSequenceNumber = int.MinValue;

		public static RenderTreeDiff ComputeDiff(Renderer renderer, RenderBatchBuilder batchBuilder, int componentId, ArrayRange<RenderTreeFrame> oldTree, ArrayRange<RenderTreeFrame> newTree)
		{
			throw null;
		}

		public static void DisposeFrames(RenderBatchBuilder batchBuilder, ArrayRange<RenderTreeFrame> frames)
		{
			throw null;
		}
	}
}
