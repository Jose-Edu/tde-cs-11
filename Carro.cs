public class Carro : Veiculo {

    private int numeroPortas;
    
    public void AbrirPortaMalas() {

        Console.WriteLine("O porta mala está aberto!");

    }

    public void ExibirInformacoes() {

        Console.WriteLine($"Marca: {marca}, modelo: {modelo}, ano: {ano}, número de portas: {numeroPortas}");

    }

    public void SetNumeroPortas(int numeroPortas) {

        this.numeroPortas = numeroPortas;

    }

    public int GetNumeroPortas() {

        return numeroPortas;

    }

}