using trilha_net_fundamentos2.Models;
using Newtonsoft.Json;

Venda v1 = new Venda(1, "Material de escritório", 25.00M);

string serializado = JsonConvert.SerializeObject(v1, Formatting.Indented);
Console.WriteLine(serializado);