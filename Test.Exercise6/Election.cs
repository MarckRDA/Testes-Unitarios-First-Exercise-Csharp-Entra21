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

        public void Vote(int id)
        {
            Candidates.Where(candidates => candidates.Id == id).Select(canditate => canditate.Vote++).ToList();
        }

        public string ShowWinners()
        {
            var winner = Candidates[0];
            var isDraw = false;
            var winnerName = winner.Name;

            for (int i = 1; i < Candidates.Count; i++)
            {
                if (Candidates[i].Vote > winner.Vote)
                {
                    winner = Candidates[i];
                    winnerName = Candidates[i].Name;
                }
                else if (Candidates[i].Vote == winner.Vote)
                {
                    isDraw = true;
                    winnerName += $", {Candidates[i].Name}";
                }
            }


            if (isDraw)
            {
                return $"Second turn: {winnerName}";
            }
            else
            {
                return $"{winnerName} won";
            }
        }

    }
}