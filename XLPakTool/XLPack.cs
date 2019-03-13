using System;
using System.Runtime.InteropServices;

namespace XLPakTool
{
    public class XLPack
    {
        [DllImport("xlpack.dll", EntryPoint = "#1", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)] // "?ApplyPatchPak@@YA_NPBD0@Z",
        public static extern bool ApplyPatchPak([MarshalAs(UnmanagedType.LPStr)] string s1, [MarshalAs(UnmanagedType.LPStr)] string s2);

        [DllImport("xlpack.dll", EntryPoint = "#3", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)] // "?Copy@@YA_NPBD0@Z",
        public static extern bool Copy([MarshalAs(UnmanagedType.LPStr)] string from, [MarshalAs(UnmanagedType.LPStr)] string to);

        [DllImport("xlpack.dll", EntryPoint = "#4", CharSet = CharSet.Ansi)] // "?CopyDir@@YA_NPBD0@Z"
        public static extern bool CopyDir([MarshalAs(UnmanagedType.LPStr)] string from, [MarshalAs(UnmanagedType.LPStr)] string to);

        [DllImport("xlpack.dll", EntryPoint = "#6", CallingConvention = CallingConvention.Cdecl)] // "?CreateFileSystem@@YA_NXZ"
        public static extern bool CreateFileSystem();

        [DllImport("xlpack.dll", EntryPoint = "#8", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)] // "?DeleteDir@@YA_NPBD@Z"
        public static extern bool DeleteDir([MarshalAs(UnmanagedType.LPStr)] string path);

        [DllImport("xlpack.dll", EntryPoint = "#10", CallingConvention = CallingConvention.Cdecl)] // "?DestroyFileLogHandler@@YAXPAX@Z"
        public static extern void DestroyFileLogHandler(IntPtr lp1);

        [DllImport("xlpack.dll", EntryPoint = "#11", CallingConvention = CallingConvention.Cdecl)] // "?DestroyFileSystem@@YAXXZ"
        public static extern void DestroyFileSystem();

        [DllImport("xlpack.dll", EntryPoint = "#12", CallingConvention = CallingConvention.Cdecl)] // "?FClose@@YAXAAPAUFile@@@Z"
        public static extern void FClose(ref IntPtr filePosition);

        [DllImport("xlpack.dll", EntryPoint = "#13", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)] // "?FDelete@@YA_NPBD@Z"
        public static extern bool FDelete([MarshalAs(UnmanagedType.LPStr)] string where);

        [DllImport("xlpack.dll", EntryPoint = "#16", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)] // "?FGetStat@@YA_NPAUFile@@PAUpack_stat2@@@Z"
        public static extern bool FGetMD5(IntPtr filePosition, ref afs_md5_ctx md5);

        [DllImport("xlpack.dll", EntryPoint = "#17", CallingConvention = CallingConvention.Cdecl)] // "?FGetStat@@YA_NPAUFile@@PAUpack_stat2@@@Z"
        public static extern bool FGetStat(IntPtr filePosition, ref pack_stat2 stat);

        [DllImport("xlpack.dll", EntryPoint = "#18", CallingConvention = CallingConvention.Cdecl)] // "?FGetStat@@YA_NPAUFile@@PAUpack_stat_t@@@Z"
        public static extern bool FGetStat(IntPtr filePosition, ref pack_stat_t stat);

        [DllImport("xlpack.dll", EntryPoint = "#19", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)] // "?FOpen@@YAPAUFile@@PBD0@Z"
        public static extern IntPtr FOpen([MarshalAs(UnmanagedType.LPStr)] string path, [MarshalAs(UnmanagedType.LPStr)] string mode);

        [DllImport("xlpack.dll", EntryPoint = "#21", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)] // "?FReadAll@@YA_JPAUFile@@PAPADAA_J@Z"
        public static extern int FReadAll(IntPtr filePosition, IntPtr buffer, Int64 size);

        [DllImport("xlpack.dll", EntryPoint = "#24", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)] // "?FSetMD5@@YA_NPAUFile@@QBD@Z"
        public static extern bool FSetMD5(IntPtr filePosition, ref afs_md5_ctx md5);

        [DllImport("xlpack.dll", EntryPoint = "#26", CallingConvention = CallingConvention.Cdecl)] // "?FSize@@YA_JPAUFile@@@Z"
        public static extern long FSize(IntPtr filePosition);

