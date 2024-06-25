public class Moto :Veiculo{
    public override void Acelerar()
    {
        Velocidade += 15;
        System.Console.WriteLine("Moto acelerou");
    }
    public override void Freiar()
    {
        Velocidade -= 10;
        System.Console.WriteLine("Moto freiou");
    }
}