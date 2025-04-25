namespace RecipeSuggestionApplicationProject
{
    partial class HomePage
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
            this.grpIngredients = new System.Windows.Forms.GroupBox();
            this.chkCheese = new System.Windows.Forms.CheckBox();
            this.chkBread = new System.Windows.Forms.CheckBox();
            this.chkHotdog = new System.Windows.Forms.CheckBox();
            this.chkEgg = new System.Windows.Forms.CheckBox();
            this.grpCountries = new System.Windows.Forms.GroupBox();
            this.chkPoland = new System.Windows.Forms.CheckBox();
            this.chkMexico = new System.Windows.Forms.CheckBox();
            this.chkPhilippines = new System.Windows.Forms.CheckBox();
            this.chkItaly = new System.Windows.Forms.CheckBox();
            this.chkAmerica = new System.Windows.Forms.CheckBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.grpMealPlanner = new System.Windows.Forms.GroupBox();
            this.listMealPlanner = new System.Windows.Forms.ListView();
            this.Day = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TimeSlot = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RecipeInPlanner = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnClearMealPlanner = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.chkFlour = new System.Windows.Forms.CheckBox();
            this.chkTortilla = new System.Windows.Forms.CheckBox();
            this.chkHam = new System.Windows.Forms.CheckBox();
            this.chkButter = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grpIngredients.SuspendLayout();
            this.grpCountries.SuspendLayout();
            this.grpMealPlanner.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // grpIngredients
            // 
            this.grpIngredients.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.grpIngredients.Controls.Add(this.chkButter);
            this.grpIngredients.Controls.Add(this.chkHam);
            this.grpIngredients.Controls.Add(this.chkTortilla);
            this.grpIngredients.Controls.Add(this.chkFlour);
            this.grpIngredients.Controls.Add(this.chkCheese);
            this.grpIngredients.Controls.Add(this.chkBread);
            this.grpIngredients.Controls.Add(this.chkHotdog);
            this.grpIngredients.Controls.Add(this.chkEgg);
            this.grpIngredients.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpIngredients.Location = new System.Drawing.Point(64, 65);
            this.grpIngredients.Name = "grpIngredients";
            this.grpIngredients.Size = new System.Drawing.Size(302, 150);
            this.grpIngredients.TabIndex = 0;
            this.grpIngredients.TabStop = false;
            this.grpIngredients.Text = "Ingredient Filters";
            this.grpIngredients.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // chkCheese
            // 
            this.chkCheese.AutoSize = true;
            this.chkCheese.Location = new System.Drawing.Point(10, 113);
            this.chkCheese.Name = "chkCheese";
            this.chkCheese.Size = new System.Drawing.Size(69, 22);
            this.chkCheese.TabIndex = 3;
            this.chkCheese.Text = "Cheese";
            this.chkCheese.UseVisualStyleBackColor = true;
            // 
            // chkBread
            // 
            this.chkBread.AutoSize = true;
            this.chkBread.Location = new System.Drawing.Point(10, 84);
            this.chkBread.Name = "chkBread";
            this.chkBread.Size = new System.Drawing.Size(65, 22);
            this.chkBread.TabIndex = 2;
            this.chkBread.Text = "Bread";
            this.chkBread.UseVisualStyleBackColor = true;
            // 
            // chkHotdog
            // 
            this.chkHotdog.AutoSize = true;
            this.chkHotdog.Location = new System.Drawing.Point(10, 55);
            this.chkHotdog.Name = "chkHotdog";
            this.chkHotdog.Size = new System.Drawing.Size(74, 22);
            this.chkHotdog.TabIndex = 1;
            this.chkHotdog.Text = "Hotdog";
            this.chkHotdog.UseVisualStyleBackColor = true;
            // 
            // chkEgg
            // 
            this.chkEgg.AutoSize = true;
            this.chkEgg.Location = new System.Drawing.Point(10, 25);
            this.chkEgg.Name = "chkEgg";
            this.chkEgg.Size = new System.Drawing.Size(52, 22);
            this.chkEgg.TabIndex = 0;
            this.chkEgg.Text = "Egg";
            this.chkEgg.UseVisualStyleBackColor = true;
            this.chkEgg.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // grpCountries
            // 
            this.grpCountries.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.grpCountries.Controls.Add(this.chkPoland);
            this.grpCountries.Controls.Add(this.chkMexico);
            this.grpCountries.Controls.Add(this.chkPhilippines);
            this.grpCountries.Controls.Add(this.chkItaly);
            this.grpCountries.Controls.Add(this.chkAmerica);
            this.grpCountries.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCountries.Location = new System.Drawing.Point(372, 65);
            this.grpCountries.Name = "grpCountries";
            this.grpCountries.Size = new System.Drawing.Size(295, 150);
            this.grpCountries.TabIndex = 1;
            this.grpCountries.TabStop = false;
            this.grpCountries.Text = "Nationality Filter";
            this.grpCountries.Enter += new System.EventHandler(this.groupBox1_Enter_1);
            // 
            // chkPoland
            // 
            this.chkPoland.AutoSize = true;
            this.chkPoland.Location = new System.Drawing.Point(106, 29);
            this.chkPoland.Name = "chkPoland";
            this.chkPoland.Size = new System.Drawing.Size(69, 22);
            this.chkPoland.TabIndex = 4;
            this.chkPoland.Text = "Polish";
            this.chkPoland.UseVisualStyleBackColor = true;
            // 
            // chkMexico
            // 
            this.chkMexico.AutoSize = true;
            this.chkMexico.Location = new System.Drawing.Point(7, 112);
            this.chkMexico.Name = "chkMexico";
            this.chkMexico.Size = new System.Drawing.Size(82, 22);
            this.chkMexico.TabIndex = 3;
            this.chkMexico.Text = "Mexican";
            this.chkMexico.UseVisualStyleBackColor = true;
            // 
            // chkPhilippines
            // 
            this.chkPhilippines.AutoSize = true;
            this.chkPhilippines.Location = new System.Drawing.Point(7, 83);
            this.chkPhilippines.Name = "chkPhilippines";
            this.chkPhilippines.Size = new System.Drawing.Size(81, 22);
            this.chkPhilippines.TabIndex = 2;
            this.chkPhilippines.Text = "Filipino";
            this.chkPhilippines.UseVisualStyleBackColor = true;
            // 
            // chkItaly
            // 
            this.chkItaly.AutoSize = true;
            this.chkItaly.Location = new System.Drawing.Point(7, 55);
            this.chkItaly.Name = "chkItaly";
            this.chkItaly.Size = new System.Drawing.Size(72, 22);
            this.chkItaly.TabIndex = 1;
            this.chkItaly.Text = "Italian";
            this.chkItaly.UseVisualStyleBackColor = true;
            // 
            // chkAmerica
            // 
            this.chkAmerica.AutoSize = true;
            this.chkAmerica.Location = new System.Drawing.Point(7, 29);
            this.chkAmerica.Name = "chkAmerica";
            this.chkAmerica.Size = new System.Drawing.Size(89, 22);
            this.chkAmerica.TabIndex = 0;
            this.chkAmerica.Text = "American";
            this.chkAmerica.UseVisualStyleBackColor = true;
            this.chkAmerica.CheckedChanged += new System.EventHandler(this.chkAmerica_CheckedChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(690, 120);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 30);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // grpMealPlanner
            // 
            this.grpMealPlanner.Controls.Add(this.listMealPlanner);
            this.grpMealPlanner.Location = new System.Drawing.Point(64, 255);
            this.grpMealPlanner.Name = "grpMealPlanner";
            this.grpMealPlanner.Size = new System.Drawing.Size(766, 316);
            this.grpMealPlanner.TabIndex = 3;
            this.grpMealPlanner.TabStop = false;
            this.grpMealPlanner.Enter += new System.EventHandler(this.groupBox1_Enter_2);
            // 
            // listMealPlanner
            // 
            this.listMealPlanner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.listMealPlanner.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listMealPlanner.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Day,
            this.TimeSlot,
            this.RecipeInPlanner});
            this.listMealPlanner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listMealPlanner.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listMealPlanner.HideSelection = false;
            this.listMealPlanner.Location = new System.Drawing.Point(3, 16);
            this.listMealPlanner.Name = "listMealPlanner";
            this.listMealPlanner.Size = new System.Drawing.Size(760, 297);
            this.listMealPlanner.TabIndex = 0;
            this.listMealPlanner.UseCompatibleStateImageBehavior = false;
            this.listMealPlanner.View = System.Windows.Forms.View.Details;
            this.listMealPlanner.SelectedIndexChanged += new System.EventHandler(this.listMealPlanner_SelectedIndexChanged);
            // 
            // Day
            // 
            this.Day.Text = "Day";
            this.Day.Width = 200;
            // 
            // TimeSlot
            // 
            this.TimeSlot.Text = "Time Slot";
            this.TimeSlot.Width = 200;
            // 
            // RecipeInPlanner
            // 
            this.RecipeInPlanner.Text = "Recipe";
            this.RecipeInPlanner.Width = 351;
            // 
            // btnClearMealPlanner
            // 
            this.btnClearMealPlanner.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearMealPlanner.Location = new System.Drawing.Point(363, 594);
            this.btnClearMealPlanner.Name = "btnClearMealPlanner";
            this.btnClearMealPlanner.Size = new System.Drawing.Size(118, 32);
            this.btnClearMealPlanner.TabIndex = 1;
            this.btnClearMealPlanner.Text = "Clear Planner";
            this.btnClearMealPlanner.UseVisualStyleBackColor = true;
            this.btnClearMealPlanner.Click += new System.EventHandler(this.btnClearMealPlanner_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Typewriter", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(343, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Meal Planner";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // chkFlour
            // 
            this.chkFlour.AutoSize = true;
            this.chkFlour.Location = new System.Drawing.Point(122, 25);
            this.chkFlour.Name = "chkFlour";
            this.chkFlour.Size = new System.Drawing.Size(63, 22);
            this.chkFlour.TabIndex = 4;
            this.chkFlour.Text = "Flour";
            this.chkFlour.UseVisualStyleBackColor = true;
            // 
            // chkTortilla
            // 
            this.chkTortilla.AutoSize = true;
            this.chkTortilla.Location = new System.Drawing.Point(122, 55);
            this.chkTortilla.Name = "chkTortilla";
            this.chkTortilla.Size = new System.Drawing.Size(77, 22);
            this.chkTortilla.TabIndex = 5;
            this.chkTortilla.Text = "Tortilla";
            this.chkTortilla.UseVisualStyleBackColor = true;
            // 
            // chkHam
            // 
            this.chkHam.AutoSize = true;
            this.chkHam.Location = new System.Drawing.Point(122, 83);
            this.chkHam.Name = "chkHam";
            this.chkHam.Size = new System.Drawing.Size(59, 22);
            this.chkHam.TabIndex = 6;
            this.chkHam.Text = "Ham";
            this.chkHam.UseVisualStyleBackColor = true;
            // 
            // chkButter
            // 
            this.chkButter.AutoSize = true;
            this.chkButter.Location = new System.Drawing.Point(122, 112);
            this.chkButter.Name = "chkButter";
            this.chkButter.Size = new System.Drawing.Size(68, 22);
            this.chkButter.TabIndex = 7;
            this.chkButter.Text = "Butter";
            this.chkButter.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 649);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 9);
            this.label2.TabIndex = 12;
            this.label2.Text = "©2024 All rights reserved";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Handwriting", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(47, 629);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Fridgeyy";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pictureBox1.Image = global::RecipeSuggestionApplicationProject.Properties.Resources.fridgeyylogo;
            this.pictureBox1.Location = new System.Drawing.Point(36, 577);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 49);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(255)))), ((int)(((byte)(202)))));
            this.ClientSize = new System.Drawing.Size(884, 661);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClearMealPlanner);
            this.Controls.Add(this.grpMealPlanner);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.grpCountries);
            this.Controls.Add(this.grpIngredients);
            this.Name = "HomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.grpIngredients.ResumeLayout(false);
            this.grpIngredients.PerformLayout();
            this.grpCountries.ResumeLayout(false);
            this.grpCountries.PerformLayout();
            this.grpMealPlanner.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpIngredients;
        private System.Windows.Forms.CheckBox chkEgg;
        private System.Windows.Forms.GroupBox grpCountries;
        private System.Windows.Forms.CheckBox chkCheese;
        private System.Windows.Forms.CheckBox chkBread;
        private System.Windows.Forms.CheckBox chkHotdog;
        private System.Windows.Forms.CheckBox chkAmerica;
        private System.Windows.Forms.CheckBox chkPoland;
        private System.Windows.Forms.CheckBox chkMexico;
        private System.Windows.Forms.CheckBox chkPhilippines;
        private System.Windows.Forms.CheckBox chkItaly;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox grpMealPlanner;
        private System.Windows.Forms.ListView listMealPlanner;
        private System.Windows.Forms.ColumnHeader Day;
        private System.Windows.Forms.ColumnHeader TimeSlot;
        private System.Windows.Forms.ColumnHeader RecipeInPlanner;
        private System.Windows.Forms.Button btnClearMealPlanner;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkTortilla;
        private System.Windows.Forms.CheckBox chkFlour;
        private System.Windows.Forms.CheckBox chkButter;
        private System.Windows.Forms.CheckBox chkHam;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

