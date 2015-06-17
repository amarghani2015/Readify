using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Text;



namespace WCFServiceWebRole1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "RedPill" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select RedPill.svc or RedPill.svc.cs at the Solution Explorer and start debugging.
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class RedPill : IRedPill
    {
        private long AddFibTerm(long n1, long n2)
        {
            return n1 + n2;
        }

        public long FibonacciNumber(long n)
        {
            n = Math.Abs(n);
            if (n == 0) return 0;
            if (n > 92)
            {
                throw new FaultException<ArgumentOutOfRangeException>(new ArgumentOutOfRangeException("n", "Fib(>92) will cause a 64-bit integer overflow."), new FaultReason("Fib(>92) will cause a 64-bit integer overflow.\r\nParameter name: n"));
            }

            List<long> fib = new List<long>();
            fib.Add(1); fib.Add(1);

            do
            {
                fib.Add(AddFibTerm(fib[fib.Count - 1], fib[fib.Count - 2]));

                int n2 = fib.Count - 1;
                int n1 = fib.Count - 2;
            } while (fib.Count <= 92);
            return fib[(int)(n - 1)];
        }
        public Guid WhatIsYourToken()
        {
            return new Guid("a30050a9-bcfa-481b-abbd-e390d015e03a");
        }
        public TriangleType WhatShapeIsThis(int a, int b, int c) 
        {
            if (a <= 0 || b <= 0 || c <= 0) return TriangleType.Error;
            if (a == b && b == c) return TriangleType.Equilateral;
            else if (a == b && a != c && c <b) return TriangleType.Isosceles;
            else if (a != b && a != c && c != b) return TriangleType.Scalene;
            return TriangleType.Error;
        }
        public string ReverseWords(string s)
        {
            if (s == null)
            {
                throw new FaultException<ArgumentNullException>(new ArgumentNullException("s", "Value cannot be null."), new FaultReason("Value cannot be null.\r\nParameter name: s"));
                //return "";
            }
            else if (s == "") return "";
            char[] chararray = s.ToCharArray();
            Array.Reverse(chararray);
            return new string(chararray);

        }
    }
}
