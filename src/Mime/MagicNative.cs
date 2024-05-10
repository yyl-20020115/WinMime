﻿using System;
using System.Runtime.InteropServices;

namespace HeyRed.Mime;

internal static class MagicNative
{
    private const string MAGIC_LIB_PATH = "libmagic";

    [DllImport(MAGIC_LIB_PATH, CallingConvention = CallingConvention.Cdecl)]
    public static extern IntPtr magic_open(MagicOpenFlags flags);

    [DllImport(MAGIC_LIB_PATH, CallingConvention = CallingConvention.Cdecl)]
    public static extern int magic_load(IntPtr magic_cookie, string? dbPath);

    [DllImport(MAGIC_LIB_PATH, CallingConvention = CallingConvention.Cdecl)]
    public static extern void magic_close(IntPtr magic_cookie);

    [DllImport(MAGIC_LIB_PATH, CallingConvention = CallingConvention.Cdecl)]
    public static extern IntPtr magic_file(IntPtr magic_cookie, string? dbPath);

    [DllImport(MAGIC_LIB_PATH, CallingConvention = CallingConvention.Cdecl)]
    public static extern IntPtr magic_buffer(IntPtr magic_cookie, byte[] buffer, int length);

    [DllImport(MAGIC_LIB_PATH, CallingConvention = CallingConvention.Cdecl)]
    public static extern IntPtr magic_error(IntPtr magic_cookie);

    [DllImport(MAGIC_LIB_PATH, CallingConvention = CallingConvention.Cdecl)]
    public static extern MagicOpenFlags magic_getflags(IntPtr magic_cookie);

    [DllImport(MAGIC_LIB_PATH, CallingConvention = CallingConvention.Cdecl)]
    public static extern int magic_setflags(IntPtr magic_cookie, MagicOpenFlags flags);

    [DllImport(MAGIC_LIB_PATH, CallingConvention = CallingConvention.Cdecl)]
    public static extern int magic_check(IntPtr magic_cookie, string? dbPath);

    [DllImport(MAGIC_LIB_PATH, CallingConvention = CallingConvention.Cdecl)]
    public static extern int magic_compile(IntPtr magic_cookie, string? dbPath);

    [DllImport(MAGIC_LIB_PATH, CallingConvention = CallingConvention.Cdecl)]
    public static extern int magic_getparam(IntPtr magic_cookie, MagicParams param, out int value);

    [DllImport(MAGIC_LIB_PATH, CallingConvention = CallingConvention.Cdecl)]
    public static extern int magic_setparam(IntPtr magic_cookie, MagicParams param, ref int value);

    [DllImport(MAGIC_LIB_PATH, CallingConvention = CallingConvention.Cdecl)]
    public static extern int magic_version();
}