using trilha_net_fundamentos2.Models;
using Newtonsoft.Json;

List<Venda> listaVendas = new List<Venda>();

Venda v1 = new Venda(1, "Material de escritório", 25.00M);
Venda v2 = new Venda(2, "Licença de Software", 110.00M);

listaVendas.Add(v1);
listaVendas.Add(v2);

string serializado = JsonConvert.SerializeObject(listaVendas, Formatting.Indented);

File.WriteAllText("Arquivos/vendas.json", serializado);

Console.WriteLine(serializado);