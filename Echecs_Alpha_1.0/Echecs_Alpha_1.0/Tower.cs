using System;
using System.Collections.Generic;
using System.Text;

namespace Echecs_Alpha_1._0
{
    class Tower
    {
        private bool _dead;
        private string _position;
        private List<string> _moves = new List<String>();

        public Tower(bool _dead, string _position, List<string> _moves)
        {
            this._dead = _dead;
            this._position = _position;
            this._moves = _moves;
        }
    }
}

