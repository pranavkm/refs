using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Routing.Tree
{
	internal struct TreeEnumerator : IEnumerator<UrlMatchingNode>, IEnumerator, IDisposable
	{
		private readonly Stack<UrlMatchingNode> _stack;

		private readonly PathTokenizer _tokenizer;

		public UrlMatchingNode Current
		{
			[CompilerGenerated]
			readonly get
			{
				throw null;
			}
		}

		object IEnumerator.Current
		{
			get
			{
				throw null;
			}
		}

		public TreeEnumerator(UrlMatchingNode root, PathTokenizer tokenizer)
		{
			throw null;
		}

		public void Dispose()
		{
			throw null;
		}

		public bool MoveNext()
		{
			throw null;
		}

		public void Reset()
		{
			throw null;
		}
	}
}
