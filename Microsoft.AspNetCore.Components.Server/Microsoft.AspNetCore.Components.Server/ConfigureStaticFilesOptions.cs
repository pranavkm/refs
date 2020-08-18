using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Options;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Components.Server
{
	internal class ConfigureStaticFilesOptions : IPostConfigureOptions<StaticFileOptions>
	{
		public IWebHostEnvironment Environment
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public ConfigureStaticFilesOptions(IWebHostEnvironment environment)
		{
			throw null;
		}

		public void PostConfigure(string name, StaticFileOptions options)
		{
			throw null;
		}
	}
}
