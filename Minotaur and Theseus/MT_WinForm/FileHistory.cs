using System.Collections.Generic;

namespace MT_WinForm
{
    static class FileHistory
    {
        public static List<LoadFile> AllFiles = new List<LoadFile>();
        public static LoadFile CurrentFile { get; set; }
        
    }
}
