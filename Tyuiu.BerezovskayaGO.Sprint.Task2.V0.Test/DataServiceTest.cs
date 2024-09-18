using Tyuiu.BerezovskayaGO.Sprint0.Task2.V0.Lib;
namespace Tyuiu.BerezovskayaGO.Sprint.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Галина";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("Привет, Галина", res);

        }
    }
}