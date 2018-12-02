using ConsoleGame.Game;
using ConsoleGame.View;
using System;

class MainApp
{
    static void Main()
    {
        Console.CursorVisible = false;
        //GameWindow gameWindow = new GameWindow();
        //CreditWindow creditWindow = new CreditWindow();
        GuiController guiController = new GuiController();
        guiController.showGameWindow();
        //guiController.showCreditWindow();
        
        Console.ReadKey();
    }
}