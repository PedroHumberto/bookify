using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bookify.Application.Abstractions.Email;

namespace Bookify.Infrastructure.Email
{
    internal sealed class EmailService : IEmailService
    {
        public Task SendAsyn(Domain.Users.Email recipient, string subject, string body)
        {
           return Task.CompletedTask;
        }
    }
}