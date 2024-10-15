using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public class LeituraArquivo
    {
        public (bool Success, string[] Lines, int Qtd) ReadFile(string path)
        {
            try
            {
                string[] lines = File.ReadAllLines(path);
                return (true, lines, lines.Count());
            }
            catch (Exception)
            {
                return (false, Array.Empty<string>(), 0);
            }
        }
    }
}