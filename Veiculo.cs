public class Veiculo {

    protected string marca;
    protected string modelo;
    protected int ano;

    public void Ligar() {

        Console.WriteLine("O veículo está ligado!");

    }

    public void Desligar() {

        Console.WriteLine("O veículo está desligado!");

    }

    public void SetMarca(string marca) {

        this.marca = marca;

    }

    public string GetMarca() {

        return marca;

    }

    public void SetModelo(string modelo) {

        this.modelo = modelo;

    }

    public string GetModelo() {

        return modelo;

    }

    public void SetAno(int ano) {

        this.ano = ano;

    }

    public int GetAno() {

        return ano;

    }

}