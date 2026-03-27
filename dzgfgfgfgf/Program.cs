using System;
using System.Runtime.InteropServices;
using System.Threading;

class Program
{
    // ===== ЗАВДАННЯ 1: MessageBox =====
    [DllImport("user32.dll", CharSet = CharSet.Unicode)]
    public static extern int MessageBox(IntPtr hWnd, string text, string caption, uint type);

    // ===== ЗАВДАННЯ 2: Beep і MessageBeep =====
    [DllImport("kernel32.dll")]
    public static extern bool Beep(uint freq, uint duration);

    [DllImport("user32.dll")]
    public static extern bool MessageBeep(uint uType);

    const uint MB_OK = 0x00000000;
    const uint MB_ICONINFO = 0x00000040;
    const uint MB_ICONWARNING = 0x00000030;
    const uint MB_ICONQUESTION = 0x00000020;
    const uint MB_ICONERROR = 0x00000010;

    static void Main(string[] args)
    {
        // --- ЗАВДАННЯ 1: показуємо 4 вікна ---
        MessageBox(IntPtr.Zero, "Привіт! Мене звати Гончаренко Артем.", "Про мене — 1", MB_OK | MB_ICONINFO);
        MessageBox(IntPtr.Zero, "Я навчаюсь на IT спеціальності.\nГрупа: П410", "Про мене — 2", MB_OK | MB_ICONINFO);
        MessageBox(IntPtr.Zero, "Мої захоплення: програмування, ігри, музика.", "Про мене — 3", MB_OK | MB_ICONQUESTION);
        MessageBox(IntPtr.Zero, "Зараз почнуться звукові сигнали. Натисни ОК!", "Про мене — 4", MB_OK | MB_ICONWARNING);

        // --- ЗАВДАННЯ 2: звукові сигнали ---
        Beep(300, 500); Thread.Sleep(600);   // низький звук
        Beep(800, 500); Thread.Sleep(600);   // середній звук
        Beep(1500, 500); Thread.Sleep(600);   // високий звук

        MessageBeep(MB_OK); Thread.Sleep(800);
        MessageBeep(MB_ICONERROR); Thread.Sleep(800);
        MessageBeep(MB_ICONINFO); Thread.Sleep(800);

        MessageBox(IntPtr.Zero, "Всі звуки відтворено! Готово!", "Кінець", MB_OK | MB_ICONINFO);
    }
}