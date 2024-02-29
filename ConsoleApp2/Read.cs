using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Read
    {

        public void Main()
        {
            Graph graph = new Graph();

            // Okunacak dosyanın yolu
            string dosyaYolu = @"C:\Users\pc\Desktop\Test\test2.txt";

            // Dosyayı satır satır oku
            using (StreamReader sr = new StreamReader(dosyaYolu))
            {
                string satir;
                Console.WriteLine("Txt Dosyasından Okunan Değerler:");
                while ((satir = sr.ReadLine()) != null)
                {
                    // E harfi ile başlayan satırları işle
                    if (satir.StartsWith("E "))
                    {
                        // Satırı boşluk karakterlerine göre parçala
                        string[] parcalar = satir.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                        if (parcalar.Length == 4 && int.TryParse(parcalar[1], out int node1) && int.TryParse(parcalar[2], out int node2) && int.TryParse(parcalar[3], out int weight))
                        {
                            // graph.AddEdge metodu çağır
                            graph.AddEdge(node1, node2, weight);
                            Console.WriteLine($"{node1} {node2} {weight}");
                        }
                        else
                        {
                            Console.WriteLine("Hatalı satır formatı: " + satir);
                        }
                    }
                }
                Console.WriteLine("");
            }

            graph.PrintGraph();
        }
    }
}
