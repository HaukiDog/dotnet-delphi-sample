using System.Runtime.InteropServices;

namespace Delphi.Integration;

public class Sample
{
    private static class WrappedSample
    {

#if LINUX 
        const string DllPath = "Sample.so";
#else
        const string DllPath = "Sample.dll";
#endif

        [DllImport(DllPath, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Negate(bool x);

        [DllImport(DllPath, CallingConvention = CallingConvention.StdCall)]
        public static extern int Multiply(int x, int y);

        [DllImport(DllPath, CallingConvention = CallingConvention.StdCall)]
        public static extern int Total(int[] v, int count);

        [DllImport(DllPath, CallingConvention = CallingConvention.StdCall)]
        public static extern int WideStringCount(
#if LINUX 
            [MarshalAs(UnmanagedType.LPWStr)]
#else
            [MarshalAs(UnmanagedType.BStr)]            
#endif
            string str);

        [DllImport(DllPath, CallingConvention = CallingConvention.StdCall)]
        internal static extern int WideStringInOut(
#if LINUX 
            [MarshalAs(UnmanagedType.LPWStr)]
#else
            [MarshalAs(UnmanagedType.BStr)]            
#endif
            string name,
#if LINUX 
            [MarshalAs(UnmanagedType.LPWStr)]
#else
            [MarshalAs(UnmanagedType.BStr)]            
#endif
             out string str);

        [DllImport(DllPath, CallingConvention = CallingConvention.StdCall)]
        internal static extern int WideStringOut(
#if LINUX 
            [MarshalAs(UnmanagedType.LPWStr)]
#else
            [MarshalAs(UnmanagedType.BStr)]            
#endif
            out string str);


        [DllImport(DllPath, CallingConvention = CallingConvention.StdCall)]
        internal static extern int PCharOut(
#if LINUX 
            [MarshalAs(UnmanagedType.LPWStr)]
#else
            [MarshalAs(UnmanagedType.BStr)]            
#endif
            out string str);

        [DllImport(DllPath, CallingConvention = CallingConvention.StdCall)]
#if LINUX 
        [return: MarshalAs(UnmanagedType.LPWStr)]
#else
        [return: MarshalAs(UnmanagedType.BStr)]
#endif
        internal static extern string WideStringReturn();

        [DllImport(DllPath, CallingConvention = CallingConvention.StdCall)]
#if LINUX 
        [return: MarshalAs(UnmanagedType.LPWStr)]
#else
        [return: MarshalAs(UnmanagedType.BStr)]
#endif
        internal static extern string PCharReturn();
    }

    public static bool Negate(bool x) => WrappedSample.Negate(x);
    public static int Multiply(int x, int y) => WrappedSample.Multiply(x, y);
    public static int Total(int[] v) => WrappedSample.Total(v, v.Count());

    public static int StringIn(string s) => WrappedSample.WideStringCount(s);

    public static string StringOut()
    {
        _ = WrappedSample.WideStringOut(out var s);
        return s;
    }

    public static string PCharOut()
    {
        _ = WrappedSample.WideStringOut(out var s);
        return s;
    }

    public static string StringReturn()
    {
        return WrappedSample.WideStringReturn();
    }

    public static string PCharReturn()
    {
        return WrappedSample.WideStringReturn();
    }

    public static string StringInOut(string name)
    {
        _ = WrappedSample.WideStringInOut(name, out var s);
        return s;
    }
}
