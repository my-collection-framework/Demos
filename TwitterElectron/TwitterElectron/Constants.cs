﻿using Bridge;

namespace TwitterElectron
{
    [External]
    public static class Constants
    {
        [InlineConst]
        public const string AppTitle = "Retyped: Electron + Twitter API Demo";

        [InlineConst]
        public const string UserSettingsFileName = "UserSettings.json";

        public static class IPC
        {
            [InlineConst]
            public const string StartCapture = "cmd-start-capture";

            [InlineConst]
            public const string StopCapture = "cmd-stop-capture";

            [InlineConst]
            public const string ClearCapture = "cmd-clear-capture";

            [InlineConst]
            public const string OptionsUpdated = "cmd-options-updated";

            [InlineConst]
            public const string RestoreOptions = "cmd-options-restore";
        }
    }
}