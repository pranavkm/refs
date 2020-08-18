using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.FileProviders;

namespace Microsoft.AspNetCore.StaticFiles
{
	internal static class Helpers
	{
		internal static IFileProvider ResolveFileProvider(IWebHostEnvironment hostingEnv)
		{
			throw null;
		}

		internal static bool IsGetOrHeadMethod(string method)
		{
			throw null;
		}

		internal static bool PathEndsInSlash(PathString path)
		{
			throw null;
		}

		internal static string GetPathValueWithSlash(PathString path)
		{
			throw null;
		}

		internal static void RedirectToPathWithSlash(HttpContext context)
		{
			throw null;
		}

		internal static bool TryMatchPath(HttpContext context, PathString matchUrl, bool forDirectory, out PathString subpath)
		{
			throw null;
		}
	}
}
