using System;
using System.Runtime.InteropServices;

namespace KeystoneEngine
{
    public class Keystone : IDisposable
    {
        private static class NativeMethods
        {
#pragma warning disable IDE1006 // Naming Styles
            /// <summary>
            /// Return combined API version &amp; major and minor version numbers.
            /// </summary>
            /// <param name="major">major number of API version</param>
            /// <param name="minor">minor number of API version</param>
            /// <returns>
            /// hexical number as (major &lt;&lt; 8 | minor), which encodes both major &amp; minor versions.
            /// </returns>
            /// <remarks>
            /// This returned value can be compared with version number made with macro KS_MAKE_VERSION
            /// 
            /// For example, second API version would return 1 in <paramref name="major"/>, and 1 in <paramref name="minor"/>
            /// The return value would be 0x0101
            /// 
            /// NOTE: if you only care about returned value, but not major and minor values, set both <paramref name="major"/> &amp; <paramref name="minor"/> arguments to NULL.
            /// </remarks>
            [DllImport("keystone.dll", CallingConvention = CallingConvention.Cdecl)]
            internal static extern uint ks_version(out uint major, out uint minor);

            /// <summary>
            /// Determine if the given architecture is supported by this library.
            /// </summary>
            /// <param name="arch">architecture type (KS_ARCH_*)</param>
            /// <returns>True if this library supports the given arch.</returns>
            [DllImport("keystone.dll", CallingConvention = CallingConvention.Cdecl)]
            internal static extern bool ks_arch_supported(ks_arch arch);

            /// <summary>
            /// Create new instance of Keystone engine.
            /// </summary>
            /// <param name="arch">architecture type (KS_ARCH_*)</param>
            /// <param name="mode">hardware mode. This is combined of KS_MODE_*</param>
            /// <param name="ks">pointer to ks_engine, which will be updated at return time</param>
            /// <returns><see cref="ks_err.KS_ERR_OK"/> on success, or other value on failure (refer to <see cref="ks_err"/> enum for detailed error).</returns>
            /// <seealso cref="ks_err"/>
            /// <seealso cref="ks_close(IntPtr)"/>
            [DllImport("keystone.dll", CallingConvention = CallingConvention.Cdecl)]
            internal static extern ks_err ks_open(ks_arch arch, ks_mode mode, out IntPtr ks);

            /// <summary>
            /// Close KS instance: MUST do to release the handle when it is not used anymore.</summary>
            /// <param name="ks">pointer to a handle returned by <see cref="ks_open(ks_arch, int, out IntPtr)"/></param>
            /// <returns><see cref="ks_err.KS_ERR_OK"/> on success, or other value on failure (refer to <see cref="ks_err"/> enum for detailed error).</returns>
            /// <seealso cref="ks_err"/>
            /// <seealso cref="ks_open(ks_arch, int, out IntPtr)"/>
            [DllImport("keystone.dll", CallingConvention = CallingConvention.Cdecl)]
            internal static extern ks_err ks_close(IntPtr ks);

            /// <summary>
            /// Report the last error number when some API function fail.
            /// </summary>
            /// <param name="ks">handle returned by <see cref="ks_open(ks_arch, int, out IntPtr)"/></param>
            /// <returns>error code of <see cref="ks_err"/> enum type (KS_ERR_*, see above)</returns>
            /// <remarks>Like glibc's errno, ks_errno might not retain its old error once accessed.</remarks>
            [DllImport("keystone.dll", CallingConvention = CallingConvention.Cdecl)]
            internal static extern ks_err ks_errno(IntPtr ks);

            /// <summary>
            /// Return a string describing given error code.
            /// </summary>
            /// <param name="code">error code (see KS_ERR_* above)</param>
            /// <returns>returns a pointer to a string that describes the error code passed in the argument <paramref name="code"/></returns>
            [DllImport("keystone.dll", CallingConvention = CallingConvention.Cdecl)]
            internal static extern string ks_strerror(ks_err code);

            /// <summary>
            /// Set option for Keystone engine at runtime
            /// </summary>
            /// <param name="ks">handle returned by <see cref="ks_open(ks_arch, int, out IntPtr)"/></param>
            /// <param name="type">type of option to be set. See <see cref="ks_opt_type"/></param>
            /// <param name="value">option value corresponding with <paramref name="type"/></param>
            /// <returns><see cref="ks_err.KS_ERR_OK"/> on success, or other value on failure. Refer to <see cref="ks_err"/> enum for detailed error.</returns>
            [DllImport("keystone.dll", CallingConvention = CallingConvention.Cdecl)]
            internal static extern ks_err ks_option(IntPtr ks, ks_opt_type type, UIntPtr value);

