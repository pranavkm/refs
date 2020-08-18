using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Routing.Matching
{
	internal class ILEmitTrieJumpTable : JumpTable
	{
		internal Func<string, PathSegment, int> _getDestination;

		public ILEmitTrieJumpTable(int defaultDestination, int exitDestination, (string text, int destination)[] entries, bool? vectorize, JumpTable fallback)
		{
			throw null;
		}

		public override int GetDestination(string path, PathSegment segment)
		{
			throw null;
		}

		[AsyncStateMachine(typeof(_003CInitializeILDelegateAsync_003Ed__13))]
		[DebuggerStepThrough]
		internal Task InitializeILDelegateAsync()
		{
			throw null;
		}

		internal void InitializeILDelegate()
		{
			throw null;
		}
	}
}
