using System;
using System.Collections.Generic;
using System.Text;

namespace Amebu.AVPlugins
{
    public interface IFrame
    {
        public int Width { get; }
        public int Height { get; }
        public int Aspect { get; }
        public byte[] GetFrame();
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
        /// Returns the total frames loaded from the file.
        /// A value of -1 indicates the file has not been loaded.
        /// </summary>
        public int frameCount { get; }
        /// <summary>
        /// Returns true if the loader can provide audio.
        /// </summary>
        public bool AudioProvided { get; }
        /// <summary>
        /// Returns true if the loader can provide video.
        /// </summary>
        public bool VideoProvided { get; }
        /// <summary>
        /// Sets the color matrix for the video.
        /// </summary>
        /// <param name="matrix"></param>
        /// <returns></returns>
        public int SetColorMatrix(string matrix);
        public int SetTrackIndex(TrackType trackType, int idx);
        public int LoadFile(string path);
        /// <summary>
        /// Gets the frame
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public IFrame GetFrame(int index);
    }
}
