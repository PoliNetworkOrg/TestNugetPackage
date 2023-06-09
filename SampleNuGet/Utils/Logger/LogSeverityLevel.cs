﻿using JetBrains.Annotations;

namespace SampleNuGet.Utils.Logger;

[PublicAPI]
public enum LogSeverityLevel
{
    EMERGENCY = 1,
    ALERT = 2,
    CRITICAL = 3,
    ERROR = 4,
    WARNING = 5,
    NOTICE = 6,
    INFO = 7,
    DEBUG = 8,
    DATABASE_QUERY = 9
}