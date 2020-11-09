using System.Windows.Forms;

namespace CodeDomExample
{
    partial class CodeDomExampleForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.run_button = new System.Windows.Forms.Button();
            this.compile_button = new System.Windows.Forms.Button();
            this.generate_button = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.HelloWordFrom = new System.Windows.Forms.TextBox();
            this.lblHelloWordFrom = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // run_button
            // 
            this.run_button.Location = new System.Drawing.Point(268, 16);
            this.run_button.Name = "run_button";
            this.run_button.Size = new System.Drawing.Size(120, 23);
            this.run_button.TabIndex = 0;
            this.run_button.Text = "Run";
            this.run_button.UseVisualStyleBackColor = true;
            this.run_button.Click += new System.EventHandler(this.run_button_Click);
            // 
            // compile_button
            // 
            this.compile_button.Location = new System.Drawing.Point(140, 16);
            this.compile_button.Name = "compile_button";
            this.compile_button.Size = new System.Drawing.Size(120, 23);
            this.compile_button.TabIndex = 1;
            this.compile_button.Text = "Compile";
            this.compile_button.UseVisualStyleBackColor = true;
            this.compile_button.Click += new System.EventHandler(this.compile_button_Click);
            // 
            // generate_button
            // 
            this.generate_button.Location = new System.Drawing.Point(12, 16);
            this.generate_button.Name = "generate_button";
            this.generate_button.Size = new System.Drawing.Size(120, 23);
            this.generate_button.TabIndex = 2;
            this.generate_button.Text = "Generate Code";
            this.generate_button.UseVisualStyleBackColor = true;
            this.generate_button.Click += new System.EventHandler(this.generate_button_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(12, 109);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(803, 329);
            this.textBox1.TabIndex = 3;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "CSharp",
            "Visual Basic",
            "JScript"});
            this.comboBox1.Location = new System.Drawing.Point(618, 15);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(197, 24);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(399, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Select a programming language:";
            // 
            // HelloWordFrom
            // 
            this.HelloWordFrom.Location = new System.Drawing.Point(140, 61);
            this.HelloWordFrom.Name = "HelloWordFrom";
            this.HelloWordFrom.Size = new System.Drawing.Size(472, 22);
            this.HelloWordFrom.TabIndex = 6;
            // 
            // lblHelloWordFrom
            // 
            this.lblHelloWordFrom.AutoSize = true;
            this.lblHelloWordFrom.Location = new System.Drawing.Point(12, 61);
            this.lblHelloWordFrom.Name = "lblHelloWordFrom";
            this.lblHelloWordFrom.Size = new System.Drawing.Size(105, 17);
            this.lblHelloWordFrom.TabIndex = 7;
            this.lblHelloWordFrom.Text = "Message From:";
            // 
            // CodeDomExampleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 450);
            this.Controls.Add(this.lblHelloWordFrom);
            this.Controls.Add(this.HelloWordFrom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.generate_button);
            this.Controls.Add(this.compile_button);
            this.Controls.Add(this.run_button);
            this.MinimumSize = new System.Drawing.Size(750, 340);
            this.Name = "CodeDomExampleForm";
            this.Text = "CodeDom Hello World";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button run_button;
        private System.Windows.Forms.Button compile_button;
        private System.Windows.Forms.Button generate_button;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private TextBox HelloWordFrom;
        private Label lblHelloWordFrom;
    }
}