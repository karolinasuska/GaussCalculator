namespace GaussCalculator
{
    public partial class Form1 : Form
    {

        private List<(double[,], double[])> systems;
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


        private void CalculateButton_Click(object sender, EventArgs e)
        {

            if (systems == null || systems.Count == 0)
            {
                MessageBox.Show("Nie za³adowano uk³adów równañ. Proszê wybraæ plik.", "B³¹d");
                return;
            }

            int[] threadCounts = { 1, 2, 4, 8, 16, 32, 64 };
            int selectedThreadCount = threadCounts[threadTrackBar.Value];
            Console.Write($"Wybrano {selectedThreadCount} w¹tków.\n");

            resultsTextBox.Clear();

            var solutions = new List<double[]>();

            Parallel.ForEach(systems, new ParallelOptions { MaxDegreeOfParallelism = selectedThreadCount }, system =>
            {
                var (coefficients, results) = system;

                double[,] coefficientsCopy = (double[,])coefficients.Clone();
                double[] resultsCopy = (double[])results.Clone();

                double[] solution = EquationSolver.Solve(coefficientsCopy, resultsCopy, selectedThreadCount);

                lock (solutions)
                {
                    solutions.Add(solution);
                    resultsTextBox.BeginInvoke(new Action(() => DisplaySolution(solution)));
                }
            });
            MessageBox.Show("Obliczenia zakoñczone.", "Sukces!");
        }


        private void DisplaySolution(double[] solution)
        {
            resultsTextBox.AppendText("Rozwi¹zanie uk³adu:\n");

            for (int i = 0; i < solution.Length; i++)
            {
                resultsTextBox.AppendText($"x{i + 1} = {solution[i]:F4}\n");
            }

            resultsTextBox.AppendText("\n---------------------------------------------------\n");
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
                    systems = EquationProcessor.ParseEquations(filePath);
                    MessageBox.Show($"Za³adowano {systems.Count} uk³adów równañ.", "Sukces");

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
