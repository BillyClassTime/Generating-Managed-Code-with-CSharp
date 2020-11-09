using System;
using System.CodeDom;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Microsoft.CSharp;
using Microsoft.VisualBasic;
using Microsoft.JScript;

namespace CodeDomExample
{
    public partial class CodeDomExampleForm : Form
    {
        public CodeDomExampleForm()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
        }

        private void generate_button_Click(object sender, EventArgs e)
        {
            CodeDomProvider provider = GetCurrentProvider();
            CodeDomExample.GenerateCode(provider, CodeDomExample.BuildHelloWorldGraph(HelloWordFrom.Text));
            
            String sourceFile;                                          // Build the source file name with the appropriate language extension.
            if (provider.FileExtension[0] == '.')
                sourceFile = "TestGraph" + provider.FileExtension;
            else
                sourceFile = "TestGraph." + provider.FileExtension;
            StreamReader sr = new StreamReader(sourceFile);             // Read in the generated source file and display the source text.
            textBox1.Text = sr.ReadToEnd();
            sr.Close();
        }

        private void compile_button_Click(object sender, EventArgs e)
        {
            CodeDomProvider provider = GetCurrentProvider();
            String sourceFile;                                              // Build the source file name with the appropriate language extension.
            if (provider.FileExtension[0] == '.')
                sourceFile = "TestGraph" + provider.FileExtension;
            else
                sourceFile = "TestGraph." + provider.FileExtension;
            CompilerResults cr = CodeDomExample.CompileCode(provider,       // Compile the source file into an executable output file.
                                                            sourceFile,
                                                            "TestGraph.exe");
            if (cr.Errors.Count > 0)
            {
                
                textBox1.Text = "Errors encountered while building " +      // Display compilation errors.
                                sourceFile + " into " + cr.PathToAssembly + ": \r\n\n";
                foreach (CompilerError ce in cr.Errors)
                    textBox1.AppendText(ce.ToString() + "\r\n");
                run_button.Enabled = false;
            }
            else
            {
                textBox1.Text = "Source " + sourceFile + " built into " +
                                cr.PathToAssembly + " with no errors.";
                run_button.Enabled = true;
            }
        }

        private void run_button_Click(object sender, EventArgs e)
        {
            Process.Start("TestGraph.exe");
        }

        private CodeDomProvider GetCurrentProvider()
        {
            return ((string)this.comboBox1.SelectedItem) switch
            {
                "Visual Basic" => CodeDomProvider.CreateProvider("VisualBasic"),
                "JScript" => CodeDomProvider.CreateProvider("JScript"),
                null => CodeDomProvider.CreateProvider("CSharp"),
                _ => CodeDomProvider.CreateProvider("CSharp"),
            };
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            HelloWordFrom.Text = $"Hello World! from {(string) comboBox1.SelectedItem} generating code.";
        }
    }
}
