using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDotNet.EventTopic
{
    public class Invoker
    {
        static void Main()
        {
            // subscribe to the event
            // raise an event
            // check if you receive the subscription

            Video video = new Video { Title = "==> My First YouTube Adventure Vlog!!!" };
            VideoEncoder videoEncoder = new VideoEncoder();

            videoEncoder.VideoEncoderEvent += new MailService().SendMail; //subscribe
            videoEncoder.VideoEncoderEvent += new MessageService().SendMessage;  //subscribe

            videoEncoder.Encoder(video); //raise an event

            Console.ReadLine();
        }


    }
    public class Subscriber
    {

    }
    public class VideoEncodeEventArgs : EventArgs
    {
        public Video Video { get; set; }
    }

    public class MailService
    {
        public void SendMail(object source, VideoEncodeEventArgs args)
        {
            Console.WriteLine("Subscribed: Mail Service sending mail...... Video Title " + args.Video.Title);
        }
    }

    public class MessageService
    {
        public void SendMessage(object source, VideoEncodeEventArgs args)
        {
            Console.WriteLine("Subscribed: Message Service sending message......Video Title " + args.Video.Title);
        }
    }
}
