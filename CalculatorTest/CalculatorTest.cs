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
    } 
}
