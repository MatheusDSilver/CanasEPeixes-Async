var p1 = Pescar();
var c1 = MascarCana();

await p1;
await c1;

Console.WriteLine($"Conseguiu pegar um peixe de {p1.Result} cm depois de mascar {c1.Result} canas");

async Task<int> Pescar()
{
    for(int i = 0; i < 5; i++)
    {
        await Task.Delay(500);
        Console.WriteLine($"Perdeu {i} minhocas tentando pegar o peixe \n");
    }

    return new Peixe().TamanhoDoPeixe();
}

async Task<int> MascarCana()
{
    int canas = 0;
    for (int i = 0; i < 10; i++)
    {
        await Task.Delay(500);
        Console.WriteLine($"Mascou {i} canas \n");
        canas = i;
    }
    return canas;
}

public class Peixe
{
    Random randNum = new Random();
    private int _tamanho;
    public Peixe()
    {
        _tamanho = (int)randNum.NextInt64(1, 150);
    }
    public int TamanhoDoPeixe()
    {
        return _tamanho;
    }
}