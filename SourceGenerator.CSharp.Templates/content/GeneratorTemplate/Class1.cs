using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

#if (!csharpFeature_ImplicitUsings)
using System;

#endif

namespace SourceGeneratorTemplate
{
    [Generator]
    public class Class1 : IIncrementalGenerator
    {
        public void Initialize(IncrementalGeneratorInitializationContext context)
        {
            throw new NotImplementedException();
        }
    }
}