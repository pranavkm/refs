using System;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Microsoft.JSInterop.Infrastructure
{
	internal sealed class DotNetObjectReferenceJsonConverter<TValue> : JsonConverter<DotNetObjectReference<TValue>> where TValue : class
	{
		public JSRuntime JSRuntime
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public DotNetObjectReferenceJsonConverter(JSRuntime jsRuntime)
		{
			throw null;
		}

		public override DotNetObjectReference<TValue> Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			throw null;
		}

		public override void Write(Utf8JsonWriter writer, DotNetObjectReference<TValue> value, JsonSerializerOptions options)
		{
			throw null;
		}
	}
}
