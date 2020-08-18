using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Http
{
	public class BindingAddress
	{
		public string Host
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public string PathBase
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public int Port
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			internal set
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

		public bool IsUnixPipe
		{
			get
			{
				throw null;
			}
		}

		public string UnixPipePath
		{
			get
			{
				throw null;
			}
		}

		public override string ToString()
		{
			throw null;
		}

		public override int GetHashCode()
		{
			throw null;
		}

		public override bool Equals(object? obj)
		{
			throw null;
		}

		public static BindingAddress Parse(string address)
		{
			throw null;
		}

		public BindingAddress()
		{
			throw null;
		}
	}
}
