// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable enable
using System;
using System.Runtime.Intrinsics;

namespace System.Runtime.Intrinsics.X86
{
    /// <summary>
    /// This class provides access to Intel PCLMULQDQ hardware instructions via intrinsics
    /// </summary>
    [CLSCompliant(false)]
    public abstract class Pclmulqdq : Sse2
    {
        internal Pclmulqdq() { }

        public new static bool IsSupported { get { return false; } }

        /// <summary>
        /// __m128i _mm_clmulepi64_si128 (__m128i a, __m128i b, const int imm8)
        ///   PCLMULQDQ xmm, xmm/m128, imm8
        /// </summary>
        public static Vector128<long> CarrylessMultiply(Vector128<long> left, Vector128<long> right, byte control) { throw new PlatformNotSupportedException(); }
        /// <summary>
        /// __m128i _mm_clmulepi64_si128 (__m128i a, __m128i b, const int imm8)
        ///   PCLMULQDQ xmm, xmm/m128, imm8
        /// </summary>
        public static Vector128<ulong> CarrylessMultiply(Vector128<ulong> left, Vector128<ulong> right, byte control) { throw new PlatformNotSupportedException(); }
    }
}
