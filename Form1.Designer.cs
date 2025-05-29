namespace Winforms_test
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
            saveFileButton = new Button();
            savePathLabel = new Label();
            pageSetupDialog1 = new PageSetupDialog();
            saveFileTab = new TabControl();
            characterPage = new TabPage();
            inventoryPage = new TabPage();
            weaponsPage = new TabPage();
            armorsPage = new TabPage();
            variablesPage = new TabPage();
            itemsButton = new Button();
            itemPathLabel = new Label();
            systemButton = new Button();
            systemPathLabel = new Label();
            saveFileTab.SuspendLayout();
            SuspendLayout();
            // 
            // saveFileButton
            // 
            saveFileButton.AutoSize = true;
            saveFileButton.Location = new Point(3, 4);
            saveFileButton.Name = "saveFileButton";
            saveFileButton.Size = new Size(242, 35);
            saveFileButton.TabIndex = 0;
            saveFileButton.Text = "Save File";
            saveFileButton.UseVisualStyleBackColor = true;
            saveFileButton.Click += button1_Click;
            // 
            // savePathLabel
            // 
            savePathLabel.AutoSize = true;
            savePathLabel.Location = new Point(251, 9);
            savePathLabel.Name = "savePathLabel";
            savePathLabel.Size = new Size(50, 25);
            savePathLabel.TabIndex = 2;
            savePathLabel.Text = "Path:";
            savePathLabel.Click += label2_Click;
            // 
            // saveFileTab
            // 
            saveFileTab.Controls.Add(characterPage);
            saveFileTab.Controls.Add(inventoryPage);
            saveFileTab.Controls.Add(weaponsPage);
            saveFileTab.Controls.Add(armorsPage);
            saveFileTab.Controls.Add(variablesPage);
            saveFileTab.Location = new Point(12, 127);
            saveFileTab.Name = "saveFileTab";
            saveFileTab.SelectedIndex = 0;
            saveFileTab.Size = new Size(850, 700);
            saveFileTab.TabIndex = 3;
            // 
            // characterPage
            // 
            characterPage.Location = new Point(4, 34);
            characterPage.Name = "characterPage";
            characterPage.Padding = new Padding(3);
            characterPage.Size = new Size(842, 662);
            characterPage.TabIndex = 0;
            characterPage.Text = "Character";
            characterPage.UseVisualStyleBackColor = true;
            // 
            // inventoryPage
            // 
            inventoryPage.Location = new Point(4, 34);
            inventoryPage.Name = "inventoryPage";
            inventoryPage.Padding = new Padding(3);
            inventoryPage.Size = new Size(858, 597);
            inventoryPage.TabIndex = 1;
            inventoryPage.Text = "Inventory";
            inventoryPage.UseVisualStyleBackColor = true;
            // 
            // weaponsPage
            // 
            weaponsPage.Location = new Point(4, 34);
            weaponsPage.Name = "weaponsPage";
            weaponsPage.Padding = new Padding(3);
            weaponsPage.Size = new Size(858, 597);
            weaponsPage.TabIndex = 2;
            weaponsPage.Text = "Weapons";
            weaponsPage.UseVisualStyleBackColor = true;
            // 
            // armorsPage
            // 
            armorsPage.Location = new Point(4, 34);
            armorsPage.Name = "armorsPage";
            armorsPage.Padding = new Padding(3);
            armorsPage.Size = new Size(858, 597);
            armorsPage.TabIndex = 3;
            armorsPage.Text = "Armors";
            armorsPage.UseVisualStyleBackColor = true;
            // 
            // variablesPage
            // 
            variablesPage.Location = new Point(4, 34);
            variablesPage.Name = "variablesPage";
            variablesPage.Padding = new Padding(3);
            variablesPage.Size = new Size(858, 597);
            variablesPage.TabIndex = 4;
            variablesPage.Text = "Variables";
            variablesPage.UseVisualStyleBackColor = true;
            // 
            // itemsButton
            // 
            itemsButton.AutoSize = true;
            itemsButton.Location = new Point(1, 45);
            itemsButton.Name = "itemsButton";
            itemsButton.Size = new Size(244, 35);
            itemsButton.TabIndex = 4;
            itemsButton.Text = "Items.json";
            itemsButton.UseVisualStyleBackColor = true;
            itemsButton.Click += button2_Click;
            // 
            // itemPathLabel
            // 
            itemPathLabel.AutoSize = true;
            itemPathLabel.Location = new Point(251, 50);
            itemPathLabel.Name = "itemPathLabel";
            itemPathLabel.Size = new Size(50, 25);
            itemPathLabel.TabIndex = 5;
            itemPathLabel.Text = "Path:";
            itemPathLabel.Click += itemPathLabel_Click;
            // 
            // systemButton
            // 
            systemButton.AutoSize = true;
            systemButton.Location = new Point(1, 86);
            systemButton.Name = "systemButton";
            systemButton.Size = new Size(244, 35);
            systemButton.TabIndex = 6;
            systemButton.Text = "System.json";
            systemButton.UseVisualStyleBackColor = true;
            systemButton.Click += systemButton_Click;
            // 
            // systemPathLabel
            // 
            systemPathLabel.AutoSize = true;
            systemPathLabel.Location = new Point(251, 91);
            systemPathLabel.Name = "systemPathLabel";
            systemPathLabel.Size = new Size(50, 25);
            systemPathLabel.TabIndex = 7;
            systemPathLabel.Text = "Path:";
            systemPathLabel.Click += systemPathLabel_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(878, 844);
            Controls.Add(saveFileTab);
            Controls.Add(systemPathLabel);
            Controls.Add(systemButton);
            Controls.Add(itemPathLabel);
            Controls.Add(itemsButton);
            Controls.Add(savePathLabel);
            Controls.Add(saveFileButton);
            Name = "Form1";
            Text = "Open Source RPG Maker Save Editor";
            Load += Form1_Load;
            saveFileTab.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button saveFileButton;
        private Label savePathLabel;
        private PageSetupDialog pageSetupDialog1;
        private TabControl saveFileTab;
        private TabPage characterPage;
        private TabPage inventoryPage;
        private Button itemsButton;
        private Label itemPathLabel;
        private Button systemButton;
        private Label systemPathLabel;
        private TabPage weaponsPage;
        private TabPage armorsPage;
        private TabPage variablesPage;
    }
}
