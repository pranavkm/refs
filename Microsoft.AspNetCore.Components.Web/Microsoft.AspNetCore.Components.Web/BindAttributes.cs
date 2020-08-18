namespace Microsoft.AspNetCore.Components.Web
{
	/// <summary>
	/// Infrastructure for the discovery of <c>bind</c> attributes for markup elements.
	/// </summary>
	/// <remarks>
	/// To extend the set of <c>bind</c> attributes, define a public class named
	/// <c>BindAttributes</c> and annotate it with the appropriate attributes.
	/// </remarks>
	[BindInputElement(null, null, "value", "onchange", false, null)]
	[BindInputElement(null, "value", "value", "onchange", false, null)]
	[BindInputElement("checkbox", null, "checked", "onchange", false, null)]
	[BindInputElement("text", null, "value", "onchange", false, null)]
	[BindInputElement("number", null, "value", "onchange", true, null)]
	[BindInputElement("number", "value", "value", "onchange", true, null)]
	[BindInputElement("date", null, "value", "onchange", true, "yyyy-MM-dd")]
	[BindInputElement("date", "value", "value", "onchange", true, "yyyy-MM-dd")]
	[BindInputElement("datetime-local", null, "value", "onchange", true, "yyyy-MM-ddTHH:mm:ss")]
	[BindInputElement("datetime-local", "value", "value", "onchange", true, "yyyy-MM-ddTHH:mm:ss")]
	[BindInputElement("month", null, "value", "onchange", true, "yyyy-MM")]
	[BindInputElement("month", "value", "value", "onchange", true, "yyyy-MM")]
	[BindInputElement("time", null, "value", "onchange", true, "HH:mm:ss")]
	[BindInputElement("time", "value", "value", "onchange", true, "HH:mm:ss")]
	[BindElement("select", null, "value", "onchange")]
	[BindElement("textarea", null, "value", "onchange")]
	public static class BindAttributes
	{
	}
}
