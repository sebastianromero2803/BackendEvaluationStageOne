﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BackendEvaluationStageOne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string receivedStr = Console.ReadLine();
            List<byte> finalStr = new List<byte>() { };
            byte[] ascii = Encoding.ASCII.GetBytes(receivedStr);
            foreach (byte b in ascii)
            {
                if (b == 32 || b == 45 || b == 95 || (b >= 48 & b <= 57) || (b >= 65 & b <= 90) || (b >= 97 & b <= 122))
                    finalStr.Add(b);
            }
            Console.WriteLine(Encoding.ASCII.GetString(finalStr.ToArray()).Trim());
        }
    }
}
