using CalculatorLibrary;
namespace CalculatorTest
{
    [TestClass]
    public class CalculatorTest
    {
        // Нэмэх үйлдлийн тестүүд
        [TestMethod]
        public void Nemeh_EyregToo_Nemegdne()
        {
            var calc = new Calculator();
            calc.Add(5);
            Assert.AreEqual(5, calc.Result);
        }

        [TestMethod]
        public void Nemeh_SurugToo_Buurna()
        {
            var calc = new Calculator();
            calc.Add(-3);
            Assert.AreEqual(-3, calc.Result);
        }

        [TestMethod]
        public void Nemeh_TegiinToo_Uurclugduhgui()
        {
            var calc = new Calculator();
            calc.Add(0);
            Assert.AreEqual(0, calc.Result);
        }

        [TestMethod]
        public void Nemeh_OlonUdaa_UrDunHurimtlagdagh()
        {
            var calc = new Calculator();
            calc.Add(5);
            calc.Add(10);
            calc.Add(2);
            Assert.AreEqual(17, calc.Result);
        }

        //[TestMethod]
        //public void Add_MaxValue_ShouldHandleOverflow()
        //{
        //    var calc = new Calculator();
        //    calc.Add(double.MaxValue);
        //    calc.Add(1); // Overflow-ийг шалгана
        //    Assert.True(double.IsInfinity(calc.Result) || calc.Result == double.MaxValue);
        //}

        // Хасах үйлдлийн тестүүд
        [TestMethod]
        public void Hasakh_EeregToonDeer_UrDunBuurah()
        {
            var calc = new Calculator();
            calc.Subtract(5);
            Assert.AreEqual(-5, calc.Result);
        }

        [TestMethod]
        public void Hasakh_SurugToonDeer_UrDunBuurah()
        {
            var calc = new Calculator();
            calc.Subtract(-3);
            Assert.AreEqual(3, calc.Result);
        }

        [TestMethod]
        public void Hasakh_TegiinToonDeer_UrDunUurclugduhgui()
        {
            var calc = new Calculator();
            calc.Subtract(0);
            Assert.AreEqual(0, calc.Result);
        }

        [TestMethod]
        public void Hasah_OlonUdaa_UrDunHurimtlagdagh()
        {
            var calc = new Calculator();
            calc.Subtract(5);
            calc.Subtract(3);
            Assert.AreEqual(-8, calc.Result);
        }

        [TestMethod]
        public void Hasah_SurugToonoos()
        {
            var calc = new Calculator();
            calc.Add(-10);
            calc.Subtract(5);
            Assert.AreEqual(-15, calc.Result);
        }

        // Санах ойтой холбоотой тестүүд
        [TestMethod]
        public void SanahOidHadgalah_EhniiElement()
        {
            var calc = new Calculator();
            calc.Add(10);
            calc.SaveToMemory();
            var items = calc.GetMemoryItems();
            Assert.AreEqual(1,items.Count);
            Assert.AreEqual(10, items.First().Value);
        }

        [TestMethod]
        public void SanahOidHadgalah_OlonUtga()
        {
            var calc = new Calculator();
            calc.Add(5);
            calc.SaveToMemory();
            calc.Add(10);
            calc.SaveToMemory();
            var items = calc.GetMemoryItems();
            Assert.AreEqual(2, items.Count);
            Assert.AreEqual(5, items[0].Value);
            Assert.AreEqual(15, items[1].Value);
        }

        [TestMethod]
        public void SanahOidHadgalah_TegiigHadgalah()
        {
            var calc = new Calculator();
            calc.SaveToMemory(); // Result = 0
            var items = calc.GetMemoryItems();
            Assert.AreEqual(1,items.Count);
            Assert.AreEqual(0, items.First().Value);
        }

        [TestMethod]
        public void SanahOigoosAvah_HoosonSanahOigoos_HoosonButsaan()
        {
            var calc = new Calculator();
            var items = calc.GetMemoryItems();
            Assert.AreEqual(0,items.Count);
        }

        [TestMethod]
        public void SanahOigTesverleh_HadgalsniiDaraa_HoosonButsaana()
        {
            var calc = new Calculator();
            calc.Add(10);
            calc.SaveToMemory();
            calc.ClearMemory();
            var items = calc.GetMemoryItems();
            Assert.AreEqual(0,items.Count);
        }

        [TestMethod]
        public void SanahOigTesverleh_HoosonSanahOig_HoosonButsaana()
        {
            var calc = new Calculator();
            calc.ClearMemory();
            var items = calc.GetMemoryItems();
            Assert.AreEqual(0,items.Count);
        }

        // Холимог үйлдлийн тестүүд
        [TestMethod]
        public void HolimogUildeluud()
        {
            var calc = new Calculator();
            calc.Add(10);
            calc.Subtract(3);
            calc.SaveToMemory();
            calc.Add(5);
            Assert.AreEqual(12, calc.Result);
            var items = calc.GetMemoryItems();
            Assert.AreEqual(1,items.Count);
            Assert.AreEqual(7, items.First().Value);
        }

        [TestMethod]
        public void SanahOigTsevrlsniiDaraahUildel_SanahOilUstna()
        {
            var calc = new Calculator();
            calc.Add(10);
            calc.SaveToMemory();
            calc.ClearMemory();
            calc.Subtract(5);
            Assert.AreEqual(5, calc.Result);
            Assert.AreEqual(0, calc.GetMemoryItems().Count);
        }

        [TestMethod]
        public void OlonDaraalsanUildel()
        {
            var calc = new Calculator();
            calc.Add(100);
            calc.Subtract(50);
            calc.SaveToMemory();
            calc.Add(25);
            calc.Subtract(10);
            calc.SaveToMemory();
            Assert.AreEqual(65, calc.Result);
            var items = calc.GetMemoryItems();
            Assert.AreEqual(2, items.Count);
            Assert.AreEqual(50, items[0].Value);
            Assert.AreEqual(65, items[1].Value);
        }

    }
}
