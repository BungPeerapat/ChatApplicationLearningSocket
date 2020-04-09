using System;

namespace WMPLib
{
    internal class WindowsMediaPlayer
    {
        public object controls { get; internal set; }
        public object settings { get; internal set; }


        public string URL { get; internal set; }
    }
}