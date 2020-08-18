using System;

namespace Microsoft.AspNetCore.Server.Kestrel.Core.Features
{
	/// <summary>
	/// Feature for efficiently handling connection timeouts.
	/// </summary>
	public interface IConnectionTimeoutFeature
	{
		/// <summary>
		/// Close the connection after the specified positive finite <see cref="T:System.TimeSpan" />
		/// unless the timeout is canceled or reset. This will fail if there is an ongoing timeout.
		/// </summary>
		void SetTimeout(TimeSpan timeSpan);

		/// <summary>
		/// Close the connection after the specified positive finite <see cref="T:System.TimeSpan" />
		/// unless the timeout is canceled or reset. This will cancel any ongoing timeouts.
		/// </summary>
		void ResetTimeout(TimeSpan timeSpan);

		/// <summary>
		/// Prevent the connection from closing after a timeout specified by <see cref="M:Microsoft.AspNetCore.Server.Kestrel.Core.Features.IConnectionTimeoutFeature.SetTimeout(System.TimeSpan)" />
		/// or <see cref="M:Microsoft.AspNetCore.Server.Kestrel.Core.Features.IConnectionTimeoutFeature.ResetTimeout(System.TimeSpan)" />.
		/// </summary>
		void CancelTimeout();
	}
}
