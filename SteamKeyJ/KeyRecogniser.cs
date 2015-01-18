using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;

namespace SteamKeyJ
{
    public sealed class KeyRecogniser
    {
        private const int WH_KEYBOARD_LL = 13;
        private const int WM_KEYDOWN = 0x0100;
        private const int WM_KEYUP = 0x0101;
        private static LowLevelKeyboardProc _proc;
        private static IntPtr _hookID = IntPtr.Zero;

        private delegate IntPtr LowLevelKeyboardProc(int nCode, IntPtr wParam, IntPtr lParam);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr SetWindowsHookEx(int idHook,
            LowLevelKeyboardProc lpfn, IntPtr hMod, uint dwThreadId);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool UnhookWindowsHookEx(IntPtr hhk);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode, IntPtr wParam, IntPtr lParam);

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr GetModuleHandle(string lpModuleName);



        private static readonly KeyRecogniser instance = new KeyRecogniser();

        private KeyRecogniser() { }

      

        public static void Unhook()
        {
            UnhookWindowsHookEx(_hookID);
        }

        public static void SetHook()
        {
            _hookID = SetHook(_proc);
        }

        public static KeyRecogniser Instance
        {
            get
            {
                _proc = HookCallBack;
                
                _hookID = SetHook(_proc); 
                return instance;
            }
        }



        private static IntPtr SetHook(LowLevelKeyboardProc proc)
        {
            using (Process curProcess = Process.GetCurrentProcess())
            using (ProcessModule curModule = curProcess.MainModule)
            {
                return SetWindowsHookEx(WH_KEYBOARD_LL, proc, GetModuleHandle(curModule.ModuleName), 0);
            }
        }

        private static bool isControlPressed = false;

        public static bool IsControlPressed
        {
            get
            {
                return isControlPressed;
            }
        }

        public static List<int> RequestKeys = new List<int>();
        private static List<int> PressedKeys = new List<int>();


        public static event EventHandler RequestedKeysPressed = delegate { };
        public static event EventHandler RequestedKeysReleased = delegate { };

  


        private static IntPtr HookCallBack(int nCode, IntPtr wParam, IntPtr lParam)
        {
            if (nCode >= 0 && wParam == (IntPtr)WM_KEYDOWN)
            {
                int vkCode = Marshal.ReadInt32(lParam);              
                RequestedKeysPressed(vkCode, EventArgs.Empty);
            }
            else
            {        
                RequestedKeysReleased(null, EventArgs.Empty);                
            }         
       
            

            return CallNextHookEx(_hookID, nCode, wParam, lParam);
            
        }
     

    }
}
