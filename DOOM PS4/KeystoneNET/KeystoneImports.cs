// KeystoneImports
using System;
using System.IO;
using System.Runtime.InteropServices;

internal class KeystoneImports
{
	static KeystoneImports()
	{
		string directoryName = Path.GetDirectoryName(new Uri(typeof(KeystoneImports).Assembly.CodeBase).LocalPath);
		string str = (IntPtr.Size == 8) ? "\\win64\\" : "\\win32\\";
		string text = directoryName + str + "keystone.dll";
		if (File.Exists(text))
		{
			LoadLibrary(text);
		}
	}

	[DllImport("kernel32.dll")]
	private static extern IntPtr LoadLibrary(string dllToLoad);

	[DllImport("keystone.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ks_version")]
	internal static extern uint Version(ref uint major, ref uint minor);

	[DllImport("keystone.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ks_open")]
	internal static extern KeystoneError Open(KeystoneArchitecture arch, int mode, ref IntPtr ks);

	[DllImport("keystone.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ks_close")]
	internal static extern KeystoneError Close(IntPtr ks);

	[DllImport("keystone.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ks_free")]
	internal static extern void Free(IntPtr buffer);

	[DllImport("keystone.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ks_strerror")]
	internal static extern IntPtr ErrorToString(KeystoneError code);

	[DllImport("keystone.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ks_errno")]
	internal static extern KeystoneError GetLastKeystoneError(IntPtr ks);

	[DllImport("keystone.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ks_arch_supported")]
	internal static extern bool IsArchitectureSupported(KeystoneArchitecture arch);

	[DllImport("keystone.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ks_option")]
	internal static extern KeystoneError SetOption(IntPtr ks, KeystoneOptionType type, IntPtr value);

	[DllImport("keystone.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ks_asm")]
	internal static extern int Assemble(IntPtr ks, [MarshalAs(UnmanagedType.LPStr)] string toEncode, ulong baseAddress, out IntPtr encoding, out uint size, out uint statements);
}
