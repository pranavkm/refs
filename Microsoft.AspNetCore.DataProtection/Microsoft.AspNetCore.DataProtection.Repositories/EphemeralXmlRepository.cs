using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Microsoft.AspNetCore.DataProtection.Repositories
{
	/// <summary>
	/// An ephemeral XML repository backed by process memory. This class must not be used for
	/// anything other than dev scenarios as the keys will not be persisted to storage.
	/// </summary>
	internal class EphemeralXmlRepository : IXmlRepository
	{
		public EphemeralXmlRepository(ILoggerFactory loggerFactory)
		{
			throw null;
		}

		public virtual IReadOnlyCollection<XElement> GetAllElements()
		{
			throw null;
		}

		public virtual void StoreElement(XElement element, string friendlyName)
		{
			throw null;
		}
	}
}
