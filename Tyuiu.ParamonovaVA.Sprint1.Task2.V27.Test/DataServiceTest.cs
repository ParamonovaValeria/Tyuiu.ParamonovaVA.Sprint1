using Tyuiu.ParamonovaVA.Sprint1.Task2.V27.Lib;

namespace Tyuiu.ParamonovaVA.Sprint1.Task2.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int a = 2;
            var res = ds.CalculateSquarePerimetr(a);
            Assert.AreEqual(8, res);
              
        }
    }
}