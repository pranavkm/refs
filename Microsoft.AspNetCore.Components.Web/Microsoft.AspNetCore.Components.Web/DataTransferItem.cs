using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Components.Web
{
	/// <summary>
	/// The <see cref="T:Microsoft.AspNetCore.Components.Web.DataTransferItem" /> object represents one drag data item.
	/// During a drag operation, each drag event has a dataTransfer property which contains a list of drag data items.
	/// Each item in the list is a <see cref="T:Microsoft.AspNetCore.Components.Web.DataTransferItem" /> object.
	/// </summary>
	public class DataTransferItem
	{
		/// <summary>
		/// The kind of drag data item, string or file
		/// </summary>
		public string Kind
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

		/// <summary>
		/// The drag data item's type, typically a MIME type
		/// </summary>
		public string Type
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

		public DataTransferItem()
		{
			throw null;
		}
	}
}
