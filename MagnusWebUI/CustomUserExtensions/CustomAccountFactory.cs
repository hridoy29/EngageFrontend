﻿using System.Security.Claims;
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;
using Microsoft.AspNetCore.Components.WebAssembly.Authentication.Internal;
using Microsoft.Graph;

public class CustomAccountFactory
    : AccountClaimsPrincipalFactory<CustomUserAccount>
{
    private readonly ILogger<CustomAccountFactory> logger;
    private readonly IServiceProvider serviceProvider;

    public CustomAccountFactory(IAccessTokenProviderAccessor accessor,
        IServiceProvider serviceProvider,
        ILogger<CustomAccountFactory> logger)
        : base(accessor)
    {
        this.serviceProvider = serviceProvider;
        this.logger = logger;
    }

    public override async ValueTask<ClaimsPrincipal> CreateUserAsync(
        CustomUserAccount account,
        RemoteAuthenticationUserOptions options)
    {
        var initialUser = await base.CreateUserAsync(account, options);

        if (initialUser.Identity is not null &&
            initialUser.Identity.IsAuthenticated)
        {
            var userIdentity = initialUser.Identity as ClaimsIdentity;

            if (userIdentity is not null)
            {
                account?.Roles?.ForEach((role) =>
                {
                    userIdentity.AddClaim(new Claim("appRole", role));
                });

                account?.Wids?.ForEach((wid) =>
                {
                    userIdentity.AddClaim(new Claim("directoryRole", wid));
                });

                try
                {
                    var client = ActivatorUtilities
                        .CreateInstance<GraphServiceClient>(serviceProvider);
                    var request = client.Me.Request();
                    var ObjectIdResult = await client.Me.Request().GetAsync();
                    var ObjectId = ObjectIdResult.Id;
                    var user = await request.GetAsync();
                    var requestMemberOf = client.Users[account?.Oid].MemberOf;
                    var memberships = await requestMemberOf.Request().GetAsync();

                    if (user is not null)
                    {
                        userIdentity.AddClaim(new Claim("mobilephone",
                            user.MobilePhone ?? "(000) 000-0000"));
                        userIdentity.AddClaim(new Claim("officelocation",
                            user.OfficeLocation ?? "Not set"));
                        userIdentity.AddClaim(new Claim("oid",
                            ObjectId ?? "Not set"));

                    }

                    

                    if (memberships is not null)
                    {
                        foreach (var entry in memberships)
                        {
                            if (entry.ODataType == "#microsoft.graph.group")
                            {
                                userIdentity.AddClaim(
                                    new Claim("directoryGroup", entry.Id));
                            }
                        }
                    }
                }
                catch (AccessTokenNotAvailableException exception)
                {
                    exception.Redirect();
                }
            }
        }

        return initialUser;
    }
}