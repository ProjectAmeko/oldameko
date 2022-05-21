using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Amebu.AVPlugins.L_Smash
{
    internal class LSAVLoader : IAVLoader
    {
        /*
         
        TODO:
        DllImports lsmash.
         - Refer to: https://github.com/l-smash/l-smash/blob/master/cli/remuxer.c#L704
           - https://github.com/l-smash/l-smash/blob/master/cli/remuxer.c#L446
         
         */

        public int frameCount => throw new NotImplementedException();

        public bool AudioProvided => throw new NotImplementedException();

        public bool VideoProvided => throw new NotImplementedException();

        public int LoadFile(string path)
        {
            if (File.Exists(path))
            {
                return 1;
            }
            return 0;
        }

        public IFrame GetFrame(int index)
        {
            throw new NotImplementedException();
        }

        public int SetColorMatrix(string matrix)
        {
            throw new NotImplementedException();
        }

        public int SetTrackIndex(TrackType trackType, int idx)
        {
            throw new NotImplementedException();
        }
    }
}
