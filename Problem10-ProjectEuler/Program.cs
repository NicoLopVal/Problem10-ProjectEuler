using System;
using System.Collections.Generic;

namespace Problem10_ProjectEuler
{
    class Program
    {
        static void Main(string[] args)
        {
            double totalSum = 2;
            List<double> primes = new List<double>();
            primes.Add(2);
            double counter = 3;

            while(counter < 2000000)
            {
                bool isPrime = true;
                foreach(double prime in primes)
                {
                    if(counter % prime == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    totalSum = totalSum + counter;
                    primes.Add(counter);
                }
                counter = counter + 2;
            }

            Console.WriteLine("The sum of all the primes below two million is: " + totalSum);
        }
    }
}
