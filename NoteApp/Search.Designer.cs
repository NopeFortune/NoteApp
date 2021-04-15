
namespace NoteApp
{
    partial class SearchForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchForm));
            this.lbWhat = new System.Windows.Forms.Label();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.btnFindNext = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cbRegister = new System.Windows.Forms.CheckBox();
            this.rbDown = new System.Windows.Forms.RadioButton();
            this.rbUp = new System.Windows.Forms.RadioButton();
            this.lbDirection = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbWhat
            // 
            this.lbWhat.AutoSize = true;
            this.lbWhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbWhat.Location = new System.Drawing.Point(12, 19);
            this.lbWhat.Name = "lbWhat";
            this.lbWhat.Size = new System.Drawing.Size(32, 15);
            this.lbWhat.TabIndex = 0;
            this.lbWhat.Text = "Что:";
            // 
            // tbSearch
            // 
            this.tbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbSearch.Location = new System.Drawing.Point(78, 19);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(152, 21);
            this.tbSearch.TabIndex = 1;
            // 
            // btnFindNext
            // 
            this.btnFindNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnFindNext.Location = new System.Drawing.Point(322, 10);
            this.btnFindNext.Name = "btnFindNext";
            this.btnFindNext.Size = new System.Drawing.Size(104, 29);
            this.btnFindNext.TabIndex = 2;
            this.btnFindNext.Text = "Найти далее";
            this.btnFindNext.UseVisualStyleBackColor = true;
            this.btnFindNext.Click += new System.EventHandler(this.btnFindNext_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCancel.Location = new System.Drawing.Point(322, 55);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(104, 29);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cbRegister
            // 
            this.cbRegister.AutoSize = true;
            this.cbRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbRegister.Location = new System.Drawing.Point(12, 87);
            this.cbRegister.Name = "cbRegister";
            this.cbRegister.Size = new System.Drawing.Size(134, 19);
            this.cbRegister.TabIndex = 4;
            this.cbRegister.Text = "С учетом регистра";
            this.cbRegister.UseVisualStyleBackColor = true;
            // 
            // rbDown
            // 
            this.rbDown.AutoSize = true;
            this.rbDown.Checked = true;
            this.rbDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbDown.Location = new System.Drawing.Point(257, 87);
            this.rbDown.Name = "rbDown";
            this.rbDown.Size = new System.Drawing.Size(53, 19);
            this.rbDown.TabIndex = 5;
            this.rbDown.TabStop = true;
            this.rbDown.Text = "Вниз";
            this.rbDown.UseVisualStyleBackColor = true;
            // 
            // rbUp
            // 
            this.rbUp.AutoSize = true;
            this.rbUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbUp.Location = new System.Drawing.Point(186, 87);
            this.rbUp.Name = "rbUp";
            this.rbUp.Size = new System.Drawing.Size(60, 19);
            this.rbUp.TabIndex = 6;
            this.rbUp.Text = "Вверх";
            this.rbUp.UseVisualStyleBackColor = true;
            // 
            // lbDirection
            // 
            this.lbDirection.AutoSize = true;
            this.lbDirection.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbDirection.Location = new System.Drawing.Point(183, 55);
            this.lbDirection.Name = "lbDirection";
            this.lbDirection.Size = new System.Drawing.Size(89, 15);
            this.lbDirection.TabIndex = 7;
            this.lbDirection.Text = "Направление:";
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 135);
            this.Controls.Add(this.lbDirection);
            this.Controls.Add(this.rbUp);
            this.Controls.Add(this.rbDown);
            this.Controls.Add(this.cbRegister);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnFindNext);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.lbWhat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SearchForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Поиск";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbWhat;
        internal System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Button btnFindNext;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.CheckBox cbRegister;
        private System.Windows.Forms.RadioButton rbDown;
        private System.Windows.Forms.RadioButton rbUp;
        private System.Windows.Forms.Label lbDirection;
    }
}