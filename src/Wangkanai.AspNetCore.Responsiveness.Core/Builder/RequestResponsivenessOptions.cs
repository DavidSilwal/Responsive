﻿// Copyright (c) 2015 Sarin Na Wangkanai, All Rights Reserved.
// The GNU GPLv3. See License.txt in the project root for license information.

using System.Collections.Generic;
using Wangkanai.AspNetCore.Responsiveness;

namespace Microsoft.AspNetCore.Builder
{
    public class RequestResponsivenessOptions
    {
        public RequestResponsivenessOptions()
        {
            
        }
        public IList<DeviceType> SupportedDevices { get; set; } = new List<DeviceType>();
    }
}