using System;
using NUnit.Framework;

namespace SodokuAI.BL.Tests
{
    [TestFixture]
    public class CellTests
    {
        [Test]
        public void A_cell_can_contain_a_number_from_the_beginning()
        {
            var cell = new Cell(1, CellState.Fixed);
            
            Assert.AreEqual(1, cell.Number);
            Assert.AreEqual(CellState.Fixed, cell.State);
        }

        [Test]
        public void If_a_cell_contains_the_number_by_initialization_its_content_cannot_be_changed()
        {
            var cell = new Cell(1, CellState.Fixed);

            Assert.Throws<Exception>(() => cell.Number = 2);
        }
        
        [Test]
        public void A_cell_whose_content_is_not_fixed_can_be_changed()
        {
            var cell = new Cell(1, CellState.Changeable);

            cell.Number = 2;
            Assert.AreEqual(2, cell.Number);
        }

        [Test]
        public void A_cell_can_have_no_content_at_all()
        {
            var cell = new Cell(null, CellState.Changeable);
            Assert.IsNull(cell.Number);
        }
    }
}