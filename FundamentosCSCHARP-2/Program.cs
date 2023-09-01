using FundamentosCSCHARP_2.Models;
using FundamentosCSHARP.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace FundamentosCSCHARP_2
{
    internal class Program
    {
        static async Task Main(string[] args)
        {

            //Cerveza cerveza = new Cerveza(10, "Cerveza");
            //string miJson = JsonSerializer.Serialize(cerveza);
            //File.WriteAllText("objeto.txt", miJson);

            //string miJson = File.ReadAllText("objeto.txt");
            //Cerveza cerveza = JsonSerializer.Deserialize<Cerveza>(miJson);

            //consumir un webservis

            //string Url = "https://jsonplaceholder.typicode.com/posts";
            //HttpClient client = new HttpClient();

            //var httpResponse = await client.GetAsync(Url); // va al mesero

            //if (httpResponse.IsSuccessStatusCode)
            //{
            //    var content = await httpResponse.Content.ReadAsStringAsync();

            //    List<Models.Post> posts =
            //        JsonSerializer.Deserialize<List<Models.Post>>(content);
            //}

            // PETICION POST

            //string Url = "https://jsonplaceholder.typicode.com/posts";
            //var client = new HttpClient();


            //Post post = new Post()
            //{
            //    userId = 1,
            //    body = "Hola Como estan",
            //    title = "titulo de saludo",
            //};


            //var data = JsonSerializer.Serialize<Post>(post);
            //HttpContent content = 
            //    new StringContent(data,System.Text.Encoding.UTF8, "application/json");
            //var httpResponse = await client.PostAsync(Url, content);


            //if (httpResponse.IsSuccessStatusCode)
            //{
            //    var result = await httpResponse.Content.ReadAsStringAsync();

            //    var postResult = JsonSerializer.Deserialize<Post>(result);
            //}


            //PETICION PUT


            //string Url = "https://jsonplaceholder.typicode.com/posts/99";
            //var client = new HttpClient();


            //Post post = new Post()
            //{
            //    userId = 1,
            //    body = "Hola Como estan",
            //    title = "titulo de saludo",
            //};


            //var data = JsonSerializer.Serialize<Post>(post);
            //HttpContent content =
            //    new StringContent(data, System.Text.Encoding.UTF8, "application/json");
            //var httpResponse = await client.PutAsync(Url, content);


            //if (httpResponse.IsSuccessStatusCode)
            //{
            //    var result = await httpResponse.Content.ReadAsStringAsync();

            //    var postResult = JsonSerializer.Deserialize<Post>(result);
            //}


            // PETECION DELETE


            string Url = "https://jsonplaceholder.typicode.com/posts/99";
            var client = new HttpClient();


            //Post post = new Post()
            //{
            //    userId = 1,
            //    body = "Hola Como estan",
            //    title = "titulo de saludo",
            //};


            //var data = JsonSerializer.Serialize<Post>(post);
            //HttpContent content =
            //    new StringContent(data, System.Text.Encoding.UTF8, "application/json");
            var httpResponse = await client.DeleteAsync(Url);


            if (httpResponse.IsSuccessStatusCode)
            {
                var result = await httpResponse.Content.ReadAsStringAsync();

                //var postResult = JsonSerializer.Deserialize<Post>(result);
            }

        }
    }

}
