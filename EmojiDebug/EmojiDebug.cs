using EmojiDebugSystem.Enums;
using EmojiDebugSystem.Helpers;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;

namespace EmojiDebugSystem
{
    public static class EmojiDebug
    {
        public static OutputMethod OutputLocation = OutputMethod.Debug;
        internal static ConcurrentDictionary<DebugEmoji, string> EmojiMap = EmojiMapHelper.CreateEmojiMap();



        public static void Write(DebugEmoji emoji, Exception e)
        {
            string emojiString = EmojiMap[emoji];
            string emojiSection = $"{emojiString} ";

            switch (OutputLocation)
            {
                case OutputMethod.Debug:
                    Debug.Write(emojiSection);
                    Debug.Write(e);
                    break;
                case OutputMethod.Console:
                    Console.Write(emojiSection);
                    Console.Write(e);
                    break;

            }
        }

        public static void Write(DebugEmoji emoji, string message)
        {
            string emojiString = EmojiMap[emoji];
            string messageToPrint = $"{emojiString} {message}";


            switch (OutputLocation)
            {
                case OutputMethod.Debug:
                    Debug.Write(messageToPrint);
                    break;
                case OutputMethod.Console:
                    Console.Write(messageToPrint);
                    break;
            }


        }

        public static void WriteLine(DebugEmoji emoji, Exception e)
        {
            string emojiString = EmojiMap[emoji];
            string emojiSection = $"{emojiString} ";

            switch (OutputLocation)
            {
                case OutputMethod.Debug:
                    Debug.Write(emojiSection);
                    Debug.WriteLine(e);
                    break;
                case OutputMethod.Console:
                    Console.Write(emojiSection);
                    Console.WriteLine(e);
                    break;

            }
        }

        public static void WriteLine(DebugEmoji emoji, string message)
        {
          
            string emojiString = EmojiMap[emoji];
            string messageToPrint = $"{emojiString} {message}";

            switch (OutputLocation)
            {
                case OutputMethod.Debug:
                    Debug.WriteLine(messageToPrint);
                    break;
                case OutputMethod.Console:
                    Console.WriteLine(messageToPrint);
                    break;
            }
        }


    }
}
