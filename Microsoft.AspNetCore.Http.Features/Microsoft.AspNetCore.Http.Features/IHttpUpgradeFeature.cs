using System.IO;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Http.Features
{
	public interface IHttpUpgradeFeature
	{
		/// <summary>
		/// Indicates if the server can upgrade this request to an opaque, bidirectional stream.
		/// </summary>
		bool IsUpgradableRequest
		{
			get;
		}

		/// <summary>
		/// Attempt to upgrade the request to an opaque, bidirectional stream. The response status code
		/// and headers need to be set before this is invoked. Check <see cref="P:Microsoft.AspNetCore.Http.Features.IHttpUpgradeFeature.IsUpgradableRequest" />
		/// before invoking.
		/// </summary>
		/// <returns></returns>
		Task<Stream> UpgradeAsync();
	}
}
