using System.Globalization;
using System.Text.Json;

var data = File.ReadAllText(".\\dados.json");
// Console.WriteLine(data);

var faturamentos = new List<Faturamento>();

faturamentos = JsonSerializer.Deserialize<List<Faturamento>>(data);

// foreach (var x in faturamentos)
//     Console.WriteLine($"dia={x.dia} | valor={x.valor}");
var listaFiltrada = GeraListaFiltrada(faturamentos);

string maiorValor = CalculaMaiorValor(listaFiltrada).ToString("c", new CultureInfo("pt-br"));
string menorValor = CalculaMenorValor(listaFiltrada).ToString("c", new CultureInfo("pt-br"));
string media = CalculaMedia(listaFiltrada).ToString("c", new CultureInfo("pt-br"));
int qtdDiasAcimaMedia = DiasAcimaDaMedia(listaFiltrada, CalculaMedia(listaFiltrada));

Console.WriteLine($"O maior valor registrado: {maiorValor}");
Console.WriteLine($"O menor valor registrado (diferente de 0): {menorValor}");
Console.WriteLine($"A media dos valores somente e dias que o faturamento foi acima de 0: {media}");
Console.WriteLine($"A quatidade de dias que passaram da media: {qtdDiasAcimaMedia}");


static int DiasAcimaDaMedia(List<Faturamento> faturamentos, double media)
{
    int cont = 0;
    foreach (var fatura in faturamentos)
    {
        if (fatura.valor > media)
        {
            cont++;
        }
    }
    return cont;
}

static double CalculaMedia(List<Faturamento> faturamentos)
{
    double media = 0;

    foreach (var fatura in faturamentos)
        media += fatura.valor;

    media = media / faturamentos.Count;

    return media;
}

static double CalculaMaiorValor(List<Faturamento> lista)
{
    double maiorValor = lista[0].valor;
    for (int i = 1; i < lista.Count; i++)
    {

        if (lista[i].valor > maiorValor)
            maiorValor = lista[i].valor;

        // Console.WriteLine(i);
    }
    return maiorValor;
}

static double CalculaMenorValor(List<Faturamento> lista)
{
    double menorValor = lista[0].valor;
    for (int i = 1; i < lista.Count; i++)
    {

        if (lista[i].valor < menorValor)
            menorValor = lista[i].valor;

        // Console.WriteLine(i);
    }
    return menorValor;
}

static List<Faturamento> GeraListaFiltrada(List<Faturamento> faturas)
{
    var listaFiltrada = new List<Faturamento>();

    foreach (var fatura in faturas)
    {
        if (fatura.valor != 0)
            listaFiltrada.Add(fatura);
    }

    return listaFiltrada;
}


public class Faturamento
{
    public int dia { get; set; }
    public double valor { get; set; }
}


