using System.Collections.Generic;
using Domain;
using Xunit;

namespace Test
{
    public class ElectionTest
    {
        
        [Fact]
        public void Should_Not_Create_A_Candidate()
        {
            //Given
            var openElections = new Election();
            var candidatesForElection = PreCandidatesFactory();
            //When
            var result = openElections.CreateCandidates(candidatesForElection, "wrongPasswrd");

            //Then
            Assert.Null(openElections.Candidates);
            Assert.False(result);
        }

        [Fact]
        public void Should_Create_A_Candidate()
        {
            //Given
            var openElections = new Election();
            var candidatesForElection = PreCandidatesFactory();

            //When
            var result = openElections.CreateCandidates(candidatesForElection, "Pa$$w0rd");

            //Then
            Assert.True(result);
            Assert.Equal(candidatesForElection.Count, openElections.Candidates.Count);
        }

        [Fact]
        public void Should_Show_The_Candidates_Subscribed_For_Election()
        {
            //Given
            var openElections = new Election();
            var candidatesForElection = PreCandidatesFactory();
            var subscribedForElection = openElections.CreateCandidates(candidatesForElection, "Pa$$w0rd");

            //When
            var showedCandidates = openElections.ShowCandidates();


            //Then
            Assert.Equal($"Vote {candidatesForElection[0].Id} for candidate {candidatesForElection[0].Name}", showedCandidates[0]);
            Assert.Equal($"Vote {candidatesForElection[1].Id} for candidate {candidatesForElection[1].Name}", showedCandidates[1]);
        }

        [Fact]
        public void Should_Shuri_To_Have_Two_Votes()
        {
            //Given
            var openElections = new Election();
            var candidatesForElection = PreCandidatesFactory();
            var subscribedForElection = openElections.CreateCandidates(candidatesForElection, "Pa$$w0rd");
            var shuriId = openElections.GetCandidateIdByCpf("112.342.543-88");          
            

            //When
            openElections.VoteCandidate(shuriId);
            openElections.VoteCandidate(shuriId);

            // //Then
            var shuriVotes = openElections.GetVotes(shuriId);
            Assert.Equal(2, shuriVotes);
        }

        [Fact]
        public void Should_Return_False_Trying_To_Vote_In_Shuri()
        {
            //Given
            var openElections = new Election();
            var candidatesForElection = PreCandidatesFactory();
            var subscribedForElection = openElections.CreateCandidates(candidatesForElection, "Pa$$w0rd");
              

            //When
            var result = openElections.VoteCandidateByCpf("112.342.553-88");

            // //Then
            Assert.False(result);
        }

        
        [Fact]
        public void Should_Return_True_Trying_To_Vote_In_Shuri()
        {
            //Given
            var openElections = new Election();
            var candidatesForElection = PreCandidatesFactory();
            var subscribedForElection = openElections.CreateCandidates(candidatesForElection, "Pa$$w0rd");
              

            //When
            var result = openElections.VoteCandidateByCpf("112.346.543-88");

            // //Then
            Assert.False(result);
        }
        
        [Fact]
        public void Should_Return_Shuri_Won()
        {
            //Given
            var openElections = new Election();
            var candidatesForElection = PreCandidatesFactory();
            var subscribedForElection = openElections.CreateCandidates(candidatesForElection, "Pa$$w0rd");
            var shuriId = openElections.GetCandidateIdByCpf("112.342.543-88");          

            //When
            openElections.VoteCandidate(shuriId);
            openElections.VoteCandidate(shuriId);
            var resultOfElection = openElections.ShowWinners();

            var shuriWon = candidatesForElection.Find(candidate => candidate.Name == "Shuri");
            //Then
            Assert.Single(resultOfElection);
            Assert.Equal(shuriWon, resultOfElection[0]);
        }

