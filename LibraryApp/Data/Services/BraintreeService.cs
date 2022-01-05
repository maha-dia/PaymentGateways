using Braintree;
using Microsoft.Extensions.Configuration;

namespace LibraryApp.Data.Services
{
    public class BraintreeService : IBraintreeService
    {
        private readonly IConfiguration _configuration;

        public BraintreeService(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public IBraintreeGateway CreateGateway()
        {
            var gateway = new BraintreeGateway()
            {
                Environment = Braintree.Environment.SANDBOX,
                MerchantId = _configuration.GetValue<string>("BraintreeGateway:MerchantId"),
                PublicKey = _configuration.GetValue<string>("BraintreeGateway:PublicKey"),
                PrivateKey = _configuration.GetValue<string>("BraintreeGateway:PrivateKey")
            };
            return gateway;
            
        }

        public IBraintreeGateway GetGateway()
        {
            return CreateGateway(); 
        }
    }
}
