using EmojiDebugSystem;
using System;

namespace TestEnvironment
{
    class Program
    {
        static void Main(string[] args)
        {
            ThrowEx();
            Console.ReadLine();
        }

        private static void ThrowEx()
        {
            try
            {
                throw new Exception("Ahhhhh! The horror!");
            }
            catch (Exception ex)
            {
                EmojiDebug.WriteLine(DebugEmoji.Explosion, ex.Message);
            }

        }
    }
}
