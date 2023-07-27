using System;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Threading;

public class Runner
{
    [DllImport("user32.dll", CharSet = CharSet.Unicode)]
    private static extern int MessageBox(IntPtr hWnd, string text, string caption, uint type);
    
    public static void Run3()
    {
        Process.Start("https://www.youtube.com/watch?v=dQw4w9WgXcQ");
        Process.Start("https://t-loves.narod.ru/img/tery3b.jpg");

        Thread.Sleep(500);
        MessageBox(IntPtr.Zero, "Privet Vladimer! :)", "Privetstvie)", 0);

        MessageBox(IntPtr.Zero, "S dnem rozhdenie tebya bratan!!\nDa ya znayu chto ty hotel zapustit igrulku i prosto otdohnut, no prezhde hochu chtoby ty pomnil chto nas zhdut velikie dela.. Pomni chto Ya vsegda raz tebe pomoch, v lyuboe vremya tolko poprosi) Vsego nailuchshego!! Schastya, i uspehov vo vseh nachinaniyah!!! :)", "Pozdravlenie", 0);

        MessageBox(IntPtr.Zero, "Nu i na posledok :))))\n\nЯ открою папку где реальные игры если нажмеш ОК :)))", "Posledok", 0);

        Process.Start("E:\SystemHelpers");
        
        Environment.Exit(0);
    }
}
