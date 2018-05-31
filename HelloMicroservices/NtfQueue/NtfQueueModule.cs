namespace HelloMicroservices.Queue
{
    using System;
    using Nancy;
    using Nancy.ModelBinding;

    public class QueueModule : NancyModule
    {
        public QueueModule()
        {
            //Get<string>("queue/", _ => "555");//should get object to store in in its own dict
            Post("queue/{ntfid:int}", 
                async ( parameters, _) =>
                {
                    var ntfId = (int) parameters.ntfId;
                    var notification = this.Bind<Notification>();
                    
                    return "Notification with phone: " + notification.RecipientPhone + " has been added to the queue.";
                });
        }
    }
}