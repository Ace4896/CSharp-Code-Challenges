using System;
using System.Collections.Generic;
using System.Text.Json;

namespace sendingnewsletters
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // MARK: Setup
            string jsonString =
            @"{
              ""Name"": ""Weekly Comics Newsletter!"",
              ""Admin"": ""Jane Porter"",
              ""CreatedOn"": ""2022-01-01"",
              ""Subscribers"": [
                {
                  ""Name"": ""Jack Powell"",
                  ""ID"": 231,
                  ""Email"": ""jpowell0@hplussport.com""
                },
                {
                  ""Name"": ""Emily Garcia"",
                  ""ID"": 221
                },
                {
                  ""Name"": ""Richard Dean"",
                  ""ID"": 211
                },
                {
                  ""Name"": ""Jane Larson"",
                  ""ID"": 201,
                  ""Email"": ""jlarsone@hplussport.com""  
                }
              ]
            }";

            Console.WriteLine("Hit ENTER to find out who's missing an email!");
            Console.ReadKey();

            // MARK: Result
            var customerIDs = DecryptJSON(jsonString);
            foreach (var id in customerIDs)
            {
                Console.WriteLine($"\nSend missing info prompt to user ID: {id}");
            }

            Console.ReadKey();
        }

        // MARK: Write your solution here...
        public static List<int> DecryptJSON(string json)
        {
            // Goal is to find any subscribers who haven't provided an email
            // We could deserialize to a class instead (where email is nullable), then check this field
            // But this is an alternative which performs this task manually, avoiding unnecessary parsing
            List<int> idsWithNoEmail = new();

            // Reference solution parsed to a document, then used the root element to traverse the JSON structure
            // Seems neater than my attempt here
            //JsonNode rootNode = JsonNode.Parse(json);
            //if (rootNode["Subscribers"]?.AsArray() is not JsonArray subscribersArray)
            //{
            //    throw new ArgumentException("Missing 'Subscribers' array");
            //}

            //foreach (JsonNode subscriber in subscribersArray)
            //{
            //    JsonObject subscriberObject = subscriber.AsObject();
            //    if (!subscriberObject.ContainsKey("Email"))
            //    {
            //        if (subscriberObject.TryGetPropertyValue("ID", out JsonNode idNode) && idNode.AsValue().TryGetValue(out int id))
            //        {
            //            idsWithNoEmail.Add(id);
            //        }
            //        else
            //        {
            //            throw new ArgumentException("Missing 'ID' field in 'Subscribers' array");
            //        }
            //    }
            //}

            try
            {
                using JsonDocument jsonDocument = JsonDocument.Parse(json);
                JsonElement subscribersArray = jsonDocument.RootElement.GetProperty("Subscribers");

                foreach (JsonElement subscriber in subscribersArray.EnumerateArray())
                {
                    if (!subscriber.TryGetProperty("Email", out JsonElement _))
                    {
                        int id = subscriber.GetProperty("ID").GetInt32();
                        idsWithNoEmail.Add(id);
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Error while traversing JSON");
            }


            return idsWithNoEmail;
        }
    }
}
