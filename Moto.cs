public class Moto : Veiculo {

    private bool temBagageiro;

    public void DarGrau() {

        Console.WriteLine("RANDANDANDAN");

    }

    public void ExibirInformacoes() {

        Console.WriteLine($"Marca: {marca}, modelo: {modelo}, ano: {ano}, tem bagageiro: {temBagageiro}");

    }

    public void SetTemBagageiro(bool temBagageiro) {

        this.temBagageiro = temBagageiro;

    }

    public bool GetTemBagageiro() {

        return temBagageiro;

    }

}