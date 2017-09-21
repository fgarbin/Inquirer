﻿using InquirerCore.Console;
using InquirerCore.Validators;
using System;
using System.Collections.Generic;
using System.Text;

namespace InquirerCore.Prompts
{
    public abstract class BasePrompt : IPrompt
    {
        public string name { private set; get; }
        public string message { private set; get; }
        protected IValidator Validator;
        protected IConsole Console;
        protected readonly IRender consoleRender;

        public BasePrompt(string name, string message, IRender consoleRender, IConsole console = null)
        {
            this.name = name;
            this.message = message;
            this.Console = console ?? new ConsoleWrapper();
            this.consoleRender = consoleRender;
        }
        public void SetValid(IValidator validator) => Validator = validator;
        public abstract string[] GetQuestion();
        public abstract void Render();
        public abstract string Answer();
        public abstract void Ask();
    }
}
