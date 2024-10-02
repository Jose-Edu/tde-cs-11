Moto moto = new Moto();
Carro carro = new Carro();

moto.SetAno(2015);
moto.SetMarca("Kawazaki");
moto.SetModelo("01");
moto.SetTemBagageiro(true);

carro.SetAno(2010);
carro.SetMarca("Ferrari");
carro.SetModelo("678");
carro.SetNumeroPortas(4);

moto.ExibirInformacoes();
carro.ExibirInformacoes();

moto.DarGrau();
carro.AbrirPortaMalas();
moto.Desligar();
carro.Ligar();