using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;

namespace DMM.Services
{
    public class SharedMethods
    {
        
        public async Task CheckIfLoggedIn(AuthenticationStateProvider AuthenticationStateProvider, NavigationManager NavigationManager)
        {
            var authState = await AuthenticationStateProvider.GetAuthenticationStateAsync();
            var user = authState.User;
            if (!user.Identity.IsAuthenticated)
            {
                NavigationManager.NavigateTo("/Identity/Account/Login");
            }
        }
    }
}
