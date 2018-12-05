using ConsoleGame.Gui;
using ConsoleGame.View;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleGame.View
{
    class GuiController
    {
        GameWindow gameWindow = new GameWindow();
        CreditWindow creditWindow = new CreditWindow();

        public GuiController()
        {
            
        }

        public void ShowMenu()
        {
            gameWindow.Render();
            
            bool needToRender = true;
            int i = 0;

            do
            { 
                ConsoleKeyInfo pressedChar = Console.ReadKey(true);
                int hashCode = pressedChar.Key.GetHashCode();

                    switch (hashCode)
                    {
                        case 39: // ConsoleKey.RightArrow:
                        if (i < 2 && i >= 0)
                        {
                            i++;
                            gameWindow.MenuButtons[i].SetActive();
                            gameWindow.MenuButtons[i - 1].SetInActive();
                        }
                        break;

                        case 37: // ConsoleKey.LeftArrow:
                        if (i < 3 && i > 0)
                        {
                            gameWindow.MenuButtons[i-1].SetActive();
                            gameWindow.MenuButtons[i].SetInActive();
                            i--;
                        }
                        break;

                        case 13: //ConsoleKey.Enter
                        if (i == 1)
                        {
                            ShowCredits();
                        } else if (i == 0)
                        {
                            StartGame();
                        }
                        else if(i == 2)
                        {
                            Environment.Exit(0);
                        }
                        break;
                    }
             gameWindow.Render();
            } while (needToRender);
        }
        
        public void ShowCredits()
        {
            creditWindow.Render();
            int hashCode = 0;
            while (true)
            {
                if (hashCode == 13)
                {
                    break;
                }else if (hashCode == 27)
                {
                    break;
                }
                else
                {
                    ConsoleKeyInfo pressedChar = Console.ReadKey(true);
                    hashCode = pressedChar.Key.GetHashCode();
                }
            }
        }

        public void StartGame()
        {
            GameController newGameWindow = new GameController();
        }

    }
}