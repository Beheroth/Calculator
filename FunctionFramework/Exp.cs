﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperComputer;

namespace FunctionFramework
{
    public class Exp : Function<string>
    {
        public string HelpMessage
        {
            get
            {
                return "help";
            }
        }

        public string Name
        {
            get
            {
                return "Exp";
            }
        }

        public string[] ParametersName
        {
            get
            {
                string[] param = new string[2];
                param.SetValue("a", 0);
                param.SetValue("b", 1);
                return param;
            }
        }

        public string Evaluate(string[] args)
        {
            try
            {
                double a = double.Parse(args[0]);
                double b = double.Parse(args[1]);
                return (a*b).ToString();
            }

            catch
            {
                throw new EvaluationException("Couldn't substract the specified doubles");
            }
        }
    }
}