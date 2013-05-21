using System;
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
        void InitializeGamePanel();
        void UpdatePlayersList(List<Player> list,Dictionary<Player, VIEW.PlayerInfo> playersPanelsMap, System.Drawing.Color colour);
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
    }
}
