namespace TaskB
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.Add = new System.Windows.Forms.Button();
            this.AddEdge = new System.Windows.Forms.Label();
            this.textBoxEdgeFrom = new System.Windows.Forms.TextBox();
            this.textBoxEdgeTo = new System.Windows.Forms.TextBox();
            this.buttonAddEdge = new System.Windows.Forms.Button();
            this.Names = new System.Windows.Forms.ListBox();
            this.labelSpecificName = new System.Windows.Forms.Label();
            this.textBoxSpecificName = new System.Windows.Forms.TextBox();
            this.buttonFindAdjacent = new System.Windows.Forms.Button();
            this.DirectFriends = new System.Windows.Forms.ListBox();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxFriends = new System.Windows.Forms.TextBox();
            this.buttonFriends = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(99, 14);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 1;
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(205, 12);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 2;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // AddEdge
            // 
            this.AddEdge.AutoSize = true;
            this.AddEdge.Location = new System.Drawing.Point(12, 62);
            this.AddEdge.Name = "AddEdge";
            this.AddEdge.Size = new System.Drawing.Size(54, 13);
            this.AddEdge.TabIndex = 3;
            this.AddEdge.Text = "Add Edge";
            // 
            // textBoxEdgeFrom
            // 
            this.textBoxEdgeFrom.Location = new System.Drawing.Point(99, 54);
            this.textBoxEdgeFrom.Name = "textBoxEdgeFrom";
            this.textBoxEdgeFrom.Size = new System.Drawing.Size(100, 20);
            this.textBoxEdgeFrom.TabIndex = 4;
            // 
            // textBoxEdgeTo
            // 
            this.textBoxEdgeTo.Location = new System.Drawing.Point(205, 55);
            this.textBoxEdgeTo.Name = "textBoxEdgeTo";
            this.textBoxEdgeTo.Size = new System.Drawing.Size(100, 20);
            this.textBoxEdgeTo.TabIndex = 5;
            // 
            // buttonAddEdge
            // 
            this.buttonAddEdge.Location = new System.Drawing.Point(311, 52);
            this.buttonAddEdge.Name = "buttonAddEdge";
            this.buttonAddEdge.Size = new System.Drawing.Size(75, 23);
            this.buttonAddEdge.TabIndex = 6;
            this.buttonAddEdge.Text = "Add Edge";
            this.buttonAddEdge.UseVisualStyleBackColor = true;
            this.buttonAddEdge.Click += new System.EventHandler(this.buttonAddEdge_Click);
            // 
            // Names
            // 
            this.Names.FormattingEnabled = true;
            this.Names.Location = new System.Drawing.Point(15, 160);
            this.Names.Name = "Names";
            this.Names.Size = new System.Drawing.Size(215, 173);
            this.Names.TabIndex = 7;
            // 
            // labelSpecificName
            // 
            this.labelSpecificName.AutoSize = true;
            this.labelSpecificName.Location = new System.Drawing.Point(12, 96);
            this.labelSpecificName.Name = "labelSpecificName";
            this.labelSpecificName.Size = new System.Drawing.Size(81, 13);
            this.labelSpecificName.TabIndex = 8;
            this.labelSpecificName.Text = "Specific Person";
            // 
            // textBoxSpecificName
            // 
            this.textBoxSpecificName.Location = new System.Drawing.Point(99, 93);
            this.textBoxSpecificName.Name = "textBoxSpecificName";
            this.textBoxSpecificName.Size = new System.Drawing.Size(100, 20);
            this.textBoxSpecificName.TabIndex = 9;
            // 
            // buttonFindAdjacent
            // 
            this.buttonFindAdjacent.Location = new System.Drawing.Point(205, 90);
            this.buttonFindAdjacent.Name = "buttonFindAdjacent";
            this.buttonFindAdjacent.Size = new System.Drawing.Size(100, 23);
            this.buttonFindAdjacent.TabIndex = 10;
            this.buttonFindAdjacent.Text = "Find adjacent";
            this.buttonFindAdjacent.UseVisualStyleBackColor = true;
            this.buttonFindAdjacent.Click += new System.EventHandler(this.buttonFindAdjacent_Click);
            // 
            // DirectFriends
            // 
            this.DirectFriends.FormattingEnabled = true;
            this.DirectFriends.Location = new System.Drawing.Point(236, 160);
            this.DirectFriends.Name = "DirectFriends";
            this.DirectFriends.Size = new System.Drawing.Size(214, 173);
            this.DirectFriends.TabIndex = 11;
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(295, 11);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(75, 23);
            this.buttonRemove.TabIndex = 12;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Find Friends";
            // 
            // textBoxFriends
            // 
            this.textBoxFriends.Location = new System.Drawing.Point(99, 123);
            this.textBoxFriends.Name = "textBoxFriends";
            this.textBoxFriends.Size = new System.Drawing.Size(100, 20);
            this.textBoxFriends.TabIndex = 14;
            // 
            // buttonFriends
            // 
            this.buttonFriends.Location = new System.Drawing.Point(205, 121);
            this.buttonFriends.Name = "buttonFriends";
            this.buttonFriends.Size = new System.Drawing.Size(75, 23);
            this.buttonFriends.TabIndex = 15;
            this.buttonFriends.Text = "Find";
            this.buttonFriends.UseVisualStyleBackColor = true;
            this.buttonFriends.Click += new System.EventHandler(this.buttonFriends_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonFriends);
            this.Controls.Add(this.textBoxFriends);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.DirectFriends);
            this.Controls.Add(this.buttonFindAdjacent);
            this.Controls.Add(this.textBoxSpecificName);
            this.Controls.Add(this.labelSpecificName);
            this.Controls.Add(this.Names);
            this.Controls.Add(this.buttonAddEdge);
            this.Controls.Add(this.textBoxEdgeTo);
            this.Controls.Add(this.textBoxEdgeFrom);
            this.Controls.Add(this.AddEdge);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Label AddEdge;
        private System.Windows.Forms.TextBox textBoxEdgeFrom;
        private System.Windows.Forms.TextBox textBoxEdgeTo;
        private System.Windows.Forms.Button buttonAddEdge;
        private System.Windows.Forms.ListBox Names;
        private System.Windows.Forms.Label labelSpecificName;
        private System.Windows.Forms.TextBox textBoxSpecificName;
        private System.Windows.Forms.Button buttonFindAdjacent;
        private System.Windows.Forms.ListBox DirectFriends;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxFriends;
        private System.Windows.Forms.Button buttonFriends;
    }
}

