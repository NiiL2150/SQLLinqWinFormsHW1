namespace SQLLinqWinFormsHW1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgData = new System.Windows.Forms.DataGridView();
            this.comboBoxTables = new System.Windows.Forms.ComboBox();
            this.btnShowTable = new System.Windows.Forms.Button();
            this.btnUpdTable = new System.Windows.Forms.Button();
            this.btnQuery = new System.Windows.Forms.Button();
            this.comboBoxQueries = new System.Windows.Forms.ComboBox();
            this.comboBoxList = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgData)).BeginInit();
            this.SuspendLayout();
            // 
            // dgData
            // 
            this.dgData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgData.Location = new System.Drawing.Point(12, 12);
            this.dgData.Name = "dgData";
            this.dgData.Size = new System.Drawing.Size(620, 426);
            this.dgData.TabIndex = 0;
            // 
            // comboBoxTables
            // 
            this.comboBoxTables.FormattingEnabled = true;
            this.comboBoxTables.Items.AddRange(new object[] {
            "Cities",
            "Countries",
            "Continents"});
            this.comboBoxTables.Location = new System.Drawing.Point(638, 70);
            this.comboBoxTables.Name = "comboBoxTables";
            this.comboBoxTables.Size = new System.Drawing.Size(150, 21);
            this.comboBoxTables.TabIndex = 3;
            // 
            // btnShowTable
            // 
            this.btnShowTable.Location = new System.Drawing.Point(638, 12);
            this.btnShowTable.Name = "btnShowTable";
            this.btnShowTable.Size = new System.Drawing.Size(150, 23);
            this.btnShowTable.TabIndex = 1;
            this.btnShowTable.Text = "Show table ...";
            this.btnShowTable.UseVisualStyleBackColor = true;
            this.btnShowTable.Click += new System.EventHandler(this.btnShowTable_Click);
            // 
            // btnUpdTable
            // 
            this.btnUpdTable.Location = new System.Drawing.Point(638, 41);
            this.btnUpdTable.Name = "btnUpdTable";
            this.btnUpdTable.Size = new System.Drawing.Size(150, 23);
            this.btnUpdTable.TabIndex = 2;
            this.btnUpdTable.Text = "Update table ...";
            this.btnUpdTable.UseVisualStyleBackColor = true;
            this.btnUpdTable.Click += new System.EventHandler(this.btnUpdTable_Click);
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(638, 180);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(150, 23);
            this.btnQuery.TabIndex = 4;
            this.btnQuery.Text = "Show query result";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // comboBoxQueries
            // 
            this.comboBoxQueries.FormattingEnabled = true;
            this.comboBoxQueries.Items.AddRange(new object[] {
            "Countries by continent",
            "Cities by counrty",
            "Capitals",
            "Top 5 countries by areas",
            "Top 5 countries by popularity",
            "Top 5 cities by popularity",
            "Top 3 continents by area",
            "Top 3 continents by popularity"});
            this.comboBoxQueries.Location = new System.Drawing.Point(638, 126);
            this.comboBoxQueries.Name = "comboBoxQueries";
            this.comboBoxQueries.Size = new System.Drawing.Size(150, 21);
            this.comboBoxQueries.TabIndex = 5;
            this.comboBoxQueries.SelectedIndexChanged += new System.EventHandler(this.comboBoxQueries_SelectedIndexChanged);
            // 
            // comboBoxList
            // 
            this.comboBoxList.Enabled = false;
            this.comboBoxList.FormattingEnabled = true;
            this.comboBoxList.Location = new System.Drawing.Point(638, 153);
            this.comboBoxList.Name = "comboBoxList";
            this.comboBoxList.Size = new System.Drawing.Size(150, 21);
            this.comboBoxList.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBoxList);
            this.Controls.Add(this.comboBoxQueries);
            this.Controls.Add(this.btnQuery);
            this.Controls.Add(this.btnUpdTable);
            this.Controls.Add(this.btnShowTable);
            this.Controls.Add(this.comboBoxTables);
            this.Controls.Add(this.dgData);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgData;
        private System.Windows.Forms.ComboBox comboBoxTables;
        private System.Windows.Forms.Button btnShowTable;
        private System.Windows.Forms.Button btnUpdTable;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.ComboBox comboBoxQueries;
        private System.Windows.Forms.ComboBox comboBoxList;
    }
}

