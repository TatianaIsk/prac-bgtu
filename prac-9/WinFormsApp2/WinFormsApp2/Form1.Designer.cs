namespace WinFormsApp2
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
            this.groupBoxMembers = new System.Windows.Forms.GroupBox();
            this.memberList = new System.Windows.Forms.CheckedListBox();
            this.peopleList = new System.Windows.Forms.ComboBox();
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.ButtonDelete = new System.Windows.Forms.Button();
            this.ButtonSort = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // groupBoxMembers
            // 
            this.groupBoxMembers.Location = new System.Drawing.Point(136, 0);
            this.groupBoxMembers.Name = "groupBoxMembers";
            this.groupBoxMembers.Size = new System.Drawing.Size(250, 125);
            this.groupBoxMembers.TabIndex = 0;
            this.groupBoxMembers.TabStop = false;
            this.groupBoxMembers.Text = "Список участников";
            // 
            // memberList
            // 
            this.memberList.FormattingEnabled = true;
            this.memberList.Location = new System.Drawing.Point(166, 131);
            this.memberList.Name = "memberList";
            this.memberList.Size = new System.Drawing.Size(143, 92);
            this.memberList.TabIndex = 0;
            // 
            // peopleList
            // 
            this.peopleList.FormattingEnabled = true;
            this.peopleList.Items.AddRange(new object[] {
            "Иванов Иван Иванович",
            "Петров Петр Петрович",
            "Алексеев Максим Вадимович"});
            this.peopleList.Location = new System.Drawing.Point(9, 173);
            this.peopleList.Name = "peopleList";
            this.peopleList.Size = new System.Drawing.Size(151, 28);
            this.peopleList.TabIndex = 1;
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.Location = new System.Drawing.Point(12, 12);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(94, 29);
            this.ButtonAdd.TabIndex = 2;
            this.ButtonAdd.Text = "Добавить";
            this.ButtonAdd.UseVisualStyleBackColor = true;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.Location = new System.Drawing.Point(12, 61);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new System.Drawing.Size(94, 29);
            this.ButtonDelete.TabIndex = 3;
            this.ButtonDelete.Text = "Удалить";
            this.ButtonDelete.UseVisualStyleBackColor = true;
            this.ButtonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // ButtonSort
            // 
            this.ButtonSort.Location = new System.Drawing.Point(12, 112);
            this.ButtonSort.Name = "ButtonSort";
            this.ButtonSort.Size = new System.Drawing.Size(94, 29);
            this.ButtonSort.TabIndex = 4;
            this.ButtonSort.Text = "Сортировать";
            this.ButtonSort.UseVisualStyleBackColor = true;
            this.ButtonSort.Click += new System.EventHandler(this.ButtonSort_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 259);
            this.Controls.Add(this.ButtonSort);
            this.Controls.Add(this.ButtonDelete);
            this.Controls.Add(this.ButtonAdd);
            this.Controls.Add(this.peopleList);
            this.Controls.Add(this.memberList);
            this.Controls.Add(this.groupBoxMembers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Работа со списками";
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBoxMembers;
        private CheckedListBox memberList;
        private ComboBox peopleList;
        private Button ButtonAdd;
        private Button ButtonDelete;
        private Button ButtonSort;
    }
}