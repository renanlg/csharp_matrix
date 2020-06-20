using System;

namespace Matrix {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Enter the number of lines:");
            int m = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the number of columns:");
            int n = int.Parse(Console.ReadLine());

            int[,] mat = new int[m, n];

            // i for lines, j for columns
            for (int i = 0; i < m; i++) {
                Console.WriteLine("Enter the values of the line "+ i + " separated by space:");
                string[] values = Console.ReadLine().Split();
                
                // este for é para iterar o vetor values 
                for (int j = 0; j < n; j++) {
                    mat[i, j] = int.Parse(values[j]);
                }                
            }

            Console.Write("Enter the number that you like to find:");
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < m; i++) {
                for (int j = 0; j < n; j++) {
                    if (mat[i,j] == number) {
                        Console.WriteLine("Position:" + i + ", " + j);
                        if (j > 0) {
                            Console.WriteLine("Left:" + mat[i, j - 1]);
                        }
                        if (j < n - 1) {
                            Console.WriteLine("Right:" + mat[i, j + 1]);
                        }
                        if (i > 0) {
                            Console.WriteLine("Up:" + mat[i - 1, j]);
                        }
                        if (i < m - 1) {
                            Console.WriteLine("Down:" + mat[i + 1, j]);
                        }                        
                    }
                }
            }

            
        }
    }
}
