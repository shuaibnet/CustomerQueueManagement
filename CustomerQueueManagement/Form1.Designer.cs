namespace CustomerQueueManagement
{
    partial class CustomerQueueUI
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.enQButton = new System.Windows.Forms.Button();
            this.complainTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.complainListView = new System.Windows.Forms.ListView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.deQButton = new System.Windows.Forms.Button();
            this.complainDQTextBox = new System.Windows.Forms.TextBox();
            this.sdfdsf = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.serialDQTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nameDQTextBox = new System.Windows.Forms.TextBox();
            this.Complain = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.enQButton);
            this.groupBox1.Controls.Add(this.complainTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.nameTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(452, 174);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enque Customer";
            // 
            // enQButton
            // 
            this.enQButton.Location = new System.Drawing.Point(142, 98);
            this.enQButton.Name = "enQButton";
            this.enQButton.Size = new System.Drawing.Size(75, 23);
            this.enQButton.TabIndex = 2;
            this.enQButton.Text = "Enque";
            this.enQButton.UseVisualStyleBackColor = true;
            this.enQButton.Click += new System.EventHandler(this.enQButton_Click);
            // 
            // complainTextBox
            // 
            this.complainTextBox.Location = new System.Drawing.Point(63, 52);
            this.complainTextBox.Name = "complainTextBox";
            this.complainTextBox.Size = new System.Drawing.Size(344, 20);
            this.complainTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Complain";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(63, 20);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(262, 20);
            this.nameTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.complainListView);
            this.groupBox2.Location = new System.Drawing.Point(12, 193);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1013, 292);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Waiting Queue";
            // 
            // complainListView
            // 
            this.complainListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.complainListView.Location = new System.Drawing.Point(7, 20);
            this.complainListView.Name = "complainListView";
            this.complainListView.Size = new System.Drawing.Size(1000, 272);
            this.complainListView.TabIndex = 0;
            this.complainListView.UseCompatibleStateImageBehavior = false;
            this.complainListView.View = System.Windows.Forms.View.Details;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.deQButton);
            this.groupBox3.Controls.Add(this.complainDQTextBox);
            this.groupBox3.Controls.Add(this.sdfdsf);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.serialDQTextBox);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.nameDQTextBox);
            this.groupBox3.Location = new System.Drawing.Point(471, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(555, 174);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Deque Customer";
            // 
            // deQButton
            // 
            this.deQButton.Location = new System.Drawing.Point(405, 23);
            this.deQButton.Name = "deQButton";
            this.deQButton.Size = new System.Drawing.Size(75, 23);
            this.deQButton.TabIndex = 2;
            this.deQButton.Text = "Dequeue";
            this.deQButton.UseVisualStyleBackColor = true;
            this.deQButton.Click += new System.EventHandler(this.deQButton_Click);
            // 
            // complainDQTextBox
            // 
            this.complainDQTextBox.Location = new System.Drawing.Point(62, 92);
            this.complainDQTextBox.Name = "complainDQTextBox";
            this.complainDQTextBox.Size = new System.Drawing.Size(344, 20);
            this.complainDQTextBox.TabIndex = 1;
            // 
            // sdfdsf
            // 
            this.sdfdsf.AutoSize = true;
            this.sdfdsf.Location = new System.Drawing.Point(23, 27);
            this.sdfdsf.Name = "sdfdsf";
            this.sdfdsf.Size = new System.Drawing.Size(33, 13);
            this.sdfdsf.TabIndex = 0;
            this.sdfdsf.Text = "Serial";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Name";
            // 
            // serialDQTextBox
            // 
            this.serialDQTextBox.Location = new System.Drawing.Point(62, 27);
            this.serialDQTextBox.Name = "serialDQTextBox";
            this.serialDQTextBox.Size = new System.Drawing.Size(196, 20);
            this.serialDQTextBox.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Complain";
            // 
            // nameDQTextBox
            // 
            this.nameDQTextBox.Location = new System.Drawing.Point(62, 58);
            this.nameDQTextBox.Name = "nameDQTextBox";
            this.nameDQTextBox.Size = new System.Drawing.Size(262, 20);
            this.nameDQTextBox.TabIndex = 1;
            // 
            // Complain
            // 
            this.Complain.Text = "Complain";
            this.Complain.Width = 621;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Serial";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            this.columnHeader2.Width = 187;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Complain";
            this.columnHeader3.Width = 877;
            // 
            // CustomerQueueUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 497);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "CustomerQueueUI";
            this.Text = "Customer Queue UI";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button enQButton;
        private System.Windows.Forms.TextBox complainTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView complainListView;
        private System.Windows.Forms.ColumnHeader Serial;
        private System.Windows.Forms.ColumnHeader Complain;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button deQButton;
        private System.Windows.Forms.TextBox complainDQTextBox;
        private System.Windows.Forms.Label sdfdsf;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox serialDQTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nameDQTextBox;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}

