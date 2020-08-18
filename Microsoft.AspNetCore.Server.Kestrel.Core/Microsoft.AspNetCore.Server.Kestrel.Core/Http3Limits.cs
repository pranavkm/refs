namespace Microsoft.AspNetCore.Server.Kestrel.Core
{
	public class Http3Limits
	{
		/// <summary>
		/// Limits the size of the header compression table, in octets, the HPACK decoder on the server can use.
		/// <para>
		/// Value must be greater than 0, defaults to 4096
		/// </para>
		/// </summary>
		public int HeaderTableSize
		{
			get
			{
				throw null;
			}
			set
			{
				throw null;
			}
		}

		/// <summary>
		/// Indicates the size of the maximum allowed size of a request header field sequence. This limit applies to both name and value sequences in their compressed and uncompressed representations.
		/// <para>
		/// Value must be greater than 0, defaults to 8192
		/// </para>
		/// </summary>
		public int MaxRequestHeaderFieldSize
		{
			get
			{
				throw null;
			}
			set
			{
				throw null;
			}
		}

		public Http3Limits()
		{
			throw null;
		}
	}
}
