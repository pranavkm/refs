using Microsoft.AspNetCore.DataProtection;

namespace Microsoft.AspNetCore.Authentication
{
	public class TicketDataFormat : SecureDataFormat<AuthenticationTicket>
	{
		public TicketDataFormat(IDataProtector protector)
		{
			throw null;
		}
	}
}
