using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Xml.Linq;

namespace Microsoft.AspNetCore.DataProtection.Repositories
{
	/// <summary>
	/// An XML repository backed by a file system.
	/// </summary>
	public class FileSystemXmlRepository : IXmlRepository
	{
		/// <summary>
		/// The default key storage directory.
		/// On Windows, this currently corresponds to "Environment.SpecialFolder.LocalApplication/ASP.NET/DataProtection-Keys".
		/// On Linux and macOS, this currently corresponds to "$HOME/.aspnet/DataProtection-Keys".
		/// </summary>
		/// <remarks>
		/// This property can return null if no suitable default key storage directory can
		/// be found, such as the case when the user profile is unavailable.
		/// </remarks>
		public static DirectoryInfo DefaultKeyStorageDirectory
		{
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// The directory into which key material will be written.
		/// </summary>
		public DirectoryInfo Directory
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Creates a <see cref="T:Microsoft.AspNetCore.DataProtection.Repositories.FileSystemXmlRepository" /> with keys stored at the given directory.
		/// </summary>
		/// <param name="directory">The directory in which to persist key material.</param>
		/// <param name="loggerFactory">The <see cref="T:Microsoft.Extensions.Logging.ILoggerFactory" />.</param>
		public FileSystemXmlRepository(DirectoryInfo directory, ILoggerFactory loggerFactory)
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
