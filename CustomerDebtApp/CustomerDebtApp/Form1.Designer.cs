namespace CustomerDebtApp
{
    partial class Form1
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
            this.Dequeue = new System.Windows.Forms.Button();
            this.Enqueue = new System.Windows.Forms.Button();
            this.Name_Label = new System.Windows.Forms.Label();
            this.AmountOwed_Label = new System.Windows.Forms.Label();
            this.Address_Label = new System.Windows.Forms.Label();
            this.Age_Label = new System.Windows.Forms.Label();
            this.Display_Info = new System.Windows.Forms.TextBox();
            this.AmountOwed_TextBox = new System.Windows.Forms.TextBox();
            this.Address_TextBox = new System.Windows.Forms.TextBox();
            this.Age_TextBox = new System.Windows.Forms.TextBox();
            this.Name_TextBox = new System.Windows.Forms.TextBox();
            this.CustomerCount = new System.Windows.Forms.Label();
            this.Total_Owed_Label = new System.Windows.Forms.Label();
            this.Customer_Max_Debt_Label = new System.Windows.Forms.Label();
            this.Peek = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Dequeue
            // 
            this.Dequeue.Location = new System.Drawing.Point(216, 232);
            this.Dequeue.Name = "Dequeue";
            this.Dequeue.Size = new System.Drawing.Size(94, 36);
            this.Dequeue.TabIndex = 24;
            this.Dequeue.Text = "Dequeue";
            this.Dequeue.UseVisualStyleBackColor = true;
            this.Dequeue.Click += new System.EventHandler(this.Dequeue_Click);
            // 
            // Enqueue
            // 
            this.Enqueue.Location = new System.Drawing.Point(79, 232);
            this.Enqueue.Name = "Enqueue";
            this.Enqueue.Size = new System.Drawing.Size(101, 36);
            this.Enqueue.TabIndex = 23;
            this.Enqueue.Text = "Enqueue";
            this.Enqueue.UseVisualStyleBackColor = true;
            this.Enqueue.Click += new System.EventHandler(this.Enqueue_Click);
            // 
            // Name_Label
            // 
            this.Name_Label.AutoSize = true;
            this.Name_Label.Location = new System.Drawing.Point(94, 9);
            this.Name_Label.Name = "Name_Label";
            this.Name_Label.Size = new System.Drawing.Size(55, 20);
            this.Name_Label.TabIndex = 22;
            this.Name_Label.Text = "Name:";
            // 
            // AmountOwed_Label
            // 
            this.AmountOwed_Label.AutoSize = true;
            this.AmountOwed_Label.Location = new System.Drawing.Point(94, 190);
            this.AmountOwed_Label.Name = "AmountOwed_Label";
            this.AmountOwed_Label.Size = new System.Drawing.Size(114, 20);
            this.AmountOwed_Label.TabIndex = 21;
            this.AmountOwed_Label.Text = "Amount Owed:";
            // 
            // Address_Label
            // 
            this.Address_Label.AutoSize = true;
            this.Address_Label.Location = new System.Drawing.Point(94, 80);
            this.Address_Label.Name = "Address_Label";
            this.Address_Label.Size = new System.Drawing.Size(72, 20);
            this.Address_Label.TabIndex = 20;
            this.Address_Label.Text = "Address:";
            // 
            // Age_Label
            // 
            this.Age_Label.AutoSize = true;
            this.Age_Label.Location = new System.Drawing.Point(94, 48);
            this.Age_Label.Name = "Age_Label";
            this.Age_Label.Size = new System.Drawing.Size(42, 20);
            this.Age_Label.TabIndex = 19;
            this.Age_Label.Text = "Age:";
            // 
            // Display_Info
            // 
            this.Display_Info.Location = new System.Drawing.Point(79, 290);
            this.Display_Info.Multiline = true;
            this.Display_Info.Name = "Display_Info";
            this.Display_Info.Size = new System.Drawing.Size(440, 95);
            this.Display_Info.TabIndex = 17;
            // 
            // AmountOwed_TextBox
            // 
            this.AmountOwed_TextBox.Location = new System.Drawing.Point(216, 184);
            this.AmountOwed_TextBox.Name = "AmountOwed_TextBox";
            this.AmountOwed_TextBox.Size = new System.Drawing.Size(267, 26);
            this.AmountOwed_TextBox.TabIndex = 16;
            // 
            // Address_TextBox
            // 
            this.Address_TextBox.Location = new System.Drawing.Point(216, 74);
            this.Address_TextBox.Multiline = true;
            this.Address_TextBox.Name = "Address_TextBox";
            this.Address_TextBox.Size = new System.Drawing.Size(267, 101);
            this.Address_TextBox.TabIndex = 15;
            // 
            // Age_TextBox
            // 
            this.Age_TextBox.Location = new System.Drawing.Point(216, 42);
            this.Age_TextBox.Name = "Age_TextBox";
            this.Age_TextBox.Size = new System.Drawing.Size(267, 26);
            this.Age_TextBox.TabIndex = 14;
            // 
            // Name_TextBox
            // 
            this.Name_TextBox.Location = new System.Drawing.Point(216, 9);
            this.Name_TextBox.Name = "Name_TextBox";
            this.Name_TextBox.Size = new System.Drawing.Size(267, 26);
            this.Name_TextBox.TabIndex = 13;
            // 
            // CustomerCount
            // 
            this.CustomerCount.AutoSize = true;
            this.CustomerCount.Location = new System.Drawing.Point(506, 42);
            this.CustomerCount.Name = "CustomerCount";
            this.CustomerCount.Size = new System.Drawing.Size(0, 20);
            this.CustomerCount.TabIndex = 25;
            // 
            // Total_Owed_Label
            // 
            this.Total_Owed_Label.AutoSize = true;
            this.Total_Owed_Label.Location = new System.Drawing.Point(510, 107);
            this.Total_Owed_Label.Name = "Total_Owed_Label";
            this.Total_Owed_Label.Size = new System.Drawing.Size(0, 20);
            this.Total_Owed_Label.TabIndex = 26;
            // 
            // Customer_Max_Debt_Label
            // 
            this.Customer_Max_Debt_Label.AutoSize = true;
            this.Customer_Max_Debt_Label.Location = new System.Drawing.Point(510, 155);
            this.Customer_Max_Debt_Label.Name = "Customer_Max_Debt_Label";
            this.Customer_Max_Debt_Label.Size = new System.Drawing.Size(0, 20);
            this.Customer_Max_Debt_Label.TabIndex = 27;
            // 
            // Peek
            // 
            this.Peek.Location = new System.Drawing.Point(360, 232);
            this.Peek.Name = "Peek";
            this.Peek.Size = new System.Drawing.Size(75, 36);
            this.Peek.TabIndex = 28;
            this.Peek.Text = "Peek";
            this.Peek.UseVisualStyleBackColor = true;
            this.Peek.Click += new System.EventHandler(this.Peek_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 450);
            this.Controls.Add(this.Peek);
            this.Controls.Add(this.Customer_Max_Debt_Label);
            this.Controls.Add(this.Total_Owed_Label);
            this.Controls.Add(this.CustomerCount);
            this.Controls.Add(this.Dequeue);
            this.Controls.Add(this.Enqueue);
            this.Controls.Add(this.Name_Label);
            this.Controls.Add(this.AmountOwed_Label);
            this.Controls.Add(this.Address_Label);
            this.Controls.Add(this.Age_Label);
            this.Controls.Add(this.Display_Info);
            this.Controls.Add(this.AmountOwed_TextBox);
            this.Controls.Add(this.Address_TextBox);
            this.Controls.Add(this.Age_TextBox);
            this.Controls.Add(this.Name_TextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Dequeue;
        private System.Windows.Forms.Button Enqueue;
        private System.Windows.Forms.Label Name_Label;
        private System.Windows.Forms.Label AmountOwed_Label;
        private System.Windows.Forms.Label Address_Label;
        private System.Windows.Forms.Label Age_Label;
        private System.Windows.Forms.TextBox Display_Info;
        private System.Windows.Forms.TextBox AmountOwed_TextBox;
        private System.Windows.Forms.TextBox Address_TextBox;
        private System.Windows.Forms.TextBox Age_TextBox;
        private System.Windows.Forms.TextBox Name_TextBox;
        private System.Windows.Forms.Label CustomerCount;
        private System.Windows.Forms.Label Total_Owed_Label;
        private System.Windows.Forms.Label Customer_Max_Debt_Label;
        private System.Windows.Forms.Button Peek;
    }
}

