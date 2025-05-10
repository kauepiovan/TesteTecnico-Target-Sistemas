Console.WriteLine("Digite uma string: ");
string texto = Console.ReadLine();

char[] caracteres = texto.ToCharArray();

int caractereInicio = 0, caractereFinal = caracteres.Length - 1;

while (caractereInicio < caractereFinal)
{
    char temp = caracteres[caractereInicio];
    caracteres[caractereInicio] = caracteres[caractereFinal];
    caracteres[caractereFinal] = temp;
    caractereInicio++;
    caractereFinal--;
}

string textoInvertido = new string(caracteres);
Console.WriteLine($"String invertida: {textoInvertido}");