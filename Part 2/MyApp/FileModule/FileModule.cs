using System.IO;
using Shared;

namespace FileModule
{
    public class FileModule : IModule
    {
        public string WhoAreYou()
        {
            return File.ReadAllText("TextFile.txt");
        }
    }
}
