using System;
using System.IO;

namespace ArchivosInformacionSobreSistOprativo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Obtener info del sistema operativo");
            //---------------------------OperatingSystem-----------------------------
            Console.WriteLine("es windous? {0}",OperatingSystem.IsWindows());//metodos estaticos
            Console.WriteLine("es Linux? {0}", OperatingSystem.IsLinux());
            Console.WriteLine("es IOS? {0}", OperatingSystem.IsIOS());
            Console.WriteLine("es MacOs? {0}", OperatingSystem.IsMacOS());
            //-----------------------------Environment
            Console.WriteLine("\nOSVersion {0}",Environment.OSVersion);//propiedad estatica
            Console.WriteLine("OSVersion.Platform {0}", Environment.OSVersion.Platform);
            Console.WriteLine("OSVersion.Version {0}", Environment.OSVersion.Version);
            Console.WriteLine("\n primera linea {0} segunda linea",Environment.NewLine);
            Console.WriteLine("Usuario {0}",Environment.UserName);
            Console.WriteLine("Tiene arquitectura de 64 bits?{0}",Environment.Is64BitOperatingSystem);
            Console.WriteLine("cantidad de procesadores logicos {0}",Environment.ProcessorCount);

            Console.WriteLine("Obtener info de unidades de almacenamiento");
            //DriveInfo
            Console.WriteLine("{0,-10} | {1,-10} | {2,-7} | {3,-26} | {4,-26}","name","tipo","formato","tamanio","espacio libre");
            foreach (DriveInfo item in DriveInfo.GetDrives())// metodo estatico q retorna array del tipo Drive info 
            {
                if( item.IsReady)// si esta ok aplico las propiedades para obtener info
                {
                    Console.WriteLine("{0,-10} | {1,-10} | {2,-7} | {3,-20:N0} bytes | {4,-20:N0} bytes",
                        item.Name,item.DriveType,item.DriveFormat,item.TotalSize,item.AvailableFreeSpace);
                }
                else
                {
                    Console.WriteLine("{0,-10} | {1,-10}",item.Name,item.DriveType);
                }
            }



        }
    }
}
