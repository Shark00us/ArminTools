using ArminTools.SubClasses.Languages;
using System;
using System.Windows.Forms;

namespace ArminTools.FormClasses
{
    public partial class SelectConfigForm : Form
    {
        private ILanguage[] _languages;
        private int _selectedLanguageIndex = -1;
        public ILanguage SelectedLanguage { get; private set; }

        public SelectConfigForm(ILanguage[] languages)
        {
            InitializeComponent();
            _languages = languages;
            CreateButtons();
            AdjustColumns();
        }

        private void CreateButtons()
        {
            var count = _languages.Length;
            tableLayoutPanel.ColumnCount = count;
            for (int i = 0; i < count; i++)
            {
                Button langButton = new Button()
                {
                    Enabled = true,
                    Visible = true,
                    Text = _languages[i].Name,
                    Tag = i,
                    Dock = DockStyle.Fill,
                    Font = _languages[i].Font,
                    Margin = new Padding(8)
                };
                langButton.Click += LangButton_Click;
                tableLayoutPanel.Controls.Add(langButton);
            }
        }

        private void LangButton_Click(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                var language = _languages[Convert.ToInt32(button.Tag)];
                DialogResult = DialogResult.OK;
                SelectedLanguage = language;
            }

        }

        private void AdjustColumns()
        {
            for (int i = 0; i < tableLayoutPanel.ColumnCount; i++)
            {
                tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50));
            }
        }

    }
}
