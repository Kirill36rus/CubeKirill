namespace CubeKirill
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
            this.gameFieldDataGridView = new System.Windows.Forms.DataGridView();
            this.gameStateLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gameFieldDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // gameFieldDataGridView
            // 
            this.gameFieldDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gameFieldDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gameFieldDataGridView.Location = new System.Drawing.Point(59, 12);
            this.gameFieldDataGridView.Name = "gameFieldDataGridView";
            this.gameFieldDataGridView.RowTemplate.Height = 60;
            this.gameFieldDataGridView.Size = new System.Drawing.Size(460, 390);
            this.gameFieldDataGridView.TabIndex = 0;
            this.gameFieldDataGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gameFieldDataGridView_CellMouseClick);
            this.gameFieldDataGridView.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.gameFieldDataGridView_CellPainting);
            this.gameFieldDataGridView.SelectionChanged += new System.EventHandler(this.gameFieldDataGridView_SelectionChanged);
            // 
            // gameStateLabel
            // 
            this.gameStateLabel.AutoSize = true;
            this.gameStateLabel.Location = new System.Drawing.Point(240, 467);
            this.gameStateLabel.Name = "gameStateLabel";
            this.gameStateLabel.Size = new System.Drawing.Size(125, 17);
            this.gameStateLabel.TabIndex = 1;
            this.gameStateLabel.Text = "Игра не началась";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 487);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(579, 53);
            this.button1.TabIndex = 2;
            this.button1.Text = "New Game";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 552);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gameStateLabel);
            this.Controls.Add(this.gameFieldDataGridView);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gameFieldDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gameFieldDataGridView;
        private System.Windows.Forms.Label gameStateLabel;
        private System.Windows.Forms.Button button1;
    }
}

