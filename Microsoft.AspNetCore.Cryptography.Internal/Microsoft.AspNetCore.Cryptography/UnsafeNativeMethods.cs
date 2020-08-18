using Microsoft.AspNetCore.Cryptography.Cng;
using Microsoft.AspNetCore.Cryptography.SafeHandles;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;

namespace Microsoft.AspNetCore.Cryptography
{
	[SuppressUnmanagedCodeSecurity]
	internal static class UnsafeNativeMethods
	{
		[DllImport("bcrypt.dll")]
		internal static extern int BCryptCloseAlgorithmProvider([In] IntPtr hAlgorithm, [In] uint dwFlags);

		[DllImport("bcrypt.dll")]
		internal unsafe static extern int BCryptCreateHash([In] BCryptAlgorithmHandle hAlgorithm, out BCryptHashHandle phHash, [In] IntPtr pbHashObject, [In] uint cbHashObject, [In] byte* pbSecret, [In] uint cbSecret, [In] uint dwFlags);

		[DllImport("bcrypt.dll")]
		internal unsafe static extern int BCryptDecrypt([In] BCryptKeyHandle hKey, [In] byte* pbInput, [In] uint cbInput, [In] void* pPaddingInfo, [In] byte* pbIV, [In] uint cbIV, [In] byte* pbOutput, [In] uint cbOutput, out uint pcbResult, [In] BCryptEncryptFlags dwFlags);

		[DllImport("bcrypt.dll")]
		internal unsafe static extern int BCryptDeriveKeyPBKDF2([In] BCryptAlgorithmHandle hPrf, [In] byte* pbPassword, [In] uint cbPassword, [In] byte* pbSalt, [In] uint cbSalt, [In] ulong cIterations, [In] byte* pbDerivedKey, [In] uint cbDerivedKey, [In] uint dwFlags);

		[DllImport("bcrypt.dll")]
		internal static extern int BCryptDestroyHash([In] IntPtr hHash);

		[DllImport("bcrypt.dll")]
		internal static extern int BCryptDestroyKey([In] IntPtr hKey);

		[DllImport("bcrypt.dll")]
		internal static extern int BCryptDuplicateHash([In] BCryptHashHandle hHash, out BCryptHashHandle phNewHash, [In] IntPtr pbHashObject, [In] uint cbHashObject, [In] uint dwFlags);

		[DllImport("bcrypt.dll")]
		internal unsafe static extern int BCryptEncrypt([In] BCryptKeyHandle hKey, [In] byte* pbInput, [In] uint cbInput, [In] void* pPaddingInfo, [In] byte* pbIV, [In] uint cbIV, [In] byte* pbOutput, [In] uint cbOutput, out uint pcbResult, [In] BCryptEncryptFlags dwFlags);

		[DllImport("bcrypt.dll")]
		internal unsafe static extern int BCryptFinishHash([In] BCryptHashHandle hHash, [In] byte* pbOutput, [In] uint cbOutput, [In] uint dwFlags);

		[DllImport("bcrypt.dll")]
		internal unsafe static extern int BCryptGenerateSymmetricKey([In] BCryptAlgorithmHandle hAlgorithm, out BCryptKeyHandle phKey, [In] IntPtr pbKeyObject, [In] uint cbKeyObject, [In] byte* pbSecret, [In] uint cbSecret, [In] uint dwFlags);

		[DllImport("bcrypt.dll")]
		internal unsafe static extern int BCryptGenRandom([In] IntPtr hAlgorithm, [In] byte* pbBuffer, [In] uint cbBuffer, [In] BCryptGenRandomFlags dwFlags);

		[DllImport("bcrypt.dll")]
		internal unsafe static extern int BCryptGetProperty([In] BCryptHandle hObject, [In] [MarshalAs(UnmanagedType.LPWStr)] string pszProperty, [In] void* pbOutput, [In] uint cbOutput, out uint pcbResult, [In] uint dwFlags);

		[DllImport("bcrypt.dll")]
		internal unsafe static extern int BCryptHashData([In] BCryptHashHandle hHash, [In] byte* pbInput, [In] uint cbInput, [In] uint dwFlags);

		[DllImport("bcrypt.dll")]
		internal unsafe static extern int BCryptKeyDerivation([In] BCryptKeyHandle hKey, [In] BCryptBufferDesc* pParameterList, [In] byte* pbDerivedKey, [In] uint cbDerivedKey, out uint pcbResult, [In] uint dwFlags);

