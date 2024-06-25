public abstract class Veiculo {
   
    protected int Velocidade;

    public abstract void Acelerar();
    public abstract void Freiar();
    public void ExibirVelocidade(){
        Console.WriteLine(Velocidade);
    }

}
