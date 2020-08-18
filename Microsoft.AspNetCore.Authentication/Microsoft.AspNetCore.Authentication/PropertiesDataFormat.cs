using Microsoft.AspNetCore.DataProtection;

namespace Microsoft.AspNetCore.Authentication
{
	public class PropertiesDataFormat : SecureDataFormat<AuthenticationProperties>
	{
		public PropertiesDataFormat(IDataProtector protector)
		{
			throw null;
		}
	}
}
