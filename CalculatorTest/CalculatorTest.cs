using CalculatorLibrary;
namespace CalculatorTest
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        public void Add_ReturnsCorrectSum()
        {
            var calculator = new Calculator();
            calculator.Add(10, 5);
            Assert.AreEqual(15, calculator.Result);

        }

        [TestMethod]
        public void Subtract_ReturnsCorrectSum()
        {
            var calculator1 = new Calculator();
            calculator1.Subtract(10, 5);
            Assert.AreEqual(5, calculator1.Result);
        }

        [TestMethod]
        public void Store_ValueInMemory()
        {
            var calculator = new Calculator();
            Memory memory = new Memory();
            calculator.Add(10, 5);
            memory.Store(calculator.Result);
            Assert.AreEqual(15, calculator.Result);
        }
        public void Clear_AllMemoryItems()
        {
            var memory = new Memory();
            memory.Store(10);
            memory.Store(5);
            memory.Clear();
            Assert.AreEqual(0, memory.GetHistory().Count);
        }

        public void Get_History()
        {
            var memory = new Memory();
            memory.Store(10);
            memory.Store(5);
            memory.Clear();
            memory.Store(6);
            Assert.AreEqual((memory.GetHistory()).Count(), 1);
            Assert.Equals(6, memory.GetHistory()[0].Value);
        }

    }
}
