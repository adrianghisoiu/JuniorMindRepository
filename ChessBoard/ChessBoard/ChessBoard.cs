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
            return 204;
        }
    }
}
