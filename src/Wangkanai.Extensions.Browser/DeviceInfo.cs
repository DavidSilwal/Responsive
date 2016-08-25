﻿using System;

namespace Wangkanai.Extensions.Browser
{
    public class DeviceInfo
    {
        public string Name => Device.ToString().ToLowerInvariant();
        public DeviceTypes Device { get; }
        public DeviceInfo(string name)
        {
            if(name==null) throw new ArgumentNullException(nameof(name));
            Device = GetDeviceInfo(name);
        }

        public DeviceInfo(DeviceTypes types)
        {
            Device = types;            
        }

        private DeviceTypes GetDeviceInfo(string name)
        {
            DeviceTypes device;
            if(!Enum.TryParse(name, true, out device))
                throw new DeviceNotFoundException("name", name, "Device Not Found");

            return device;
        }
    }
}