using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Graph
    {
        // Dictionary, Java'daki map yapısına benzemektedir
        // Key ve Value değerlerini birbirine bağlar

        // Burada her bir node'u diğer node'lara aralarındaki ağırlıkla
        // birlikte bağlıyoruz.

        private Dictionary<int, Dictionary<int, int>> adjacencyList; 

        public Graph()
        {
            adjacencyList = new Dictionary<int, Dictionary<int, int>>();
        }

        public void AddEdge(int source, int destination, int weight)
        {
            if (!adjacencyList.ContainsKey(source))
            {
                adjacencyList[source] = new Dictionary<int, int>();
            }
            adjacencyList[source][destination] = weight; 

            if (!adjacencyList.ContainsKey(destination))
            {
                adjacencyList[destination] = new Dictionary<int, int>();
            }
            adjacencyList[destination][source] = weight; 
        }

        // Sırası ile Node'ları, bağlı olduğu node'ları ve 
        // aralarındaki ağırlıkları yazdırıyoruz

        public void PrintGraph()
        {
            foreach (var item in adjacencyList)
            {
                Console.Write($"Node {item.Key}: ");
                foreach (var neighbor in item.Value)
                {
                    Console.Write($"({neighbor.Key}, {neighbor.Value}) "); // komşu düğüm ve ağırlığı yazdır
                }
                Console.WriteLine();
            }
        }
    }
}
