using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Http.Features
{
	public class FormFeature : IFormFeature
	{
		public bool HasFormContentType
		{
			get
			{
				throw null;
			}
		}

		public IFormCollection? Form
		{
			[System.Runtime.CompilerServices.NullableContext(2)]
			get
			{
				throw null;
			}
			[System.Runtime.CompilerServices.NullableContext(2)]
			set
			{
				throw null;
			}
		}

		public FormFeature(IFormCollection form)
		{
			throw null;
		}

		public FormFeature(HttpRequest request)
		{
			throw null;
		}

		public FormFeature(HttpRequest request, FormOptions options)
		{
			throw null;
		}

		public IFormCollection ReadForm()
		{
			throw null;
		}

		public Task<IFormCollection> ReadFormAsync()
		{
			throw null;
		}

		public Task<IFormCollection> ReadFormAsync(CancellationToken cancellationToken)
		{
			throw null;
		}
	}
}
