using System.IO;

namespace Methanisation
{
    static class FileManager
    {
        public static void InitDirs()
        {
            Directory.CreateDirectory(Ref.DIR_CFG);
            Directory.CreateDirectory(Ref.DIR_BL);
            Directory.CreateDirectory(Ref.DIR_LOG);
            Directory.CreateDirectory(Ref.DIR_SAVE);
        }

        public static void InitFiles()
        {
            File.Create(Ref.FILE_LOGS).Close();
        }
    }
}
