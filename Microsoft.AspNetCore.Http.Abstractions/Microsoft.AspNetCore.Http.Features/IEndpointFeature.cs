namespace Microsoft.AspNetCore.Http.Features
{
	/// <summary>
	/// A feature interface for endpoint routing. Use <see cref="P:Microsoft.AspNetCore.Http.HttpContext.Features" />
	/// to access an instance associated with the current request.
	/// </summary>
	public interface IEndpointFeature
	{
		/// <summary>
		/// Gets or sets the selected <see cref="T:Microsoft.AspNetCore.Http.Endpoint" /> for the current
		/// request.
		/// </summary>
		Endpoint? Endpoint
		{
			get;
			set;
		}
	}
}
