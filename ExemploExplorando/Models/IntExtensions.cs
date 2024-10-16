using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public static class IntExtensions
    {
        public static bool ehPar(this int number)
        {
            return number % 2 == 0;
        }
    }
}