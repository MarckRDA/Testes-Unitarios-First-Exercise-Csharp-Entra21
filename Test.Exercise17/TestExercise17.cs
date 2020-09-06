using System;
using System.Collections.Generic;
using Xunit;

namespace Test.Exercise17
{
    public class TestExercise17
    {
        [Fact]
        public void Should_Return_A_Multiplication_Table_Of_7()
        {
            //Given
            var exercise17 = new Exercise17();
            
            //When
            var result = exercise17.MutiplicationTable(7);

            //Then
            Assert.Collection(
                result,
                i1 =>{Assert.Equal(7,i1);},
                i2 =>{Assert.Equal(14,i2);},
                i3 =>{Assert.Equal(21,i3);},
                i4 =>{Assert.Equal(28,i4);},
                i5 =>{Assert.Equal(35,i5);},
                i6 =>{Assert.Equal(42,i6);},
                i7 =>{Assert.Equal(49,i7);},
                i8 =>{Assert.Equal(56,i8);},
                i9 =>{Assert.Equal(63,i9);},
                i10 =>{Assert.Equal(70,i10);}
            );
        }
    }
}
