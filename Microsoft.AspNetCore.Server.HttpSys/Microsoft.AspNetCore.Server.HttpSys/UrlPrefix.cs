using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Server.HttpSys
{
	public class UrlPrefix
	{
		public bool IsHttps
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public string Scheme
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public string Host
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public string Port
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		internal string HostAndPort
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public int PortValue
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public string Path
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		internal string PathWithoutTrailingSlash
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public string FullPrefix
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// http://msdn.microsoft.com/en-us/library/windows/desktop/aa364698(v=vs.85).aspx
		/// </summary>
		/// <param name="scheme">http or https. Will be normalized to lower case.</param>
		/// <param name="host">+, *, IPv4, [IPv6], or a dns name. Http.Sys does not permit punycode (xn--), use Unicode instead.</param>
		/// <param name="port">If empty, the default port for the given scheme will be used (80 or 443).</param>
		/// <param name="path">Should start and end with a '/', though a missing trailing slash will be added. This value must be un-escaped.</param>
		public static UrlPrefix Create(string scheme, string host, string port, string path)
		{
			throw null;
		}

		/// <summary>
		/// http://msdn.microsoft.com/en-us/library/windows/desktop/aa364698(v=vs.85).aspx
		/// </summary>
		/// <param name="scheme">http or https. Will be normalized to lower case.</param>
		/// <param name="host">+, *, IPv4, [IPv6], or a dns name. Http.Sys does not permit punycode (xn--), use Unicode instead.</param>
		/// <param name="portValue">If empty, the default port for the given scheme will be used (80 or 443).</param>
		/// <param name="path">Should start and end with a '/', though a missing trailing slash will be added. This value must be un-escaped.</param>
		public static UrlPrefix Create(string scheme, string host, int? portValue, string path)
		{
			throw null;
		}

		public static UrlPrefix Create(string prefix)
		{
			throw null;
		}

		public override bool Equals(object obj)
		{
			throw null;
		}

		public override int GetHashCode()
		{
			throw null;
		}

		public override string ToString()
		{
			throw null;
		}
	}
}
