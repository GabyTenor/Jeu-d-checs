using System;
using System.Collections.Generic;
using System.Text;

namespace Echecs_Alpha_1._0
{
    class Kings
    {
        private bool _dead;
        private string _position;
        private List<String> _moves = new List<String>();
        private bool _check;

        public Kings(bool _dead, string _position, List<String> _moves, bool _check)
        {
            this._dead = _dead;
            this._position = _position;
            this._moves = _moves;
            this._check = _check;
        }
    }
}
