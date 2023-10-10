//Calculadora simples 

Console.WriteLine("Calculadora simples");
Thread.Sleep(1000);
Console.WriteLine("Insira a operação desejada");
Thread.Sleep(2000); 
Console.Clear();
Console.WriteLine("Para ADIÇÃO insira 1");
Console.WriteLine("Para SUBTRAÇÃO insira 2");
Console.WriteLine("Para DIVISÃO insira 3");
Console.WriteLine("Para MULTIPLICAÇÃO insira 4");

var opcao = Convert.ToInt32(Console.ReadLine());
int n1 = 1;
int n2 = 2;
int n3 = 3;
int n4 = 4; 

if (opcao > 4)
{
    Console.WriteLine("Opção invalida");
}


//ADIÇÃO
if (opcao == n1)
{ 
    Console.WriteLine("Você selecionou adição");
    Thread.Sleep(2000);
    Console.Clear();
    Console.WriteLine("Insira o primeiro numero");
    var primeiroNumero = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Insira o segundo numero");
    var segundoNumero = Convert.ToInt32(Console.ReadLine());


    Console.WriteLine($"Seu resultado é {primeiroNumero + segundoNumero}" );
}

//SUBTRAÇÃO
if (opcao == n2)
{
    Console.WriteLine("Você selecionou subtração");
    Thread.Sleep(2000);
    Console.Clear();
    Console.WriteLine("Insira o primeiro numero");
    var primeiroNumero = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Insira o segundo numero");
    var segundoNumero = Convert.ToInt32(Console.ReadLine());


    Console.WriteLine($"Seu resultado é {primeiroNumero - segundoNumero}");
}

//DIVISÃO
if (opcao == n3)
{
    Console.WriteLine("Você selecionou divisão");
    Thread.Sleep(2000);
    Console.Clear();
    Console.WriteLine("Insira o primeiro numero");
    var primeiroNumero = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Insira o segundo numero");
    var segundoNumero = Convert.ToInt32(Console.ReadLine());


    Console.WriteLine($"Seu resultado é {primeiroNumero / segundoNumero}");
}

//MULTIPLICAÇÃO
if (opcao == n4)
{
    Console.WriteLine("Você selecionou multiplicação");
    Thread.Sleep(2000);
    Console.Clear();
    Console.WriteLine("Insira o primeiro numero");
    var primeiroNumero = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Insira o segundo numero");
    var segundoNumero = Convert.ToInt32(Console.ReadLine());


    Console.WriteLine($"Seu resultado é {primeiroNumero * segundoNumero}");

}

//retorno ao inicio

Console.WriteLine("Deseja retornar ao menu inicial ?");
Thread.Sleep(2000);
Console.WriteLine("Digite 1 para voltar ou 0 para finalizar");

var retorno = Convert.ToInt32(Console.ReadLine());

if (retorno == 1)
{
    while (true)
    {
        Console.WriteLine("Insira a operação desejada");
        Thread.Sleep(2000);
        Console.Clear();
        Console.WriteLine("Para ADIÇÃO insira 1");
        Console.WriteLine("Para SUBTRAÇÃO insira 2");
        Console.WriteLine("Para DIVISÃO insira 3");
        Console.WriteLine("Para MULTIPLICAÇÃO insira 4");

        var opcao1 = Convert.ToInt32(Console.ReadLine());

        //ADIÇÃO
        if (opcao1 == n1)
        {
            Console.WriteLine("Você selecionou adição");
            Thread.Sleep(2000);
            Console.Clear();
            Console.WriteLine("Insira o primeiro numero");
            var primeiroNumero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insira o segundo numero");
            var segundoNumero = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine($"Seu resultado é {primeiroNumero + segundoNumero}");
        }

        //SUBTRAÇÃO
        if (opcao1 == n2)
        {
            Console.WriteLine("Você selecionou subtração");
            Thread.Sleep(2000);
            Console.Clear();
            Console.WriteLine("Insira o primeiro numero");
            var primeiroNumero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insira o segundo numero");
            var segundoNumero = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine($"Seu resultado é {primeiroNumero - segundoNumero}");
        }

        //DIVISÃO
        if (opcao1 == n3)
        {
            Console.WriteLine("Você selecionou divisão");
            Thread.Sleep(2000);
            Console.Clear();
            Console.WriteLine("Insira o primeiro numero");
            var primeiroNumero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insira o segundo numero");
            var segundoNumero = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine($"Seu resultado é {primeiroNumero / segundoNumero}");
        }

        //MULTIPLICAÇÃO
        if (opcao1 == n4)
        {
            Console.WriteLine("Você selecionou multiplicação");
            Thread.Sleep(2000);
            Console.Clear();
            Console.WriteLine("Insira o primeiro numero");
            var primeiroNumero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insira o segundo numero");
            var segundoNumero = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine($"Seu resultado é {primeiroNumero * segundoNumero}");
        }

        Console.WriteLine("Deseja retornar ao menu inicial ?");
        Thread.Sleep(2000);
        Console.WriteLine("Digite 1 para voltar ou 0 para finalizar");

        var retorno1 = Convert.ToInt32(Console.ReadLine());
         if (retorno1 == 0)
         {
            break;
         }
    }

}

