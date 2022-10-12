using System;

namespace Form_PasswordGeneratorProject {
    public static class Globals {
        public const int MaxPasswordLength = 24;
        private const int FramesPerSecond = 60;

        public static int DelayBetweenFramesInMs() {
            return (1000 / FramesPerSecond);
        }
        public static int DelayBetweenFramesInMs(int fps) {
            return (1000 / fps);
        }
    }
    public static class Utilities {
        
    }
}