using System.Collections;
using System.Collections.Generic;

namespace Microsoft.AspNetCore.Http
{
	/// <summary>
	/// Represents the collection of files sent with the HttpRequest.
	/// </summary>
	public interface IFormFileCollection : IReadOnlyList<IFormFile>, IEnumerable<IFormFile>, IEnumerable, IReadOnlyCollection<IFormFile>
	{
		/// <summary>
		/// Gets the first file with the specified name.
		/// </summary>
		/// <param name="name">The name of the file to get.</param>
		/// <returns>
		/// The requested file, or null if it is not present.
		/// </returns>
		IFormFile? this[string name]
		{
			get;
		}

		/// <summary>
		/// Gets the first file with the specified name.
		/// </summary>
		/// <param name="name">The name of the file to get.</param>
		/// <returns>
		/// The requested file, or null if it is not present.
		/// </returns>
		IFormFile? GetFile(string name);

		/// <summary>
		///     Gets an <see cref="T:System.Collections.Generic.IReadOnlyList`1" /> containing the files of the
		///     <see cref="T:Microsoft.AspNetCore.Http.IFormFileCollection" /> with the specified name.
		/// </summary>
		/// <param name="name">The name of the files to get.</param>
		/// <returns>
		///     An <see cref="T:System.Collections.Generic.IReadOnlyList`1" /> containing the files of the object
		///     that implements <see cref="T:Microsoft.AspNetCore.Http.IFormFileCollection" />.
		/// </returns>
		IReadOnlyList<IFormFile> GetFiles(string name);
	}
}
