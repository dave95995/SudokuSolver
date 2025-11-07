namespace SudokuSolver.Tests
{
    public class SudokuEngineTests
    {
        [Fact]
        public void Constructor_InputStringToShort_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new SudokuEngine(""));
        }

        [Fact]
        public void Constructor_InputStringContainsInvalidCharacters_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new SudokuEngine("530070-00600195000098000060800060003400803001700020006060000280000419005000080079"));
        }
        [Fact]
        public void SolveWithDepthFirstSearch_ValidSudokuString_FindsSolution()
        {
            SudokuEngine engine = new("530070000600195000098000060800060003400803001700020006060000280000419005000080079");
            Assert.True(engine.SolveWithDepthFirstSearch());
        }

        [Fact]
        public void GridAsString_ValidSudokuString_ReturnsCorrectString()
        {
            SudokuEngine engine = new("530070000600195000098000060800060003400803001700020006060000280000419005000080079");
            engine.SolveWithDepthFirstSearch();
            Assert.Equal("534678912672195348198342567859761423426853791713924856961537284287419635345286179", engine.GridAsString);
        }

        [Fact]
        public void SolveWithDepthFirstSearch_InValidSudokuString_ReturnsFalse()
        {
            SudokuEngine engine = new("530070000600195000098000060810060003400803001700020006060000280000419005000080079");
            Assert.False(engine.SolveWithDepthFirstSearch());
        }
    }
}
