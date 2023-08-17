namespace ControlString
{
    partial class Form1
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
            txt = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtDni = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // txt
            // 
            txt.Font = new Font("Arial Narrow", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt.Location = new Point(12, 199);
            txt.MaxLength = 9;
            txt.Name = "txt";
            txt.Size = new Size(100, 22);
            txt.TabIndex = 0;
            txt.KeyPress += txt_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(407, 31);
            label1.TabIndex = 1;
            label1.Text = "FORMATOS DE PATENTES: AAA 000";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(126, 89);
            label2.Name = "label2";
            label2.Size = new Size(293, 32);
            label2.TabIndex = 2;
            label2.Text = "formato 2: AA 123 AA";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(12, 240);
            label3.Name = "label3";
            label3.Size = new Size(387, 31);
            label3.TabIndex = 3;
            label3.Text = "FORMATO CUIT: NN-NNNNNNNN-N";
            // 
            // txtDni
            // 
            txtDni.Font = new Font("Arial Narrow", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtDni.Location = new Point(12, 333);
            txtDni.MaxLength = 11;
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(100, 22);
            txtDni.TabIndex = 4;
            txtDni.KeyPress += txtDni_KeyPress;
            // 
            // button1
            // 
            button1.Location = new Point(183, 332);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 5;
            button1.Text = "Imprimir";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(txtDni);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtDni;
        private Button button1;
    }
}