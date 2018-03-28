namespace GameOfLife
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel = new System.Windows.Forms.Panel();
            this.playButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.worldsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stillLifeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blocksLoafsBeehivesBoatsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oscillatorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blinkerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.koksGalaxyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spaceshipsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gliderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lightweightSpaceshipToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.variousToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.smallExploderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exploderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tenCellRowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gosperGliderGunToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.speedNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.speedNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel.Location = new System.Drawing.Point(0, 27);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(683, 341);
            this.panel.TabIndex = 1;
            // 
            // playButton
            // 
            this.playButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.playButton.Location = new System.Drawing.Point(596, 397);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(75, 23);
            this.playButton.TabIndex = 5;
            this.playButton.Text = "Start";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 371);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(439, 52);
            this.label1.TabIndex = 2;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.worldsToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(683, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveAsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.openToolStripMenuItem.Text = "Open...";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.saveAsToolStripMenuItem.Text = "Save As...";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // worldsToolStripMenuItem
            // 
            this.worldsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colorToolStripMenuItem,
            this.resetToolStripMenuItem,
            this.stillLifeToolStripMenuItem,
            this.oscillatorsToolStripMenuItem,
            this.spaceshipsToolStripMenuItem,
            this.variousToolStripMenuItem});
            this.worldsToolStripMenuItem.Name = "worldsToolStripMenuItem";
            this.worldsToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.worldsToolStripMenuItem.Text = "World";
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.colorToolStripMenuItem.Text = "Color...";
            this.colorToolStripMenuItem.Click += new System.EventHandler(this.colorToolStripMenuItem_Click);
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.resetToolStripMenuItem.Text = "Reset";
            this.resetToolStripMenuItem.Click += new System.EventHandler(this.resetToolStripMenuItem_Click);
            // 
            // stillLifeToolStripMenuItem
            // 
            this.stillLifeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.blocksLoafsBeehivesBoatsToolStripMenuItem});
            this.stillLifeToolStripMenuItem.Name = "stillLifeToolStripMenuItem";
            this.stillLifeToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.stillLifeToolStripMenuItem.Text = "Still Life";
            // 
            // blocksLoafsBeehivesBoatsToolStripMenuItem
            // 
            this.blocksLoafsBeehivesBoatsToolStripMenuItem.Name = "blocksLoafsBeehivesBoatsToolStripMenuItem";
            this.blocksLoafsBeehivesBoatsToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
            this.blocksLoafsBeehivesBoatsToolStripMenuItem.Text = "Blocks, loafs, beehives and boats";
            this.blocksLoafsBeehivesBoatsToolStripMenuItem.Click += new System.EventHandler(this.TemplateToolStripMenuItem_Click);
            // 
            // oscillatorsToolStripMenuItem
            // 
            this.oscillatorsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.blinkerToolStripMenuItem,
            this.koksGalaxyToolStripMenuItem});
            this.oscillatorsToolStripMenuItem.Name = "oscillatorsToolStripMenuItem";
            this.oscillatorsToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.oscillatorsToolStripMenuItem.Text = "Oscillators";
            // 
            // blinkerToolStripMenuItem
            // 
            this.blinkerToolStripMenuItem.Name = "blinkerToolStripMenuItem";
            this.blinkerToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.blinkerToolStripMenuItem.Text = "Blinker";
            this.blinkerToolStripMenuItem.Click += new System.EventHandler(this.TemplateToolStripMenuItem_Click);
            // 
            // koksGalaxyToolStripMenuItem
            // 
            this.koksGalaxyToolStripMenuItem.Name = "koksGalaxyToolStripMenuItem";
            this.koksGalaxyToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.koksGalaxyToolStripMenuItem.Text = "Kok\'s galaxy";
            this.koksGalaxyToolStripMenuItem.Click += new System.EventHandler(this.TemplateToolStripMenuItem_Click);
            // 
            // spaceshipsToolStripMenuItem
            // 
            this.spaceshipsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gliderToolStripMenuItem,
            this.lightweightSpaceshipToolStripMenuItem});
            this.spaceshipsToolStripMenuItem.Name = "spaceshipsToolStripMenuItem";
            this.spaceshipsToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.spaceshipsToolStripMenuItem.Text = "Spaceships";
            // 
            // gliderToolStripMenuItem
            // 
            this.gliderToolStripMenuItem.Name = "gliderToolStripMenuItem";
            this.gliderToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.gliderToolStripMenuItem.Text = "Glider";
            this.gliderToolStripMenuItem.Click += new System.EventHandler(this.TemplateToolStripMenuItem_Click);
            // 
            // lightweightSpaceshipToolStripMenuItem
            // 
            this.lightweightSpaceshipToolStripMenuItem.Name = "lightweightSpaceshipToolStripMenuItem";
            this.lightweightSpaceshipToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.lightweightSpaceshipToolStripMenuItem.Text = "Lightweight spaceship";
            this.lightweightSpaceshipToolStripMenuItem.Click += new System.EventHandler(this.TemplateToolStripMenuItem_Click);
            // 
            // variousToolStripMenuItem
            // 
            this.variousToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smallExploderToolStripMenuItem,
            this.exploderToolStripMenuItem,
            this.tenCellRowToolStripMenuItem,
            this.gosperGliderGunToolStripMenuItem});
            this.variousToolStripMenuItem.Name = "variousToolStripMenuItem";
            this.variousToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.variousToolStripMenuItem.Text = "Various";
            // 
            // smallExploderToolStripMenuItem
            // 
            this.smallExploderToolStripMenuItem.Name = "smallExploderToolStripMenuItem";
            this.smallExploderToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.smallExploderToolStripMenuItem.Text = "Small exploder";
            this.smallExploderToolStripMenuItem.Click += new System.EventHandler(this.TemplateToolStripMenuItem_Click);
            // 
            // exploderToolStripMenuItem
            // 
            this.exploderToolStripMenuItem.Name = "exploderToolStripMenuItem";
            this.exploderToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.exploderToolStripMenuItem.Text = "Exploder";
            this.exploderToolStripMenuItem.Click += new System.EventHandler(this.TemplateToolStripMenuItem_Click);
            // 
            // tenCellRowToolStripMenuItem
            // 
            this.tenCellRowToolStripMenuItem.Name = "tenCellRowToolStripMenuItem";
            this.tenCellRowToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.tenCellRowToolStripMenuItem.Text = "10 cell row";
            this.tenCellRowToolStripMenuItem.Click += new System.EventHandler(this.TemplateToolStripMenuItem_Click);
            // 
            // gosperGliderGunToolStripMenuItem
            // 
            this.gosperGliderGunToolStripMenuItem.Name = "gosperGliderGunToolStripMenuItem";
            this.gosperGliderGunToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.gosperGliderGunToolStripMenuItem.Text = "Gosper glider gun";
            this.gosperGliderGunToolStripMenuItem.Click += new System.EventHandler(this.TemplateToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(588, 373);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Speed";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // speedNumericUpDown
            // 
            this.speedNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.speedNumericUpDown.Location = new System.Drawing.Point(632, 371);
            this.speedNumericUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.speedNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.speedNumericUpDown.Name = "speedNumericUpDown";
            this.speedNumericUpDown.Size = new System.Drawing.Size(39, 20);
            this.speedNumericUpDown.TabIndex = 4;
            this.speedNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 432);
            this.Controls.Add(this.speedNumericUpDown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conway\'s Game of Life";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.speedNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem worldsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stillLifeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oscillatorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blocksLoafsBeehivesBoatsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blinkerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem koksGalaxyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem spaceshipsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gliderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lightweightSpaceshipToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem variousToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem smallExploderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exploderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tenCellRowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gosperGliderGunToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown speedNumericUpDown;
    }
}

