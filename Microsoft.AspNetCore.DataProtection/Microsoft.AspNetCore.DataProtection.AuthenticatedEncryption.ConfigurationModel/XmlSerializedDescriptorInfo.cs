using System;
using System.Runtime.CompilerServices;
using System.Xml.Linq;

namespace Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption.ConfigurationModel
{
	/// <summary>
	/// Wraps an <see cref="T:System.Xml.Linq.XElement" /> that contains the XML-serialized representation of an
	/// <see cref="T:Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption.ConfigurationModel.IAuthenticatedEncryptorDescriptor" /> along with the type that can be used
	/// to deserialize it.
	/// </summary>
	public sealed class XmlSerializedDescriptorInfo
	{
		/// <summary>
		/// The class whose <see cref="M:Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption.ConfigurationModel.IAuthenticatedEncryptorDescriptorDeserializer.ImportFromXml(System.Xml.Linq.XElement)" />
		/// method can be used to deserialize the value stored in <see cref="P:Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption.ConfigurationModel.XmlSerializedDescriptorInfo.SerializedDescriptorElement" />.
		/// </summary>
		public Type DeserializerType
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// An XML-serialized representation of an <see cref="T:Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption.ConfigurationModel.IAuthenticatedEncryptorDescriptor" />.
		/// </summary>
		public XElement SerializedDescriptorElement
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Creates an instance of an <see cref="T:Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption.ConfigurationModel.XmlSerializedDescriptorInfo" />.
		/// </summary>
		/// <param name="serializedDescriptorElement">The XML-serialized form of the <see cref="T:Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption.ConfigurationModel.IAuthenticatedEncryptorDescriptor" />.</param>
		/// <param name="deserializerType">The class whose <see cref="M:Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption.ConfigurationModel.IAuthenticatedEncryptorDescriptorDeserializer.ImportFromXml(System.Xml.Linq.XElement)" />
		/// method can be used to deserialize <paramref name="serializedDescriptorElement" />.</param>
		public XmlSerializedDescriptorInfo(XElement serializedDescriptorElement, Type deserializerType)
		{
			throw null;
		}
	}
}
