using System;
using System.Threading;

namespace EventsDelegates
{
    internal class VideoEncoder
    {
        public VideoEncoder()
        {
        }
        // 1 - Define a delegate 
        // 2 - Define event based on that delegate
        // 3 - Raise or publish that event

        // signature of event handler, first the object(source of the event) and next the Event args
        public delegate void VideoEncodedEventHandler(object source, EventArgs args);
        public event VideoEncodedEventHandler VideoEncoded;

        public void Encode(Video video)
        {
            Console.WriteLine("Encode video...");
            Thread.Sleep(3000);

            OnVideoEncoded();
        }
 
        //raises the event
        protected virtual void OnVideoEncoded()
        {
            if (VideoEncoded != null)
                VideoEncoded(this, EventArgs.Empty);
        }
    }
}