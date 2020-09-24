using System;
using System.Collections.Generic;
using System.Linq;

namespace Test.Exercise6
{
    public class Election
    {
        public List<Candidate> Candidates { get; set; }

        public bool CreateCandidates(List<Candidate> candidatesForElection, string passwrd)
        {
            if (passwrd == "Pa$$w0rd")
            {
                Candidates = candidatesForElection.Select(candidate => candidate).ToList();
                return true;
            }

            return false;
        }

        public List<string> ShowCandidates() => Candidates.Select(candidate => $"Vote {candidate.Id} for candidate {candidate.Name}").ToList();

        public List<Guid> getCandidatesIdByName(string name) => Candidates.Where(candidate => candidate.Name == name).Select(canditate => canditate.Id).ToList();
        public Guid getCandidateIdByName(string name) => Candidates.FirstOrDefault(candidate => candidate.Name == name).Id;
        
        public Guid getCandidateIdByCpf(string cpf) =>  Candidates.First(candidate => candidate.Cpf == cpf).Id;
        public void Vote(Guid id)
        {
            Candidates.First(candidates => candidates.Id == id).Vote++;
        }

        public List<Candidate> ShowWinners()
        {
            var winners = new List<Candidate>()
            {
                Candidates[0]
            };
            
            for (int i = 1; i < Candidates.Count; i++)
            {
                if (Candidates[i].Vote > winners[0].Vote)
                {
                    winners.Clear();
                    winners.Add(Candidates[i]);
                }
                else if (Candidates[i].Vote == winners[0].Vote)
                {
                    winners.Add(Candidates[i]);
                }
            }

            return winners;
        }

    }
}