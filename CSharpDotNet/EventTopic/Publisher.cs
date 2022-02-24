using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpDotNet.EventTopic
{
    class Publisher
    {
    }

    public class Video
    {
        public string Title { get; set; }
    }

    public class VideoEncoder 
    {
        // create a delegate
        // create an event based on the delegate
        // raise an event and subscribe to it

        // public delegate void VideoEncoderDelegate(object source, EventArgs); //delegate
        public delegate void VideoEncoderDelegate(object source, VideoEncodeEventArgs args); //delegate
        public event VideoEncoderDelegate VideoEncoderEvent;

        public void Encoder_WithoutEvent(Video video)
        {
            Console.WriteLine("Video Encoding........... Video Title " + video.Title);
            Thread.Sleep(4000);

            // This is not the idle place to keep this mail/ message service code to keep at
            new MailService().SendMail(this, new VideoEncodeEventArgs { Video = video });
            new MessageService().SendMessage(this, new VideoEncodeEventArgs { Video = video });
        }

        public void Encoder(Video video)
        {
            Console.WriteLine("Video Encoding........... " + video.Title);
            Thread.Sleep(4000);

            OnVideoEncoderEventHandler(video);
        }

        protected void OnVideoEncoderEventHandler(Video video)
        {
            if (VideoEncoderEvent != null)
                VideoEncoderEvent(this, new VideoEncodeEventArgs() { Video = video});
        }

    }
}
