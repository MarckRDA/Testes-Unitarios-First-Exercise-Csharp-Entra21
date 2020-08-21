using System;

namespace Exercicio14
{
    public class Exercicio14SobTeste
    {
        public string NumbersSorted(double n1, double n2, double n3)
        {
            var numberA = n1;
            var numberB = n2;
            var numberC = n3;
            var temp = 0.0;
            
            if (numberA > numberB && numberA > numberC)
            {
                temp = numberC;
                numberC = numberA;
                numberA = temp;
            }
            if (numberB > numberA && numberB > numberC)
            {
                temp = numberC;
                numberC = numberB;
                numberB = temp;
            }
            if (numberA > numberB)
            {
                temp = numberB;
                numberB = numberA;
                numberA = temp;
            }
          
          return $"{numberA},{numberB},{numberC}";
        }

    }
}

