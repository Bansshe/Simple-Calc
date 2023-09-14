using System.Runtime.CompilerServices;

operacao();

static void error()
{
    Console.Beep();
    Console.Clear();
    Console.WriteLine("Valor Invalido!");
    Console.WriteLine("");
    operacao();
}
static void operacao()
{
    try
    {
        static void somar(float v1, float v2)
        {
            float res = 0;
            Console.Beep();
            Console.Clear();
            res = v1 + v2;
            Console.WriteLine("Resultado: " + res);
            Console.WriteLine("");
            operacao();
        }
        static void subtrair(float v1, float v2)
        {
            float res = 0;
            Console.Beep();
            Console.Clear();
            res = v1 - v2;
            Console.WriteLine("Resultado: " + res);
            Console.WriteLine("");
            operacao();
        }
        static void multiplicar(float v1, float v2)
        {
            float res = 0;
            Console.Beep();
            Console.Clear();
            res = v1 * v2;
            Console.WriteLine("Resultado: " + res);
            Console.WriteLine("");
            operacao();
        }
        static void dividir(float v1, float v2)
        {
            float res = 0;
            Console.Beep();
            Console.Clear();
            res = v1 / v2;
            Console.WriteLine("Resultado: " + res);
            Console.WriteLine("");
            operacao();
        }

        Console.WriteLine("Selecione uma Opção!");
        Console.WriteLine("1 - Somar");
        Console.WriteLine("2 - Subtrair");
        Console.WriteLine("3 - Multiplicar");
        Console.WriteLine("4 - Dividir");
        Console.WriteLine("0 - Sair");


        int op = int.Parse(Console.ReadLine());

        if (op == 1)
        {
            Console.WriteLine("Somar");
            Console.WriteLine("Insira o primeiro valor a ser somado!");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Insira o segundo valor a ser somado!");
            float v2 = float.Parse(Console.ReadLine());
            somar(v1, v2);
        }
        else if (op == 2)
        {
            Console.WriteLine("Subtrair");
            Console.WriteLine("Insira o primeiro valor a ser subtraido!");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Insira o segundo valor a ser subtraido!");
            float v2 = float.Parse(Console.ReadLine());
            subtrair(v1, v2);
        }
        else if (op == 3)
        {
            Console.WriteLine("Multiplicar");
            Console.WriteLine("Insira o primeiro valor a ser multiplicado!");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Insira o segundo valor a ser multiplicado!");
            float v2 = float.Parse(Console.ReadLine());
            multiplicar(v1, v2);
        }
        else if (op == 4)
        {
            Console.WriteLine("Dividir");
            Console.WriteLine("Insira o primeiro valor a ser dividido!");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Insira o segundo valor a ser dividido!");
            float v2 = float.Parse(Console.ReadLine());
            dividir(v1, v2);
        }
        else if (op == 0)
        {
            return;
        }
        else
        {
            error();

        }
    } catch
    {
        error();
    }
}