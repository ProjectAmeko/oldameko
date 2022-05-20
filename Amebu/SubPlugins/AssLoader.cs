using Ameko.AssCS;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Amebu.SubPlugins
{
    public class AssLoader : ISubLoader
    {
        public string[] FileExtensions => new string[] {".ass","*"};


        public string GetErrorMessage(int errCode)
        {
            throw new NotImplementedException();
        }

        public SubtitleResponse LoadFile(string path, int index = -1)
        {
            SubtitleResponse subtitleResponse = new SubtitleResponse();
            if (File.Exists(path))
            {
                subtitleResponse.AssFile = AssParser.LoadAndParse(path);
                subtitleResponse.Status = "OK";
            }
            else
            {
                subtitleResponse.Status = "File does not exist.";
            }
            return subtitleResponse;
        }
    }
}
