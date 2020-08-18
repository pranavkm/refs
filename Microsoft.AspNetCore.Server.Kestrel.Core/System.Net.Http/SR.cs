using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace System.Net.Http
{
	internal static class SR
	{
		internal static ResourceManager ResourceManager
		{
			get
			{
				throw null;
			}
		}

		internal static CultureInfo Culture
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			set
			{
				throw null;
			}
		}

		/// <summary>The HTTP headers length exceeded the set limit of {0} bytes.</summary>
		internal static string net_http_headers_exceeded_length
		{
			get
			{
				throw null;
			}
		}

		/// <summary>The header name format is invalid.</summary>
		internal static string net_http_headers_invalid_header_name
		{
			get
			{
				throw null;
			}
		}

		/// <summary>HPACK integer exceeds limits or has an overlong encoding.</summary>
		internal static string net_http_hpack_bad_integer
		{
			get
			{
				throw null;
			}
		}

		/// <summary>Failed to HPACK encode the headers.</summary>
		internal static string net_http_hpack_encode_failure
		{
			get
			{
				throw null;
			}
		}

		/// <summary>Huffman-coded literal string failed to decode.</summary>
		internal static string net_http_hpack_huffman_decode_failed
		{
			get
			{
				throw null;
			}
		}

		/// <summary>Incomplete header block received.</summary>
		internal static string net_http_hpack_incomplete_header_block
		{
			get
			{
				throw null;
			}
		}

		/// <summary>Invalid header index: {0} is outside of static table and no dynamic table entry found.</summary>
		internal static string net_http_hpack_invalid_index
		{
			get
			{
				throw null;
			}
		}

		/// <summary>A dynamic table size update of {0} octets is greater than the configured maximum size of {1} octets.</summary>
		internal static string net_http_hpack_large_table_size_update
		{
			get
			{
				throw null;
			}
		}

		/// <summary>Dynamic table size update received after beginning of header block.</summary>
		internal static string net_http_hpack_late_dynamic_table_size_update
		{
			get
			{
				throw null;
			}
		}

		/// <summary>End of headers reached with incomplete token.</summary>
		internal static string net_http_hpack_unexpected_end
		{
			get
			{
				throw null;
			}
		}

		/// <summary>Received an invalid header name: '{0}'.</summary>
		internal static string net_http_invalid_header_name
		{
			get
			{
				throw null;
			}
		}

		/// <summary>No dynamic table support</summary>
		internal static string net_http_qpack_no_dynamic_table
		{
			get
			{
				throw null;
			}
		}

		/// <summary>Request headers must contain only ASCII characters.</summary>
		internal static string net_http_request_invalid_char_encoding
		{
			get
			{
				throw null;
			}
		}

		/// <summary>Connection aborted by peer ({0}).</summary>
		internal static string net_quic_connectionaborted
		{
			get
			{
				throw null;
			}
		}

		/// <summary>QUIC is not supported on this platform. See http://aka.ms/dotnetquic</summary>
		internal static string net_quic_notsupported
		{
			get
			{
				throw null;
			}
		}

		/// <summary>Operation aborted.</summary>
		internal static string net_quic_operationaborted
		{
			get
			{
				throw null;
			}
		}

		/// <summary>Stream aborted by peer ({0}).</summary>
		internal static string net_quic_streamaborted
		{
			get
			{
				throw null;
			}
		}

		internal static string Format(string resourceFormat, params object[] args)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static string GetResourceString(string resourceKey, string defaultValue = null)
		{
			throw null;
		}

		/// <summary>The HTTP headers length exceeded the set limit of {0} bytes.</summary>
		internal static string Formatnet_http_headers_exceeded_length(object p0)
		{
			throw null;
		}

		/// <summary>Invalid header index: {0} is outside of static table and no dynamic table entry found.</summary>
		internal static string Formatnet_http_hpack_invalid_index(object p0)
		{
			throw null;
		}

		/// <summary>A dynamic table size update of {0} octets is greater than the configured maximum size of {1} octets.</summary>
		internal static string Formatnet_http_hpack_large_table_size_update(object p0, object p1)
		{
			throw null;
		}

		/// <summary>Received an invalid header name: '{0}'.</summary>
		internal static string Formatnet_http_invalid_header_name(object p0)
		{
			throw null;
		}

		/// <summary>Connection aborted by peer ({0}).</summary>
		internal static string Formatnet_quic_connectionaborted(object p0)
		{
			throw null;
		}

		/// <summary>Stream aborted by peer ({0}).</summary>
		internal static string Formatnet_quic_streamaborted(object p0)
		{
			throw null;
		}
	}
}
