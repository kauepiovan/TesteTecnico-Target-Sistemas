Console.WriteLine("Informe um numero: ");
if (int.TryParse(Console.ReadLine(), out int numero))
{
    int a = 0, b = 1;
    bool numeroPertence = false;

    while (a <= numero)
    {
        if (a == numero)
        {
            numeroPertence = true;
            break;
        }

        int proxNumero = a + b;
        a = b;
        b = proxNumero;
    }

    string respTrue = $"O numero {numero} pertence a sequencia de Fibonacci";
    string respFalse = $"O numero {numero} NAO pertence a sequencia de Fibonacci";

    if (numeroPertence)
    {
        Console.WriteLine(respTrue);
    }
    else
    {
        Console.WriteLine(respFalse);
    }
}