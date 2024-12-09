using Tyuiu.ParamonovaVA.Sprint1.Task4.V24.Lib;

namespace Tyuiu.ParamonovaVA.Sprint1.Task4.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValideExpression()
        {
                DataService ds = new DataService();
                double x = 1;
                double y = 2;
                double wait = 0;
                var res = ds.Calculate(x, y);
                Assert.AreEqual(wait, res);
            }
    }
}