using Microsoft.AspNetCore.Components.Routing;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Components
{
	/// <summary>
	/// Resolves components for an application.
	/// </summary>
	internal static class RouteTableFactory
	{
		private readonly struct Key : IEquatable<Key>
		{
			public readonly Assembly[] Assemblies;

			[System.Runtime.CompilerServices.NullableContext(1)]
			public Key(Assembly[] assemblies)
			{
				throw null;
			}

			public override bool Equals(object? obj)
			{
				throw null;
			}

			public bool Equals(Key other)
			{
				throw null;
			}

			public override int GetHashCode()
			{
				throw null;
			}
		}

		public static readonly IComparer<RouteEntry> RoutePrecedence;

		public static RouteTable Create(IEnumerable<Assembly> assemblies)
		{
			throw null;
		}

		internal static RouteTable Create(IEnumerable<Type> componentTypes)
		{
			throw null;
		}

		internal static RouteTable Create(Dictionary<Type, string[]> templatesByHandler)
		{
			throw null;
		}

		/// <summary>
		/// Route precedence algorithm.
		/// We collect all the routes and sort them from most specific to
		/// less specific. The specificity of a route is given by the specificity
		/// of its segments and the position of those segments in the route.
		/// * A literal segment is more specific than a parameter segment.
		/// * A parameter segment with more constraints is more specific than one with fewer constraints
		/// * Segment earlier in the route are evaluated before segments later in the route.
		/// For example:
		/// /Literal is more specific than /Parameter
		/// /Route/With/{parameter} is more specific than /{multiple}/With/{parameters}
		/// /Product/{id:int} is more specific than /Product/{id}
		///
		/// Routes can be ambiguous if:
		/// They are composed of literals and those literals have the same values (case insensitive)
		/// They are composed of a mix of literals and parameters, in the same relative order and the
		/// literals have the same values.
		/// For example:
		/// * /literal and /Literal
		/// /{parameter}/literal and /{something}/literal
		/// /{parameter:constraint}/literal and /{something:constraint}/literal
		///
		/// To calculate the precedence we sort the list of routes as follows:
		/// * Shorter routes go first.
		/// * A literal wins over a parameter in precedence.
		/// * For literals with different values (case insensitive) we choose the lexical order
		/// * For parameters with different numbers of constraints, the one with more wins
		/// If we get to the end of the comparison routing we've detected an ambiguous pair of routes.
		/// </summary>
		internal static int RouteComparison(RouteEntry x, RouteEntry y)
		{
			throw null;
		}
	}
}
