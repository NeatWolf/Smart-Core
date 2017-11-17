﻿using System.Collections.Generic;

namespace Smart.Evaluator
{
    public class Variables : Dictionary<string, object>
    {

        /// <summary>
        /// clones this set of variables
        /// this is required in order to support local scope and recursion
        /// a copy of the set of variables (arguments in a function) will be pushed on the scope stack
        /// </summary>
        /// <returns></returns>
        public Variables Clone()
        {
            var vars = new Variables();
            foreach (var key in Keys)
                vars.Add(key, this[key]);

            return vars;
        }
    }
}