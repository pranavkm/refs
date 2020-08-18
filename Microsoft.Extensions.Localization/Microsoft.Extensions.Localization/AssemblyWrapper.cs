using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Microsoft.Extensions.Localization
{
	/// <summary>
	/// This API supports infrastructure and is not intended to be used
	/// directly from your code. This API may change or be removed in future releases.
	/// </summary>
	internal class AssemblyWrapper
	{
		public Assembly Assembly
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public virtual string FullName
		{
			get
			{
				throw null;
			}
		}

		public AssemblyWrapper(Assembly assembly)
		{
			throw null;
		}

		public virtual Stream? GetManifestResourceStream(string name)
		{
			throw null;
		}
	}
}
