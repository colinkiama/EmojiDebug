using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Text;

namespace EmojiDebug.Helpers
{
    internal static class EmojiMapHelper
    {
        internal static ConcurrentDictionary<DebugEmoji, string> CreateEmojiMap()
        {
            List<KeyValuePair<DebugEmoji, string>> emojiValues = FillInEmojiValues();

            return new ConcurrentDictionary<DebugEmoji, string>(emojiValues);
        }

        private static List<KeyValuePair<DebugEmoji, string>> FillInEmojiValues()
        {
            return new List<KeyValuePair<DebugEmoji, string>>()
            {
                new KeyValuePair<DebugEmoji, string>(DebugEmoji.BlackFlag, "🏴" ),
                new KeyValuePair<DebugEmoji, string>(DebugEmoji.Bug, "🐛"),
                new KeyValuePair<DebugEmoji, string>(DebugEmoji.Celebrate, "🎉"),
                new KeyValuePair<DebugEmoji, string>(DebugEmoji.Conflict, "⚔" ),
                new KeyValuePair<DebugEmoji, string>(DebugEmoji.Dead, "☠" ),
                new KeyValuePair<DebugEmoji, string>(DebugEmoji.Explosion, "💥" ),
                new KeyValuePair<DebugEmoji, string>(DebugEmoji.Fail, "❌" ),
                new KeyValuePair<DebugEmoji, string>(DebugEmoji.Fix, "🔨" ),
                new KeyValuePair<DebugEmoji, string>(DebugEmoji.Happy, "☺" ),
                new KeyValuePair<DebugEmoji, string>(DebugEmoji.Key, "🔑" ),
                new KeyValuePair<DebugEmoji, string>(DebugEmoji.Locked, "🔒" ),
                new KeyValuePair<DebugEmoji, string>(DebugEmoji.Message, "💬" ),
                new KeyValuePair<DebugEmoji, string>(DebugEmoji.NoAccess, "🚫"),
                new KeyValuePair<DebugEmoji, string>(DebugEmoji.BlackFlag, "🏴" ),
                new KeyValuePair<DebugEmoji, string>(DebugEmoji.BlackFlag, "🏴" ),
                new KeyValuePair<DebugEmoji, string>(DebugEmoji.BlackFlag, "🏴" ),
            };
        }
    }
}
