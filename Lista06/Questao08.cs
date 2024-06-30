using System;
using System.IO;

public class Questao08 {

// Definindo caminho fixo para o arquivo ao longo do programa
    private string caminhoArquivo = @"C:\Users\USUÁRIO\Documents\ATP\Lista06\resultado.txt";
    public void Rodar() {
        Console.WriteLine("Informe a quantidade de veículos da locadora:");
        if (!int.TryParse(Console.ReadLine(), out int veiculos) || veiculos <= 0) {
            Console.WriteLine("Quantidade inválida de veículos. Encerrando o programa.");
            return;
        }

        Console.WriteLine("Informe o valor do aluguel por veículo:");
        if (!decimal.TryParse(Console.ReadLine(), out decimal valorAluguel) || valorAluguel <= 0) {
            Console.WriteLine("Valor de aluguel inválido. Encerrando o programa.");
            return;
        }

// Calculando faturamento mensal
        decimal faturamentoMensal = (veiculos * valorAluguel) / 3;

// Calculando faturamento anual
        decimal faturamentoAnual = faturamentoMensal * 12;

// Calculando valor ganho com multas no mês
        decimal multa = (faturamentoMensal / 10) * 0.2m;

// Calculando valor gasto com manutenção anual
        decimal valorManutencao = (veiculos * 0.02m) * 600;

// Imprimindo resultados na tela
        Console.WriteLine($"Faturamento anual da locadora: R${faturamentoAnual}");
        Console.WriteLine($"Valor ganho com multas no mês: R${multa}");
        Console.WriteLine($"Valor gasto com manutenção anual: R${valorManutencao}");

// Salvando resultados no arquivo resultado.txt
        SalvarResultado(faturamentoAnual, multa, valorManutencao);
        Console.WriteLine($"Resultados salvos no arquivo '{caminhoArquivo}'.");
    }

    private void SalvarResultado(decimal faturamentoAnual, decimal multa, decimal valorManutencao) {
        try {
            using (StreamWriter writer = new StreamWriter(caminhoArquivo)) {
                writer.WriteLine($"Faturamento anual: R${faturamentoAnual}");
                writer.WriteLine($"Valor ganho com multas no mês: R${multa}");
                writer.WriteLine($"Valor gasto com manutenção anual: R${valorManutencao}");
            }
        }
        catch (Exception) {
            Console.WriteLine($"Erro ao salvar o arquivo! Verifique e tente novamente.");
        }
    }
}
