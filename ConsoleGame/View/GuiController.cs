using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleGame.View
{
    class GuiController
    {
        public GuiController()
        {
            
        }
        public void showGameWindow()
        {
            GameWindow gameWindow = new GameWindow();
        }
        public void showCreditWindow()
        {
            CreditWindow creditWindow = new CreditWindow();
        }
    }
}