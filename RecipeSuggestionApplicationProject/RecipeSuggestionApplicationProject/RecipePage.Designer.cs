namespace RecipeSuggestionApplicationProject
{
    partial class RecipePage
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
            this.pbRecipeImage = new System.Windows.Forms.PictureBox();
            this.lblRecipeName = new System.Windows.Forms.Label();
            this.txtIngredients = new System.Windows.Forms.TextBox();
            this.txtSteps = new System.Windows.Forms.TextBox();
            this.btnAddToPlanner = new System.Windows.Forms.Button();
            this.comboDay = new System.Windows.Forms.ComboBox();
            this.comboTimeSlot = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.backButton2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbRecipeImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pbRecipeImage
            // 
            this.pbRecipeImage.BackColor = System.Drawing.Color.White;
            this.pbRecipeImage.Location = new System.Drawing.Point(50, 50);
            this.pbRecipeImage.Name = "pbRecipeImage";
            this.pbRecipeImage.Size = new System.Drawing.Size(300, 200);
            this.pbRecipeImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbRecipeImage.TabIndex = 0;
            this.pbRecipeImage.TabStop = false;
            // 
            // lblRecipeName
            // 
            this.lblRecipeName.AutoSize = true;
            this.lblRecipeName.Font = new System.Drawing.Font("Lucida Handwriting", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecipeName.Location = new System.Drawing.Point(451, 50);
            this.lblRecipeName.Name = "lblRecipeName";
            this.lblRecipeName.Size = new System.Drawing.Size(105, 31);
            this.lblRecipeName.TabIndex = 1;
            this.lblRecipeName.Text = "label1";
            this.lblRecipeName.Click += new System.EventHandler(this.lblRecipeName_Click);
            // 
            // txtIngredients
            // 
            this.txtIngredients.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIngredients.Location = new System.Drawing.Point(457, 84);
            this.txtIngredients.Multiline = true;
            this.txtIngredients.Name = "txtIngredients";
            this.txtIngredients.ReadOnly = true;
            this.txtIngredients.Size = new System.Drawing.Size(300, 166);
            this.txtIngredients.TabIndex = 2;
            // 
            // txtSteps
            // 
            this.txtSteps.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSteps.Location = new System.Drawing.Point(50, 282);
            this.txtSteps.Multiline = true;
            this.txtSteps.Name = "txtSteps";
            this.txtSteps.ReadOnly = true;
            this.txtSteps.Size = new System.Drawing.Size(707, 227);
            this.txtSteps.TabIndex = 3;
            // 
            // btnAddToPlanner
            // 
            this.btnAddToPlanner.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddToPlanner.Location = new System.Drawing.Point(533, 580);
            this.btnAddToPlanner.Name = "btnAddToPlanner";
            this.btnAddToPlanner.Size = new System.Drawing.Size(200, 40);
            this.btnAddToPlanner.TabIndex = 4;
            this.btnAddToPlanner.Text = "Add to Meal Planner";
            this.btnAddToPlanner.UseVisualStyleBackColor = true;
            this.btnAddToPlanner.Click += new System.EventHandler(this.btnAddToPlanner_Click);
            // 
            // comboDay
            // 
            this.comboDay.AllowDrop = true;
            this.comboDay.Font = new System.Drawing.Font("Microsoft Uighur", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboDay.FormattingEnabled = true;
            this.comboDay.Location = new System.Drawing.Point(509, 543);
            this.comboDay.Name = "comboDay";
            this.comboDay.Size = new System.Drawing.Size(121, 31);
            this.comboDay.TabIndex = 5;
            this.comboDay.Text = "Set Day of the Week";
            // 
            // comboTimeSlot
            // 
            this.comboTimeSlot.AllowDrop = true;
            this.comboTimeSlot.Font = new System.Drawing.Font("Microsoft Uighur", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboTimeSlot.FormattingEnabled = true;
            this.comboTimeSlot.Location = new System.Drawing.Point(636, 543);
            this.comboTimeSlot.Name = "comboTimeSlot";
            this.comboTimeSlot.Size = new System.Drawing.Size(121, 31);
            this.comboTimeSlot.TabIndex = 6;
            this.comboTimeSlot.Text = "Set the Time";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pictureBox1.Image = global::RecipeSuggestionApplicationProject.Properties.Resources.fridgeyylogo;
            this.pictureBox1.Location = new System.Drawing.Point(36, 571);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 49);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Handwriting", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 623);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Fridgeyy";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 643);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 9);
            this.label2.TabIndex = 9;
            this.label2.Text = "©2024 All rights reserved";
            // 
            // backButton2
            // 
            this.backButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.backButton2.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton2.Location = new System.Drawing.Point(146, 582);
            this.backButton2.Name = "backButton2";
            this.backButton2.Size = new System.Drawing.Size(110, 32);
            this.backButton2.TabIndex = 10;
            this.backButton2.Text = "Back";
            this.backButton2.UseVisualStyleBackColor = false;
            this.backButton2.Click += new System.EventHandler(this.backButton2_Click);
            // 
            // RecipePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(884, 661);
            this.Controls.Add(this.backButton2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.comboTimeSlot);
            this.Controls.Add(this.comboDay);
            this.Controls.Add(this.btnAddToPlanner);
            this.Controls.Add(this.txtSteps);
            this.Controls.Add(this.txtIngredients);
            this.Controls.Add(this.lblRecipeName);
            this.Controls.Add(this.pbRecipeImage);
            this.Name = "RecipePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.RecipePage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbRecipeImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbRecipeImage;
        private System.Windows.Forms.Label lblRecipeName;
        private System.Windows.Forms.TextBox txtIngredients;
        private System.Windows.Forms.TextBox txtSteps;
        private System.Windows.Forms.Button btnAddToPlanner;
        private System.Windows.Forms.ComboBox comboDay;
        private System.Windows.Forms.ComboBox comboTimeSlot;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button backButton2;
    }
}