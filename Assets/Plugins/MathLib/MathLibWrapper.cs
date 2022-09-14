using System.Runtime.InteropServices;

public class MathLibWrapper
{
#if UNITY_WEBGL && !UNITY_EDITOR
    [DllImport("__Internal")]
#else
    [DllImport("MathLib")]
#endif
    public static extern int add(int a, int b);
#if UNITY_WEBGL && !UNITY_EDITOR
    [DllImport("__Internal")]
#else
    [DllImport("MathLib")]
#endif
    public static extern int subtract(int a, int b);
#if UNITY_WEBGL && !UNITY_EDITOR
    [DllImport("__Internal")]
#else
    [DllImport("MathLib")]
#endif
    public static extern int multiply(int a, int b);
#if UNITY_WEBGL && !UNITY_EDITOR
    [DllImport("__Internal")]
#else
    [DllImport("MathLib")]
#endif
    public static extern int divide(int a, int b);

}
