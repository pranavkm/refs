using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Microsoft.AspNetCore.Components
{
	internal sealed class ElementReferenceJsonConverter : JsonConverter<ElementReference>
	{
		public ElementReferenceJsonConverter(ElementReferenceContext elementReferenceContext)
		{
			throw null;
		}

		public override ElementReference Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			throw null;
		}

		public override void Write(Utf8JsonWriter writer, ElementReference value, JsonSerializerOptions options)
		{
			throw null;
		}
	}
}
