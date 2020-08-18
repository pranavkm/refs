using Microsoft.AspNetCore.Routing.Patterns;

namespace Microsoft.AspNetCore.Routing.Template
{
	/// <summary>
	/// A factory used to create <see cref="T:Microsoft.AspNetCore.Routing.Template.TemplateBinder" /> instances.
	/// </summary>
	public abstract class TemplateBinderFactory
	{
		/// <summary>
		/// Creates a new <see cref="T:Microsoft.AspNetCore.Routing.Template.TemplateBinder" /> from the provided <paramref name="template" /> and
		/// <paramref name="defaults" />.
		/// </summary>
		/// <param name="template">The route template.</param>
		/// <param name="defaults">A collection of extra default values that do not appear in the route template.</param>
		/// <returns>A <see cref="T:Microsoft.AspNetCore.Routing.Template.TemplateBinder" />.</returns>
		public abstract TemplateBinder Create(RouteTemplate template, RouteValueDictionary defaults);

		/// <summary>
		/// Creates a new <see cref="T:Microsoft.AspNetCore.Routing.Template.TemplateBinder" /> from the provided <paramref name="pattern" />.
		/// </summary>
		/// <param name="pattern">The <see cref="T:Microsoft.AspNetCore.Routing.Patterns.RoutePattern" />.</param>
		/// <returns>A <see cref="T:Microsoft.AspNetCore.Routing.Template.TemplateBinder" />.</returns>
		public abstract TemplateBinder Create(RoutePattern pattern);

		protected TemplateBinderFactory()
		{
			throw null;
		}
	}
}
