using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PartyInvites.Models
{
    public static class Repository
    {
        private static List<GuestReponse> responses = new List<GuestReponse>();

        public static IEnumerable<GuestReponse> Responses
        {
            get
            {
                return responses;
            }
        }

        public static void AddResponse(GuestReponse guestResponse)
        {
            responses.Add(guestResponse);
        }

    }
}
