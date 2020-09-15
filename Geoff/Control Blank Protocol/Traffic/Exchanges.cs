using System;
using RestSharp;

namespace Geoff.Control_Blank_Protocol.Traffic
{
    public class Exchanges
    {
        public Exchanges(int euroCentPercent)
        {
            Crown = euroCentPercent;
        }

        public Exchanges(string symbol)
        {
            // Check for symbol availability

            var BPClient = new RestClient("https://api.exchange.bitpanda.com/public/v1");
            // client.Authenticator = new HttpBasicAuthenticator("bearer","eyJvcmciOiJiaXRwYW5kYS1nZSIsImFsZyI6IlJTMjU2Iiwia2lkIjoiZXhjaGFuZ2UtbGl2ZSJ9.eyJhdWQiOlsiaHR0cHM6XC9cL2FwaS5leGNoYW5nZS5iaXRwYW5kYS5jb20iLCJ3c3M6XC9cL3N0cmVhbXMuZXhjaGFuZ2UuYml0cGFuZGEuY29tIl0sInN1YiI6ImFjYzpiMGM1NmM0ZC01NjQxLTRjNGYtYjliZS01ZTA3NmQ3ZmQxOWEiLCJzY3AiOlsiUkVBRF9PTkxZIl0sIm5iZiI6MTU5NjE0NDc5MSwiaXNzIjoiaHR0cHM6XC9cL2FwaS5leGNoYW5nZS5iaXRwYW5kYS5jb21cL29hdXRoMiIsImlwcyI6W10sImlhdCI6MTU5NjE0NDc5MSwianRpIjoiMWQ2MzIyZmItZjEwZC00N2RjLTk3YWItOTU3NWJiZWUyZTJiIn0.HFdz2OsXCtKC5iBpdshRtZr6_ZxkJovRpBTOdkBu9xwJ730Efr_W7JWXs0An5gG9J9MRoIhVFElFB4nkWJnQ1nnU1xMl0IF6WSo0_oWNoGy_AOmAN7N-VZbm4Yk5fABbkMwMOB8M1BTRfSBvxoaSGYo7nxaJ2vmlCWEwh9CZeDplzKnEGiWuDDu4ONj2EfiYLjkulTOIBXJ8JGa5OEg2-0Giiihpt6NGfNs7YMrTjzafIvGRKm4I4oD4GvfhK6-G6a9JUlB-wyr4UCzETgj1srtXmeyawGPrYVM8jDaOzL8kJamFQp7shYCKXTUMoxPNM4rs6JGKdXh7bnVyXh45xuZrpMsr14tJYgDeNut_v2jayhf79Sf2Bdb3zxRyaZAvNnEwVxjssHjo2BybNO3z7YP1s5wSodyKQIKnur12pqFLuwQXkP3oYGUlBWs9rBnHAK-AGfmdXx6TSBhOLCehv7bJE2CR8eP5cGbH7PfNLeCTqknwnVLw6s64AuYII1Vbng1WKMnGifYKk5GPICQ3_8EVgm07cDYCf2L3eJ8QmU2Nht9eXrmbtP-I8nV1KkdS7W2fj18yjq6fPA4lT2cZ6m3wjhkOAyZOrKfPjE4wJx_WwSsMdIk6vvJhSdRIikCxZa1FjJSbGMJkgY4jE3adMJUtd-Ax9Kpd0W9xNzZeXdA");
            var BPRequest = new RestRequest("currencies", DataFormat.Json);
            var BPResponse = BPClient.Get(BPRequest);

            var BClient = new RestClient("https://api.binance.com/api/v3");
            var BRequest = new RestRequest("exchangeInfo", DataFormat.Json);
            var BResponse = BClient.Get(BRequest);

            var AClient = new RestClient("https://127.0.0.1");
            var ARequest = new RestRequest("currencies", DataFormat.Json);
            var AResponse = AClient.Get(ARequest);
            
//            SymbolTriplet = new Tuple<char, char, char>(AResponse.IsSuccessful, BResponse.IsSuccessful, BPResponse.IsSuccessful);
        }

        public Exchanges(char letter)
        {

        }

        public static int Crown { get; set; }
        public Tuple<char, char, char> SymbolTriplet { get; set; }
    }
}