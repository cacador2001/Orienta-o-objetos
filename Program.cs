using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CriacaoArquivos
{
    class Program
    {
        static void Main(string[] args)
        {
            string diretorio = @"C:\Users\2114070024\Documents\Codigos Orientação à objeto\Aula 02.05\CriaçãoExclusãoArquivos\CriacaoArquivos\";
            string nomeArquivo = "meuPrimeiroArquivo.txt";

            if (File.Exists(diretorio + nomeArquivo))
            {
                Console.WriteLine("Arquivo já existente...");
            }
            else
            {
                Stream arquivo = File.Create(diretorio + nomeArquivo);
                arquivo.Close();
            }

            string novoDiretorio = @"C:\Users\2114070024\Documents\Codigos Orientação à objeto\Aula 02.05\CriaçãoExclusãoArquivos\CriacaoArquivos\Ranking";
            Directory.CreateDirectory(novoDiretorio);
        }
    }
}
