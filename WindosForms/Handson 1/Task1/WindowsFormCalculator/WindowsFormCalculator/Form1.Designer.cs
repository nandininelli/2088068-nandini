
namespace WindowsFormCalculator
{
    partial class calci
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
            this.lblinput1 = new System.Windows.Forms.Label();
            this.lblinput2 = new System.Windows.Forms.Label();
            this.lblresult = new System.Windows.Forms.Label();
            this.lblOperation = new System.Windows.Forms.Label();
            this.txtinput1 = new System.Windows.Forms.TextBox();
            this.txtinput2 = new System.Windows.Forms.TextBox();
            this.txtresult = new System.Windows.Forms.TextBox();
            this.btnresult = new System.Windows.Forms.Button();
            this.radioButton_add = new System.Windows.Forms.RadioButton();
            this.radioButton_substract = new System.Windows.Forms.RadioButton();
            this.radioButton_multiply = new System.Windows.Forms.RadioButton();
            this.radioButton_division = new System.Windows.Forms.RadioButton();
            this.lblcal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblinput1
            // 
            this.lblinput1.AutoSize = true;
            this.lblinput1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblinput1.Location = new System.Drawing.Point(230, 109);
            this.lblinput1.Name = "lblinput1";
            this.lblinput1.Size = new System.Drawing.Size(55, 13);
            this.lblinput1.TabIndex = 0;
            this.lblinput1.Text = "Input1  :";
            this.lblinput1.Click += new System.EventHandler(this.lblInput1_Click);
            // 
            // lblinput2
            // 
            this.lblinput2.AutoSize = true;
            this.lblinput2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblinput2.Location = new System.Drawing.Point(230, 154);
            this.lblinput2.Name = "lblinput2";
            this.lblinput2.Size = new System.Drawing.Size(55, 13);
            this.lblinput2.TabIndex = 1;
            this.lblinput2.Text = "Input2  :";
            this.lblinput2.Click += new System.EventHandler(this.lblinput2_Click);
            // 
            // lblresult
            // 
            this.lblresult.AutoSize = true;
            this.lblresult.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblresult.Location = new System.Drawing.Point(230, 201);
            this.lblresult.Name = "lblresult";
            this.lblresult.Size = new System.Drawing.Size(55, 13);
            this.lblresult.TabIndex = 2;
            this.lblresult.Text = "Result  :";
            // 
            // lblOperation
            // 
            this.lblOperation.AutoSize = true;
            this.lblOperation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperation.Location = new System.Drawing.Point(211, 254);
            this.lblOperation.Name = "lblOperation";
            this.lblOperation.Size = new System.Drawing.Size(74, 13);
            this.lblOperation.TabIndex = 4;
            this.lblOperation.Text = "Operation  :";
            // 
            // txtinput1
            // 
            this.txtinput1.Location = new System.Drawing.Point(306, 102);
            this.txtinput1.Name = "txtinput1";
            this.txtinput1.Size = new System.Drawing.Size(100, 20);
            this.txtinput1.TabIndex = 5;
            // 
            // txtinput2
            // 
            this.txtinput2.Location = new System.Drawing.Point(306, 151);
            this.txtinput2.Name = "txtinput2";
            this.txtinput2.Size = new System.Drawing.Size(100, 20);
            this.txtinput2.TabIndex = 6;
            this.txtinput2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtresult
            // 
            this.txtresult.Location = new System.Drawing.Point(306, 198);
            this.txtresult.Name = "txtresult";
            this.txtresult.ReadOnly = true;
            this.txtresult.Size = new System.Drawing.Size(100, 20);
            this.txtresult.TabIndex = 7;
            this.txtresult.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // btnresult
            // 
            this.btnresult.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnresult.Location = new System.Drawing.Point(492, 369);
            this.btnresult.Name = "btnresult";
            this.btnresult.Size = new System.Drawing.Size(75, 23);
            this.btnresult.TabIndex = 8;
            this.btnresult.Text = "GetResult";
            this.btnresult.UseVisualStyleBackColor = true;
            this.btnresult.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // radioButton_add
            // 
            this.radioButton_add.AutoSize = true;
            this.radioButton_add.Location = new System.Drawing.Point(307, 252);
            this.radioButton_add.Name = "radioButton_add";
            this.radioButton_add.Size = new System.Drawing.Size(63, 17);
            this.radioButton_add.TabIndex = 9;
            this.radioButton_add.TabStop = true;
            this.radioButton_add.Text = "Addition";
            this.radioButton_add.UseVisualStyleBackColor = true;
            this.radioButton_add.CheckedChanged += new System.EventHandler(this.radioButton_add_CheckedChanged);
            // 
            // radioButton_substract
            // 
            this.radioButton_substract.AutoSize = true;
            this.radioButton_substract.Location = new System.Drawing.Point(307, 288);
            this.radioButton_substract.Name = "radioButton_substract";
            this.radioButton_substract.Size = new System.Drawing.Size(78, 17);
            this.radioButton_substract.TabIndex = 10;
            this.radioButton_substract.TabStop = true;
            this.radioButton_substract.Text = "Substration";
            this.radioButton_substract.UseVisualStyleBackColor = true;
            this.radioButton_substract.CheckedChanged += new System.EventHandler(this.radioButton_subtract_CheckedChanged);
            // 
            // radioButton_multiply
            // 
            this.radioButton_multiply.AutoSize = true;
            this.radioButton_multiply.Location = new System.Drawing.Point(306, 330);
            this.radioButton_multiply.Name = "radioButton_multiply";
            this.radioButton_multiply.Size = new System.Drawing.Size(86, 17);
            this.radioButton_multiply.TabIndex = 11;
            this.radioButton_multiply.TabStop = true;
            this.radioButton_multiply.Text = "Multiplication";
            this.radioButton_multiply.UseVisualStyleBackColor = true;
            this.radioButton_multiply.CheckedChanged += new System.EventHandler(this.radioButton_multiply_CheckedChanged);
            // 
            // radioButton_division
            // 
            this.radioButton_division.AutoSize = true;
            this.radioButton_division.Location = new System.Drawing.Point(307, 369);
            this.radioButton_division.Name = "radioButton_division";
            this.radioButton_division.Size = new System.Drawing.Size(62, 17);
            this.radioButton_division.TabIndex = 12;
            this.radioButton_division.TabStop = true;
            this.radioButton_division.Text = "Division";
            this.radioButton_division.UseVisualStyleBackColor = true;
            this.radioButton_division.CheckedChanged += new System.EventHandler(this.radioButton_division_CheckedChanged);
            // 
            // lblcal
            // 
            this.lblcal.AutoSize = true;
            this.lblcal.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcal.Location = new System.Drawing.Point(255, 28);
            this.lblcal.Name = "lblcal";
            this.lblcal.Size = new System.Drawing.Size(257, 25);
            this.lblcal.TabIndex = 13;
            this.lblcal.Text = "WINDOWS CALCULATOR";
            // 
            // calci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblcal);
            this.Controls.Add(this.radioButton_division);
            this.Controls.Add(this.radioButton_multiply);
            this.Controls.Add(this.radioButton_substract);
            this.Controls.Add(this.radioButton_add);
            this.Controls.Add(this.btnresult);
            this.Controls.Add(this.txtresult);
            this.Controls.Add(this.txtinput2);
            this.Controls.Add(this.txtinput1);
            this.Controls.Add(this.lblOperation);
            this.Controls.Add(this.lblresult);
            this.Controls.Add(this.lblinput2);
            this.Controls.Add(this.lblinput1);
            this.Name = "calci";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.calci_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblinput1;
        private System.Windows.Forms.Label lblinput2;
        private System.Windows.Forms.Label lblresult;
        private System.Windows.Forms.Label lblOperation;
        private System.Windows.Forms.TextBox txtinput1;
        private System.Windows.Forms.TextBox txtinput2;
        private System.Windows.Forms.TextBox txtresult;
        private System.Windows.Forms.Button btnresult;
        private System.Windows.Forms.RadioButton radioButton_add;
        private System.Windows.Forms.RadioButton radioButton_substract;
        private System.Windows.Forms.RadioButton radioButton_multiply;
        private System.Windows.Forms.RadioButton radioButton_division;
        private System.Windows.Forms.Label lblcal;
    }
}

