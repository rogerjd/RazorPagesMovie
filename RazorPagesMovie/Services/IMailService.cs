using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RazorPagesMovie.Models;

namespace RazorPagesMovie.Services
{
    public interface IMailService
    {
        Task Send(Message message);
    }
}
