
Fernanda França
10:27 AM(5 minutes ago)
to marquessilvaluana22, leticiaalima77, me

class Program
{
    public static void Main()
    {
        Console.WriteLine("Digite um número: ");
        int numero = Convert.ToInt32(Console.ReadLine());

        if (numero > 0)
            Console.WriteLine("O número é positivo.");
        else if (numero < 0)
            Console.WriteLine("O número é negativo.");
        else
            Console.WriteLine("O número é zero.");
    }