

using System.Text.Json;
using ConsumerUsersJsonPlaceHolder.Models;

var enderecoUrl = "https://jsonplaceholder.typicode.com/users";

var client = new HttpClient();

try
{
    HttpResponseMessage? respostaAPi = await client.GetAsync(enderecoUrl);

    respostaAPi.EnsureSuccessStatusCode();

    string respostaAPiJson = await respostaAPi.Content.ReadAsStringAsync();

    Usuarios? users = JsonSerializer.Deserialize<Usuarios>(respostaAPiJson);

    Console.WriteLine("Nome: " + users.nome);
    Console.WriteLine("Cidadde: " + users.cidade);
    Console.WriteLine("Empresa: " + users.empresa);
}
catch (System.Exception e)
{
    
    Console.WriteLine("Aconteceu um erro:\n" + e.Message);
}