using System;
using System.IO;
using Calc.SyntaxNodes;
using System.Collections.Generic;

namespace Calc
{
    public class LogInterpreter : Interpreter, IDisposable
    {
        public LogInterpreter()
        {
            _logWriter = new StreamWriter("log.txt");
        }

        public void Dispose()
        {
            _logWriter.Dispose();
        }

        public override void Visit(ArithmeticOperation operation)
        {
            base.Visit(operation);
            _logWriter.WriteLine(operation.ToString());
        }

        public override void Visit(Constant constant)
        {
            base.Visit(constant);
            _logWriter.WriteLine(constant.ToString());
        }
    }
}