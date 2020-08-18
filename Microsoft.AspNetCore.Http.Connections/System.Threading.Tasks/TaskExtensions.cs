using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace System.Threading.Tasks
{
	internal static class TaskExtensions
	{
		[AsyncStateMachine(typeof(_003CNoThrow_003Ed__0))]
		[DebuggerStepThrough]
		public static Task NoThrow(this Task task)
		{
			throw null;
		}
	}
}
