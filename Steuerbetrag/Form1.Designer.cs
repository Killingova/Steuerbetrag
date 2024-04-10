namespace Steuerbetrag
{
    partial class Steuerbetrag
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelGehalt = new Label();
            textBoxGehalt = new TextBox();
            LblSteuerbetrag = new Label();
            Cmdifelse = new Button();
            CmdSwitchcase = new Button();
            SuspendLayout();
            // 
            // labelGehalt
            // 
            labelGehalt.AutoSize = true;
            labelGehalt.Location = new Point(52, 41);
            labelGehalt.Name = "labelGehalt";
            labelGehalt.Size = new Size(55, 20);
            labelGehalt.TabIndex = 0;
            labelGehalt.Text = "Gehalt:";
            // 
            // textBoxGehalt
            // 
            textBoxGehalt.Location = new Point(52, 64);
            textBoxGehalt.Name = "textBoxGehalt";
            textBoxGehalt.Size = new Size(216, 27);
            textBoxGehalt.TabIndex = 1;
            textBoxGehalt.TextChanged += textBoxGehalt_TextChanged;
            // 
            // LblSteuerbetrag
            // 
            LblSteuerbetrag.AutoSize = true;
            LblSteuerbetrag.BorderStyle = BorderStyle.FixedSingle;
            LblSteuerbetrag.Location = new Point(331, 67);
            LblSteuerbetrag.Name = "LblSteuerbetrag";
            LblSteuerbetrag.Size = new Size(2, 22);
            LblSteuerbetrag.TabIndex = 2;
            LblSteuerbetrag.Click += LblSteuerbetrag_Click;
            // 
            // Cmdifelse
            // 
            Cmdifelse.Location = new Point(52, 167);
            Cmdifelse.Name = "Cmdifelse";
            Cmdifelse.Size = new Size(216, 33);
            Cmdifelse.TabIndex = 3;
            Cmdifelse.Text = "Berechnen mit if ... else";
            Cmdifelse.UseVisualStyleBackColor = true;
            Cmdifelse.Click += Cmdifelse_Click;
            // 
            // CmdSwitchcase
            // 
            CmdSwitchcase.Location = new Point(52, 233);
            CmdSwitchcase.Name = "CmdSwitchcase";
            CmdSwitchcase.Size = new Size(216, 33);
            CmdSwitchcase.TabIndex = 4;
            CmdSwitchcase.Text = "Berechnen mit switch ... case";
            CmdSwitchcase.UseVisualStyleBackColor = true;
            CmdSwitchcase.Click += CmdSwitchcase_Click;
            // 
            // Steuerbetrag
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(800, 450);
            Controls.Add(CmdSwitchcase);
            Controls.Add(Cmdifelse);
            Controls.Add(LblSteuerbetrag);
            Controls.Add(textBoxGehalt);
            Controls.Add(labelGehalt);
            Name = "Steuerbetrag";
            Text = "Steuerbetrag";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelGehalt;
        private TextBox textBoxGehalt;
        private Label LblSteuerbetrag;
        private Button Cmdifelse;
        private Button CmdSwitchcase;
    }
}
