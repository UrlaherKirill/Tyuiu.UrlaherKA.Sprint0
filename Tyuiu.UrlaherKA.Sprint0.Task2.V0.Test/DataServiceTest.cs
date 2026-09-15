using Tyuiu.UrlaherKA.Sprint0.Task2.V0.Lib;
namespace Tyuiu.UrlaherKA.Sprint0.Task2.V0.Test

{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Кирилл";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("Привет..., Кирилл", res);
        }
    }
}
