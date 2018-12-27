namespace SodokuAI.BL
{
    public enum CellState
    {
        /// <summary>
        /// The cell has been initialized empty. We now fill it with
        /// numbers.
        /// </summary>
        Changeable,
        
        /// <summary>
        /// This cell content belongs to the stuff that was initially set up by the
        /// Sodoku. (It is not to be changed by the AI.)
        /// </summary>
        Fixed
    }
}