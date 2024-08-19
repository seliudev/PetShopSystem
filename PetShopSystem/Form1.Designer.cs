namespace PetShopSystem
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
            lbxBreeds = new ListBox();
            label1 = new Label();
            tbxEnterBreed = new TextBox();
            lblNewBreed = new Label();
            btnAddBreed = new Button();
            btnRemoveBreed = new Button();
            SuspendLayout();
            // 
            // lbxBreeds
            // 
            lbxBreeds.Font = new Font("Segoe UI", 12F);
            lbxBreeds.FormattingEnabled = true;
            lbxBreeds.ItemHeight = 32;
            lbxBreeds.Location = new Point(38, 82);
            lbxBreeds.Name = "lbxBreeds";
            lbxBreeds.Size = new Size(273, 324);
            lbxBreeds.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(38, 31);
            label1.Name = "label1";
            label1.Size = new Size(173, 32);
            label1.TabIndex = 1;
            label1.Text = "Current Breeds";
            // 
            // tbxEnterBreed
            // 
            tbxEnterBreed.Font = new Font("Segoe UI", 12F);
            tbxEnterBreed.Location = new Point(535, 82);
            tbxEnterBreed.Name = "tbxEnterBreed";
            tbxEnterBreed.Size = new Size(242, 39);
            tbxEnterBreed.TabIndex = 2;
            // 
            // lblNewBreed
            // 
            lblNewBreed.AutoSize = true;
            lblNewBreed.Font = new Font("Segoe UI", 12F);
            lblNewBreed.Location = new Point(340, 84);
            lblNewBreed.Name = "lblNewBreed";
            lblNewBreed.Size = new Size(189, 32);
            lblNewBreed.TabIndex = 3;
            lblNewBreed.Text = "Enter new breed";
            // 
            // btnAddBreed
            // 
            btnAddBreed.BackColor = Color.MediumSeaGreen;
            btnAddBreed.Font = new Font("Segoe UI", 12F);
            btnAddBreed.ForeColor = Color.White;
            btnAddBreed.Location = new Point(792, 82);
            btnAddBreed.Name = "btnAddBreed";
            btnAddBreed.Size = new Size(152, 39);
            btnAddBreed.TabIndex = 4;
            btnAddBreed.Text = "Add Breed";
            btnAddBreed.UseVisualStyleBackColor = false;
            btnAddBreed.Click += btnAddBreed_Click;
            // 
            // btnRemoveBreed
            // 
            btnRemoveBreed.BackColor = Color.Red;
            btnRemoveBreed.Font = new Font("Segoe UI", 12F);
            btnRemoveBreed.ForeColor = Color.White;
            btnRemoveBreed.Location = new Point(38, 423);
            btnRemoveBreed.Name = "btnRemoveBreed";
            btnRemoveBreed.Size = new Size(273, 43);
            btnRemoveBreed.TabIndex = 5;
            btnRemoveBreed.Text = "Delete Breed";
            btnRemoveBreed.UseVisualStyleBackColor = false;
            btnRemoveBreed.Click += btnRemoveBreed_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(976, 591);
            Controls.Add(btnRemoveBreed);
            Controls.Add(btnAddBreed);
            Controls.Add(lblNewBreed);
            Controls.Add(tbxEnterBreed);
            Controls.Add(label1);
            Controls.Add(lbxBreeds);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lbxBreeds;
        private Label label1;
        private TextBox tbxEnterBreed;
        private Label lblNewBreed;
        private Button btnAddBreed;
        private Button btnRemoveBreed;
    }
}
