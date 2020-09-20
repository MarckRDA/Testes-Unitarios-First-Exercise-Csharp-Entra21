using System.Collections.Generic;
using Xunit;

namespace Test.Exercise6
{
    public class ElectionTest
    {
        [Fact]
        public void Should_Not_Create_An_ID_Candidate()
        {
            //Given
            var candidateMarcos = new Candidate(-1, "Marcos");

            //Then
            Assert.Equal(0, candidateMarcos.Id);
        }


        [Fact]
        public void Should_Not_Create_A_Candidate()
        {
            //Given
            var openElections = new Election();
            var candidatesForElection = MakeCandidates();
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
            var candidatesForElection = MakeCandidates();

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
            var candidatesForElection = MakeCandidates();
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
            var candidatesForElection = MakeCandidates();
            var subscribedForElection = openElections.CreateCandidates(candidatesForElection, "Pa$$w0rd");

            //When
            openElections.Vote(2);
            openElections.Vote(2);

            //Then
            var shuriVotes = openElections.Candidates.Find(candidate => candidate.Id == 2);
            Assert.Equal(2, shuriVotes.Vote);
        }
        
        [Fact]
        public void Should_Return_Shuri_Won()
        {
            //Given
            var openElections = new Election();
            var candidatesForElection = MakeCandidates();
            var subscribedForElection = openElections.CreateCandidates(candidatesForElection, "Pa$$w0rd");

            //When
            openElections.Vote(2);
            openElections.Vote(2);
            var resultOfElection = openElections.ShowWinners();

            //Then
            Assert.Equal("Shuri won", resultOfElection);
        }

        [Fact]
        public void Should_Return_Second_Turn_Between_Marcos_And_Shuri()
        {
            //Given
            var openElections = new Election();
            var candidatesForElection = MakeCandidates();
            var subscribedForElection = openElections.CreateCandidates(candidatesForElection, "Pa$$w0rd");

            //When
            openElections.Vote(2);
            openElections.Vote(2);
            
            openElections.Vote(1);
            openElections.Vote(1);

            var resultOfElection = openElections.ShowWinners();

            //Then
            Assert.Equal("Second turn: Marcos, Shuri", resultOfElection);
        }
        
         
        
        public List<Candidate> MakeCandidates()
        {
            var candidateMarcos = new Candidate(1, "Marcos");
            var candidateShuri = new Candidate(2, "Shuri");

            var cantidatesList = new List<Candidate>()
            {
                candidateMarcos, candidateShuri
            };

            return cantidatesList;
        }
    }
}
