using System;
using System.Collections.Generic;
using System.Text;

namespace My.Dev.Api.Models.Responses
{
    public class CartCreatedResponse
    {
        public CartCreatedResponse()
        {
            CartId = CartId;
        }

        public string CartId { get; set; }

        public static implicit operator CartCreatedResponse(string cartId)
        {
            return new CartCreatedResponse
            {
                CartId = cartId
            };
        }
    }
}