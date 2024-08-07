using DesignPattern.BehavioralDesignPattern.InterpreterDesignPattern.Interface;

namespace DesignPattern.BehavioralDesignPattern.InterpreterDesignPattern
{
    public class DayExpression : IExpression
    {
        public void Evaluate(Context context)
        {
            string expression = context.Expression;
            context.Expression = expression.Replace("DD", context.Date.Day.ToString());
        }
    }
}
