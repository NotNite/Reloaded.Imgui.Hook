﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Reloaded.Imgui.Hook.Misc
{
    public class Debug
    {
        public static void WriteLine(string text) => SDK.Debug?.Invoke(text);
    }
}
