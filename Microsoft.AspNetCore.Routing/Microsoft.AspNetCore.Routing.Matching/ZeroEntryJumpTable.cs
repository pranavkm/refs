namespace Microsoft.AspNetCore.Routing.Matching
{
	internal class ZeroEntryJumpTable : JumpTable
	{
		public ZeroEntryJumpTable(int defaultDestination, int exitDestination)
		{
			throw null;
		}

		public override int GetDestination(string path, PathSegment segment)
		{
			throw null;
		}

		public override string DebuggerToString()
		{
			throw null;
		}
	}
}
