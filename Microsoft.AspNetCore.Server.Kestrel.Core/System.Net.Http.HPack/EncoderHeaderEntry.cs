using System.Diagnostics;

namespace System.Net.Http.HPack
{
	[DebuggerDisplay("Name = {Name} Value = {Value}")]
	internal class EncoderHeaderEntry
	{
		public string Name;

		public string Value;

		public EncoderHeaderEntry Next;

		public int Hash;

		public int Index;

		public EncoderHeaderEntry Before;

		public EncoderHeaderEntry After;

		/// <summary>
		/// Initialize header values. An entry will be reinitialized when reused.
		/// </summary>
		public void Initialize(int hash, string name, string value, int index, EncoderHeaderEntry next)
		{
			throw null;
		}

		public uint CalculateSize()
		{
			throw null;
		}

		/// <summary>
		/// Remove entry from the linked list and reset header values.
		/// </summary>
		public void Remove()
		{
			throw null;
		}

		/// <summary>
		/// Add before an entry in the linked list.
		/// </summary>
		public void AddBefore(EncoderHeaderEntry existingEntry)
		{
			throw null;
		}

		public EncoderHeaderEntry()
		{
			throw null;
		}
	}
}
