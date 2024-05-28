using System.Runtime.CompilerServices;

namespace SwitchCaseEnum
{
    public static class ControlEnumOperations
    {
        public static Dictionary<ControlEnum, Func<int, int, int>> operations = new() {
            { ControlEnum.Add, (a, b) => a + b },
            { ControlEnum.Subtract, (a, b) => a - b },
            { ControlEnum.Mulptiply, (a, b) => a * b },
            { ControlEnum.Divide, (a, b) => a / b },
        };

        public static int Execute (ControlEnum control, int a, int b)
        {
            return operations[control](a, b);
            /*
                if (operations.TryGetValue(control, out var operation))
                {
                    return operation(a, b);
                }
                throw new NotImplementedException($"Operation {control} is not implemented");
             */
        }

        public static int ExecuteLambda(this ControlEnum controlEnum, int a, int b)
        {
            return controlEnum switch
            {
                ControlEnum.Add => a + b,
                ControlEnum.Subtract => a - b,
                ControlEnum.Mulptiply => a * b,
                ControlEnum.Divide => a / b
            };
        }
    }
}
