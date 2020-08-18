using System.IO;
using System.Runtime.CompilerServices;
using System.Security.Claims;

namespace Microsoft.AspNetCore.Authentication
{
	public class TicketSerializer : IDataSerializer<AuthenticationTicket>
	{
		public static TicketSerializer Default
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public virtual byte[] Serialize(AuthenticationTicket ticket)
		{
			throw null;
		}

		public virtual AuthenticationTicket? Deserialize(byte[] data)
		{
			throw null;
		}

		public virtual void Write(BinaryWriter writer, AuthenticationTicket ticket)
		{
			throw null;
		}

		protected virtual void WriteIdentity(BinaryWriter writer, ClaimsIdentity identity)
		{
			throw null;
		}

		protected virtual void WriteClaim(BinaryWriter writer, Claim claim)
		{
			throw null;
		}

		public virtual AuthenticationTicket? Read(BinaryReader reader)
		{
			throw null;
		}

		protected virtual ClaimsIdentity ReadIdentity(BinaryReader reader)
		{
			throw null;
		}

		protected virtual Claim ReadClaim(BinaryReader reader, ClaimsIdentity identity)
		{
			throw null;
		}

		public TicketSerializer()
		{
			throw null;
		}
	}
}
