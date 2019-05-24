namespace RWSystem
{
    partial class MainWindow
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
            this.MainPanel = new System.Windows.Forms.Panel();
            this.MainSplit = new System.Windows.Forms.SplitContainer();
            this.MainLeftPanel = new System.Windows.Forms.Panel();
            this.StoryGroupBox = new System.Windows.Forms.GroupBox();
            this.StoryPanel = new System.Windows.Forms.Panel();
            this.StoryTextBox = new System.Windows.Forms.RichTextBox();
            this.MainRightPanel = new System.Windows.Forms.Panel();
            this.QueriesSplitContainer = new System.Windows.Forms.SplitContainer();
            this.QueryControlPanel = new System.Windows.Forms.Panel();
            this.QueriesGroupBox = new System.Windows.Forms.GroupBox();
            this.QueriesGroupBoxPanel = new System.Windows.Forms.Panel();
            this.QueriesGroupSplitContainer = new System.Windows.Forms.SplitContainer();
            this.QueryTextPanel = new System.Windows.Forms.Panel();
            this.QueryText = new System.Windows.Forms.TextBox();
            this.ExecuteQueryButton = new System.Windows.Forms.Button();
            this.PrologPanel = new System.Windows.Forms.Panel();
            this.QueryPrologText = new System.Windows.Forms.RichTextBox();
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.FileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenStory = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveStory = new System.Windows.Forms.ToolStripMenuItem();
            this.LangMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CauseFull = new System.Windows.Forms.ToolStripMenuItem();
            this.CauseAlways = new System.Windows.Forms.ToolStripMenuItem();
            this.CauseImpossible = new System.Windows.Forms.ToolStripMenuItem();
            this.CausesTypicallyFull = new System.Windows.Forms.ToolStripMenuItem();
            this.CausesTypicallyAlways = new System.Windows.Forms.ToolStripMenuItem();
            this.Invokes = new System.Windows.Forms.ToolStripMenuItem();
            this.Triggers = new System.Windows.Forms.ToolStripMenuItem();
            this.Releases = new System.Windows.Forms.ToolStripMenuItem();
            this.DisableBetween = new System.Windows.Forms.ToolStripMenuItem();
            this.DisableWhen = new System.Windows.Forms.ToolStripMenuItem();
            this.acsATBTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.obsATBTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.QueryMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.QueryWholeSc = new System.Windows.Forms.ToolStripMenuItem();
            this.NecessarySc = new System.Windows.Forms.ToolStripMenuItem();
            this.PossiblySc = new System.Windows.Forms.ToolStripMenuItem();
            this.QueryAction = new System.Windows.Forms.ToolStripMenuItem();
            this.NecessaryAction = new System.Windows.Forms.ToolStripMenuItem();
            this.PossiblyAction = new System.Windows.Forms.ToolStripMenuItem();
            this.QueryFluent = new System.Windows.Forms.ToolStripMenuItem();
            this.NecessaryFluent = new System.Windows.Forms.ToolStripMenuItem();
            this.PossiblyFluent = new System.Windows.Forms.ToolStripMenuItem();
            this.TypicallyFluent = new System.Windows.Forms.ToolStripMenuItem();
            this.MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainSplit)).BeginInit();
            this.MainSplit.Panel1.SuspendLayout();
            this.MainSplit.Panel2.SuspendLayout();
            this.MainSplit.SuspendLayout();
            this.MainLeftPanel.SuspendLayout();
            this.StoryGroupBox.SuspendLayout();
            this.StoryPanel.SuspendLayout();
            this.MainRightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QueriesSplitContainer)).BeginInit();
            this.QueriesSplitContainer.Panel1.SuspendLayout();
            this.QueriesSplitContainer.Panel2.SuspendLayout();
            this.QueriesSplitContainer.SuspendLayout();
            this.QueryControlPanel.SuspendLayout();
            this.QueriesGroupBox.SuspendLayout();
            this.QueriesGroupBoxPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QueriesGroupSplitContainer)).BeginInit();
            this.QueriesGroupSplitContainer.Panel1.SuspendLayout();
            this.QueriesGroupSplitContainer.Panel2.SuspendLayout();
            this.QueriesGroupSplitContainer.SuspendLayout();
            this.QueryTextPanel.SuspendLayout();
            this.PrologPanel.SuspendLayout();
            this.MainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.MainSplit);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Padding = new System.Windows.Forms.Padding(4);
            this.MainPanel.Size = new System.Drawing.Size(1156, 670);
            this.MainPanel.TabIndex = 0;
            // 
            // MainSplit
            // 
            this.MainSplit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainSplit.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.MainSplit.Location = new System.Drawing.Point(4, 4);
            this.MainSplit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MainSplit.Name = "MainSplit";
            // 
            // MainSplit.Panel1
            // 
            this.MainSplit.Panel1.Controls.Add(this.MainLeftPanel);
            // 
            // MainSplit.Panel2
            // 
            this.MainSplit.Panel2.Controls.Add(this.MainRightPanel);
            this.MainSplit.Size = new System.Drawing.Size(1148, 662);
            this.MainSplit.SplitterDistance = 751;
            this.MainSplit.TabIndex = 0;
            // 
            // MainLeftPanel
            // 
            this.MainLeftPanel.Controls.Add(this.StoryGroupBox);
            this.MainLeftPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainLeftPanel.Location = new System.Drawing.Point(0, 0);
            this.MainLeftPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MainLeftPanel.Name = "MainLeftPanel";
            this.MainLeftPanel.Padding = new System.Windows.Forms.Padding(4, 32, 4, 4);
            this.MainLeftPanel.Size = new System.Drawing.Size(751, 662);
            this.MainLeftPanel.TabIndex = 0;
            // 
            // StoryGroupBox
            // 
            this.StoryGroupBox.Controls.Add(this.StoryPanel);
            this.StoryGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StoryGroupBox.Location = new System.Drawing.Point(4, 32);
            this.StoryGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StoryGroupBox.Name = "StoryGroupBox";
            this.StoryGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StoryGroupBox.Size = new System.Drawing.Size(743, 626);
            this.StoryGroupBox.TabIndex = 2;
            this.StoryGroupBox.TabStop = false;
            this.StoryGroupBox.Text = "Historyjka (scenariusz Sc)";
            // 
            // StoryPanel
            // 
            this.StoryPanel.Controls.Add(this.StoryTextBox);
            this.StoryPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StoryPanel.Location = new System.Drawing.Point(3, 17);
            this.StoryPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StoryPanel.Name = "StoryPanel";
            this.StoryPanel.Padding = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.StoryPanel.Size = new System.Drawing.Size(737, 607);
            this.StoryPanel.TabIndex = 1;
            // 
            // StoryTextBox
            // 
            this.StoryTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StoryTextBox.Location = new System.Drawing.Point(9, 8);
            this.StoryTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StoryTextBox.Name = "StoryTextBox";
            this.StoryTextBox.Size = new System.Drawing.Size(719, 591);
            this.StoryTextBox.TabIndex = 0;
            this.StoryTextBox.Text = "father(martin, inka).\nfather(uwe, gloria).\nfather(uwe, melanie).\nfather(uwe, ayal" +
    "a).";
            // 
            // MainRightPanel
            // 
            this.MainRightPanel.Controls.Add(this.QueriesSplitContainer);
            this.MainRightPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainRightPanel.Location = new System.Drawing.Point(0, 0);
            this.MainRightPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MainRightPanel.Name = "MainRightPanel";
            this.MainRightPanel.Padding = new System.Windows.Forms.Padding(4, 24, 4, 4);
            this.MainRightPanel.Size = new System.Drawing.Size(393, 662);
            this.MainRightPanel.TabIndex = 0;
            // 
            // QueriesSplitContainer
            // 
            this.QueriesSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.QueriesSplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.QueriesSplitContainer.Location = new System.Drawing.Point(4, 24);
            this.QueriesSplitContainer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.QueriesSplitContainer.Name = "QueriesSplitContainer";
            this.QueriesSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // QueriesSplitContainer.Panel1
            // 
            this.QueriesSplitContainer.Panel1.Controls.Add(this.QueryControlPanel);
            // 
            // QueriesSplitContainer.Panel2
            // 
            this.QueriesSplitContainer.Panel2.Controls.Add(this.PrologPanel);
            this.QueriesSplitContainer.Size = new System.Drawing.Size(385, 634);
            this.QueriesSplitContainer.SplitterDistance = 125;
            this.QueriesSplitContainer.SplitterWidth = 3;
            this.QueriesSplitContainer.TabIndex = 0;
            // 
            // QueryControlPanel
            // 
            this.QueryControlPanel.Controls.Add(this.QueriesGroupBox);
            this.QueryControlPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.QueryControlPanel.Location = new System.Drawing.Point(0, 0);
            this.QueryControlPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.QueryControlPanel.Name = "QueryControlPanel";
            this.QueryControlPanel.Padding = new System.Windows.Forms.Padding(9, 16, 9, 8);
            this.QueryControlPanel.Size = new System.Drawing.Size(385, 125);
            this.QueryControlPanel.TabIndex = 0;
            // 
            // QueriesGroupBox
            // 
            this.QueriesGroupBox.Controls.Add(this.QueriesGroupBoxPanel);
            this.QueriesGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.QueriesGroupBox.Location = new System.Drawing.Point(9, 16);
            this.QueriesGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.QueriesGroupBox.Name = "QueriesGroupBox";
            this.QueriesGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.QueriesGroupBox.Size = new System.Drawing.Size(367, 101);
            this.QueriesGroupBox.TabIndex = 0;
            this.QueriesGroupBox.TabStop = false;
            this.QueriesGroupBox.Text = "Kwerendy";
            // 
            // QueriesGroupBoxPanel
            // 
            this.QueriesGroupBoxPanel.Controls.Add(this.QueriesGroupSplitContainer);
            this.QueriesGroupBoxPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.QueriesGroupBoxPanel.Location = new System.Drawing.Point(3, 17);
            this.QueriesGroupBoxPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.QueriesGroupBoxPanel.Name = "QueriesGroupBoxPanel";
            this.QueriesGroupBoxPanel.Padding = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.QueriesGroupBoxPanel.Size = new System.Drawing.Size(361, 82);
            this.QueriesGroupBoxPanel.TabIndex = 2;
            // 
            // QueriesGroupSplitContainer
            // 
            this.QueriesGroupSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.QueriesGroupSplitContainer.Location = new System.Drawing.Point(9, 8);
            this.QueriesGroupSplitContainer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.QueriesGroupSplitContainer.Name = "QueriesGroupSplitContainer";
            this.QueriesGroupSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // QueriesGroupSplitContainer.Panel1
            // 
            this.QueriesGroupSplitContainer.Panel1.Controls.Add(this.QueryTextPanel);
            // 
            // QueriesGroupSplitContainer.Panel2
            // 
            this.QueriesGroupSplitContainer.Panel2.Controls.Add(this.ExecuteQueryButton);
            this.QueriesGroupSplitContainer.Size = new System.Drawing.Size(343, 66);
            this.QueriesGroupSplitContainer.SplitterDistance = 29;
            this.QueriesGroupSplitContainer.SplitterWidth = 3;
            this.QueriesGroupSplitContainer.TabIndex = 1;
            // 
            // QueryTextPanel
            // 
            this.QueryTextPanel.Controls.Add(this.QueryText);
            this.QueryTextPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.QueryTextPanel.Location = new System.Drawing.Point(0, 0);
            this.QueryTextPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.QueryTextPanel.Name = "QueryTextPanel";
            this.QueryTextPanel.Padding = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.QueryTextPanel.Size = new System.Drawing.Size(343, 29);
            this.QueryTextPanel.TabIndex = 2;
            // 
            // QueryText
            // 
            this.QueryText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.QueryText.Location = new System.Drawing.Point(9, 8);
            this.QueryText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.QueryText.Name = "QueryText";
            this.QueryText.Size = new System.Drawing.Size(325, 22);
            this.QueryText.TabIndex = 0;
            this.QueryText.Text = "father(uwe, Child)";
            // 
            // ExecuteQueryButton
            // 
            this.ExecuteQueryButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ExecuteQueryButton.Location = new System.Drawing.Point(0, 0);
            this.ExecuteQueryButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ExecuteQueryButton.Name = "ExecuteQueryButton";
            this.ExecuteQueryButton.Size = new System.Drawing.Size(343, 34);
            this.ExecuteQueryButton.TabIndex = 1;
            this.ExecuteQueryButton.Text = "Zapytaj";
            this.ExecuteQueryButton.UseVisualStyleBackColor = true;
            // 
            // PrologPanel
            // 
            this.PrologPanel.Controls.Add(this.QueryPrologText);
            this.PrologPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PrologPanel.Location = new System.Drawing.Point(0, 0);
            this.PrologPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PrologPanel.Name = "PrologPanel";
            this.PrologPanel.Padding = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.PrologPanel.Size = new System.Drawing.Size(385, 506);
            this.PrologPanel.TabIndex = 0;
            // 
            // QueryPrologText
            // 
            this.QueryPrologText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.QueryPrologText.Location = new System.Drawing.Point(9, 8);
            this.QueryPrologText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.QueryPrologText.Name = "QueryPrologText";
            this.QueryPrologText.Size = new System.Drawing.Size(367, 490);
            this.QueryPrologText.TabIndex = 1;
            this.QueryPrologText.Text = "";
            // 
            // MainMenu
            // 
            this.MainMenu.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.MainMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenuItem,
            this.LangMenuItem,
            this.QueryMenuItem});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.MainMenu.Size = new System.Drawing.Size(1156, 28);
            this.MainMenu.TabIndex = 1;
            this.MainMenu.Text = "menuStrip1";
            // 
            // FileMenuItem
            // 
            this.FileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenStory,
            this.SaveStory});
            this.FileMenuItem.Name = "FileMenuItem";
            this.FileMenuItem.Size = new System.Drawing.Size(44, 24);
            this.FileMenuItem.Text = "Plik";
            // 
            // OpenStory
            // 
            this.OpenStory.Name = "OpenStory";
            this.OpenStory.Size = new System.Drawing.Size(203, 26);
            this.OpenStory.Text = "Otwórz scenariusz";
            // 
            // SaveStory
            // 
            this.SaveStory.Name = "SaveStory";
            this.SaveStory.Size = new System.Drawing.Size(203, 26);
            this.SaveStory.Text = "Zapisz scenariusz";
            // 
            // LangMenuItem
            // 
            this.LangMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CauseFull,
            this.CauseAlways,
            this.CauseImpossible,
            this.CausesTypicallyFull,
            this.CausesTypicallyAlways,
            this.Invokes,
            this.Triggers,
            this.Releases,
            this.DisableBetween,
            this.DisableWhen,
            this.acsATBTToolStripMenuItem,
            this.obsATBTToolStripMenuItem});
            this.LangMenuItem.Name = "LangMenuItem";
            this.LangMenuItem.Size = new System.Drawing.Size(55, 24);
            this.LangMenuItem.Text = "Jezyk";
            // 
            // CauseFull
            // 
            this.CauseFull.Name = "CauseFull";
            this.CauseFull.Size = new System.Drawing.Size(252, 26);
            this.CauseFull.Text = "A causes a if p";
            // 
            // CauseAlways
            // 
            this.CauseAlways.Name = "CauseAlways";
            this.CauseAlways.Size = new System.Drawing.Size(252, 26);
            this.CauseAlways.Text = "A causes a";
            // 
            // CauseImpossible
            // 
            this.CauseImpossible.Name = "CauseImpossible";
            this.CauseImpossible.Size = new System.Drawing.Size(252, 26);
            this.CauseImpossible.Text = "impossible A if p";
            // 
            // CausesTypicallyFull
            // 
            this.CausesTypicallyFull.Name = "CausesTypicallyFull";
            this.CausesTypicallyFull.Size = new System.Drawing.Size(252, 26);
            this.CausesTypicallyFull.Text = "A typically causes a if p";
            // 
            // CausesTypicallyAlways
            // 
            this.CausesTypicallyAlways.Name = "CausesTypicallyAlways";
            this.CausesTypicallyAlways.Size = new System.Drawing.Size(252, 26);
            this.CausesTypicallyAlways.Text = "A typically causes a";
            // 
            // Invokes
            // 
            this.Invokes.Name = "Invokes";
            this.Invokes.Size = new System.Drawing.Size(252, 26);
            this.Invokes.Text = "A invokes B after d if p";
            // 
            // Triggers
            // 
            this.Triggers.Name = "Triggers";
            this.Triggers.Size = new System.Drawing.Size(252, 26);
            this.Triggers.Text = "p triggers A";
            // 
            // Releases
            // 
            this.Releases.Name = "Releases";
            this.Releases.Size = new System.Drawing.Size(252, 26);
            this.Releases.Text = "A releases f if p";
            // 
            // DisableBetween
            // 
            this.DisableBetween.Name = "DisableBetween";
            this.DisableBetween.Size = new System.Drawing.Size(252, 26);
            this.DisableBetween.Text = "disable A between d1, d2";
            // 
            // DisableWhen
            // 
            this.DisableWhen.Name = "DisableWhen";
            this.DisableWhen.Size = new System.Drawing.Size(252, 26);
            this.DisableWhen.Text = "disable A when d";
            // 
            // acsATBTToolStripMenuItem
            // 
            this.acsATBTToolStripMenuItem.Name = "acsATBTToolStripMenuItem";
            this.acsATBTToolStripMenuItem.Size = new System.Drawing.Size(252, 26);
            this.acsATBTToolStripMenuItem.Text = "Acs = { ( A ; t ) , ( B ; t ) }";
            // 
            // obsATBTToolStripMenuItem
            // 
            this.obsATBTToolStripMenuItem.Name = "obsATBTToolStripMenuItem";
            this.obsATBTToolStripMenuItem.Size = new System.Drawing.Size(252, 26);
            this.obsATBTToolStripMenuItem.Text = "Obs = { ( a ; t ) , ( b ; t ) }";
            // 
            // QueryMenuItem
            // 
            this.QueryMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.QueryWholeSc,
            this.QueryAction,
            this.QueryFluent});
            this.QueryMenuItem.Name = "QueryMenuItem";
            this.QueryMenuItem.Size = new System.Drawing.Size(85, 24);
            this.QueryMenuItem.Text = "Kwerendy";
            // 
            // QueryWholeSc
            // 
            this.QueryWholeSc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NecessarySc,
            this.PossiblySc});
            this.QueryWholeSc.Name = "QueryWholeSc";
            this.QueryWholeSc.Size = new System.Drawing.Size(269, 26);
            this.QueryWholeSc.Text = "Realizowalności scenariusza";
            // 
            // NecessarySc
            // 
            this.NecessarySc.Name = "NecessarySc";
            this.NecessarySc.Size = new System.Drawing.Size(166, 26);
            this.NecessarySc.Text = "necessary Sc";
            // 
            // PossiblySc
            // 
            this.PossiblySc.Name = "PossiblySc";
            this.PossiblySc.Size = new System.Drawing.Size(166, 26);
            this.PossiblySc.Text = "possibly Sc";
            // 
            // QueryAction
            // 
            this.QueryAction.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NecessaryAction,
            this.PossiblyAction});
            this.QueryAction.Name = "QueryAction";
            this.QueryAction.Size = new System.Drawing.Size(269, 26);
            this.QueryAction.Text = "Wykonywalności akcji";
            // 
            // NecessaryAction
            // 
            this.NecessaryAction.Name = "NecessaryAction";
            this.NecessaryAction.Size = new System.Drawing.Size(245, 26);
            this.NecessaryAction.Text = "necessary A at t when Sc";
            // 
            // PossiblyAction
            // 
            this.PossiblyAction.Name = "PossiblyAction";
            this.PossiblyAction.Size = new System.Drawing.Size(245, 26);
            this.PossiblyAction.Text = "possibly A at t when Sc";
            // 
            // QueryFluent
            // 
            this.QueryFluent.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NecessaryFluent,
            this.PossiblyFluent,
            this.TypicallyFluent});
            this.QueryFluent.Name = "QueryFluent";
            this.QueryFluent.Size = new System.Drawing.Size(269, 26);
            this.QueryFluent.Text = "Spełnialności";
            // 
            // NecessaryFluent
            // 
            this.NecessaryFluent.Name = "NecessaryFluent";
            this.NecessaryFluent.Size = new System.Drawing.Size(242, 26);
            this.NecessaryFluent.Text = "necessary y at t when Sc";
            // 
            // PossiblyFluent
            // 
            this.PossiblyFluent.Name = "PossiblyFluent";
            this.PossiblyFluent.Size = new System.Drawing.Size(242, 26);
            this.PossiblyFluent.Text = "possibly y at t when Sc";
            // 
            // TypicallyFluent
            // 
            this.TypicallyFluent.Name = "TypicallyFluent";
            this.TypicallyFluent.Size = new System.Drawing.Size(242, 26);
            this.TypicallyFluent.Text = "typically y at t when Sc";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 670);
            this.Controls.Add(this.MainMenu);
            this.Controls.Add(this.MainPanel);
            this.MainMenuStrip = this.MainMenu;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainWindow";
            this.Text = "Projekt z RW - 3";
            this.MainPanel.ResumeLayout(false);
            this.MainSplit.Panel1.ResumeLayout(false);
            this.MainSplit.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainSplit)).EndInit();
            this.MainSplit.ResumeLayout(false);
            this.MainLeftPanel.ResumeLayout(false);
            this.StoryGroupBox.ResumeLayout(false);
            this.StoryPanel.ResumeLayout(false);
            this.MainRightPanel.ResumeLayout(false);
            this.QueriesSplitContainer.Panel1.ResumeLayout(false);
            this.QueriesSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.QueriesSplitContainer)).EndInit();
            this.QueriesSplitContainer.ResumeLayout(false);
            this.QueryControlPanel.ResumeLayout(false);
            this.QueriesGroupBox.ResumeLayout(false);
            this.QueriesGroupBoxPanel.ResumeLayout(false);
            this.QueriesGroupSplitContainer.Panel1.ResumeLayout(false);
            this.QueriesGroupSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.QueriesGroupSplitContainer)).EndInit();
            this.QueriesGroupSplitContainer.ResumeLayout(false);
            this.QueryTextPanel.ResumeLayout(false);
            this.QueryTextPanel.PerformLayout();
            this.PrologPanel.ResumeLayout(false);
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.SplitContainer MainSplit;
        private System.Windows.Forms.Panel MainLeftPanel;
        private System.Windows.Forms.Panel MainRightPanel;
        private System.Windows.Forms.SplitContainer QueriesSplitContainer;
        private System.Windows.Forms.Panel QueryControlPanel;
        private System.Windows.Forms.Panel PrologPanel;
        private System.Windows.Forms.GroupBox QueriesGroupBox;
        private System.Windows.Forms.RichTextBox StoryTextBox;
        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem FileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LangMenuItem;
        private System.Windows.Forms.ToolStripMenuItem QueryMenuItem;
        private System.Windows.Forms.RichTextBox QueryPrologText;
        private System.Windows.Forms.TextBox QueryText;
        private System.Windows.Forms.Button ExecuteQueryButton;
        private System.Windows.Forms.GroupBox StoryGroupBox;
        private System.Windows.Forms.Panel StoryPanel;
        private System.Windows.Forms.Panel QueriesGroupBoxPanel;
        private System.Windows.Forms.SplitContainer QueriesGroupSplitContainer;
        private System.Windows.Forms.Panel QueryTextPanel;
        private System.Windows.Forms.ToolStripMenuItem QueryWholeSc;
        private System.Windows.Forms.ToolStripMenuItem NecessarySc;
        private System.Windows.Forms.ToolStripMenuItem PossiblySc;
        private System.Windows.Forms.ToolStripMenuItem QueryAction;
        private System.Windows.Forms.ToolStripMenuItem NecessaryAction;
        private System.Windows.Forms.ToolStripMenuItem PossiblyAction;
        private System.Windows.Forms.ToolStripMenuItem QueryFluent;
        private System.Windows.Forms.ToolStripMenuItem NecessaryFluent;
        private System.Windows.Forms.ToolStripMenuItem PossiblyFluent;
        private System.Windows.Forms.ToolStripMenuItem TypicallyFluent;
        private System.Windows.Forms.ToolStripMenuItem CauseFull;
        private System.Windows.Forms.ToolStripMenuItem CauseAlways;
        private System.Windows.Forms.ToolStripMenuItem CauseImpossible;
        private System.Windows.Forms.ToolStripMenuItem CausesTypicallyFull;
        private System.Windows.Forms.ToolStripMenuItem CausesTypicallyAlways;
        private System.Windows.Forms.ToolStripMenuItem Invokes;
        private System.Windows.Forms.ToolStripMenuItem Triggers;
        private System.Windows.Forms.ToolStripMenuItem Releases;
        private System.Windows.Forms.ToolStripMenuItem DisableBetween;
        private System.Windows.Forms.ToolStripMenuItem DisableWhen;
        private System.Windows.Forms.ToolStripMenuItem OpenStory;
        private System.Windows.Forms.ToolStripMenuItem SaveStory;
        private System.Windows.Forms.ToolStripMenuItem acsATBTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem obsATBTToolStripMenuItem;
    }
}

