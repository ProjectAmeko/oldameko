using Ameko.AssCS;
using System;
using System.Collections.Generic;
using System.Text;

namespace Amebu.SubPlugins
{
    public class AssLoader : ISubLoader
    {
        public string[] FileExtensions => new string[] {".ass","*"};

        public AssFile? GetAssFile()
        {
            throw new NotImplementedException();
        }

        public string GetErrorMessage(int errCode)
        {
            throw new NotImplementedException();
        }

        public int LoadFile(string path, int index = -1)
        {
            throw new NotImplementedException();
        }
    }
}
