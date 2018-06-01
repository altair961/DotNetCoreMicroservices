namespace HelloMicroservices.Queue
{
    using System;
    using Nancy;
    using Nancy.IO;
    using Nancy.ModelBinding;

    public class QueueModule : NancyModule
    {
        public QueueModule()
        {
            //Get<string>("queue/", _ => "555");//should get object to store in in its own dict
            Post("queue/{ntfid:int}",
                async (parameters, _) =>
                {
                    var ntfId = (int)parameters.ntfId;
                    var text = this.Bind<int[]>();

                    //string response = parameters.RecipientPhone;
                    //string notification = RequestStream.FromStream(Request.Body);

                    return text[0].ToString();//response + "hey";//"Notification with phone: " + notification.RecipientPhone + " has been added to the queue.";
                });
        }
    }
}