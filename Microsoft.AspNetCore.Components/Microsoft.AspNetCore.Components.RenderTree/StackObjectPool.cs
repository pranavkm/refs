using System;

namespace Microsoft.AspNetCore.Components.RenderTree
{
	internal class StackObjectPool<T> where T : class
	{
		public StackObjectPool(int maxPreservedItems, Func<T> instanceFactory)
		{
			throw null;
		}

		public T Get()
		{
			throw null;
		}

		public void Return(T instance)
		{
			throw null;
		}
	}
}
