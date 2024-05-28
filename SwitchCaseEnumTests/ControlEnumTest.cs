using SwitchCaseEnum;

namespace SwitchCaseEnumTests
{
    [TestClass]
    public class ControlEnumTest
    {
        [TestMethod]
        public void TestEnumOperationAdd()
        {
            var controlEnum = ControlEnum.Add;
            int result = ControlEnumOperations.Execute(controlEnum, 2, 3);

            Assert.AreEqual(5, result);

        }

        [TestMethod]
        public void TestEnumOperationSubtract()
        {
            var controlEnum = ControlEnum.Subtract;
            int result = ControlEnumOperations.Execute(controlEnum, 2, 3);

            Assert.AreEqual(-1, result);
        }

        [TestMethod]
        public void TestEnumOperationMultiply()
        {
            var controlEnum = ControlEnum.Mulptiply;
            int result = ControlEnumOperations.Execute(controlEnum, 2, 3);

            Assert.AreEqual(6, result);
        }

        [TestMethod]
        public void TestEnumOperationDivide()
        {
            var controlEnum = ControlEnum.Divide;
            int result = ControlEnumOperations.Execute(controlEnum, 10, 2);

            Assert.AreEqual(5, result);
        }
    }
}