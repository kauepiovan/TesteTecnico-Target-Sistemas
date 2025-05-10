// • SP – R$67.836,43
//• RJ – R$36.678,66
//• MG – R$29.229,88
//• ES – R$27.165,48
//• Outros – R$19.849,53
// total - 180759.98

double valorSP = 67836.43;
double valorRJ = 36678.66;
double valorMG = 29229.88;
double valorES = 27165.48;
double outros = 19849.53;

double total = valorSP + valorRJ + valorMG + valorES + outros;

double percentualSP = (valorSP / total) * 100;
double percentualMG = (valorMG / total) * 100;
double percentualRJ = (valorRJ / total) * 100;
double percentualES = (valorES / total) * 100;
double percentualOutros = (outros / total) * 100;

Console.WriteLine($"O percentual de SP foi: {percentualSP:f2}%");
Console.WriteLine($"O percentual de RJ foi: {percentualRJ:f2}%");
Console.WriteLine($"O percentual de MG foi: {percentualMG:f2}%");
Console.WriteLine($"O percentual de ES foi: {percentualES:f2}%");
Console.WriteLine($"O percentual de Outros estados foi: {percentualOutros:f2}%");