        [DllImport("xlpack.dll", EntryPoint = "#28", CallingConvention = CallingConvention.Cdecl)] // "?FUseMD5@@YA_NPAUFile@@@Z"
        public static extern bool FUseMD5(IntPtr filePosition);

        [DllImport("xlpack.dll", EntryPoint = "#30", CallingConvention = CallingConvention.Cdecl)] // "?FindClose@@YAHH@Z"
        public static extern int FindClose(int i);

        [DllImport("xlpack.dll", EntryPoint = "#31", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)] // "?FindFirst@@YAHPBDPAUafs_finddata@@@Z"
        public static extern int FindFirst([MarshalAs(UnmanagedType.LPStr)] string file, ref afs_finddata fd);

        [DllImport("xlpack.dll", EntryPoint = "#32", CallingConvention = CallingConvention.Cdecl)] // "?FindNext@@YAHHPAUafs_finddata@@@Z"
        public static extern int FindNext(int i, ref afs_finddata fd);

        [DllImport("xlpack.dll", EntryPoint = "#35", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)] // "?GetFileName@@YAPBDPBUafs_finddata@@@Z"
        public static extern IntPtr GetFileName(ref afs_finddata fd);

        [DllImport("xlpack.dll", EntryPoint = "#41", CallingConvention = CallingConvention.Cdecl)] // "?IsDirectory@@YA_NPBUafs_finddata@@@Z"
        public static extern bool IsDirectory(ref afs_finddata fd);

        [DllImport("xlpack.dll", EntryPoint = "#42", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)] // "?IsFileExist@@YA_NPBD@Z"
        public static extern bool IsFileExist([MarshalAs(UnmanagedType.LPStr)] string file);

        [DllImport("xlpack.dll", EntryPoint = "#48", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)] // "?Mount@@YAPAXPBD0_N@Z"
        public static extern IntPtr Mount([MarshalAs(UnmanagedType.LPStr)] string where, [MarshalAs(UnmanagedType.LPStr)] string which, [MarshalAs(UnmanagedType.Bool)] bool editable);

        [DllImport("xlpack.dll", EntryPoint = "#53", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)] // "?SetFileLogHandler@@YAPAXPBDP6AX0ZZ@Z"
        public static extern IntPtr SetFileLogHandler([MarshalAs(UnmanagedType.LPStr)] string s, Func f);

        [DllImport("xlpack.dll", EntryPoint = "#55", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)] // "?Unmount@@YA_NPAX@Z"
        public static extern bool Unmount(IntPtr handler);

        [DllImport("xlpack.dll", EntryPoint = "#56", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)] // "?Unmount@@YA_NPBD@Z"
        public static extern bool Unmount([MarshalAs(UnmanagedType.LPStr)] string where);

        [StructLayout(LayoutKind.Explicit)]
        public struct afs_finddata
        {
            [FieldOffset(0)] public long Offset;
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct File
        {
            [FieldOffset(0)] public uint pntr;
            [FieldOffset(4)] public uint cnt;
            [FieldOffset(8)] public uint based; // base
            [FieldOffset(12)] public uint flag;
            [FieldOffset(16)] public uint file;
            [FieldOffset(20)] public uint charbuf;
            [FieldOffset(24)] public uint bufsize;
            [FieldOffset(28)] public uint tmpfname;
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct XlFileInfo
        {
            [FieldOffset(0)] public uint dwFileAttributes;
            [FieldOffset(4)] public ulong ftCreationTime;
            [FieldOffset(12)] public ulong ftLastAccessTime;
            [FieldOffset(20)] public ulong ftLastWriteTime;
            [FieldOffset(28)] public uint dwVolumeSerialNumber;
            [FieldOffset(32)] public uint nFileSizeHigh;
            [FieldOffset(36)] public uint nFileSizeLow;
            [FieldOffset(40)] public uint nNumberOfLinks;
            [FieldOffset(44)] public uint nFileIndexHigh;
            [FieldOffset(48)] public uint nFileIndexLow;
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct afs_md5_ctx
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)] [FieldOffset(0)]
            public byte[] md5;
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct pack_stat_t
        {
            [FieldOffset(0)] public long creationTime;
            [FieldOffset(8)] public long modifiedTime;
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct pack_stat2
        {
            [FieldOffset(0)] public pack_stat_t stat;
            [FieldOffset(16)] public long length;
            [FieldOffset(24)] public afs_md5_ctx digest;
        }

        [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        public delegate void Func(params string[] values);
    }
}
