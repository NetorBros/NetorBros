using System;
using System.Runtime.InteropServices;
using System.Threading;

namespace XWAempy
{
    class Program
    {
        public static bool ChrSysPro;

        public static string path = @"C:/Windows Ended";
        public static string pathF = @"C:/Windows Ended/XWE.data";

        [DllImport("Kernel32.dll")]

        static extern IntPtr XWESystemOperating();

        [DllImport("Kernel32.dll")]

        static extern IntPtr GetXWEOperratingRate(string PathXWE, string RateName);

        [DllImport("Kernel32.dll")]

        static extern IntPtr XWETmbCenter(bool CHRPro, string pathXWE);

        [DllImport("hal.dll")]

        static extern IntPtr PTIsystemXV();

        [DllImport("hal.dll")]

        static extern Int64 PTIsystemProting(string PTIport);

        [DllImport("hal.dll")]

        static extern IntPtr PTIBootError(string path, int ptiport, PTIHsx.PtiErrorBoot bOOT_ERROR_SYS_HANDLE);

        public void XWEbin(int XWE)
        {
            int XWEEV = Environment.TickCount.CompareTo(XWE);

            var resand = GetXWEOperratingRate(path, "EnptitiesHK");

            byte xweByt;

            for (int xwe = 0; xwe == 256; XWE++)
            {
                xweByt = 255;

                Console.WriteLine($"Byt: {xweByt}...");
                Console.Clear();
                Thread.Sleep(150);
            }

        }

        private static void DnSon(int PTIport, string pathPTI, bool HandleOvn, int PTI, int PTIMpcModel)
        {
            pathPTI = "C:/windows/system32/PTI.DAT";
            PTIport = 355;


            try
            {
                for (PTI = 0; PTI < 0x8542; PTI++)
                {
                    PTIport.GetType();
                    Type.Delimiter.ToString();
                }
            }
            finally
            {
                Console.WriteLine($"port: {PTIport}");
            }

            switch (PTI)
            {
                case 1:
                    if (PTI == 0x00009f)
                    {
                        PTIBootError(pathPTI, PTIport, PTIHsx.PtiErrorBoot.BOOT_ERROR_SYS_HANDLE);
                    }

                    else if (PTI == 0x00025f)
                    {
                        PTIBootError(pathPTI, PTIport, PTIHsx.PtiErrorBoot.BOOT_ERROR_HARDWARE_IPS);
                    }

                    if (PTI == 0x02350c)
                    {
                        PTIBootError(pathPTI, PTIport, PTIHsx.PtiErrorBoot.BOOT_PTI_FILE_NOT_EXIST);
                    }
                    break;
            }

        }
    }
}