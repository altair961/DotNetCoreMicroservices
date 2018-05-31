namespace HelloMicroservices.Queue
{
    using System;
    using Nancy;

    public class QueueModule : NancyModule
    {
        public QueueModule()
        {
            //Get<string>("queue/", _ => "555");//should get object to store in in its own dict
            Post("queue/{ntfid:int}", 
                async ( parameters, _) =>
                {
                    var ntfId = (int) parameters.ntfId;
                    return "Notification with id " + ntfId + " has been added to the queue.";
                });
        }
    }
}