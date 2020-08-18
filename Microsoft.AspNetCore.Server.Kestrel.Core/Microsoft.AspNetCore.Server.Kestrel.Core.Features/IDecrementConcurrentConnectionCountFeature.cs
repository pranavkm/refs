namespace Microsoft.AspNetCore.Server.Kestrel.Core.Features
{
	/// <summary>
	/// A connection feature allowing middleware to stop counting connections towards <see cref="P:Microsoft.AspNetCore.Server.Kestrel.Core.KestrelServerLimits.MaxConcurrentConnections" />.
	/// This is used by Kestrel internally to stop counting upgraded connections towards this limit.
	/// </summary>
	public interface IDecrementConcurrentConnectionCountFeature
	{
		/// <summary>
		/// Idempotent method to stop counting a connection towards <see cref="P:Microsoft.AspNetCore.Server.Kestrel.Core.KestrelServerLimits.MaxConcurrentConnections" />.
		/// </summary>
		void ReleaseConnection();
	}
}
