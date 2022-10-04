using System;
using System.Collections.Generic;
using System.Text;

namespace Echecs_Alpha_1._0
{
    class Horses
    {
        private bool _dead;
        private string _position;
        private List<String> _moves = new List<string>();

        public Horses(bool _dead, string _position, List<String> _moves)
        {
            this._dead = _dead;
            this._position = _position;
            this._moves = _moves;
        }
    }
}
