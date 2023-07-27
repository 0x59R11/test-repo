using System;
using System.Runtime.InteropServices;
using System.Diagnostics;

public class Runner
{
    [DllImport("user32.dll", CharSet = CharSet.Unicode)]
    private static extern int MessageBox(IntPtr hWnd, string text, string caption, uint type);
    
    public static void Run()
    {
        Process.Start("https://t-loves.narod.ru/img/tery3b.jpg");
        
        MessageBox(IntPtr.Zero, "Привет Вовчик! :)", "Приветствие)", 0);

        MessageBox(IntPtr.Zero, "С днем рождение тебя братан!!\nДа я знаю что ты хотел запустить игрульку и просто отдохнуть, но прежде хочу чтобы ты помнил что нас ждут великие дела.. Помни что Я всегда раз тебе помочь, в любое время только попроси) Всего наилучшего!! Счастья, и успехов во всех начинаниях!!! :)", "Поздравление", 0);

        MessageBox(IntPtr.Zero, "Ну и на последок :))))", "Последок", 0);

        var args = Environment.GetCommandLineArgs();
        if (args != null && args.Length > 0)
        {
          Process.Start(args[0]);
        }
    }
}
