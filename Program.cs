using System;
using System.Linq.Expressions;

namespace ExpressionTreeLambda
{
    class Program
    {
        static void DirectLambdaExpression()
        {
            Expression<Func<int, int>> lambdaMultiplication = x =>  x * x ;
            Console.WriteLine(lambdaMultiplication);
        }

        static void APIExpression()
        {
            ParameterExpression parameter = Expression.Parameter(typeof(int), "x");
            BinaryExpression binaryExpression = Expression.Multiply(parameter, parameter);
            Expression<Func<int, int>> lambda1 = Expression.Lambda<Func<int, int>>(binaryExpression,new ParameterExpression[] {parameter});
            Console.WriteLine(lambda1);
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("DirectLambdaExpression:");
            DirectLambdaExpression();
            Console.WriteLine("APIExpression:");
            APIExpression();
        }
    }
}
