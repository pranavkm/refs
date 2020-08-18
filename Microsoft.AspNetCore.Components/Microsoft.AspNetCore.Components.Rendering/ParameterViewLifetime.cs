namespace Microsoft.AspNetCore.Components.Rendering
{
	internal readonly struct ParameterViewLifetime
	{
		private readonly RenderBatchBuilder _owner;

		private readonly int _stamp;

		public static readonly ParameterViewLifetime Unbound;

		public ParameterViewLifetime(RenderBatchBuilder owner)
		{
			throw null;
		}

		public void AssertNotExpired()
		{
			throw null;
		}
	}
}
