namespace NotificationSystem.SmsModule
{
    using Nancy;
    using Nancy.ModelBinding;
    public class SmsNotifierModule : NancyModule
    {
        public SmsNotifierModule()
        {
            Post("smsnotifier/{smsid:int}",
                async (parameters, _) =>
                {
                    var smsId = (int)parameters.smsid;

                    var smsNotification =  this.Bind<SmsNotification>();

                    return smsNotification.Message;
                });
        }
    }
}