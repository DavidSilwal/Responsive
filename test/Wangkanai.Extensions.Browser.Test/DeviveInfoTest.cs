﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Wangkanai.Extensions.Browser.Test
{
    public class DeviveInfoTest
    {
        [Fact]
        public void browser_mobile()
        {
            var deviceinfo = new DeviceInfo("mobile");
            Assert.Equal("mobile", deviceinfo.Name);
        }

        [Fact]
        public void browser_tablet()
        {
            var deviceinfo = new DeviceInfo("tablet");
            Assert.Equal("tablet", deviceinfo.Name);
        }

        [Fact]
        public void broswer_desktop()
        {
            var deviceinfo = new DeviceInfo("desktop");
            Assert.Equal("desktop", deviceinfo.Name);
        }
        [Fact]
        public void Device_not_found()
        {            
            Exception ex = Assert.Throws<DeviceNotFoundException>(()=> new DeviceInfo("fake"));
            Assert.Equal("Device Not Found\r\nParameter name: name\r\nfake", ex.Message);
        }
    }
}
