using System;

namespace EventsDelegates
{
    public class TextService
    {
        public void OnVideoEncoded(object source, EventArgs args)
        {
            System.Console.WriteLine("TextMessage: Sending a text message...");
        }

    }
}
