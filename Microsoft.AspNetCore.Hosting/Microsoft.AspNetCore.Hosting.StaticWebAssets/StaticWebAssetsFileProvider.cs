using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Primitives;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Hosting.StaticWebAssets
{
	internal class StaticWebAssetsFileProvider : IFileProvider
	{
		private class StaticWebAssetsDirectoryRoot : IDirectoryContents, IEnumerable<IFileInfo>, IEnumerable
		{
			private class StaticWebAssetsFileInfo : IFileInfo
			{
				public bool Exists
				{
					get
					{
						throw null;
					}
				}

				public long Length
				{
					get
					{
						throw null;
					}
				}

				public string PhysicalPath
				{
					get
					{
						throw null;
					}
				}

				public DateTimeOffset LastModified
				{
					get
					{
						throw null;
					}
				}

				public bool IsDirectory
				{
					get
					{
						throw null;
					}
				}

				public string Name
				{
					[CompilerGenerated]
					get
					{
						throw null;
					}
				}

				public StaticWebAssetsFileInfo(string name)
				{
					throw null;
				}

				public Stream CreateReadStream()
				{
					throw null;
				}
			}

			public bool Exists
			{
				get
				{
					throw null;
				}
			}

			public StaticWebAssetsDirectoryRoot(PathString remainingPath)
			{
				throw null;
			}

			public IEnumerator<IFileInfo> GetEnumerator()
			{
				throw null;
			}

			IEnumerator IEnumerable.GetEnumerator()
			{
				throw null;
			}
		}

		public PhysicalFileProvider InnerProvider
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public PathString BasePath
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public StaticWebAssetsFileProvider(string pathPrefix, string contentRoot)
		{
			throw null;
		}

		/// <inheritdoc />
		public IDirectoryContents GetDirectoryContents(string subpath)
		{
			throw null;
		}

		/// <inheritdoc />
		public IFileInfo GetFileInfo(string subpath)
		{
			throw null;
		}

		/// <inheritdoc />
		public IChangeToken Watch(string filter)
		{
			throw null;
		}
	}
}
