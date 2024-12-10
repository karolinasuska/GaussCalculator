namespace GaussCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeCheckBoxes();
            InitializeThreadTrackBar();
        }

        private void InitializeCheckBoxes()
        {
            cCheckBox.Checked = true;
            asmCheckBox.Checked = false;
        }

        private void InitializeThreadTrackBar()
        {
            threadTrackBar.Minimum = 0;
            threadTrackBar.Maximum = 6;

            int processorCount = Environment.ProcessorCount;
            int[] threadCounts = { 1, 2, 4, 8, 16, 32, 64 };
            int selectedThreadCount = threadCounts.FirstOrDefault(count => count >= processorCount);

            if (selectedThreadCount == 0)
                selectedThreadCount = 1;

            threadTrackBar.Value = Array.IndexOf(threadCounts, selectedThreadCount);
            Console.WriteLine($"Domylna liczba procesorów logicznych: {processorCount}");
            Console.WriteLine($"Ustawiono {selectedThreadCount} w¹tków.");
        }


        private void calculateButton_Click(object sender, EventArgs e)
        {

        }

        private void ChooseFileButton(object sender, EventArgs e)
        {
            using OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog.Title = "Wybierz plik z uk³adami równañ";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                string fileContent = File.ReadAllText(filePath);

                fileContentsTextBox.Text = fileContent;

                try
                {
                    var systems = EquationProcessor.ParseEquations(filePath);
                    MessageBox.Show($"Za³adowano {systems.Count} uk³adów równañ.", "Sukces");

                    foreach (var (coefficients, results) in systems)
                    {
                        resultsTextBox.AppendText("Macierz wspó³czynnikow:\n");
                        for (int i = 0; i < coefficients.GetLength(0); i++)
                        {
                            for (int j = 0; j < coefficients.GetLength(1); j++)
                            {
                                resultsTextBox.AppendText($"{coefficients[i, j],5}");
                            }
                            resultsTextBox.AppendText("\n");
                        }

                        resultsTextBox.AppendText("\nWektor wyników:\n");
                        for (int i = 0; i < results.Length; i++)
                        {
                            resultsTextBox.AppendText($"{results[i],5}\n");
                        }

                        resultsTextBox.AppendText("\n---------------------------------------------------\n");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"B³¹d podczas przetwarzania danych: {ex.Message}", "B³¹d");
                }

            }
        }


        private void CCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (cCheckBox.Checked)
                asmCheckBox.Checked = false;
        }


        private void AsmCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (asmCheckBox.Checked)
                cCheckBox.Checked = false;
        }

        private void ThreadTrackBar_Scroll(object sender, EventArgs e)
        {
            int[] threadCounts = { 1, 2, 4, 8, 16, 32, 64 };
            int selectedThreadCount = threadCounts[threadTrackBar.Value];
            Console.WriteLine($"Ustawiono: {selectedThreadCount} w¹tków.");
        }
    }
}
