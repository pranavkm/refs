using Microsoft.AspNetCore.Builder;
using System;

namespace Microsoft.AspNetCore.Hosting
{
	public interface IStartupFilter
	{
		Action<IApplicationBuilder> Configure(Action<IApplicationBuilder> next);
	}
}
