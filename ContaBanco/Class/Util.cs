using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContaBanco.Class
{
    public static class Util
    {
        public static void MetodoTempo(string Msg, int quant, int tempo){
            Console.Write($"{Msg}");
            for (var i = 0; i < quant; i++)
            {
                Console.Write(".");
                Thread.Sleep(tempo);
              
            }
        }
    

    }
}