using System;
using System.Runtime.InteropServices;

public class Runner
{
    [DllImport("user32.dll", CharSet = CharSet.Unicode)]
    private static extern int MessageBox(IntPtr hWnd, string text, string caption, uint type);
    
    public static void Run()
    {
        MessageBox(IntPtr.Zero, "You were hacked!", "MESSAGE BOX", 0);
        //Console.WriteLine("You were hacked!");
    }
}
