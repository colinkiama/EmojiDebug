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
            // 1. Create String (with emoji)
            string emojiString = EmojiMap[emoji];
            string emojiSection = $"{emojiString} ";
            // 2. Determine Output method to run

            switch (OutputLocation)
            {
                case OutputMethod.Console:
                    Debug.Write(emojiSection);
                    Debug.Write(e);
                    break;
                case OutputMethod.Debug:
                    Console.Write(emojiSection);
                    Console.Write(e);
                    break;

            }
        }

        public static void Write(DebugEmoji emoji, string message)
        {
            // 1. Create String (with emoji)
            string emojiString = EmojiMap[emoji];
            string messageToPrint = $"{emojiString} {message}";

            // 2. Determine Output method to run

            switch (OutputLocation)
            {
                case OutputMethod.Console:
                    Debug.Write(messageToPrint);
                    break;
                case OutputMethod.Debug:
                    Console.Write(messageToPrint);
                    break;
            }


        }

        public static void WriteLine(DebugEmoji emoji, Exception e)
        {
            // 1. Create String (with emoji)
            string emojiString = EmojiMap[emoji];
            string emojiSection = $"{emojiString} ";
            // 2. Determine Output method to run

            switch (OutputLocation)
            {
                case OutputMethod.Console:
                    Debug.Write(emojiSection);
                    Debug.WriteLine(e);
                    break;
                case OutputMethod.Debug:
                    Console.Write(emojiSection);
                    Console.WriteLine(e);
                    break;

            }
        }

        public static void WriteLine(DebugEmoji emoji, string message)
        {
            // 1. Create String (with emoji)
            string emojiString = EmojiMap[emoji];
            string messageToPrint = $"{emojiString} {message}";

            // 2. Determine Output method to run

            switch (OutputLocation)
            {
                case OutputMethod.Console:
                    Debug.WriteLine(messageToPrint);
                    break;
                case OutputMethod.Debug:
                    Console.WriteLine(messageToPrint);
                    break;
            }
        }


    }
}
