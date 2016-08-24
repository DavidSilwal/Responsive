﻿// Copyright (c) 2015 Sarin Na Wangkanai, All Rights Reserved.
// The GNU GPLv3. See License.txt in the project root for license information.

using System.Collections.Generic;
using Wangkanai.AspNetCore.Responsiveness;
using Wangkanai.AspNetCore.Responsiveness.Abstractions;
using Wangkanai.AspNetCore.Responsiveness.Abstractions.Devices;

namespace Wangkanai.AspNetCore.Responsiveness
{
    public class ResponsivenessManagerFactory : IResponsivenessManagerFactory
    {
        public IList<IDeviceProvider> DeviceProviders { get; } = new List<IDeviceProvider>();
    }
}