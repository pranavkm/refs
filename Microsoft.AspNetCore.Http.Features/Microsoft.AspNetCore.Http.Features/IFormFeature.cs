using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Http.Features
{
	public interface IFormFeature
	{
		/// <summary>
		/// Indicates if the request has a supported form content-type.
		/// </summary>
		bool HasFormContentType
		{
			get;
		}

		/// <summary>
		/// The parsed form, if any.
		/// </summary>
		IFormCollection? Form
		{
			get;
			set;
		}

		/// <summary>
		/// Parses the request body as a form.
		/// </summary>
		/// <returns>The <see cref="T:Microsoft.AspNetCore.Http.IFormCollection" />.</returns>
		IFormCollection ReadForm();

		/// <summary>
		/// Parses the request body as a form.
		/// </summary>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		Task<IFormCollection> ReadFormAsync(CancellationToken cancellationToken);
	}
}
