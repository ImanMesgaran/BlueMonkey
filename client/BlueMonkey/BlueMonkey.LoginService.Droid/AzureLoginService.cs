using Microsoft.WindowsAzure.MobileServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BlueMonkey.LoginService.Droid
{
    public class AzureLoginService : ILoginService
    {
        private readonly IMobileServiceClient _client;

        public AzureLoginService(IMobileServiceClient client)
        {
            _client = client;
        }

        public async Task<bool> LoginAsync()
        {
            var user = await _client.LoginAsync(Forms.Context, MobileServiceAuthenticationProvider.MicrosoftAccount);
            return user != null;
        }
    }
}
