using Microsoft.AspNetCore.Routing.Patterns;
using Microsoft.Extensions.ObjectPool;

namespace Microsoft.AspNetCore.Routing.Template
{
	internal sealed class DefaultTemplateBinderFactory : TemplateBinderFactory
	{
		public DefaultTemplateBinderFactory(ParameterPolicyFactory policyFactory, ObjectPool<UriBuildingContext> pool)
		{
			throw null;
		}

		public override TemplateBinder Create(RouteTemplate template, RouteValueDictionary defaults)
		{
			throw null;
		}

		public override TemplateBinder Create(RoutePattern pattern)
		{
			throw null;
		}
	}
}
