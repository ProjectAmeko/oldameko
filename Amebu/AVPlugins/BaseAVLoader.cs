using System;
using System.Collections.Generic;
using System.Text;

namespace Amebu.AVPlugins
{
    public interface IFrame
    {
        int Width { get; }
        int Height { get; }
        int Aspect { get; }
    }

    public enum TrackType
    {
        AUDIO,
        VIDEO,
        SUBTITLE,
        UNKNOWN
    }

    /// <summary>
    /// Provides the interface for a custom Audio/Video loader.
    /// The loader should not have to care about whether
    /// </summary>
    public interface IAVLoader
    {
        /// <summary>
        /// Returns the total frames loaded from the file
        /// </summary>
        public int frameCount { get; }
        /// <summary>
        /// 
        /// </summary>
        public bool AudioProvided { get; }
        public bool VideoProvided { get; }
        public int SetColorMatrix(string matrix);
        public int SetTrackIndex(TrackType trackType, int idx);
        public int LoadFile(string path);
    }
}
