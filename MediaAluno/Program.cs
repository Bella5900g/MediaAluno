class Colegio
{
    static void Main(){
        double nota1,nota2;
        double media;
        string nome;

        Console.WriteLine("Digite seu nome: ");
        nome=Console.ReadLine();
        Console.WriteLine("Digite a primeira nota> ");
        nota1=Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Digite sua segunda nota: ");
        nota2=Convert.ToDouble(Console.ReadLine());

        media = (nota1 + nota2) / 2;

        if(media >=6){
            Console.WriteLine($"Parabéns {nome} você foi APROVADO! ");
        }
        else{
            Console.WriteLine($"Infelizmente você foi REPROVADO {nome} ");
        }
        Console.ReadKey();
    }
}