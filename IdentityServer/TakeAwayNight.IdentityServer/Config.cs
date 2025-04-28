// Copyright (c) Brock Allen & Dominick Baier. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.


using IdentityServer4;
using IdentityServer4.Models;
using System.Collections.Generic;

namespace TakeAwayNight.IdentityServer
{
    public static class Config
    {
        public static IEnumerable<ApiResource> ApiResources = new ApiResource[]
        {
            new ApiResource("ResourceCatalog"){Scopes={"CatalogFullPermission","CatalogReadPermission"}},
            new ApiResource("ResourceDiscount"){Scopes={"DiscountFullPermission"}},
            new ApiResource("ResourceDiscount2"){Scopes={"DiscountDeleteFullPermission"}},
            new ApiResource("ResourceOrder"){Scopes={"OrderFullPermission"}},
            new ApiResource("ResourceCargo"){Scopes={"CargoFullPermission"}},
            new ApiResource("ResourceBasket"){Scopes={"BasketFullPermission"}},
            new ApiResource("ResourceComment"){Scopes={"CommentFullPermission"}},
            new ApiResource("ResourceOcelot"){Scopes={"OcelotFullPermission"}},
            new ApiResource("ResourceMessage"){Scopes={"MessageFullPermission"}},
            new ApiResource(IdentityServerConstants.LocalApi.ScopeName)
        };

        public static IEnumerable<IdentityResource> IdentityResources => new IdentityResource[]
        {
            new IdentityResources.OpenId(),
            new IdentityResources.Profile(),
            new IdentityResources.Email()
        };

        public static IEnumerable<ApiScope> ApiScopes => new ApiScope[]
        {
            new ApiScope("CatalogFullPermission", "Full access to catalog"),
            new ApiScope("DiscountFullPermission", "Full access to discount"),
            new ApiScope("DiscountDeletePermission", "Full access to discount"),
            new ApiScope("OrderFullPermission", "Full access to order"),
            new ApiScope("CargoFullPermission", "Full access to Cargo"),
            new ApiScope("BasketFullPermission", "Full access to Basket"),
            new ApiScope("CommentFullPermission", "Full access to Comment"),
            new ApiScope("MessageFullPermission", "Full access to Message"),
            new ApiScope("OcelotFullPermission", "Full access to Ocelot"),
            new ApiScope(IdentityServerConstants.LocalApi.ScopeName)
        };
        public static IEnumerable<Client> Clients => new Client[]
        {
            new Client
            {
                ClientId="TakeAwayVisitorId",
                ClientName="TakeAwayVisitor User",
                AllowedGrantTypes=GrantTypes.ClientCredentials,
                ClientSecrets={new Secret("takeawaysecret".Sha256())},
                AllowedScopes={"CatalogFullPermission","OcelotFullPermission",IdentityServerConstants.LocalApi.ScopeName },
                AccessTokenLifetime=300
            },
            new Client
            {
                ClientId="TakeAwayAdminId",
                ClientName="TakeAwayAdminUser",
                AllowedGrantTypes=GrantTypes.ResourceOwnerPassword,
                ClientSecrets={new Secret("takeawaysecret".Sha256())},
                AllowedScopes={"CatalogFullPermission", "DiscountFullPermission", "DiscountDeletePermission", "OrderFullPermission", "CargoFullPermission","BasketFullPermission", "CommentFullPermission", "MessageFullPermission", "OcelotFullPermission",IdentityServerConstants.LocalApi.ScopeName,IdentityServerConstants.StandardScopes.OpenId,IdentityServerConstants.StandardScopes.Email,IdentityServerConstants.StandardScopes.Profile },
                AccessTokenLifetime=750
            }
        };
    }
}