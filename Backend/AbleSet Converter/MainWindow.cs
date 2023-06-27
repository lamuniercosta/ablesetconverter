using AbleSet_Converter.Services;
using AbleSet_Converter.Services.AbleSet;
using AbleSet_Converter.Services.BandHelper;
using System.ComponentModel;

namespace AbleSet_Converter
{
    public partial class MainWindow : Form
    {
        private readonly BandHelperImporter _bandHelperImporter;
        private readonly AbleSetImporter _ableSetImporter;
        private readonly SetListGenerator _generator;

        private string AbleSetFileName = string.Empty;
        private string BandHelperFileName = string.Empty;
        public MainWindow()
        {
            InitializeComponent();
            _generator = new SetListGenerator();
            _ableSetImporter = new AbleSetImporter();
            _bandHelperImporter = new BandHelperImporter();
        }

        private async void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            if (e.Cancel) return;
            if (!string.IsNullOrEmpty(saveFileDialog1.FileName))
            {
                var ableSet = await _ableSetImporter.Import(AbleSetFileName);
                var bandHelper = await _bandHelperImporter.Import(BandHelperFileName);

                if (ableSet is not null && bandHelper is not null)
                {
                    var setList = await SetListProcessor.Process(ableSet, bandHelper);
                    var fileName = saveFileDialog1.FileName;
                    var setListOutput = await _generator.GenerateSetList(setList);
                    File.WriteAllText(fileName, setListOutput);
                }
            }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            saveFileDialog1.AddExtension = true;
            saveFileDialog1.Filter = "*.json|*.json";
            saveFileDialog1.ShowDialog();
        }

        private void btnAbleSet_Click(object sender, EventArgs e)
        {
            fileDialogAbleSet.Filter = "Select Valid Document(*.json)|*.json";
            if (fileDialogAbleSet.ShowDialog() == DialogResult.OK)
            {
                if (fileDialogAbleSet.CheckFileExists) 
                {
                    AbleSetFileName = Path.GetFullPath(fileDialogAbleSet.FileName);
                    lblAbleset.Text = fileDialogAbleSet.FileName;
                }

            }            
        }

        private void btnBandHelper_Click(object sender, EventArgs e)
        {
            fileDialogBandHelper.Filter = "Select Valid Document(*.txt)|*.txt";
            if (fileDialogBandHelper.ShowDialog() == DialogResult.OK)
            {
                if (fileDialogBandHelper.CheckFileExists)
                {
                    BandHelperFileName = Path.GetFullPath(fileDialogBandHelper.FileName);
                    lblBandHelper.Text = fileDialogBandHelper.FileName;
                }

            }
        }
    }
}
