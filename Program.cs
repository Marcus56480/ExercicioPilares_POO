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

//TODO: Implementar list com objetos
// EntregaEconomica e2 = new EntregaEconomica();
// e2.CalcularFrete(10);

// RetiradaLocal e3 = new RetiradaLocal();
// e3.CalcularFrete(10);

// List<double> Entrega = new List<double>();

// Entrega.Add(EntregaExpressa);
// Entrega.Add(20);
// Entrega.Add(30);

// EntregaExpressa e1 = new EntregaExpressa();
// e1.CalcularFrete(Entrega[0]);

// EntregaEconomica e2 = new EntregaEconomica();
// e2.CalcularFrete(Entrega[1]);


// foreach (var item in Entrega)
// {

// }

Contrato ctr1 = new Contrato();
ctr1.Imprimir();

Relatorio r1 = new Relatorio();
r1.Imprimir();
r1.Exportar();