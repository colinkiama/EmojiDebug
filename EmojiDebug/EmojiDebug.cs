using EmojiDebug.Enums;
using EmojiDebug.Helpers;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;

namespace EmojiDebug
{
    public static class EmojiDebug
    {
        public static OutputMethod OutputLocation = OutputMethod.Debug;
        internal static ConcurrentDictionary<DebugEmoji, string> EmojiMap = EmojiMapHelper.CreateEmojiMap();

        

        public static void Write(DebugEmoji emoji, Exception e) 
        {
            
        }

        public static void Write(DebugEmoji emoji, string message)
        {
            // 1. Create String (with emoji)
            string emojiString = 

            // 2. Determine Output method to run

            Action<string> OutputMethodToRun;

            switch (OutputLocation)
            {
                case OutputMethod.Console:
                    OutputMethodToRun = Debug.WriteLine("");
                    break;
                case OutputMethod.Debug:
                    break;
                default:
                    break;
            }

            // 3. Print the message
        }

        public static void WriteLine(DebugEmoji emoji, Exception e) { }

        public static void WriteLine(DebugEmoji emoji, string message)
        {

        }

        
    }
}
