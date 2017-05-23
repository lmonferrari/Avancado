using System;

namespace EventsDelegates
{
    class MailService
    {
        public void OnVideoEncoded(object source, EventArgs args)
        {
            System.Console.WriteLine("MailService: Sending an email...");
        }
    }
}
