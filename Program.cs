List<Veiculo> veiculos = new List<Veiculo>();

Carro carro1 = new Carro();
Moto moto1 = new Moto();

veiculos.Add(carro1);
veiculos.Add(moto1);

foreach (Veiculo veiculo in veiculos){
    veiculo.Acelerar();
    veiculo.ExibirVelocidade();
    veiculo.Freiar();
    veiculo.ExibirVelocidade();
    System.Console.WriteLine();
}