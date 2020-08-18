using System.ComponentModel;

namespace Microsoft.AspNetCore.Server.HttpSys
{
	public class HttpSysException : Win32Exception
	{
		public override int ErrorCode
		{
			get
			{
				throw null;
			}
		}

		internal HttpSysException()
		{
			throw null;
		}

		internal HttpSysException(int errorCode)
		{
			throw null;
		}

		internal HttpSysException(int errorCode, string message)
		{
			throw null;
		}
	}
}