		[DllImport("bcrypt.dll")]
		internal static extern int BCryptOpenAlgorithmProvider(out BCryptAlgorithmHandle phAlgorithm, [In] [MarshalAs(UnmanagedType.LPWStr)] string pszAlgId, [In] [MarshalAs(UnmanagedType.LPWStr)] string pszImplementation, [In] uint dwFlags);

		[DllImport("bcrypt.dll")]
		internal unsafe static extern int BCryptSetProperty([In] BCryptHandle hObject, [In] [MarshalAs(UnmanagedType.LPWStr)] string pszProperty, [In] void* pbInput, [In] uint cbInput, [In] uint dwFlags);

		[DllImport("crypt32.dll", SetLastError = true)]
		internal unsafe static extern bool CryptProtectData([In] DATA_BLOB* pDataIn, [In] IntPtr szDataDescr, [In] DATA_BLOB* pOptionalEntropy, [In] IntPtr pvReserved, [In] IntPtr pPromptStruct, [In] uint dwFlags, out DATA_BLOB pDataOut);

		[DllImport("crypt32.dll", SetLastError = true)]
		public static extern bool CryptProtectMemory([In] SafeHandle pData, [In] uint cbData, [In] uint dwFlags);

		[DllImport("crypt32.dll", SetLastError = true)]
		internal unsafe static extern bool CryptUnprotectData([In] DATA_BLOB* pDataIn, [In] IntPtr ppszDataDescr, [In] DATA_BLOB* pOptionalEntropy, [In] IntPtr pvReserved, [In] IntPtr pPromptStruct, [In] uint dwFlags, out DATA_BLOB pDataOut);

		[DllImport("crypt32.dll", SetLastError = true)]
		public unsafe static extern bool CryptUnprotectMemory([In] byte* pData, [In] uint cbData, [In] uint dwFlags);

		[DllImport("crypt32.dll", SetLastError = true)]
		public static extern bool CryptUnprotectMemory([In] SafeHandle pData, [In] uint cbData, [In] uint dwFlags);

		[DllImport("ncrypt.dll")]
		internal static extern int NCryptCloseProtectionDescriptor([In] IntPtr hDescriptor);

		[DllImport("ncrypt.dll")]
		internal static extern int NCryptCreateProtectionDescriptor([In] [MarshalAs(UnmanagedType.LPWStr)] string pwszDescriptorString, [In] uint dwFlags, out NCryptDescriptorHandle phDescriptor);

		[DllImport("ncrypt.dll")]
		internal static extern int NCryptGetProtectionDescriptorInfo([In] NCryptDescriptorHandle hDescriptor, [In] IntPtr pMemPara, [In] uint dwInfoType, out LocalAllocHandle ppvInfo);

		[DllImport("ncrypt.dll")]
		internal unsafe static extern int NCryptProtectSecret([In] NCryptDescriptorHandle hDescriptor, [In] uint dwFlags, [In] byte* pbData, [In] uint cbData, [In] IntPtr pMemPara, [In] IntPtr hWnd, out LocalAllocHandle ppbProtectedBlob, out uint pcbProtectedBlob);

		[DllImport("ncrypt.dll")]
		internal unsafe static extern int NCryptUnprotectSecret([In] IntPtr phDescriptor, [In] uint dwFlags, [In] byte* pbProtectedBlob, [In] uint cbProtectedBlob, [In] IntPtr pMemPara, [In] IntPtr hWnd, out LocalAllocHandle ppbData, out uint pcbData);

		[DllImport("ncrypt.dll")]
		internal unsafe static extern int NCryptUnprotectSecret(out NCryptDescriptorHandle phDescriptor, [In] uint dwFlags, [In] byte* pbProtectedBlob, [In] uint cbProtectedBlob, [In] IntPtr pMemPara, [In] IntPtr hWnd, out LocalAllocHandle ppbData, out uint pcbData);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void ThrowExceptionForBCryptStatus(int ntstatus)
		{
			throw null;
		}

		public static void ThrowExceptionForLastCrypt32Error()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void ThrowExceptionForNCryptStatus(int ntstatus)
		{
			throw null;
		}
	}
}
