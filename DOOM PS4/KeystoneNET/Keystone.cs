// Keystone
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;

public class Keystone : IDisposable
{
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	private delegate bool ResolverInternal(IntPtr symbol, ref ulong value);

	public delegate bool Resolver(string symbol, ref ulong value);

	private IntPtr engine = IntPtr.Zero;

	private bool throwOnError;

	private bool addedResolveSymbol;

	private ResolverInternal internalImpl;

	private List<Resolver> resolvers = new List<Resolver>();

	public event Resolver ResolveSymbol
	{
		add
		{
			resolvers.Add(value);
			if (!addedResolveSymbol)
			{
				KeystoneImports.SetOption(engine, KeystoneOptionType.KS_OPT_SYM_RESOLVER, Marshal.GetFunctionPointerForDelegate((Delegate)internalImpl));
				addedResolveSymbol = true;
			}
		}
		remove
		{
			resolvers.Remove(value);
			if (addedResolveSymbol && resolvers.Count == 0)
			{
				KeystoneImports.SetOption(engine, KeystoneOptionType.KS_OPT_SYM_RESOLVER, IntPtr.Zero);
				addedResolveSymbol = false;
			}
		}
	}

	private bool SymbolResolver(IntPtr symbolPtr, ref ulong value)
	{
		string symbol = Marshal.PtrToStringAnsi(symbolPtr);
		foreach (Resolver resolver in resolvers)
		{
			if (resolver(symbol, ref value))
			{
				return true;
			}
		}
		return false;
	}

	public Keystone(KeystoneArchitecture architecture, KeystoneMode mode, bool throwOnKeystoneError = true)
	{
		internalImpl = this.SymbolResolver;
		throwOnError = throwOnKeystoneError;
		KeystoneError keystoneError = KeystoneImports.Open(architecture, (int)mode, ref engine);
		if (keystoneError != 0 && throwOnKeystoneError)
		{
			throw new InvalidOperationException($"Error while initializing keystone: {ErrorToString(keystoneError)}");
		}
	}

	public bool SetOption(KeystoneOptionType type, uint value)
	{
		KeystoneError keystoneError = KeystoneImports.SetOption(engine, type, (IntPtr)(long)value);
		if (keystoneError != 0)
		{
			if (throwOnError)
			{
				throw new InvalidOperationException($"Error while setting option in keystone: {ErrorToString(keystoneError)}");
			}
			return false;
		}
		return true;
	}

	public static string ErrorToString(KeystoneError result)
	{
		IntPtr intPtr = KeystoneImports.ErrorToString(result);
		if (intPtr != IntPtr.Zero)
		{
			return Marshal.PtrToStringAnsi(intPtr);
		}
		return string.Empty;
	}

	public KeystoneEncoded Assemble(string toEncode, ulong address)
	{
		if (KeystoneImports.Assemble(engine, toEncode, address, out IntPtr encoding, out uint size, out uint statements) != 0)
		{
			if (throwOnError)
			{
				throw new InvalidOperationException($"Error while assembling {toEncode}: {ErrorToString(GetLastKeystoneError())}");
			}
			return null;
		}
		byte[] array = new byte[size];
		Marshal.Copy(encoding, array, 0, (int)size);
		KeystoneImports.Free(encoding);
		return new KeystoneEncoded(array, statements, address);
	}

	public bool AppendAssemble(string toEncode, ICollection<byte> encoded, ulong address, out int size, out uint statements)
	{
		if (encoded == null)
		{
			throw new ArgumentNullException("encoded");
		}
		if (toEncode == null)
		{
			throw new ArgumentNullException("toEncode");
		}
		if (encoded.IsReadOnly)
		{
			throw new ArgumentException("encoded collection can't be read-only.");
		}
		KeystoneEncoded keystoneEncoded = Assemble(toEncode, address);
		if (keystoneEncoded != null)
		{
			byte[] buffer = keystoneEncoded.Buffer;
			foreach (byte item in buffer)
			{
				encoded.Add(item);
			}
			size = keystoneEncoded.Buffer.Length;
			statements = keystoneEncoded.StatementCount;
			return true;
		}
		size = 0;
		statements = 0u;
		return false;
	}

	public bool AppendAssemble(string toEncode, ICollection<byte> encoded, ulong address, out int size)
	{
		uint statements;
		return AppendAssemble(toEncode, encoded, address, out size, out statements);
	}

	public bool AppendAssemble(string toEncode, ICollection<byte> encoded, ulong address)
	{
		int size;
		uint statements;
		return AppendAssemble(toEncode, encoded, address, out size, out statements);
	}

	public bool AppendAssemble(string toEncode, ICollection<byte> encoded)
	{
		int size;
		uint statements;
		return AppendAssemble(toEncode, encoded, 0uL, out size, out statements);
	}

	public KeystoneError GetLastKeystoneError()
	{
		return KeystoneImports.GetLastKeystoneError(engine);
	}

	public static bool IsArchitectureSupported(KeystoneArchitecture architecture)
	{
		return KeystoneImports.IsArchitectureSupported(architecture);
	}

	public static uint GetKeystoneVersion(ref uint major, ref uint minor)
	{
		return KeystoneImports.Version(ref major, ref minor);
	}

	public void Dispose()
	{
		IntPtr intPtr = Interlocked.Exchange(ref engine, IntPtr.Zero);
		if (intPtr != IntPtr.Zero)
		{
			KeystoneImports.Close(intPtr);
		}
		GC.SuppressFinalize(this);
	}
}
