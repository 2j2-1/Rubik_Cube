
using CubeLiabry;

namespace CubeTests
{
    public class CubeTests
    {
        [Fact]
        public void TestInitialCubeState()
        {
            var cube = new Cube();
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    Assert.Equal(i * 9 + j, cube.cube[i, j]);
                }
            }
        }

        [Fact]
        public void TestRotateFaceOnce()
        {
            var cube = new Cube();
            cube.TurnFace(0,1); // Rotate the first face once
            var expected = new int[] { 2, 5, 8, 1, 4, 7, 0, 3, 6 };
            for (int i = 0; i < 9; i++)
            {
                Assert.Equal(expected[i], cube.cube[0, i]);
            }
        }

        [Fact]
        public void TestRotateFaceTwice()
        {
            var cube = new Cube();
            cube.TurnFace(0, 1); // Rotate the first face once
            cube.TurnFace(0, 1); // Rotate the first face again
            var expected = new int[] { 8, 7, 6, 5, 4, 3, 2, 1, 0 };
            for (int i = 0; i < 9; i++)
            {
                Assert.Equal(expected[i], cube.cube[0, i]);
            }
        }

        [Fact]
        public void TestRotateFaceThrice()
        {
            var cube = new Cube();
            cube.TurnFace(0, 1); // Rotate the first face once
            cube.TurnFace(0, 1); // Rotate the first face again
            cube.TurnFace(0, 1); // Rotate the first face again
            var expected = new int[] { 6, 3, 0, 7, 4, 1, 8, 5, 2 };
            for (int i = 0; i < 9; i++)
            {
                Assert.Equal(expected[i], cube.cube[0, i]);
            }
        }

        [Fact]
        public void TestRotateFaceFourTimes()
        {
            var cube = new Cube();
            cube.TurnFace(0,1); // Rotate the first face once
            cube.TurnFace(0, 1); // Rotate the first face again
            cube.TurnFace(0, 1); // Rotate the first face again
            cube.TurnFace(0, 1); // Rotate the first face again
            var expected = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8 }; // Should be back to initial state
            for (int i = 0; i < 9; i++)
            {
                Assert.Equal(expected[i], cube.cube[0, i]);
            }
        }

        [Fact]
        public void TestRotateFaceOffset()
        {
            var cube = new Cube();
            cube.TurnFace(0, 2); // Rotate the first face Twice

            var expected = new int[] { 8, 7, 6, 5, 4, 3, 2, 1, 0 };
            for (int i = 0; i < 9; i++)
            {
                Assert.Equal(expected[i], cube.cube[0, i]);
            }
        }
    }
}