            /// <summary>
            /// Assemble a string given its the buffer, size, start address and number of instructions to be decoded.
            /// </summary>
            /// <param name="ks">handle returned by <see cref="ks_open(ks_arch, int, out IntPtr)"/></param>
            /// <param name="str">NULL-terminated assembly string. Use ; or \n to separate statements.</param>
            /// <param name="address">address of the first assembly instruction, or 0 to ignore.</param>
            /// <param name="encoding">array of bytes containing encoding of input assembly string.
            /// NOTE: *encoding will be allocated by this function, and should be freed with <see cref="ks_free(IntPtr)"/> function.
            /// </param>
            /// <param name="encoding_size">size of *<paramref name="encoding"/></param>
            /// <param name="stat_count">number of statements successfully processed</param>
            /// <returns>0 on success, or -1 on failure. On failure, call <see cref="ks_errno(IntPtr)"/> for error code.</returns>
            /// <remarks>
            /// This API dynamically allocate memory to contain assembled instruction.
            /// Resulted array of bytes containing the machine code is put into <paramref name="encoding"/>
            /// 
            /// NOTE 1: this API will automatically determine memory needed to contain
            /// output bytes in *<paramref name="encoding"/>.
            /// 
            /// NOTE 2: caller must free the allocated memory itself to avoid memory leaking.
            /// </remarks>
            [DllImport("keystone.dll", CallingConvention = CallingConvention.Cdecl)]
            internal static extern int ks_asm(IntPtr ks,
                [MarshalAs(UnmanagedType.LPStr)]
                string str,
                ulong address,
                out IntPtr encoding,
                out UIntPtr encoding_size,
                out UIntPtr stat_count);

            /// <summary>
            /// Free memory allocated by <see cref="ks_asm(IntPtr, string, ulong, out byte[], out UIntPtr, out UIntPtr)"/>
            /// </summary>
            /// <param name="p">memory allocated in encoding argument of <see cref="ks_asm(IntPtr, string, ulong, out byte[], out UIntPtr, out UIntPtr)"/></param>
            [DllImport("keystone.dll", CallingConvention = CallingConvention.Cdecl)]
            internal static extern void ks_free(IntPtr p);
#pragma warning restore IDE1006 // Naming Styles
        }

        private class KeystoneException : Exception
        {
            public KeystoneException(IntPtr ks)
                : this(NativeMethods.ks_errno(ks))
            {
            }

            public KeystoneException(ks_err code)
                : base(NativeMethods.ks_strerror(code))
            {
            }
        }

        public enum ks_arch
        {
            KS_ARCH_ARM = 1,    // ARM architecture (including Thumb, Thumb-2)
            KS_ARCH_ARM64,      // ARM-64, also called AArch64
            KS_ARCH_MIPS,       // Mips architecture
            KS_ARCH_X86,        // X86 architecture (including x86 & x86-64)
            KS_ARCH_PPC,        // PowerPC architecture (currently unsupported)
            KS_ARCH_SPARC,      // Sparc architecture
            KS_ARCH_SYSTEMZ,    // SystemZ architecture (S390X)
            KS_ARCH_HEXAGON,    // Hexagon architecture
            KS_ARCH_MAX,
        }

