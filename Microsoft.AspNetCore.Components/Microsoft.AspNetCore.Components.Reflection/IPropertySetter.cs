namespace Microsoft.AspNetCore.Components.Reflection
{
	internal interface IPropertySetter
	{
		bool Cascading
		{
			get;
		}

		void SetValue(object target, object value);
	}
}
