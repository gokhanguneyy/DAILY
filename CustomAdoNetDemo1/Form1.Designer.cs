namespace CustomAdoNetDemo1
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
            this.dgwDaily = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxNameAddfa = new System.Windows.Forms.Label();
            this.asdfa = new System.Windows.Forms.Label();
            this.tbxDateAdd = new System.Windows.Forms.TextBox();
            this.tbxNameAdd = new System.Windows.Forms.TextBox();
            this.tbxContextAdd = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.tbxContextUpdate = new System.Windows.Forms.TextBox();
            this.tbxNameUpdate = new System.Windows.Forms.TextBox();
            this.tbxDateUpdate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgwDaily)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwDaily
            // 
            this.dgwDaily.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            this.dgwDaily.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgwDaily.Location = new System.Drawing.Point(12, 47);
            this.dgwDaily.Name = "dgwDaily";
            this.dgwDaily.Size = new System.Drawing.Size(844, 241);
            this.dgwDaily.TabIndex = 0;
            this.dgwDaily.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwDaily_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 320);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "DATE";
            // 
            // tbxNameAddfa
            // 
            this.tbxNameAddfa.AutoSize = true;
            this.tbxNameAddfa.Location = new System.Drawing.Point(34, 353);
            this.tbxNameAddfa.Name = "tbxNameAddfa";
            this.tbxNameAddfa.Size = new System.Drawing.Size(38, 13);
            this.tbxNameAddfa.TabIndex = 2;
            this.tbxNameAddfa.Text = "NAME";
            // 
            // asdfa
            // 
            this.asdfa.AutoSize = true;
            this.asdfa.Location = new System.Drawing.Point(34, 392);
            this.asdfa.Name = "asdfa";
            this.asdfa.Size = new System.Drawing.Size(58, 13);
            this.asdfa.TabIndex = 3;
            this.asdfa.Text = "CONTEXT";
            // 
            // tbxDateAdd
            // 
            this.tbxDateAdd.Location = new System.Drawing.Point(155, 312);
            this.tbxDateAdd.Name = "tbxDateAdd";
            this.tbxDateAdd.Size = new System.Drawing.Size(133, 20);
            this.tbxDateAdd.TabIndex = 4;
            // 
            // tbxNameAdd
            // 
            this.tbxNameAdd.Location = new System.Drawing.Point(155, 346);
            this.tbxNameAdd.Name = "tbxNameAdd";
            this.tbxNameAdd.Size = new System.Drawing.Size(133, 20);
            this.tbxNameAdd.TabIndex = 5;
            // 
            // tbxContextAdd
            // 
            this.tbxContextAdd.Location = new System.Drawing.Point(155, 385);
            this.tbxContextAdd.Multiline = true;
            this.tbxContextAdd.Name = "tbxContextAdd";
            this.tbxContextAdd.Size = new System.Drawing.Size(271, 218);
            this.tbxContextAdd.TabIndex = 6;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(155, 634);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(271, 79);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(585, 634);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(271, 79);
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // tbxContextUpdate
            // 
            this.tbxContextUpdate.Location = new System.Drawing.Point(585, 385);
            this.tbxContextUpdate.Multiline = true;
            this.tbxContextUpdate.Name = "tbxContextUpdate";
            this.tbxContextUpdate.Size = new System.Drawing.Size(271, 218);
            this.tbxContextUpdate.TabIndex = 13;
            // 
            // tbxNameUpdate
            // 
            this.tbxNameUpdate.Location = new System.Drawing.Point(585, 346);
            this.tbxNameUpdate.Name = "tbxNameUpdate";
            this.tbxNameUpdate.Size = new System.Drawing.Size(133, 20);
            this.tbxNameUpdate.TabIndex = 12;
            // 
            // tbxDateUpdate
            // 
            this.tbxDateUpdate.Location = new System.Drawing.Point(585, 313);
            this.tbxDateUpdate.Name = "tbxDateUpdate";
            this.tbxDateUpdate.Size = new System.Drawing.Size(133, 20);
            this.tbxDateUpdate.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(464, 392);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "CONTEXT";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(464, 353);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "NAME";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(464, 320);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "DATE";
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(12, 5);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(178, 36);
            this.btnRemove.TabIndex = 15;
            this.btnRemove.Text = "REMOVE";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // tbxSearch
            // 
            this.tbxSearch.Location = new System.Drawing.Point(496, 20);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(245, 20);
            this.tbxSearch.TabIndex = 16;
            this.tbxSearch.TextChanged += new System.EventHandler(this.tbxSearch_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 743);
            this.Controls.Add(this.tbxSearch);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.tbxContextUpdate);
            this.Controls.Add(this.tbxNameUpdate);
            this.Controls.Add(this.tbxDateUpdate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbxContextAdd);
            this.Controls.Add(this.tbxNameAdd);
            this.Controls.Add(this.tbxDateAdd);
            this.Controls.Add(this.asdfa);
            this.Controls.Add(this.tbxNameAddfa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgwDaily);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwDaily)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwDaily;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label tbxNameAddfa;
        private System.Windows.Forms.Label asdfa;
        private System.Windows.Forms.TextBox tbxDateAdd;
        private System.Windows.Forms.TextBox tbxNameAdd;
        private System.Windows.Forms.TextBox tbxContextAdd;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox tbxContextUpdate;
        private System.Windows.Forms.TextBox tbxNameUpdate;
        private System.Windows.Forms.TextBox tbxDateUpdate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.TextBox tbxSearch;
    }
}

