using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using My.Dev.Api.Models.Responses;

namespace My.Dev.Api.Services
{
    public class CartService : ICartService
    {
        public CartService()
        {
        }

        public async Task<CartCreatedResponse> CreateCartAsync()
        {
            CartCreatedResponse newCart = new CartCreatedResponse();
            return newCart;
        }
    }
}