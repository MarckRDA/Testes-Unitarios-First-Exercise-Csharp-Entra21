using System;

namespace Domain
{
    public class Candidate
    {
        public Guid Id {get; private set;}      
        public string Cpf {get; private set;} 
        public string Name { get; set;}
        public int Vote { get; set; }

        public Candidate(string name, string cpf)
        {
            Id = Guid.NewGuid();
            this.Name = name;
            this.Cpf = cpf;
            this.Vote = 0;
        }
    }
}