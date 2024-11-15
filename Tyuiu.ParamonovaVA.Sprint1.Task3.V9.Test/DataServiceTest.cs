using Tyuiu.ParamonovaVA.Sprint1.Task3.V9.Lib;

namespace Tyuiu.ParamonovaVA.Sprint1.Task3.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 150;
            double wait = 2; 
            var res = ds.ConvertMinutesToHours(x);
            Assert.AreEqual(wait, res);
            
        }
    }
}