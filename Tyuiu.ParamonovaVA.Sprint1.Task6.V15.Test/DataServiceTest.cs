using Tyuiu.ParamonovaVA.Sprint1.Task6.V15.Lib;

namespace Tyuiu.ParamonovaVA.Sprint1.Task6.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestCheckLettersCount()
        {
            DataService ds = new DataService();
            string value = "stroka...";
            bool result = ds.CheckLettersCount(value);
            Assert.AreEqual(true, result);
        }
    }
}