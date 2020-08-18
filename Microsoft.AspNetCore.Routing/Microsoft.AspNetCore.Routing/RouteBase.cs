using Microsoft.AspNetCore.Routing.Template;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Routing
{
	public abstract class RouteBase : IRouter, INamedRouter
	{
		public virtual IDictionary<string, IRouteConstraint> Constraints
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			protected set
			{
				throw null;
			}
		}

		protected virtual IInlineConstraintResolver ConstraintResolver
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

		public virtual RouteValueDictionary DataTokens
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			protected set
			{
				throw null;
			}
		}

		public virtual RouteValueDictionary Defaults
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			protected set
			{
				throw null;
			}
		}

		public virtual string? Name
		{
			[System.Runtime.CompilerServices.NullableContext(2)]
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[System.Runtime.CompilerServices.NullableContext(2)]
			[CompilerGenerated]
			protected set
			{
				throw null;
			}
		}

		public virtual RouteTemplate ParsedTemplate
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			protected set
			{
				throw null;
			}
		}

		[System.Runtime.CompilerServices.NullableContext(2)]
		public RouteBase(string? template, string? name, IInlineConstraintResolver constraintResolver, RouteValueDictionary? defaults, IDictionary<string, object>? constraints, RouteValueDictionary? dataTokens)
		{
			throw null;
		}

		protected abstract Task OnRouteMatched(RouteContext context);

		protected abstract VirtualPathData? OnVirtualPathGenerated(VirtualPathContext context);

		/// <inheritdoc />
		public virtual Task RouteAsync(RouteContext context)
		{
			throw null;
		}

		/// <inheritdoc />
		public virtual VirtualPathData? GetVirtualPath(VirtualPathContext context)
		{
			throw null;
		}

		protected static IDictionary<string, IRouteConstraint> GetConstraints(IInlineConstraintResolver inlineConstraintResolver, RouteTemplate parsedTemplate, IDictionary<string, object>? constraints)
		{
			throw null;
		}

		protected static RouteValueDictionary GetDefaults(RouteTemplate parsedTemplate, RouteValueDictionary? defaults)
		{
			throw null;
		}

		public override string ToString()
		{
			throw null;
		}
	}
}
