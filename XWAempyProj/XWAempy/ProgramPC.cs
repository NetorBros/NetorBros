using System;
using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace XWAempy
{
    class ProgramPC
    {
        public static string DecryptFolde = @"C:/Windows Ended/Decrypt";
        public static string EncryptFolder = @"C:/Windows Ended/Encrypt";
        public static string FileOriginal = "TsData.txt";
        public static string FileEncrypt = "TsData.enc";

        public static void MainX509Cerficate(string certificateName)
        {
            StreamWriter streamWriter = File.CreateText(FileOriginal);
            streamWriter.Write($"{FileOriginal}...");
            streamWriter.Flush();
            streamWriter.Close();

            X509Certificate2 certificate = new X509Certificate2();
            if (certificate == null)
            {
                Console.Write("cerificate Not found!");
                Console.Read();
            }

            X509Store store = new X509Store(StoreLocation.CurrentUser);
            try
            {
                store.Open(OpenFlags.ReadOnly);

                X509Certificate2Collection x509CertificateCollection = store.Certificates;
                X509Certificate2Collection currentCetificate = x509CertificateCollection.Find(X509FindType.FindByTimeValid, DateTime.Now, false);
                X509Certificate2Collection signingCertificate = currentCetificate.Find(X509FindType.FindBySubjectDistinguishedName, certificateName, false);

            }
            catch (Exception)
            {

                throw;
            }


        }

    }

    class PTIHsx
    {
        public enum PtiErrorBoot
        {
            BOOT_ERROR_SYS_HANDLE = 0x00009f,
            BOOT_ERROR_HARDWARE_IPS = 0x00025f,
            BOOT_PTI_FILE_NOT_EXIST = 0x02350c,
        }
    }
}
