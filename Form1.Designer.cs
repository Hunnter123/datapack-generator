namespace datapack_generator
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
            namelabel = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            button1 = new Button();
            enchantments = new CheckBox();
            dementions = new CheckBox();
            recipes = new CheckBox();
            SuspendLayout();
            // 
            // namelabel
            // 
            namelabel.AutoSize = true;
            namelabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            namelabel.Location = new Point(335, 9);
            namelabel.Name = "namelabel";
            namelabel.Size = new Size(61, 25);
            namelabel.TabIndex = 0;
            namelabel.Text = "name";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(267, 37);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(207, 23);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(60, 192);
            label1.Name = "label1";
            label1.Size = new Size(158, 25);
            label1.TabIndex = 2;
            label1.Text = "load.mcfunction";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(470, 192);
            label2.Name = "label2";
            label2.Size = new Size(152, 25);
            label2.TabIndex = 3;
            label2.Text = "tick.mcfunction";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(18, 220);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(253, 292);
            textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(436, 220);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(253, 292);
            textBox3.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(278, 530);
            button1.Name = "button1";
            button1.Size = new Size(153, 40);
            button1.TabIndex = 6;
            button1.Text = "create";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // enchantments
            // 
            enchantments.AutoSize = true;
            enchantments.Location = new Point(587, 41);
            enchantments.Name = "enchantments";
            enchantments.Size = new Size(102, 19);
            enchantments.TabIndex = 7;
            enchantments.Text = "enchantments";
            enchantments.UseVisualStyleBackColor = true;
            // 
            // dementions
            // 
            dementions.AutoSize = true;
            dementions.Location = new Point(587, 66);
            dementions.Name = "dementions";
            dementions.Size = new Size(87, 19);
            dementions.TabIndex = 8;
            dementions.Text = "dimensions";
            dementions.UseVisualStyleBackColor = true;
            // 
            // recipes
            // 
            recipes.AutoSize = true;
            recipes.Location = new Point(587, 91);
            recipes.Name = "recipes";
            recipes.Size = new Size(63, 19);
            recipes.TabIndex = 9;
            recipes.Text = "recipes";
            recipes.UseMnemonic = false;
            recipes.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(757, 622);
            Controls.Add(recipes);
            Controls.Add(dementions);
            Controls.Add(enchantments);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(namelabel);
            Name = "Form1";
            Text = "datapack generator";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label namelabel;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button button1;
        private CheckBox enchantments;
        private CheckBox dementions;
        private CheckBox recipes;
    }
}