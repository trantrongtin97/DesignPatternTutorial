using DesignPattern.BehavioralDesignPattern.InterpreterDesignPattern.Interface;

namespace DesignPattern.BehavioralDesignPattern.InterpreterDesignPattern
{
    public class ExampleInterpreterDesignPattern
    {
        public void Run()
        {
            Context context = new Context(DateTime.Now);
            Console.WriteLine("Select the Expression  : MM DD YYYY");
            context.Expression = "MM DD YYYY";
            EvaluateExpression(context);
            Console.WriteLine("Select the Expression  : YYYY MM DD");
            context.Expression = "YYYY MM DD";
            EvaluateExpression(context);
            Console.WriteLine("Select the Expression  : DD MM YYYY");
            context.Expression = "DD MM YYYY";
            EvaluateExpression(context);
        }

        public void EvaluateExpression(Context context)
        {
            List<IExpression> objExpressions = new List<IExpression>();
            string[] strArray = context.Expression.Split(' ');
            foreach (var item in strArray)
            {
                if (item == "DD")
                {
                    objExpressions.Add(new DayExpression());
                }
                else if (item == "MM")
                {
                    objExpressions.Add(new MonthExpression());
                }
                else if (item == "YYYY")
                {
                    objExpressions.Add(new YearExpression());
                }
            }

            objExpressions.Add(new SeparatorExpression());
            foreach (var obj in objExpressions)
            {
                obj.Evaluate(context);
            }
            Console.WriteLine(context.Expression);
        }
    }
}
