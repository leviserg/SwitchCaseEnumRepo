using SwitchCaseEnum;

namespace SwitchCaseEnumTests
{
    [TestClass]
    public class ControlEnumLambdaTest
    {
        [TestMethod]
        public void TestEnumOperationLambdaAdd()
        {
            var controlEnum = ControlEnum.Add;
            int result = ControlEnumOperations.ExecuteLambda(controlEnum, 2, 3);

            Assert.AreEqual(5, result);

        }

        [TestMethod]
        public void TestEnumOperationLambdaSubtract()
        {
            var controlEnum = ControlEnum.Subtract;
            int result = ControlEnumOperations.ExecuteLambda(controlEnum, 2, 3);

            Assert.AreEqual(-1, result);
        }

        [TestMethod]
        public void TestEnumOperationLambdaMultiply()
        {
            var controlEnum = ControlEnum.Mulptiply;
            int result = ControlEnumOperations.ExecuteLambda(controlEnum, 2, 3);

            Assert.AreEqual(6, result);
        }

        [TestMethod]
        public void TestEnumOperationLambdaDivide()
        {
            var controlEnum = ControlEnum.Divide;
            int result = ControlEnumOperations.ExecuteLambda(controlEnum, 10, 2);

            Assert.AreEqual(5, result);
            Assert.IsTrue(5 == result);
        }
    }
}