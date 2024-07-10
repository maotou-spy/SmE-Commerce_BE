﻿using System;
using System.Collections.Generic;

namespace BusinessObjects.Models;

public partial class Setting : Common.Common
{
    public int SettingId { get; set; }

    public string SettingKey { get; set; } = null!;

    public string SettingValue { get; set; } = null!;

    public string? Description { get; set; }
}
