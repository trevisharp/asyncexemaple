using System;
using System.Threading.Tasks;

Action evento = () =>
{
    Console.WriteLine("Xispita!!");
};

Action outroevento = async () =>
{
    int result = await DemoradaAsync();
    Console.WriteLine(result);
};

while (true)
{
    string value = Console.ReadLine();
    if (value == "xispita")
        evento();
    else if (value == "demora")
        outroevento();
}

async Task<int> DemoradaAsync()
{
    int resultado = await Task<int>
        .Factory.StartNew(Demorada);
    return resultado;
}

int Demorada()
{
    int max = 2 * 1000 * 1000 * 1000;
    for (int i = 0; i < max; i++) ;
    return 8;
}