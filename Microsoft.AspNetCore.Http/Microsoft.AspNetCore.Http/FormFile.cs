using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Http
{
	/// <summary>
	/// Default implementation of <see cref="T:Microsoft.AspNetCore.Http.IFormFile" />.
	/// </summary>
	public class FormFile : IFormFile
	{
		/// <summary>
		/// Gets the raw Content-Disposition header of the uploaded file.
		/// </summary>
		public string ContentDisposition
		{
			get
			{
				throw null;
			}
			set
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets the raw Content-Type header of the uploaded file.
		/// </summary>
		public string ContentType
		{
			get
			{
				throw null;
			}
			set
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets the header dictionary of the uploaded file.
		/// </summary>
		public IHeaderDictionary Headers
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			set
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets the file length in bytes.
		/// </summary>
		public long Length
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets the name from the Content-Disposition header.
		/// </summary>
		public string Name
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets the file name from the Content-Disposition header.
		/// </summary>
		public string FileName
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public FormFile(Stream baseStream, long baseStreamOffset, long length, string name, string fileName)
		{
			throw null;
		}

		/// <summary>
		/// Opens the request stream for reading the uploaded file.
		/// </summary>
		public Stream OpenReadStream()
		{
			throw null;
		}

		/// <summary>
		/// Copies the contents of the uploaded file to the <paramref name="target" /> stream.
		/// </summary>
		/// <param name="target">The stream to copy the file contents to.</param>
		public void CopyTo(Stream target)
		{
			throw null;
		}

		/// <summary>
		/// Asynchronously copies the contents of the uploaded file to the <paramref name="target" /> stream.
		/// </summary>
		/// <param name="target">The stream to copy the file contents to.</param>
		/// <param name="cancellationToken"></param>
		[AsyncStateMachine(typeof(_003CCopyToAsync_003Ed__25))]
		[DebuggerStepThrough]
		public Task CopyToAsync(Stream target, CancellationToken cancellationToken = default(CancellationToken))
		{
			throw null;
		}
	}
}
