using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;
using Twilio.Clients;
using Twilio.Http;

namespace Infra.CrossCutting.Identity.Configuration
{
    public class SmsService : ITwilioRestClient
    {
        private readonly ITwilioRestClient _twilioRestClient;
        public string AccountSid => _twilioRestClient.AccountSid;

        public string Region => _twilioRestClient.Region;

        public HttpClient HttpClient => _twilioRestClient.HttpClient;

        public SmsService(IConfiguration config, System.Net.Http.HttpClient httpClient)
        {
            httpClient.DefaultRequestHeaders.Add("X-Custom-Header", "SmsService");
            _twilioRestClient = new TwilioRestClient(
                config["Twilio:AccountSid"],
                config["Twilio:AuthToken"],
                httpClient: new SystemNetHttpClient(httpClient));
        }

        public Response Request(Request request)
        {
            return _twilioRestClient.Request(request);
        }

        public Task<Response> RequestAsync(Request request)
        {
            return _twilioRestClient.RequestAsync(request);
        }
        
    }
}