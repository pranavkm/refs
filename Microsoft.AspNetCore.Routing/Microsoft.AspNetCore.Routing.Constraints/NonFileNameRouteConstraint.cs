using Microsoft.AspNetCore.Http;

namespace Microsoft.AspNetCore.Routing.Constraints
{
	/// <summary>
	/// Constrains a route parameter to represent only non-file-name values. Does not validate that
	/// the route value contains valid file system characters, or that the value represents
	/// an actual file on disk.
	/// </summary>
	/// <remarks>
	/// <para>
	/// This constraint can be used to disambiguate requests for dynamic content versus
	/// static files served from the application.
	/// </para>
	/// <para>
	/// This constraint determines whether a route value represents a file name by examining
	/// the last URL Path segment of the value (delimited by <c>/</c>). The last segment
	/// must contain the dot (<c>.</c>) character followed by one or more non-(<c>.</c>) characters.
	/// </para>
	/// <para>
	/// If the route value does not contain a <c>/</c> then the entire value will be interpreted
	/// as a the last segment.
	/// </para>
	/// <para>
	/// The <see cref="T:Microsoft.AspNetCore.Routing.Constraints.NonFileNameRouteConstraint" /> does not attempt to validate that the value contains
	/// a legal file name for the current operating system.
	/// </para>
	/// <para>
	/// <list type="bullet">  
	///     <listheader>  
	///         <term>Examples of route values that will be matched as non-file-names</term>  
	///         <description>description</description>  
	///     </listheader>  
	///     <item>  
	///         <term><c>/a/b/c</c></term>  
	///         <description>Final segment does not contain a <c>.</c>.</description>  
	///     </item>
	///     <item>  
	///         <term><c>/a/b.d/c</c></term>  
	///         <description>Final segment does not contain a <c>.</c>.</description>  
	///     </item>
	///     <item>  
	///         <term><c>/a/b.d/c/</c></term>  
	///         <description>Final segment is empty.</description>  
	///     </item>
	///     <item>  
	///         <term><c></c></term>  
	///         <description>Value is empty</description>  
	///     </item>
	/// </list>
	/// <list type="bullet">  
	///     <listheader>  
	///         <term>Examples of route values that will be rejected as file names</term>  
	///         <description>description</description>  
	///     </listheader>  
	///     <item>  
	///         <term><c>/a/b/c.txt</c></term>  
	///         <description>Final segment contains a <c>.</c> followed by other characters.</description>  
	///     </item>
	///     <item>  
	///         <term><c>/hello.world.txt</c></term>  
	///         <description>Final segment contains a <c>.</c> followed by other characters.</description>  
	///     </item>
	///     <item>  
	///         <term><c>hello.world.txt</c></term>  
	///         <description>Final segment contains a <c>.</c> followed by other characters.</description>  
	///     </item>
	///     <item>  
	///         <term><c>.gitignore</c></term>  
	///         <description>Final segment contains a <c>.</c> followed by other characters.</description>  
	///     </item> 
	/// </list>
	/// </para>
	/// </remarks>
	public class NonFileNameRouteConstraint : IRouteConstraint, IParameterPolicy
	{
		/// <inheritdoc />
		public bool Match(HttpContext? httpContext, IRouter? route, string routeKey, RouteValueDictionary values, RouteDirection routeDirection)
		{
			throw null;
		}

		public NonFileNameRouteConstraint()
		{
			throw null;
		}
	}
}
