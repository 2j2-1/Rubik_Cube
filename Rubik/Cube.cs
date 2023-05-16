using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rubik
{
    // This class represents a Rubik's Cube.
    class Cube
    {
        // This 2D array represents the state of the cube. Each row represents a face of the cube,
        // and each element in the row represents a sticker on that face.
        public int[,] cube = { { 0, 1, 2, 3, 4, 5, 6, 7, 8 },
                               { 9, 10, 11, 12, 13, 14, 15, 16, 17 },
                               { 18, 19, 20, 21, 22, 23, 24, 25, 26 },
                               { 27, 28, 29, 30, 31, 32, 33, 34, 35 },
                               { 36, 37, 38, 39, 40, 41, 42, 43, 44 },
                               { 45, 46, 47, 48, 49, 50, 51, 52, 53 } };

        // An array of colors representing the color of each face on the cube.
        public Color[] colors = { Color.Yellow, Color.Blue, Color.Red, Color.Green, Color.Orange, Color.White };

        // Matrices used to represent the rotation of a face of the cube. 
        public int[,] cubeFaceMatrix = {
            { 2,5,8,1,4,7,0,3,6 },
            { 8,7,6,5,4,3,2,1,0 },
            { 6,3,0,7,4,1,8,5,2 }
        };

        // Matrix used to represent the edge rotations of each face of the cube
        public int[,] cubeEdgeMatrix = { 
            { 1,4,3,2 },
            { 0,2,5,4 },
            { 0,3,5,1 },
            { 0,4,5,2 },
            { 0,1,5,3 },
            { 1,2,3,4 } 
        };

        // Matrix used to represent the corner roatations of each face of the cube.
        public int[,] cubeCornerMatrix = { 
            { 0,1,2,0,1,2,0,1,2,0,1,2 },
            { 0,3,6,0,3,6,0,3,6,8,5,2 },
            { 6,7,8,0,3,6,2,1,0,8,5,2 },
            { 2,5,8,6,3,0,2,5,8,2,5,8 },
            { 0,1,2,6,3,0,8,7,6,2,5,8 },
            { 6,7,8,6,7,8,6,7,8,6,7,8 } 
        };

        // This method rotates a given face of the cube around a center point by a given offset.
        public void RotateFace(int face, int offset = 3)
        {
            TurnFace(face, offset);
            TurnEdges(face, offset);

        }

        // This method rotates the given face of the cube by a given offset.
        public void TurnFace(int face, int offset)
        {
            int[] temp = new int[9];
            for (int i = 0; i < 9; i++)
            {
                temp[i] = cube[face,i];
            }
            for (int i = 0; i < 9; i++)
            {
                cube[face,i] = temp[cubeFaceMatrix[offset - 1,i]];
            }
        }

        // This method rotates the edges of a given face of the cube by a given offset.
        public void TurnEdges(int face, int offset)
        {
            int[] temp = new int[12];

            for (int i = 0; i < 12; i++)
            {
                int faceIndex = cubeEdgeMatrix[face, i / 3];
                int edgeIndex = cubeCornerMatrix[face, i];
                temp[i] = cube[faceIndex, edgeIndex];
            }

            for (int i = 0; i < 12; i++)
            {
                int faceIndex = cubeEdgeMatrix[face, i / 3];
                int edgeIndex = cubeCornerMatrix[face, i];
                cube[faceIndex, edgeIndex] = temp[(i + offset * 3) % 12];
            }
        }

        
    }
}
