﻿using System;
using System.Runtime.Serialization;

namespace Wangkanai.Extensions.Browser
{
    [System.Runtime.InteropServices.ComVisible(true)]
    public class DeviceNotFoundException : ArgumentException
    {
        private string m_invalidDeviceName; // unrecognized device name
        private static string DefaultMessage => "Device Not Supported";
        public virtual string InvalidDeviceName => m_invalidDeviceName;
        public override string Message
        {
            get
            {
                var s = base.Message;
                if (m_invalidDeviceName != null)
                {
                    var valueMessage = InvalidDeviceName;
                    if (s == null) return valueMessage;
                    return s + Environment.NewLine + valueMessage;
                }
                return s;
            }
        }

        public DeviceNotFoundException() : base(DefaultMessage) { }
        public DeviceNotFoundException(string message) : base(message) { }
        public DeviceNotFoundException(string paramName, string message)
            : base(message, paramName) { }
        public DeviceNotFoundException(string message, Exception innerException)
            : base(message, innerException) { }

        public DeviceNotFoundException(string message, string invalidDeviceName, Exception innerException)
            : base(message, innerException)
        {
            m_invalidDeviceName = invalidDeviceName;
        }

        public DeviceNotFoundException(string paramName, string invalidDeviceName, string message)
            : base(message, paramName)
        {
            m_invalidDeviceName = invalidDeviceName;
        }
    }
}