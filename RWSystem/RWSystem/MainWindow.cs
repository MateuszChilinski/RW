using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RWSystem.Translation;

namespace RWSystem
{
    public partial class MainWindow : Form
    {
        ActionLanguageTranslator actionLanguageTranslator = new ActionLanguageTranslator();

        public MainWindow()
        {
            InitializeComponent();
            ExecuteQueryButton.Click += ExecuteQuery;
            InitializeMenu();
        }

        private void InitializeMenu()
        {
            CauseFull.Click += (s, e) => AddScenarioText("A causes a if p");
            CauseAlways.Click += (s, e) => AddScenarioText("A causes a");
            CauseImpossible.Click += (s, e) => AddScenarioText("impossible A if p");
            CausesTypicallyFull.Click += (s, e) => AddScenarioText("A typically causes a if p");
            CausesTypicallyAlways.Click += (s, e) => AddScenarioText("A typically causes a");
            Invokes.Click += (s, e) => AddScenarioText("A invokes B after d if p");
            Triggers.Click += (s, e) => AddScenarioText("p triggers A");
            Releases.Click += (s, e) => AddScenarioText("A releases f if p");
            DisableBetween.Click += (s, e) => AddScenarioText("disable A between d1, d2");
            DisableWhen.Click += (s, e) => AddScenarioText("disable A when d");
            NecessarySc.Click += (s, e) => AddQueryText("necessary Sc");
            PossiblySc.Click += (s, e) => AddQueryText("possibly Sc");
            NecessaryAction.Click += (s, e) => AddQueryText("necessary A at t when Sc");
            PossiblyAction.Click += (s, e) => AddQueryText("possibly A at t when Sc");
            NecessaryFluent.Click += (s, e) => AddQueryText("necessary y at t when Sc");
            PossiblyFluent.Click += (s, e) => AddQueryText("possibly y at t when Sc");
            TypicallyFluent.Click += (s, e) => AddQueryText("typically y at t when Sc");

            OpenStory.Click += (s, e) => OpenFile();
            SaveStory.Click += (s, e) => SaveFile();
        }

        private void SaveFile()
        {
            using (SaveFileDialog dialog = new SaveFileDialog())
            {
                dialog.Filter = "Story Files (*.story)|*.story";
                dialog.DefaultExt = "story";
                dialog.AddExtension = true;
                dialog.FilterIndex = 2;
                dialog.RestoreDirectory = true;

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(dialog.FileName, StoryTextBox.Text);
                }
            }
        }

        private void OpenFile()
        {
            OpenFileDialog dialog = new OpenFileDialog();
            DialogResult result = dialog.ShowDialog(); // Show the dialog.
            string text;
            if (result == DialogResult.OK) // Test result.
            {
                string file = dialog.FileName;
                try
                {
                    text = File.ReadAllText(file);
                    StoryTextBox.Text = text;
                }
                catch (IOException)
                {
                }
            }
        }

        private void AddQueryText(string s)
        {
            QueryText.Text = s;
        }
        private void AddScenarioText(string s)
        {
            StoryTextBox.Text += "\n" + s;
        }
        private void ExecuteQuery(object sender, EventArgs e)
        {
            string storyInProlog = TranslateStoryToProlog(StoryTextBox.Text);
            string queryInProlog = TranslateQueryToProlog(QueryText.Text);
            QueryPrologText.Text = PrologSystem.MakeQuery(storyInProlog, queryInProlog);
        }

        private string TranslateStoryToProlog(string story)
        {
            //return actionLanguageTranslator.Translate(story); //TODO: Uncomment when engine finished.
            return story;
        }

        private string TranslateQueryToProlog(string q)
        {
            // implement translation!!!
            return q;
        }
    }
}
