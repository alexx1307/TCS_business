﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TCS_business.MODEL;
using System.Windows.Forms;
namespace TCS_business.VIEW
{
    interface IView
    {
        void InitializeMainWindow();
        void InitializeGamePanel(Board board);
        void UpdatePlayersList(List<Player> list);
        void UpdateFieldState(Field field);
        void UpdateTurnStatePanel(TurnState turnState, GameState gameState);
        void ShowLoginDialog();
        void ShowConfigDialog(GameConfig gameConfig);
        void UpdatePlayerPanel(Player player);
        void UpdateTimeLeftPanel(TimeSpan timeLeft);
        void ShowMessage(string msg);
        void AdjustButtonsAvailability(ApplicationState appState);
        void UpdateBoard(Board board);
        void ShowMainWindow();
        void UpdateDice(int i, int j);
        void UpdateCommunicate(string s);
        void ShowBuyPrompt();
        void ShowCardPrompt(string s);

        void UpdateFieldInfoPanel(Field field);
    }
}
