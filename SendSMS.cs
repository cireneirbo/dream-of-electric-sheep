// using System;
// using System.Threading.Tasks;
// using Twilio;
// using Twilio.Rest.Api.V2010.Account;

// namespace dream_of_electric_sheep {
//     public class SendSMS {
//         // Install the C# / .NET helper library from twilio.com/docs/csharp/install

//         static void Main(string[] args) {
//             SendSms().Wait();
//             Console.Write("Press any key to continue.");
//             Console.ReadKey();
//         }

//         static async Task SendSms() {
//             // Find your Account Sid and Token at twilio.com/console
//             const string accountSid = "ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX";
//             const string authToken = "your_auth_token";

//             TwilioClient.Init(accountSid, authToken);

//             var message = await MessageResource.CreateAsync(
//                 body: "This is the ship that made the Kessel Run in fourteen parsecs?",
//                 from: new Twilio.Types.PhoneNumber("+15017122661"),
//                 to: new Twilio.Types.PhoneNumber("+1xxxxxxxxxx")
//             );

//             Console.WriteLine(message.Sid);
//         }

//     }
// }