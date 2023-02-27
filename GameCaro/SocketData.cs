using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCaro
{
    [Serializable]

    class SocketData
    {
        public int command;
        public int curRow;
        public int curCol;
        public string message;

        public SocketData(int command, string message, int curRow, int curCol)
        {
            this.command = command;
            this.message = message;
            this.curRow = curRow;
            this.curCol = curCol;
        }
    }

    public enum SocketCommand
    {
        SEND_POINT,
        SEND_MESSAGE,
        NEW_GAME,
        UNDO,
        END_GAME,
        TIME_OUT,
        QUIT
    }
}
