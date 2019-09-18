namespace circustTrein
{
    partial class Form1
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
            this.createAnimal = new System.Windows.Forms.Button();
            this.animalSizeSelector = new System.Windows.Forms.ComboBox();
            this.setAnimalType = new System.Windows.Forms.ComboBox();
            this.sortAnimals = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // createAnimal
            // 
            this.createAnimal.Location = new System.Drawing.Point(140, 212);
            this.createAnimal.Name = "createAnimal";
            this.createAnimal.Size = new System.Drawing.Size(75, 23);
            this.createAnimal.TabIndex = 2;
            this.createAnimal.Text = "Maak dier aan";
            this.createAnimal.UseVisualStyleBackColor = true;
            this.createAnimal.Click += new System.EventHandler(this.CreateAnimal_Click);
            // 
            // animalSizeSelector
            // 
            this.animalSizeSelector.FormattingEnabled = true;
            this.animalSizeSelector.Location = new System.Drawing.Point(140, 172);
            this.animalSizeSelector.Name = "animalSizeSelector";
            this.animalSizeSelector.Size = new System.Drawing.Size(121, 21);
            this.animalSizeSelector.TabIndex = 3;
            // 
            // setAnimalType
            // 
            this.setAnimalType.FormattingEnabled = true;
            this.setAnimalType.Location = new System.Drawing.Point(140, 131);
            this.setAnimalType.Name = "setAnimalType";
            this.setAnimalType.Size = new System.Drawing.Size(121, 21);
            this.setAnimalType.TabIndex = 4;
            // 
            // sortAnimals
            // 
            this.sortAnimals.Location = new System.Drawing.Point(140, 252);
            this.sortAnimals.Name = "sortAnimals";
            this.sortAnimals.Size = new System.Drawing.Size(75, 23);
            this.sortAnimals.TabIndex = 5;
            this.sortAnimals.Text = "Sorteer dieren";
            this.sortAnimals.UseVisualStyleBackColor = true;
            this.sortAnimals.Click += new System.EventHandler(this.SortAnimals_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sortAnimals);
            this.Controls.Add(this.setAnimalType);
            this.Controls.Add(this.animalSizeSelector);
            this.Controls.Add(this.createAnimal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button createAnimal;
        private System.Windows.Forms.ComboBox animalSizeSelector;
        private System.Windows.Forms.ComboBox setAnimalType;
        private System.Windows.Forms.Button sortAnimals;
    }
}

