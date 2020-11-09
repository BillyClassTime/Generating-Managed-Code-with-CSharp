using System;
using System.CodeDom;
using System.CodeDom.Compiler;
using System.IO;
namespace CodeDomExample
{
    class CodeDomExample
    {
        // Build a Hello World program graph using System.CodeDom types.
        public static CodeCompileUnit BuildHelloWorldGraph(string message)
        {
            CodeCompileUnit compileUnit = new CodeCompileUnit();    // Create a new CodeCompileUnit to contain the program graph.
            CodeNamespace samples = new CodeNamespace("Samples");   // Declare a new namespace called Samples.
            compileUnit.Namespaces.Add(samples);                    // Add the new namespace to the compile unit.
            samples.Imports.Add(new CodeNamespaceImport("System")); // Add the new namespace import for the System namespace.
            CodeTypeDeclaration class1 = new CodeTypeDeclaration("Program"); // Declare a new type called Class1.
            samples.Types.Add(class1);                              // Add the new type to the namespace type collection.
            CodeEntryPointMethod start = new CodeEntryPointMethod();// Declare a new code entry point method.
            CodeTypeReferenceExpression csSystemConsoleType = new CodeTypeReferenceExpression("System.Console");// Create a type reference for the System.Console class.
            CodeMethodInvokeExpression cs1 = new CodeMethodInvokeExpression(// Build a Console.WriteLine statement.
                csSystemConsoleType, "WriteLine",
                new CodePrimitiveExpression(message));
            start.Statements.Add(cs1);                              // Add the WriteLine call to the statement collection.
            CodeMethodInvokeExpression cs2 = new CodeMethodInvokeExpression( // Build another Console.WriteLine statement.
                csSystemConsoleType, "WriteLine",
                new CodePrimitiveExpression("Press the Enter key to continue."));
            start.Statements.Add(cs2);                              // Add the WriteLine call to the statement collection.
            CodeMethodInvokeExpression csReadLine = new CodeMethodInvokeExpression( // Build a call to System.Console.ReadLine.
                csSystemConsoleType, "ReadLine");
            start.Statements.Add(csReadLine);                       // Add the ReadLine statement.
            class1.Members.Add(start);                              // Add the code entry point method to the Members collection of the type.
            return compileUnit;
        }

        public static void GenerateCode(CodeDomProvider provider,
            CodeCompileUnit compileunit)
        {
            // Build the source file name with the appropriate language extension.
            String sourceFile;
            if (provider.FileExtension[0] == '.')
                sourceFile = "TestGraph" + provider.FileExtension;
            else
                sourceFile = "TestGraph." + provider.FileExtension;

            // Create an IndentedTextWriter, constructed with a StreamWriter to the source file.
            IndentedTextWriter tw = new IndentedTextWriter(new StreamWriter(sourceFile, false), "    ");
            provider.GenerateCodeFromCompileUnit(compileunit, tw, new CodeGeneratorOptions());  // Generate source code using the code generator.
            tw.Close();                                                                         // Close the output file.
        }

        public static CompilerResults CompileCode(CodeDomProvider provider,
                                                  String sourceFile,
                                                  String exeFile)
        {
            // Configure a CompilerParameters that links System.dll and produces the specified executable file.
            String[] referenceAssemblies = { "System.dll" };
            CompilerParameters cp = new CompilerParameters(referenceAssemblies,exeFile, false);
            cp.GenerateExecutable = true;                                           // Generate an executable rather than a DLL file.
            CompilerResults cr = provider.CompileAssemblyFromFile(cp, sourceFile);  // Invoke compilation.
            return cr;                                                              // Return the results of compilation.
        }
    }
}