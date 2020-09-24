using System;

namespace Test.Exercise6
{
    public class Candidate
    {
        public Guid Id {get; set;}      
        public string Cpf {get; set;} 
        public string Name { get; set; }
        public int Vote { get; set; }

        public Candidate(string name, string cpf)
        {
            Id = Guid.NewGuid();
            this.Name = name;
            this.Cpf = cpf;
        }
    }
}