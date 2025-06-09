namespace zd2_Rogov
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
            listBoxContacts = new ListBox();
            buttonSearch = new Button();
            buttonRemove = new Button();
            textSearch = new TextBox();
            textName = new TextBox();
            textPhone = new TextBox();
            buttonSave = new Button();
            buttonLoad = new Button();
            buttonAdd = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            buttonExit = new Button();
            buttonInsert = new Button();
            buttonDelete = new Button();
            numericUpDownInsert = new NumericUpDown();
            numericUpDownRemove = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numericUpDownInsert).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownRemove).BeginInit();
            SuspendLayout();
            // 
            // listBoxContacts
            // 
            listBoxContacts.Font = new Font("Segoe UI", 12F);
            listBoxContacts.FormattingEnabled = true;
            listBoxContacts.ItemHeight = 28;
            listBoxContacts.Location = new Point(392, 12);
            listBoxContacts.Name = "listBoxContacts";
            listBoxContacts.Size = new Size(396, 424);
            listBoxContacts.TabIndex = 0;
            // 
            // buttonSearch
            // 
            buttonSearch.Font = new Font("Segoe UI", 12F);
            buttonSearch.Location = new Point(201, 43);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(171, 34);
            buttonSearch.TabIndex = 3;
            buttonSearch.Text = "Поиск";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // buttonRemove
            // 
            buttonRemove.Font = new Font("Segoe UI", 12F);
            buttonRemove.Location = new Point(201, 243);
            buttonRemove.Name = "buttonRemove";
            buttonRemove.Size = new Size(171, 34);
            buttonRemove.TabIndex = 4;
            buttonRemove.Text = "Удал по индексу";
            buttonRemove.UseVisualStyleBackColor = true;
            buttonRemove.Click += buttonRemove_Click;
            // 
            // textSearch
            // 
            textSearch.Font = new Font("Segoe UI", 12F);
            textSearch.Location = new Point(17, 43);
            textSearch.Name = "textSearch";
            textSearch.Size = new Size(159, 34);
            textSearch.TabIndex = 5;
            // 
            // textName
            // 
            textName.Font = new Font("Segoe UI", 12F);
            textName.Location = new Point(17, 119);
            textName.Name = "textName";
            textName.Size = new Size(159, 34);
            textName.TabIndex = 6;
            // 
            // textPhone
            // 
            textPhone.Font = new Font("Segoe UI", 12F);
            textPhone.Location = new Point(17, 187);
            textPhone.Name = "textPhone";
            textPhone.Size = new Size(159, 34);
            textPhone.TabIndex = 7;
            // 
            // buttonSave
            // 
            buttonSave.Font = new Font("Segoe UI", 12F);
            buttonSave.Location = new Point(201, 323);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(171, 34);
            buttonSave.TabIndex = 8;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonLoad
            // 
            buttonLoad.Font = new Font("Segoe UI", 12F);
            buttonLoad.Location = new Point(201, 363);
            buttonLoad.Name = "buttonLoad";
            buttonLoad.Size = new Size(171, 34);
            buttonLoad.TabIndex = 9;
            buttonLoad.Text = "Загрузить всех";
            buttonLoad.UseVisualStyleBackColor = true;
            buttonLoad.Click += buttonLoad_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.Font = new Font("Segoe UI", 12F);
            buttonAdd.Location = new Point(201, 83);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(171, 34);
            buttonAdd.TabIndex = 10;
            buttonAdd.Text = "Доб. в конец";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(17, 12);
            label1.Name = "label1";
            label1.Size = new Size(163, 28);
            label1.TabIndex = 11;
            label1.Text = "Поиск по имени";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(17, 88);
            label2.Name = "label2";
            label2.Size = new Size(136, 28);
            label2.TabIndex = 12;
            label2.Text = "Имя контакта";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(17, 156);
            label3.Name = "label3";
            label3.Size = new Size(159, 28);
            label3.TabIndex = 13;
            label3.Text = "Номер контакта";
            // 
            // buttonExit
            // 
            buttonExit.Font = new Font("Segoe UI", 12F);
            buttonExit.Location = new Point(201, 403);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(171, 33);
            buttonExit.TabIndex = 14;
            buttonExit.Text = "Выход";
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Click += buttonExit_Click;
            // 
            // buttonInsert
            // 
            buttonInsert.Font = new Font("Segoe UI", 12F);
            buttonInsert.Location = new Point(201, 123);
            buttonInsert.Name = "buttonInsert";
            buttonInsert.Size = new Size(171, 34);
            buttonInsert.TabIndex = 15;
            buttonInsert.Text = "Доб. по индексу";
            buttonInsert.UseVisualStyleBackColor = true;
            buttonInsert.Click += buttonInsert_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Font = new Font("Segoe UI", 12F);
            buttonDelete.Location = new Point(201, 203);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(171, 34);
            buttonDelete.TabIndex = 16;
            buttonDelete.Text = "Удал. последнее";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // numericUpDownInsert
            // 
            numericUpDownInsert.Font = new Font("Segoe UI", 12F);
            numericUpDownInsert.Location = new Point(201, 163);
            numericUpDownInsert.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownInsert.Name = "numericUpDownInsert";
            numericUpDownInsert.Size = new Size(171, 34);
            numericUpDownInsert.TabIndex = 17;
            numericUpDownInsert.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // numericUpDownRemove
            // 
            numericUpDownRemove.Font = new Font("Segoe UI", 12F);
            numericUpDownRemove.Location = new Point(201, 283);
            numericUpDownRemove.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownRemove.Name = "numericUpDownRemove";
            numericUpDownRemove.Size = new Size(171, 34);
            numericUpDownRemove.TabIndex = 18;
            numericUpDownRemove.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(numericUpDownRemove);
            Controls.Add(numericUpDownInsert);
            Controls.Add(buttonDelete);
            Controls.Add(buttonInsert);
            Controls.Add(buttonExit);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonAdd);
            Controls.Add(buttonLoad);
            Controls.Add(buttonSave);
            Controls.Add(textPhone);
            Controls.Add(textName);
            Controls.Add(textSearch);
            Controls.Add(buttonRemove);
            Controls.Add(buttonSearch);
            Controls.Add(listBoxContacts);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDownInsert).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownRemove).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxContacts;
        private Button buttonSearch;
        private Button buttonRemove;
        private TextBox textSearch;
        private TextBox textName;
        private TextBox textPhone;
        private Button buttonSave;
        private Button buttonLoad;
        private Button buttonAdd;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button buttonExit;
        private Button buttonInsert;
        private Button buttonDelete;
        private NumericUpDown numericUpDownInsert;
        private NumericUpDown numericUpDownRemove;
    }
}