        public enum ks_mode
        {
            KS_MODE_LITTLE_ENDIAN = 0,    // little-endian mode (default mode)
            KS_MODE_BIG_ENDIAN = 1 << 30, // big-endian mode
                                          // arm / arm64
            KS_MODE_ARM = 1 << 0,              // ARM mode
            KS_MODE_THUMB = 1 << 4,       // THUMB mode (including Thumb-2)
            KS_MODE_V8 = 1 << 6,          // ARMv8 A32 encodings for ARM
                                          // mips
            KS_MODE_MICRO = 1 << 4,       // MicroMips mode
            KS_MODE_MIPS3 = 1 << 5,       // Mips III ISA
            KS_MODE_MIPS32R6 = 1 << 6,    // Mips32r6 ISA
            KS_MODE_MIPS32 = 1 << 2,      // Mips32 ISA
            KS_MODE_MIPS64 = 1 << 3,      // Mips64 ISA
                                          // x86 / x64
            KS_MODE_16 = 1 << 1,          // 16-bit mode
            KS_MODE_32 = 1 << 2,          // 32-bit mode
            KS_MODE_64 = 1 << 3,          // 64-bit mode
                                          // ppc 
            KS_MODE_PPC32 = 1 << 2,       // 32-bit mode
            KS_MODE_PPC64 = 1 << 3,       // 64-bit mode
            KS_MODE_QPX = 1 << 4,         // Quad Processing eXtensions mode
                                          // sparc
            KS_MODE_SPARC32 = 1 << 2,     // 32-bit mode
            KS_MODE_SPARC64 = 1 << 3,     // 64-bit mode
            KS_MODE_V9 = 1 << 4,          // SparcV9 mode
        }

        private enum ks_err
        {
            KS_ERR_OK = 0,   // No error: everything was fine
            KS_ERR_NOMEM,      // Out-Of-Memory error: ks_open(), ks_emulate()
            KS_ERR_ARCH,     // Unsupported architecture: ks_open()
            KS_ERR_HANDLE,   // Invalid handle
            KS_ERR_MODE,     // Invalid/unsupported mode: ks_open()
            KS_ERR_VERSION,  // Unsupported version (bindings)
            KS_ERR_OPT_INVALID,  // Unsupported option

            // generic input assembly errors - parser specific
            KS_ERR_ASM_EXPR_TOKEN = 128,    // unknown token in expression
            KS_ERR_ASM_DIRECTIVE_VALUE_RANGE,   // literal value out of range for directive
            KS_ERR_ASM_DIRECTIVE_ID,    // expected identifier in directive
            KS_ERR_ASM_DIRECTIVE_TOKEN, // unexpected token in directive
            KS_ERR_ASM_DIRECTIVE_STR,   // expected string in directive
            KS_ERR_ASM_DIRECTIVE_COMMA, // expected comma in directive
            KS_ERR_ASM_DIRECTIVE_RELOC_NAME, // expected relocation name in directive
            KS_ERR_ASM_DIRECTIVE_RELOC_TOKEN, // unexpected token in .reloc directive
            KS_ERR_ASM_DIRECTIVE_FPOINT,    // invalid floating point in directive
            KS_ERR_ASM_DIRECTIVE_UNKNOWN,    // unknown directive
            KS_ERR_ASM_DIRECTIVE_EQU,   // invalid equal directive
            KS_ERR_ASM_DIRECTIVE_INVALID,   // (generic) invalid directive
            KS_ERR_ASM_VARIANT_INVALID, // invalid variant
            KS_ERR_ASM_EXPR_BRACKET,    // brackets expression not supported on this target
            KS_ERR_ASM_SYMBOL_MODIFIER, // unexpected symbol modifier following '@'
            KS_ERR_ASM_SYMBOL_REDEFINED, // invalid symbol redefinition
            KS_ERR_ASM_SYMBOL_MISSING,  // cannot find a symbol
            KS_ERR_ASM_RPAREN,          // expected ')' in parentheses expression
            KS_ERR_ASM_STAT_TOKEN,      // unexpected token at start of statement
            KS_ERR_ASM_UNSUPPORTED,     // unsupported token yet
            KS_ERR_ASM_MACRO_TOKEN,     // unexpected token in macro instantiation
            KS_ERR_ASM_MACRO_PAREN,     // unbalanced parentheses in macro argument
            KS_ERR_ASM_MACRO_EQU,       // expected '=' after formal parameter identifier
            KS_ERR_ASM_MACRO_ARGS,      // too many positional arguments
            KS_ERR_ASM_MACRO_LEVELS_EXCEED, // macros cannot be nested more than 20 levels deep
            KS_ERR_ASM_MACRO_STR,    // invalid macro string
            KS_ERR_ASM_MACRO_INVALID,    // invalid macro (generic error)
            KS_ERR_ASM_ESC_BACKSLASH,   // unexpected backslash at end of escaped string
            KS_ERR_ASM_ESC_OCTAL,       // invalid octal escape sequence  (out of range)
            KS_ERR_ASM_ESC_SEQUENCE,         // invalid escape sequence (unrecognized character)
            KS_ERR_ASM_ESC_STR,         // broken escape string
            KS_ERR_ASM_TOKEN_INVALID,   // invalid token
            KS_ERR_ASM_INSN_UNSUPPORTED,   // this instruction is unsupported in this mode
            KS_ERR_ASM_FIXUP_INVALID,   // invalid fixup
            KS_ERR_ASM_LABEL_INVALID,   // invalid label
            KS_ERR_ASM_FRAGMENT_INVALID,   // invalid fragment

