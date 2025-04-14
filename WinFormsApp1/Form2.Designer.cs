namespace WinFormsApp1
{
    partial class Form2
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
            button_Search = new Button();
            ProductID_Label = new Label();
            Input_ID = new TextBox();
            button_Add = new Button();
            label1 = new Label();
            label2 = new Label();
            InputId = new TextBox();
            InputName = new TextBox();
            button_delete = new Button();
            label3 = new Label();
            Input_Delete = new TextBox();
            InputId_Edit = new TextBox();
            label4 = new Label();
            label5 = new Label();
            Input_Value = new TextBox();
            label6 = new Label();
            button_Update = new Button();
            comboBox_edit = new ComboBox();
            SuspendLayout();
            // 
            // button_Search
            // 
            button_Search.Location = new Point(126, 105);
            button_Search.Name = "button_Search";
            button_Search.Size = new Size(136, 57);
            button_Search.TabIndex = 4;
            button_Search.Text = "Search";
            button_Search.UseVisualStyleBackColor = true;
            button_Search.Click += button_Search_Click;
            // 
            // ProductID_Label
            // 
            ProductID_Label.AutoSize = true;
            ProductID_Label.Location = new Point(12, 49);
            ProductID_Label.Name = "ProductID_Label";
            ProductID_Label.Size = new Size(75, 20);
            ProductID_Label.TabIndex = 0;
            ProductID_Label.Text = "ProductID";
            // 
            // Input_ID
            // 
            Input_ID.Location = new Point(96, 49);
            Input_ID.Name = "Input_ID";
            Input_ID.Size = new Size(186, 27);
            Input_ID.TabIndex = 1;
            // 
            // button_Add
            // 
            button_Add.Location = new Point(129, 358);
            button_Add.Name = "button_Add";
            button_Add.Size = new Size(133, 57);
            button_Add.TabIndex = 5;
            button_Add.Text = "ADD";
            button_Add.UseVisualStyleBackColor = true;
            button_Add.Click += button_Add_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 247);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 6;
            label1.Text = "ProductId";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 301);
            label2.Name = "label2";
            label2.Size = new Size(100, 20);
            label2.TabIndex = 7;
            label2.Text = "ProductName";
            // 
            // InputId
            // 
            InputId.Location = new Point(93, 240);
            InputId.Name = "InputId";
            InputId.Size = new Size(156, 27);
            InputId.TabIndex = 8;
            // 
            // InputName
            // 
            InputName.Location = new Point(126, 301);
            InputName.Name = "InputName";
            InputName.Size = new Size(156, 27);
            InputName.TabIndex = 9;
            // 
            // button_delete
            // 
            button_delete.Location = new Point(513, 105);
            button_delete.Name = "button_delete";
            button_delete.Size = new Size(136, 57);
            button_delete.TabIndex = 10;
            button_delete.Text = "Delete";
            button_delete.UseVisualStyleBackColor = true;
            button_delete.Click += button_delete_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(377, 52);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 11;
            label3.Text = "ProductID";
            // 
            // Input_Delete
            // 
            Input_Delete.Location = new Point(490, 52);
            Input_Delete.Name = "Input_Delete";
            Input_Delete.Size = new Size(186, 27);
            Input_Delete.TabIndex = 12;
            // 
            // InputId_Edit
            // 
            InputId_Edit.Location = new Point(490, 230);
            InputId_Edit.Name = "InputId_Edit";
            InputId_Edit.Size = new Size(186, 27);
            InputId_Edit.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(377, 230);
            label4.Name = "label4";
            label4.Size = new Size(75, 20);
            label4.TabIndex = 13;
            label4.Text = "ProductID";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(377, 282);
            label5.Name = "label5";
            label5.Size = new Size(105, 20);
            label5.TabIndex = 15;
            label5.Text = "Updated_Field";
            // 
            // Input_Value
            // 
            Input_Value.Location = new Point(492, 324);
            Input_Value.Name = "Input_Value";
            Input_Value.Size = new Size(186, 27);
            Input_Value.TabIndex = 18;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(377, 324);
            label6.Name = "label6";
            label6.Size = new Size(109, 20);
            label6.TabIndex = 17;
            label6.Text = "Updated_Value";
            // 
            // button_Update
            // 
            button_Update.Location = new Point(529, 372);
            button_Update.Name = "button_Update";
            button_Update.Size = new Size(120, 57);
            button_Update.TabIndex = 19;
            button_Update.Text = "Update";
            button_Update.UseVisualStyleBackColor = true;
            button_Update.Click += button_Update_Click;
            // 
            // comboBox_edit
            // 
            comboBox_edit.FormattingEnabled = true;
            comboBox_edit.Location = new Point(492, 279);
            comboBox_edit.Name = "comboBox_edit";
            comboBox_edit.Size = new Size(186, 28);
            comboBox_edit.TabIndex = 20;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBox_edit);
            Controls.Add(button_Update);
            Controls.Add(Input_Value);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(InputId_Edit);
            Controls.Add(label4);
            Controls.Add(Input_Delete);
            Controls.Add(label3);
            Controls.Add(button_delete);
            Controls.Add(InputName);
            Controls.Add(InputId);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button_Add);
            Controls.Add(button_Search);
            Controls.Add(Input_ID);
            Controls.Add(ProductID_Label);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button_Search;
        private Label ProductID_Label;
        private TextBox Input_ID;
        private Button button_Add;
        private Label label1;
        private Label label2;
        private TextBox InputId;
        private TextBox InputName;
        private Button button_delete;
        private Label label3;
        private TextBox Input_Delete;
        private TextBox textBox1;
        private Label label4;
        private Label label5;
        protected internal TextBox InputId_Edit;
        private TextBox Input_Value;
        private Label label6;
        private Button button_Update;
        private ComboBox comboBox_edit;
    }
}