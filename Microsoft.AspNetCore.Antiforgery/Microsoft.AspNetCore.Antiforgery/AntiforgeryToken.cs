using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Antiforgery
{
	internal sealed class AntiforgeryToken
	{
		internal const int SecurityTokenBitLength = 128;

		internal const int ClaimUidBitLength = 256;

		public string AdditionalData
		{
			[System.Runtime.CompilerServices.NullableContext(1)]
			get
			{
				throw null;
			}
			[System.Runtime.CompilerServices.NullableContext(1)]
			set
			{
				throw null;
			}
		}

		public BinaryBlob? ClaimUid
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

		public bool IsCookieToken
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

		public BinaryBlob? SecurityToken
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

		public string? Username
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

		public AntiforgeryToken()
		{
			throw null;
		}
	}
}
