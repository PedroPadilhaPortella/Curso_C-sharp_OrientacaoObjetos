using System;
using System.IO;
using System.Collections.Generic;

namespace Votacao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter full path: ");
            string path = Console.ReadLine();

            try{
                Dictionary<string, int> dados = new Dictionary<string, int>();

                using(StreamReader sr = File.OpenText(path)) {

                    while(!sr.EndOfStream) {
                        string[] votingRecord = sr.ReadLine().Split(",");
                        string candidate = votingRecord[0];
                        int votes = int.Parse(votingRecord[1]);
                        
                        if(dados.ContainsKey(candidate)){
                            dados[candidate] += votes;
                        }else{
                            dados[candidate] = votes;
                        }
                    }
                }

                foreach (var item in dados) {
                    Console.WriteLine($"{item.Key}: {item.Value}");
                }
            }
            catch (IOException e) {
                Console.WriteLine(e.Message);
            }
        }
    }
}
