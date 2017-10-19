using System;
using System.Collections.Generic;
using System.Text;
using AspNet.Security.OpenIdConnect.Primitives;
using EAP.Model;
using Microsoft.AspNetCore.Http;

namespace EAP.Service.UnitOfWork
{
    public class HttpUnitOfWork : UnitOfWork
    {
        public HttpUnitOfWork(EAPContext context, IHttpContextAccessor httpAccessor) : base(context)
        {
            context.CurrentUserId = httpAccessor.HttpContext.User.FindFirst(OpenIdConnectConstants.Claims.Subject)?.Value?.Trim();
        }
    }
}
