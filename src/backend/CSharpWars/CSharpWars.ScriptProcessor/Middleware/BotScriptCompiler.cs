using System;
using System.Linq;
using System.Runtime.CompilerServices;
using CSharpWars.Common.Extensions;
using CSharpWars.Enums;
using CSharpWars.Scripting;
using CSharpWars.Scripting.Model;
using CSharpWars.ScriptProcessor.Middleware.Interfaces;
using Microsoft.CodeAnalysis.CSharp.Scripting;
using Microsoft.CodeAnalysis.Scripting;

namespace CSharpWars.ScriptProcessor.Middleware
{
    public class BotScriptCompiler : IBotScriptCompiler
    {
        public Script Compile(String script)
        {
            throw new NotImplementedException();
        }
    }
}