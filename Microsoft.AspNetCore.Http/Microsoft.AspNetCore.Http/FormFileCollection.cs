using System.Collections;
using System.Collections.Generic;

namespace Microsoft.AspNetCore.Http
{
	/// <summary>
	/// Default implementation of <see cref="T:Microsoft.AspNetCore.Http.IFormFileCollection" />.
	/// </summary>
	public class FormFileCollection : List<IFormFile>, IFormFileCollection, IReadOnlyList<IFormFile>, IEnumerable<IFormFile>, IEnumerable, IReadOnlyCollection<IFormFile>
	{
		/// <inheritdoc />
		public IFormFile? this[string name]
		{
			get
			{
				throw null;
			}
		}

		/// <inheritdoc />
		public IFormFile? GetFile(string name)
		{
			throw null;
		}

		/// <inheritdoc />
		public IReadOnlyList<IFormFile> GetFiles(string name)
		{
			throw null;
		}

		public FormFileCollection()
		{
			throw null;
		}
	}
}
