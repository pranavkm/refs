using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Microsoft.Extensions.Internal
{
	internal class PropertyHelper
	{
		private delegate TValue ByRefFunc<TDeclaringType, TValue>(ref TDeclaringType arg);

		/// <summary>
		/// Gets the backing <see cref="T:System.Reflection.PropertyInfo" />.
		/// </summary>
		public PropertyInfo Property
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets (or sets in derived types) the property name.
		/// </summary>
		public virtual string Name
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

		/// <summary>
		/// Gets the property value getter.
		/// </summary>
		public Func<object, object> ValueGetter
		{
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets the property value setter.
		/// </summary>
		public Action<object, object> ValueSetter
		{
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Initializes a fast <see cref="T:Microsoft.Extensions.Internal.PropertyHelper" />.
		/// This constructor does not cache the helper. For caching, use <see cref="M:Microsoft.Extensions.Internal.PropertyHelper.GetProperties(System.Type)" />.
		/// </summary>
		public PropertyHelper(PropertyInfo property)
		{
			throw null;
		}

		/// <summary>
		/// Returns the property value for the specified <paramref name="instance" />.
		/// </summary>
		/// <param name="instance">The object whose property value will be returned.</param>
		/// <returns>The property value.</returns>
		public object GetValue(object instance)
		{
			throw null;
		}

		/// <summary>
		/// Sets the property value for the specified <paramref name="instance" />.
		/// </summary>
		/// <param name="instance">The object whose property value will be set.</param>
		/// <param name="value">The property value.</param>
		public void SetValue(object instance, object value)
		{
			throw null;
		}

		/// <summary>
		/// Creates and caches fast property helpers that expose getters for every public get property on the
		/// underlying type.
		/// </summary>
		/// <param name="typeInfo">The type info to extract property accessors for.</param>
		/// <returns>A cached array of all public properties of the specified type.
		/// </returns>
		public static PropertyHelper[] GetProperties(TypeInfo typeInfo)
		{
			throw null;
		}

		/// <summary>
		/// Creates and caches fast property helpers that expose getters for every public get property on the
		/// specified type.
		/// </summary>
		/// <param name="type">The type to extract property accessors for.</param>
		/// <returns>A cached array of all public properties of the specified type.
		/// </returns>
		public static PropertyHelper[] GetProperties(Type type)
		{
			throw null;
		}

		/// <summary>
		/// <para>
		/// Creates and caches fast property helpers that expose getters for every non-hidden get property
		/// on the specified type.
		/// </para>
		/// <para>
		/// <see cref="M:GetVisibleProperties" /> excludes properties defined on base types that have been
		/// hidden by definitions using the <c>new</c> keyword.
		/// </para>
		/// </summary>
		/// <param name="typeInfo">The type info to extract property accessors for.</param>
		/// <returns>
		/// A cached array of all public properties of the specified type.
		/// </returns>
		public static PropertyHelper[] GetVisibleProperties(TypeInfo typeInfo)
		{
			throw null;
		}

		/// <summary>
		/// <para>
		/// Creates and caches fast property helpers that expose getters for every non-hidden get property
		/// on the specified type.
		/// </para>
		/// <para>
		/// <see cref="M:GetVisibleProperties" /> excludes properties defined on base types that have been
		/// hidden by definitions using the <c>new</c> keyword.
		/// </para>
		/// </summary>
		/// <param name="type">The type to extract property accessors for.</param>
		/// <returns>
		/// A cached array of all public properties of the specified type.
		/// </returns>
		public static PropertyHelper[] GetVisibleProperties(Type type)
		{
			throw null;
		}

		/// <summary>
		/// Creates a single fast property getter. The result is not cached.
		/// </summary>
		/// <param name="propertyInfo">propertyInfo to extract the getter for.</param>
		/// <returns>a fast getter.</returns>
		/// <remarks>
		/// This method is more memory efficient than a dynamically compiled lambda, and about the
		/// same speed.
		/// </remarks>
		public static Func<object, object> MakeFastPropertyGetter(PropertyInfo propertyInfo)
		{
			throw null;
		}

		/// <summary>
		/// Creates a single fast property getter which is safe for a null input object. The result is not cached.
		/// </summary>
		/// <param name="propertyInfo">propertyInfo to extract the getter for.</param>
		/// <returns>a fast getter.</returns>
		/// <remarks>
		/// This method is more memory efficient than a dynamically compiled lambda, and about the
		/// same speed.
		/// </remarks>
		public static Func<object, object> MakeNullSafeFastPropertyGetter(PropertyInfo propertyInfo)
		{
			throw null;
		}

		/// <summary>
		/// Creates a single fast property setter for reference types. The result is not cached.
		/// </summary>
		/// <param name="propertyInfo">propertyInfo to extract the setter for.</param>
		/// <returns>a fast getter.</returns>
		/// <remarks>
		/// This method is more memory efficient than a dynamically compiled lambda, and about the
		/// same speed. This only works for reference types.
		/// </remarks>
		public static Action<object, object> MakeFastPropertySetter(PropertyInfo propertyInfo)
		{
			throw null;
		}

		/// <summary>
		/// Given an object, adds each instance property with a public get method as a key and its
		/// associated value to a dictionary.
		///
		/// If the object is already an <see cref="T:System.Collections.Generic.IDictionary`2" /> instance, then a copy
		/// is returned.
		/// </summary>
		/// <remarks>
		/// The implementation of PropertyHelper will cache the property accessors per-type. This is
		/// faster when the same type is used multiple times with ObjectToDictionary.
		/// </remarks>
		public static IDictionary<string, object> ObjectToDictionary(object value)
		{
			throw null;
		}

		protected static PropertyHelper[] GetVisibleProperties(Type type, Func<PropertyInfo, PropertyHelper> createPropertyHelper, ConcurrentDictionary<Type, PropertyHelper[]> allPropertiesCache, ConcurrentDictionary<Type, PropertyHelper[]> visiblePropertiesCache)
		{
			throw null;
		}

		protected static PropertyHelper[] GetProperties(Type type, Func<PropertyInfo, PropertyHelper> createPropertyHelper, ConcurrentDictionary<Type, PropertyHelper[]> cache)
		{
			throw null;
		}
	}
}
