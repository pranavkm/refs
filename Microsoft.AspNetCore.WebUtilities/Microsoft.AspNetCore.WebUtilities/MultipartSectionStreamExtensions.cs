using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.WebUtilities
{
	/// <summary>
	/// Various extension methods for dealing with the section body stream
	/// </summary>
	public static class MultipartSectionStreamExtensions
	{
		/// <summary>
		/// Reads the body of the section as a string
		/// </summary>
		/// <param name="section">The section to read from</param>
		/// <returns>The body steam as string</returns>
		[AsyncStateMachine(typeof(_003CReadAsStringAsync_003Ed__0))]
		[DebuggerStepThrough]
		public static Task<string> ReadAsStringAsync(this MultipartSection section)
		{
			throw null;
		}
	}
}
