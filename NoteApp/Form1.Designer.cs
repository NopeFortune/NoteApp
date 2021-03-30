
namespace NoteApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCreate = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSave = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.правкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCancel = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCut = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiInsert = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFind = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFindNext = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFindPrevious = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiReplace = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiGoOn = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDateAndTime = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFile,
            this.правкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiFile
            // 
            this.tsmiFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCreate,
            this.tsmiOpen,
            this.tsmiSave,
            this.tsmiSaveAs,
            this.выходToolStripMenuItem});
            this.tsmiFile.Name = "tsmiFile";
            this.tsmiFile.Size = new System.Drawing.Size(48, 20);
            this.tsmiFile.Text = "Файл";
            // 
            // tsmiCreate
            // 
            this.tsmiCreate.Name = "tsmiCreate";
            this.tsmiCreate.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.tsmiCreate.Size = new System.Drawing.Size(226, 22);
            this.tsmiCreate.Text = "Создать";
            // 
            // tsmiOpen
            // 
            this.tsmiOpen.Name = "tsmiOpen";
            this.tsmiOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.tsmiOpen.Size = new System.Drawing.Size(226, 22);
            this.tsmiOpen.Text = "Открыть";
            // 
            // tsmiSave
            // 
            this.tsmiSave.Name = "tsmiSave";
            this.tsmiSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.tsmiSave.Size = new System.Drawing.Size(226, 22);
            this.tsmiSave.Text = "Сохранить";
            // 
            // tsmiSaveAs
            // 
            this.tsmiSaveAs.Name = "tsmiSaveAs";
            this.tsmiSaveAs.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.tsmiSaveAs.Size = new System.Drawing.Size(226, 22);
            this.tsmiSaveAs.Text = "Сохранить как";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            // 
            // правкаToolStripMenuItem
            // 
            this.правкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCancel,
            this.tsmiCut,
            this.tsmiCopy,
            this.tsmiInsert,
            this.tsmiDelete,
            this.tsmiFind,
            this.tsmiFindNext,
            this.tsmiFindPrevious,
            this.tsmiReplace,
            this.tsmiGoOn,
            this.tsmiSelectAll,
            this.tsmiDateAndTime});
            this.правкаToolStripMenuItem.Name = "правкаToolStripMenuItem";
            this.правкаToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.правкаToolStripMenuItem.Text = "Правка";
            // 
            // tsmiCancel
            // 
            this.tsmiCancel.Name = "tsmiCancel";
            this.tsmiCancel.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.tsmiCancel.Size = new System.Drawing.Size(194, 22);
            this.tsmiCancel.Text = "Отменить";
            // 
            // tsmiCut
            // 
            this.tsmiCut.Name = "tsmiCut";
            this.tsmiCut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.tsmiCut.Size = new System.Drawing.Size(194, 22);
            this.tsmiCut.Text = "Вырезать";
            // 
            // tsmiCopy
            // 
            this.tsmiCopy.Name = "tsmiCopy";
            this.tsmiCopy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.tsmiCopy.Size = new System.Drawing.Size(194, 22);
            this.tsmiCopy.Text = "Копировать";
            // 
            // tsmiInsert
            // 
            this.tsmiInsert.Name = "tsmiInsert";
            this.tsmiInsert.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.tsmiInsert.Size = new System.Drawing.Size(194, 22);
            this.tsmiInsert.Text = "Вставить";
            // 
            // tsmiDelete
            // 
            this.tsmiDelete.Name = "tsmiDelete";
            this.tsmiDelete.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.tsmiDelete.Size = new System.Drawing.Size(194, 22);
            this.tsmiDelete.Text = "Удалить";
            // 
            // tsmiFind
            // 
            this.tsmiFind.Name = "tsmiFind";
            this.tsmiFind.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.tsmiFind.Size = new System.Drawing.Size(194, 22);
            this.tsmiFind.Text = "Найти";
            // 
            // tsmiFindNext
            // 
            this.tsmiFindNext.Name = "tsmiFindNext";
            this.tsmiFindNext.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.tsmiFindNext.Size = new System.Drawing.Size(194, 22);
            this.tsmiFindNext.Text = "Найти далее";
            // 
            // tsmiFindPrevious
            // 
            this.tsmiFindPrevious.Name = "tsmiFindPrevious";
            this.tsmiFindPrevious.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.F3)));
            this.tsmiFindPrevious.Size = new System.Drawing.Size(194, 22);
            this.tsmiFindPrevious.Text = "Найти ранее";
            // 
            // tsmiReplace
            // 
            this.tsmiReplace.Name = "tsmiReplace";
            this.tsmiReplace.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.tsmiReplace.Size = new System.Drawing.Size(194, 22);
            this.tsmiReplace.Text = "Заменить";
            // 
            // tsmiGoOn
            // 
            this.tsmiGoOn.Name = "tsmiGoOn";
            this.tsmiGoOn.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.tsmiGoOn.Size = new System.Drawing.Size(194, 22);
            this.tsmiGoOn.Text = "Перейти";
            // 
            // tsmiSelectAll
            // 
            this.tsmiSelectAll.Name = "tsmiSelectAll";
            this.tsmiSelectAll.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.tsmiSelectAll.Size = new System.Drawing.Size(194, 22);
            this.tsmiSelectAll.Text = "Выделить всё";
            // 
            // tsmiDateAndTime
            // 
            this.tsmiDateAndTime.Name = "tsmiDateAndTime";
            this.tsmiDateAndTime.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.tsmiDateAndTime.Size = new System.Drawing.Size(194, 22);
            this.tsmiDateAndTime.Text = "Время и дата";
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(0, 24);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(800, 426);
            this.textBox1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NoteApp";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiFile;
        private System.Windows.Forms.ToolStripMenuItem tsmiCreate;
        private System.Windows.Forms.ToolStripMenuItem tsmiOpen;
        private System.Windows.Forms.ToolStripMenuItem tsmiSave;
        private System.Windows.Forms.ToolStripMenuItem tsmiSaveAs;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem правкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiCancel;
        private System.Windows.Forms.ToolStripMenuItem tsmiCut;
        private System.Windows.Forms.ToolStripMenuItem tsmiCopy;
        private System.Windows.Forms.ToolStripMenuItem tsmiInsert;
        private System.Windows.Forms.ToolStripMenuItem tsmiDelete;
        private System.Windows.Forms.ToolStripMenuItem tsmiFind;
        private System.Windows.Forms.ToolStripMenuItem tsmiFindNext;
        private System.Windows.Forms.ToolStripMenuItem tsmiFindPrevious;
        private System.Windows.Forms.ToolStripMenuItem tsmiReplace;
        private System.Windows.Forms.ToolStripMenuItem tsmiGoOn;
        private System.Windows.Forms.ToolStripMenuItem tsmiSelectAll;
        private System.Windows.Forms.ToolStripMenuItem tsmiDateAndTime;
        private System.Windows.Forms.TextBox textBox1;
    }
}

