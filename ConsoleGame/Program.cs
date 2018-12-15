using ConsoleGame.Game;
using ConsoleGame.View;
using ConsoleGame.Gui;
using System;

class MainApp
{
    static void Main()
    {
        Console.CursorVisible = false;
        GuiController guiController = new GuiController();
        guiController.ShowMenu();
        
        Console.ReadKey();
    }
}