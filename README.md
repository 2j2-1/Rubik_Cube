# Rubik's Cube Simulator

This repository contains a simple Rubik's Cube Simulator implemented in C# with a Windows Forms interface.
Description

The application uses Windows Forms for the interface and simulates a Rubik's Cube. The cube's current state is displayed on the form, and the user can perform operations on the cube through the interface, such as rotating faces.
Features

- Simulate a 3x3 Rubik's Cube.
- Rotate each face individually by clicking on the center sticker of each face in the GUI.
- Visual feedback of the cube's state after each operation.

How it works

The Cube class represents the Rubik's Cube. It holds the cube's current state in a 2D array, and each sticker on the cube is represented by a number. This class also includes methods for rotating faces and edges of the cube.

The Form1 class is the main form of the application and it handles the user interface. It displays the current state of the cube and handles user interactions. When the user clicks on the center sticker of a face, the corresponding face is rotated and the cube's state is updated on the form.
How to Run

To run the application:

- Clone the repository to your local machine.
- Open the solution in Visual Studio.
- Build and run the application.

Contributing

Contributions are welcome. Please open an issue to discuss your ideas or submit a pull request with your changes.
