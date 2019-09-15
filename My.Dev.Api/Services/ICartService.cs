using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using My.Dev.Api.Models.Responses;

namespace My.Dev.Api.Services
{
    public interface ICartService
    {
        Task<CartCreatedResponse> CreateCartAsync();
    }
}