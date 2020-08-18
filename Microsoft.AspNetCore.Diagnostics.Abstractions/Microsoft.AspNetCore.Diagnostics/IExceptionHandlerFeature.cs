using System;

namespace Microsoft.AspNetCore.Diagnostics
{
	public interface IExceptionHandlerFeature
	{
		Exception Error
		{
			get;
		}
	}
}
