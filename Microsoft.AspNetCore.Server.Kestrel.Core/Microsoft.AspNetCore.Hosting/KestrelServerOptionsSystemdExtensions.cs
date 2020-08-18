using Microsoft.AspNetCore.Server.Kestrel.Core;
using System;

namespace Microsoft.AspNetCore.Hosting
{
	public static class KestrelServerOptionsSystemdExtensions
	{
		/// <summary>
		/// Open file descriptor (SD_LISTEN_FDS_START) initialized by systemd socket-based activation logic if available.
		/// </summary>
		/// <returns>
		/// The <see cref="T:Microsoft.AspNetCore.Server.Kestrel.Core.KestrelServerOptions" />.
		/// </returns>
		public static KestrelServerOptions UseSystemd(this KestrelServerOptions options)
		{
			throw null;
		}

		/// <summary>
		/// Open file descriptor (SD_LISTEN_FDS_START) initialized by systemd socket-based activation logic if available.
		/// Specify callback to configure endpoint-specific settings.
		/// </summary>
		/// <returns>
		/// The <see cref="T:Microsoft.AspNetCore.Server.Kestrel.Core.KestrelServerOptions" />.
		/// </returns>
		public static KestrelServerOptions UseSystemd(this KestrelServerOptions options, Action<ListenOptions> configure)
		{
			throw null;
		}
	}
}
