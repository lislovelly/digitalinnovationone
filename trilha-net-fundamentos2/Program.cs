using trilha_net_fundamentos2.Models;
using Newtonsoft.Json;

Venda v1 = new Venda(1, "Mterial de escritório", 25.00M);

string serializado = JsonConvert.SerializeObject(v1);