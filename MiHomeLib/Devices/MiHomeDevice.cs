﻿namespace MiHomeLib.Devices
{
    public abstract class MiHomeDevice
    {
        public string Sid { get; }
        public string Name { get; set; }
        public abstract string Type { get; }

        protected MiHomeDevice(string sid)
        {
            Sid = sid;
        }

        public abstract void ParseData(string command);
    }
}