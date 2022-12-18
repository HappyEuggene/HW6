using HW4;
using System.Text.Json;

string path = "./JSON.json";
var content = File.ReadAllText(path);
var deserializedJson = JsonSerializer.Deserialize<List<Book>>(content);