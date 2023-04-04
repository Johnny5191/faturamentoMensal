using System;

class Program
{
    public static void Main(string[] args)
    {
        double[] faturamentoDiario = { 100.0, 200.0, 150.0, 300.0, 75.0, 80.0, 250.0, 180.0, 120.0, 220.0, 90.0, 240.0, 170.0, 300.0, 200.0, 180.0, 160.0, 210.0, 190.0, 250.0, 120.0, 80.0, 150.0, 200.0, 170.0, 250.0, 300.0, 90.0 };

        double menorFaturamento = double.MaxValue;
        double maiorFaturamento = double.MinValue;
        double somaFaturamento = 0.0;
        int diasAcimaMedia = 0;

        for (int i = 0; i < faturamentoDiario.Length; i++)
        {
            if ((i + 1) % 7 != 0 && i % 7 != 6)
            {
                // Dia útil (não é final de semana)
                double faturamento = faturamentoDiario[i];
                if (faturamento < menorFaturamento)
                {
                    menorFaturamento = faturamento;
                }
                if (faturamento > maiorFaturamento)
                {
                    maiorFaturamento = faturamento;
                }
                somaFaturamento += faturamento;
                if (faturamento > somaFaturamento / faturamentoDiario.Length)
                {
                    diasAcimaMedia++;
                }
            }
        }

        Console.WriteLine("Menor faturamento (dias úteis): {0}", menorFaturamento);
        Console.WriteLine("Maior faturamento (dias úteis): {0}", maiorFaturamento);
        Console.WriteLine("Número de dias acima da média: {0}", diasAcimaMedia);
    }
}