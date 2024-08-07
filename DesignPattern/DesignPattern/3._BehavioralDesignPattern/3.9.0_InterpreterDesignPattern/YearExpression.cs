using DesignPattern.BehavioralDesignPattern.InterpreterDesignPattern.Interface;

namespace DesignPattern.BehavioralDesignPattern.InterpreterDesignPattern
{
    public class YearExpression : IExpression
    {
        public void Evaluate(Context context)
        {
            string expression = context.Expression;
            context.Expression = expression.Replace("YYYY", context.Date.Year.ToString());
        }
    }
}
