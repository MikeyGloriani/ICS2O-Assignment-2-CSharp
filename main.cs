// Created by: Mikey Gloriani
// Created on: Oct 2022
//
// This program displays the area of a square


using System;

class Program {
    public static void Main (string[] args) {
        // This function accepts user input
        int length;
        int area;
        Console.WriteLine("This program calculates the area and perimeter of a rectangle.");
        Console.WriteLine("");
        Console.Write("Enter the length (cm): ");
        length = Convert.ToInt32(Console.ReadLine());
        area = length * length;
        Console.WriteLine("");
        Console.WriteLine("The area is: " + area + " cm². ");
        Console.WriteLine("\nDone.");
    }
}
