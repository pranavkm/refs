using Microsoft.Extensions.FileProviders;

namespace Microsoft.Extensions.Hosting.Internal
{
	/// <summary>
	/// This API supports infrastructure and is not intended to be used
	/// directly from your code. This API may change or be removed in future releases.
	/// </summary>
	public class HostingEnvironment : IHostEnvironment, IHostingEnvironment
	{
		public string ApplicationName
		{
			get
			{
				throw null;
			}
			set
			{
			}
		}

		public IFileProvider ContentRootFileProvider
		{
			get
			{
				throw null;
			}
			set
			{
			}
		}

		public string ContentRootPath
		{
			get
			{
				throw null;
			}
			set
			{
			}
		}

		public string EnvironmentName
		{
			get
			{
				throw null;
			}
			set
			{
			}
		}
	}
}
