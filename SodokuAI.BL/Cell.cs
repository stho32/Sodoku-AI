using System;

namespace SodokuAI.BL
{
    /// <summary>
    /// A cell of the game. Does not matter where it is.
    /// </summary>
    public class Cell
    {
        private int? _number; 
        public int? Number {
            get => _number;
            set
            {
                if (State == CellState.Fixed)
                    throw new Exception("This cells content cannot be changed because it is fixed.");
                _number = value;
            }
        }
        public CellState State { get; }

        public Cell(int? number, CellState state)
        {
            Number = number;
            State = state;
        }
    }
}