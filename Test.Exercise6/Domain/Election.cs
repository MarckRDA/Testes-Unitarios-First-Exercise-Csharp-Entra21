using System;
using System.Collections.Generic;
using System.Linq;

namespace Domain
{
    public class Election
    {
        private List<Candidate> candidates;
        
        public IReadOnlyCollection<Candidate> Candidates => candidates;


        public bool CreateCandidates(List<Candidate> candidatesForElection, string passwrd)
        {
            if (passwrd == "Pa$$w0rd")
            {
                candidates = candidatesForElection;
                return true;
            }

            return false;
        }

        public List<string> ShowCandidates() => candidates.Select(candidate => $"Vote {candidate.Id} for candidate {candidate.Name}").ToList();
        public List<Candidate> GetCandidatesByName(string name) => candidates.Where(candidate => candidate.Name == name).ToList();
        public Guid GetCandidateIdByCpf(string cpf) =>  candidates.First(candidate => candidate.Cpf == cpf).Id;
        public void VoteCandidate(Guid id)
        {
            candidates.First(candidates => candidates.Id == id).Vote();
        }

        public bool VoteCandidateByCpf(string cpf)
        {
            var selectedCandidate = candidates.FirstOrDefault(x => x.Cpf == cpf);
            if (selectedCandidate == null)
            {
                return false;
            }
            else
            {
                selectedCandidate.Vote();
                return true;
            }
        }

        public int GetVotes(Guid id) => candidates.First(x => x.Id == id).Votes;
        public List<Candidate> ShowWinners()
        {
            var winners = new List<Candidate>()
            {
                candidates[0]
            };
            
            for (int i = 1; i < candidates.Count; i++)
            {
                if (candidates[i].Votes > winners[0].Votes)
                {
                    winners.Clear();
                    winners.Add(candidates[i]);
                }
                else if (candidates[i].Votes == winners[0].Votes)
                {
                    winners.Add(candidates[i]);
                }
            }

            return winners;
        }

    }
}