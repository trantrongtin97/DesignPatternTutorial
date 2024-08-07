using DesignPattern.BehavioralDesignPattern.InterpreterDesignPattern.Interface;

namespace DesignPattern.BehavioralDesignPattern.InterpreterDesignPattern
{
    public class MonthExpression : IExpression
    {
        public void Evaluate(Context context)
        {
            string expression = context.Expression;
            context.Expression = expression.Replace("MM", context.Date.Month.ToString());
        }
    }
}
