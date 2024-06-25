public class Carro :Veiculo{
    public override void Acelerar()
    {
        Velocidade += 10;
        System.Console.WriteLine("Carro acelerou");
    }
    public override void Freiar()
    {
       Velocidade -= 5;
       System.Console.WriteLine("Carro freiou");
    }

    
}
