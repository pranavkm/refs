using Microsoft.Extensions.Logging;
using Microsoft.Win32;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Linq;

namespace Microsoft.AspNetCore.DataProtection.Repositories
{
	/// <summary>
	/// An XML repository backed by the Windows registry.
	/// </summary>
	public class RegistryXmlRepository : IXmlRepository
	{
		/// <summary>
		/// The default key storage directory, which currently corresponds to
		/// "HKLM\SOFTWARE\Microsoft\ASP.NET\4.0.30319.0\AutoGenKeys\{SID}".
		/// </summary>
		/// <remarks>
		/// This property can return null if no suitable default registry key can
		/// be found, such as the case when this application is not hosted inside IIS.
		/// </remarks>
		public static RegistryKey DefaultRegistryKey
		{
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// The registry key into which key material will be written.
		/// </summary>
		public RegistryKey RegistryKey
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Creates a <see cref="T:Microsoft.AspNetCore.DataProtection.Repositories.RegistryXmlRepository" /> with keys stored in the given registry key.
		/// </summary>
		/// <param name="registryKey">The registry key in which to persist key material.</param>
		/// <param name="loggerFactory">The <see cref="T:Microsoft.Extensions.Logging.ILoggerFactory" />.</param>
		public RegistryXmlRepository(RegistryKey registryKey, ILoggerFactory loggerFactory)
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
