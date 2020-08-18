namespace Microsoft.AspNetCore.Components.RenderTree
{
	internal static class ArrayBuilderExtensions
	{
		/// <summary>
		/// Produces an <see cref="T:Microsoft.AspNetCore.Components.RenderTree.ArrayRange`1" /> structure describing the current contents.
		/// </summary>
		/// <returns>The <see cref="T:Microsoft.AspNetCore.Components.RenderTree.ArrayRange`1" />.</returns>
		public static ArrayRange<T> ToRange<T>(this ArrayBuilder<T> builder)
		{
			throw null;
		}

		/// <summary>
		/// Produces an <see cref="T:Microsoft.AspNetCore.Components.RenderTree.ArrayBuilderSegment`1" /> structure describing the selected contents.
		/// </summary>
		/// <param name="builder">The <see cref="T:Microsoft.AspNetCore.Components.RenderTree.ArrayBuilder`1" /></param>
		/// <param name="fromIndexInclusive">The index of the first item in the segment.</param>
		/// <param name="toIndexExclusive">One plus the index of the last item in the segment.</param>
		/// <returns>The <see cref="T:System.ArraySegment`1" />.</returns>
		public static ArrayBuilderSegment<T> ToSegment<T>(this ArrayBuilder<T> builder, int fromIndexInclusive, int toIndexExclusive)
		{
			throw null;
		}
	}
}
