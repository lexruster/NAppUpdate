﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetreveil.AutoUpdate.Framework.Tasks
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true, Inherited = false)]
    public class UpdateTaskAliasAttribute : Attribute
    {
        private readonly string _alias;

        public UpdateTaskAliasAttribute(string alias)
        {
            this._alias = alias;
        }

        public string Alias
        {
            [System.Diagnostics.DebuggerStepThrough]
            get { return this._alias; }
        }
    }
}
