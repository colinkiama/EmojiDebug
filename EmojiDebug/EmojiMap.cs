using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Text;

namespace EmojiDebug
{   
    internal class EmojiMap: ConcurrentDictionary<DebugEmoji, string>
    {
        public EmojiMap(): base()
        {
            // Add all the emoji you want to add here
            this[DebugEmoji.]
        }
    }
}
