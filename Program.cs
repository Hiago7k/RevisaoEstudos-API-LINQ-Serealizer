using (HttpClient client = new HttpClient())
{
    var resposta  = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
    Console.WriteLine(resposta);
}

    
