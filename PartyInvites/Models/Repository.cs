using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PartyInvites.Models
{
    public class Repository
    {

        private static List<GuestResponse> responses = new List<GuestResponse>();


        public static IEnumerable<GuestResponse> Responses => responses;

        public static void AddResponse(GuestResponse guestResponse)
        {
            responses.Add(guestResponse);
        }

    }
}
