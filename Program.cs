using System.ComponentModel;
using Exercicios_Csharp;

Carro Honda = new Carro();

Honda.Modelo = "Civic";
Honda.Marca = "Honda";
Honda.QuantidadePortas = 4;

Honda.ExibirInformacoes();
Console.WriteLine($"Quantidade de portas: {Honda.QuantidadePortas}");

Motocicleta Harley = new Motocicleta();

Harley.Modelo = "StreetBoy";
Harley.Marca = "Harley";
Harley.Cilindradas = 1923;

Harley.ExibirInformacoes();
Console.WriteLine($"Quantidade de Cilindradas: {Harley.Cilindradas}");

Ebook l1 = new Ebook();
Ebook l2 = new Ebook("Clean Code", 120m, 123);
// l2.QuantidadePaginas = 123;

Console.WriteLine($"Titulo: {l2.Nome} - Preço: {l2.Preco:C} - Quantidade de Pagínas: {l2.QuantidadePaginas}");

CursoOnline c1 = new CursoOnline("JavaScript Iniciante", 130m, 1200);

Console.WriteLine($"Curso: {c1.Nome} - Preço: {c1.Preco:C} - Carga Horaria: {c1.CargaHoraria} horas");

JogoFisico j1 = new JogoFisico("PES", "PS2");
j1.Apresentarjogo();

JogoDigital j2 = new JogoDigital("GTA 6", "PS5");
j2.Apresentarjogo();

Notificacao n1 = new Notificacao();
NotificacaoEmail n2 = new NotificacaoEmail();
NotificacaoSMS n3 = new NotificacaoSMS();
NotificacaoPush n4 = new NotificacaoPush();

n1.Enviar();
n2.Enviar();
n3.Enviar();
n4.Enviar();

List<Entrega> lista = new List<Entrega>();

lista.Add(new EntregaExpressa { Distancia = 10 });
lista.Add(new EntregaEconomica { Distancia = 10 });
lista.Add(new RetiradaLocal { Distancia = 10 });



 foreach (var item in lista)
 {
    Console.WriteLine($"{item.CalcularFrete():C}");
 }

Contrato ctr1 = new Contrato();
ctr1.Imprimir();

Relatorio r1 = new Relatorio();
r1.Imprimir();
r1.Exportar();