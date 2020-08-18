namespace Microsoft.AspNetCore.Cors.Infrastructure
{
	/// <summary>
	/// An interface which can be used to identify a type which provides metdata to disable cors for a resource.
	/// </summary>
	public interface IDisableCorsAttribute : ICorsMetadata
	{
	}
}
