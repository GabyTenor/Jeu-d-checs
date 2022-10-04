using System;
using System.Collections.Generic;
using System.Text;

namespace Echecs_Alpha_1._0
{
    class Pawns
    {
        private string _position;
        private bool _dead;
        private bool _passantYes;
        private List<string> _moves = new List<String>();

        public Pawns(string _position, bool _dead, bool _passantYes, List<String> _moves)
        {
            this._position = _position;
            this._dead = _dead;
            this._passantYes = _passantYes;
            this._moves = _moves;
        }
    }
}
