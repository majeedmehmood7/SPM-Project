using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    class Postfix : operatorclass
    {
        public static double evaluater(string postfix)
        {
            double result; 
            double op1;
            double op2;
            
            Stack<double> stack = new Stack<double>();
            int len = (postfix.Length);
            for (int i = 0; i < len; i++)
            {
                char c1 = postfix[i];
                string x = ""; double read_x = 0; char c = ' ';
                if (c1 == ' ')
                    continue;

             
                else if (char.IsDigit(c1))
                {
                    x += c1;

                    while (i < len - 1 && char.IsDigit(c = postfix[++i]))
                        x += c;


                    read_x = double.Parse(x);
                    stack.Push(read_x);
                }
                else
                {
                    op1 = stack.Pop();
                    try
                    {
                        op2 = stack.Pop();
                    }
                    catch (Exception)
                    {
                        op2 = 0;
                    }
                    switch (c1)
                    {
                        case '+':
                            result = (double)(op2 + op1);
                            stack.Push(result);
                            break;
                        case '-':
                            result = (double)(op2 - op1);
                            stack.Push(result);
                            break;
                        case '*':
                            result = (double)(op2 * op1);
                            stack.Push(result);
                            break;
                        case '/':
                            if (op1 == 0)
                            {
                                throw new DivideByZeroException();

                            }
                            else
                            {
                                result = (double)(op2 / op1);
                                stack.Push(result);
                            }
                            break;
                        case '^':
                            result = (double)(Math.Pow(op2, op1));
                            stack.Push(result);
                            break;
                    }
                }
            }
            result = (double)stack.Pop();
            return result;
        }
       


        public static string infixToPostfix(string exp)
        { 
            string result = "";
 
            Stack<char> stack = new Stack<char>();

            for (int i = 0; i < exp.Length; ++i)
            {
                char c = exp[i]; 

                if (char.IsWhiteSpace(c))
                {
                    continue;
                }

                else if (char.IsDigit(exp[i]))
                {
                    int operand = 0;

                    while (i < exp.Length && char.IsDigit(exp[i]))
                    {

                        operand = (operand * 10) + (exp[i] - '0');
                        i++;
                    }
                    i--;
                    result = result + operand.ToString() + " ";
                }

                else if (c == '(')
                {
                    stack.Push(c);
                } 
                else if (c == ')')
                {
                    while (stack.Count > 0 && stack.Peek() != '(')
                    {
                        result = result + " " + stack.Pop();
                    }

                    if (stack.Count > 0 && stack.Peek() != '(')
                    {
                        System.Windows.Forms.MessageBox.Show("Invalid Expression"); 
                    }
                    else
                    {
                        stack.Pop();
                    }
                }
                else 
                {
                    while (stack.Count > 0 && Prec(c) <= Prec(stack.Peek()))
                    {
                        result = result + " " + stack.Pop();
                    }
                    stack.Push(c);
                }

            }
 
            while (stack.Count > 0)
            {
                result = result + " " + stack.Pop();
            }
            return evaluater(result).ToString();
        }

        bool isDigi(char ch)
        {
            if (ch >= '0' && ch <= '9')
                return true;
            return false;
        }

    }

    class operatorclass
    {
        protected static int Prec(char ch)
        {
            switch (ch)
            {
                case '+':
                case '-':
                    return 1;

                case '*':
                case '/':
                    return 2;

                case '^':
                    return 3;
            }
            return -1;
        }
        
    }
}
    
    

    
