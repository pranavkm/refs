using System;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.DiagnosticsViewPage.Views
{
	internal class AttributeValue
	{
		public string Prefix
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public object Value
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public bool Literal
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public AttributeValue(string prefix, object value, bool literal)
		{
			throw null;
		}

		public static AttributeValue FromTuple(Tuple<string, object, bool> value)
		{
			throw null;
		}

		public static AttributeValue FromTuple(Tuple<string, string, bool> value)
		{
			throw null;
		}

		public static implicit operator AttributeValue(Tuple<string, object, bool> value)
		{
			throw null;
		}
	}
}
