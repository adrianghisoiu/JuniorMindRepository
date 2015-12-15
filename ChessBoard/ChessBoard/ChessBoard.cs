using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ChessBoard
{
    [TestClass]
    public class ChessBoard
    {
        [TestMethod]
        public void EightByEightChessBoard()
        {
            Assert.AreEqual(204, CalculateNumberOfSquaresOnAChessBoard(8));
        }

        int CalculateNumberOfSquaresOnAChessBoard(int numberOfSquares)
        {
            int totalNumber = 0;
            for (int i = 0; i <= numberOfSquares; i++)
                totalNumber += i * i;
            return totalNumber;

                
                    
        }
    }
}
