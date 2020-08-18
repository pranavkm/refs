using System.Xml.Linq;

namespace Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption.ConfigurationModel
{
	public static class XmlExtensions
	{
		internal static bool IsMarkedAsRequiringEncryption(this XElement element)
		{
			throw null;
		}

		/// <summary>
		/// Marks the provided <see cref="T:System.Xml.Linq.XElement" /> as requiring encryption before being persisted
		/// to storage. Use when implementing <see cref="M:Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption.ConfigurationModel.IAuthenticatedEncryptorDescriptor.ExportToXml" />.
		/// </summary>
		public static void MarkAsRequiresEncryption(this XElement element)
		{
			throw null;
		}
	}
}
