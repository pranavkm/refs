using Microsoft.AspNetCore.Routing.Patterns;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Routing.Template
{
	[DebuggerDisplay("{DebuggerToString()}")]
	public class TemplatePart
	{
		public bool IsCatchAll
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public bool IsLiteral
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public bool IsParameter
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public bool IsOptional
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public bool IsOptionalSeperator
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			set
			{
				throw null;
			}
		}

		public string? Name
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public string? Text
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public object? DefaultValue
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public IEnumerable<InlineConstraint> InlineConstraints
		{
			[System.Runtime.CompilerServices.NullableContext(1)]
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public TemplatePart()
		{
			throw null;
		}

		[System.Runtime.CompilerServices.NullableContext(1)]
		public TemplatePart(RoutePatternPart other)
		{
			throw null;
		}

		public static TemplatePart CreateLiteral(string text)
		{
			throw null;
		}

		public static TemplatePart CreateParameter(string name, bool isCatchAll, bool isOptional, object? defaultValue, IEnumerable<InlineConstraint>? inlineConstraints)
		{
			throw null;
		}

		internal string? DebuggerToString()
		{
			throw null;
		}

		public RoutePatternPart ToRoutePatternPart()
		{
			throw null;
		}
	}
}