            // generic input assembly errors - architecture specific
            KS_ERR_ASM_INVALIDOPERAND = 512,
            KS_ERR_ASM_MISSINGFEATURE,
            KS_ERR_ASM_MNEMONICFAIL,
        }

        private enum ks_opt_type
        {
            KS_OPT_SYNTAX = 1,    // Choose syntax for input assembly
            KS_OPT_SYM_RESOLVER,  // Set symbol resolver callback
        }

        public enum ks_opt_value
        {
            KS_OPT_SYNTAX_INTEL = 1 << 0, // X86 Intel syntax - default on X86 (KS_OPT_SYNTAX).
            KS_OPT_SYNTAX_ATT = 1 << 1, // X86 ATT asm syntax (KS_OPT_SYNTAX).
            KS_OPT_SYNTAX_NASM = 1 << 2, // X86 Nasm syntax (KS_OPT_SYNTAX).
            KS_OPT_SYNTAX_MASM = 1 << 3, // X86 Masm syntax (KS_OPT_SYNTAX) - unsupported yet.
            KS_OPT_SYNTAX_GAS = 1 << 4, // X86 GNU GAS syntax (KS_OPT_SYNTAX).
            KS_OPT_SYNTAX_RADIX16 = 1 << 5, // All immediates are in hex format (i.e 12 is 0x12)
        }

        private IntPtr m_ks;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate bool ks_sym_resolver(string symbol, out ulong value);

        public Keystone(ks_arch arch, ks_mode mode)
        {
            var err = NativeMethods.ks_open(arch, mode, out m_ks);
            if (err != ks_err.KS_ERR_OK)
            {
                throw new KeystoneException(err);
            }
        }

        public Keystone()
            : this(ks_arch.KS_ARCH_X86, ks_mode.KS_MODE_32)
        {
        }

        public byte[] Assemble(string str, ulong address, out UIntPtr stat_count)
        {
            var ret = NativeMethods.ks_asm(m_ks, str, address, out IntPtr encoding, out UIntPtr encoding_size, out stat_count);
            if (ret != 0)
            {
                throw new KeystoneException(m_ks);
            }
            byte[] enc = new byte[encoding_size.ToUInt64()];
            Marshal.Copy(encoding, enc, 0, enc.Length);
            NativeMethods.ks_free(encoding);
            return enc;
        }

        public byte[] Assemble(string str, ulong address)
        {
            return this.Assemble(str, address, out UIntPtr stat_count);
        }

        public byte[] Assemble(string str)
        {
            return this.Assemble(str, 0uL);
        }

        public static Version GetVersion()
        {
            NativeMethods.ks_version(out uint major, out uint minor);
            return new Version((int)major, (int)minor);
        }

        private void SetOption(ks_opt_type type, UIntPtr value)
        {
            var err = NativeMethods.ks_option(m_ks, type, value);
            if (err != ks_err.KS_ERR_OK)
            {
                throw new KeystoneException(err);
            }
        }

        public void SetSyntax(ks_opt_value value)
        {
            this.SetOption(ks_opt_type.KS_OPT_SYNTAX, (UIntPtr)value);
        }

        public void SetSymbolResolverCallback(ks_sym_resolver resolver)
        {
            var ptr = Marshal.GetFunctionPointerForDelegate(resolver);
            this.SetOption(ks_opt_type.KS_OPT_SYM_RESOLVER, (UIntPtr)ptr.ToInt64());
        }

        #region IDisposable Support
        private bool disposed = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects).
                }

                if (m_ks != IntPtr.Zero)
                {
                    var err = NativeMethods.ks_close(m_ks);
                }
                // TODO: set large fields to null.

                disposed = true;
            }
        }

        ~Keystone()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(false);
        }

        // This code added to correctly implement the disposable pattern.
        public void Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        #endregion
    }
}