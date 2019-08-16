﻿using System;
using System.Runtime.CompilerServices;
using Platform.Exceptions.ExtensionRoots;

#pragma warning disable IDE0060 // Remove unused parameter
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

namespace Platform.Exceptions
{
    public static class ThrowExtensions
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void NotSupportedException(this ThrowExtensionRoot root) => throw new NotSupportedException();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T NotSupportedExceptionAndReturn<T>(this ThrowExtensionRoot root) => throw new NotSupportedException();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void NotImplementedException(this ThrowExtensionRoot root) => throw new NotImplementedException();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T NotImplementedExceptionAndReturn<T>(this ThrowExtensionRoot root) => throw new NotImplementedException();
    }
}