        [Fact]
        public void Should_Return_Second_Turn_Between_Marcos_And_Shuri()
        {
            //Given
            var openElections = new Election();
            var candidatesForElection = PreCandidatesFactory();
            var subscribedForElection = openElections.CreateCandidates(candidatesForElection, "Pa$$w0rd");
            var shuriId = openElections.GetCandidateIdByCpf("112.342.543-88");          
            var marcosId = openElections.GetCandidateIdByCpf("000.123.452-00");
            //When
            openElections.VoteCandidate(shuriId);
            openElections.VoteCandidate(shuriId);
            
            openElections.VoteCandidate(marcosId);
            openElections.VoteCandidate(marcosId);

            var resultOfElection = openElections.ShowWinners();
            
            //Then
            Assert.Equal(2, resultOfElection.Count);
        }

        
        [Fact]
        public void Should_Register_A_Third_Candidate()
        {
            //Given
            var openElections = new Election();
            var candidatesForElection = PreCandidatesFactory();
            var candidateShuriSegunda = new Candidate("Shuri", "145.098.756-98");
            candidatesForElection.Add(candidateShuriSegunda);
            //When
            var subscribedForElection = openElections.CreateCandidates(candidatesForElection, "Pa$$w0rd");
            
            //Then
            Assert.True(subscribedForElection);
            Assert.Equal(candidatesForElection.Count, openElections.Candidates.Count);
        } 
        
        [Fact]
        public void Should_Return_Second_Shuri_ID_Search_By_Her_CPF()
        {
            //Given
            var openElections = new Election();
            var candidatesForElection = PreCandidatesFactory();
            var candidateShuriSecond = new Candidate("Shuri", "145.098.756-98");
            candidatesForElection.Add(candidateShuriSecond);
            var subscribedForElection = openElections.CreateCandidates(candidatesForElection, "Pa$$w0rd");
            
            //When
            var shuriSegundaId = openElections.GetCandidateIdByCpf("145.098.756-98");
            
            //Then
            Assert.Equal(candidateShuriSecond.Id, shuriSegundaId);
        } 

        [Fact]
        public void Should_Return_Two_ID_s_Candidates_Called_Shuri_Search_By_Their_Name()
        {
            //Given
            var openElections = new Election();
            var candidatesForElection = PreCandidatesFactory();
            var candidateShuriSecond = new Candidate("Shuri", "145.098.756-98");
            candidatesForElection.Add(candidateShuriSecond);
            var subscribedForElection = openElections.CreateCandidates(candidatesForElection, "Pa$$w0rd");
            
            //When
            var expectedResult = new List<Candidate>(){candidatesForElection[1], candidateShuriSecond};
            var twoIdsShuri = openElections.GetCandidatesByName("Shuri");
            
            //Then
            Assert.Equal(expectedResult, twoIdsShuri);
        } 

        [Fact]
        public void Should_Return_Two_Votes_To_Shuri_Second()
        {
            //Given
            var openElections = new Election();
            var candidatesForElection = PreCandidatesFactory();
            var candidateShuriSecond = new Candidate("Shuri", "145.098.756-98");
            candidatesForElection.Add(candidateShuriSecond);
            var subscribedForElection = openElections.CreateCandidates(candidatesForElection, "Pa$$w0rd");
            var shuriSecondId = openElections.GetCandidateIdByCpf("145.098.756-98");
            
            //When
            openElections.VoteCandidate(shuriSecondId);
            openElections.VoteCandidate(shuriSecondId);
            var shuriSecondVotes = candidatesForElection.Find(candidate => candidate.Id == shuriSecondId).Votes;

            //Then
            Assert.Equal(2, shuriSecondVotes);
        } 



        public List<Candidate> PreCandidatesFactory()
        {
            var candidateMarcos = new Candidate("Marcos", "000.123.452-00");
            var candidateShuri = new Candidate("Shuri", "112.342.543-88");

            var cantidatesList = new List<Candidate>()
            {
                candidateMarcos, candidateShuri
            };

            return cantidatesList;
        }
    }
}
