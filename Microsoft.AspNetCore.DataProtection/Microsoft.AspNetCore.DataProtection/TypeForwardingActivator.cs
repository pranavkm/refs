using Microsoft.Extensions.Logging;
using System;

namespace Microsoft.AspNetCore.DataProtection
{
	internal class TypeForwardingActivator : SimpleActivator
	{
		public TypeForwardingActivator(IServiceProvider services)
		{
			throw null;
		}

		public TypeForwardingActivator(IServiceProvider services, ILoggerFactory loggerFactory)
		{
			throw null;
		}

		public override object CreateInstance(Type expectedBaseType, string originalTypeName)
		{
			throw null;
		}

		internal object CreateInstance(Type expectedBaseType, string originalTypeName, out bool forwarded)
		{
			throw null;
		}

		protected string RemoveVersionFromAssemblyName(string forwardedTypeName)
		{
			throw null;
		}
	}
}
