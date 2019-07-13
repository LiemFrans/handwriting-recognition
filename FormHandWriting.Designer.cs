namespace handwriting_recognition
{
    partial class FormHandWriting
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
            this.components = new System.ComponentModel.Container();
            this.imageListReal = new System.Windows.Forms.ImageList(this.components);
            this.bwLoadingPreprocessing = new System.ComponentModel.BackgroundWorker();
            this.imageListGrayscale = new System.Windows.Forms.ImageList(this.components);
            this.imageListFiltering = new System.Windows.Forms.ImageList(this.components);
            this.imageListBinary = new System.Windows.Forms.ImageList(this.components);
            this.imageListHorizontalProjector = new System.Windows.Forms.ImageList(this.components);
            this.bwExtractionFeature = new System.ComponentModel.BackgroundWorker();
            this.bwBPNN = new System.ComponentModel.BackgroundWorker();
            this.bwParagraph = new System.ComponentModel.BackgroundWorker();
            this.tabTestingDataParagraph = new System.Windows.Forms.TabPage();
            this.tlpParagraph = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel15 = new System.Windows.Forms.TableLayoutPanel();
            this.btnTestingDataParagraph = new System.Windows.Forms.Button();
            this.listViewParagraph = new System.Windows.Forms.ListView();
            this.tabTesting = new System.Windows.Forms.TabPage();
            this.tlpPengenalanParagraph = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel23 = new System.Windows.Forms.TableLayoutPanel();
            this.dataFiturParagraf = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel24 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel26 = new System.Windows.Forms.TableLayoutPanel();
            this.numHorizontally = new System.Windows.Forms.NumericUpDown();
            this.label39 = new System.Windows.Forms.Label();
            this.tableLayoutPanel25 = new System.Windows.Forms.TableLayoutPanel();
            this.numVertically = new System.Windows.Forms.NumericUpDown();
            this.label38 = new System.Windows.Forms.Label();
            this.listViewVertically = new System.Windows.Forms.ListView();
            this.listViewHorizontally = new System.Windows.Forms.ListView();
            this.tableLayoutPanel22 = new System.Windows.Forms.TableLayoutPanel();
            this.btnProfileProjection = new System.Windows.Forms.Button();
            this.btnFeatureExtractionParagraph = new System.Windows.Forms.Button();
            this.tableLayoutPanel13 = new System.Windows.Forms.TableLayoutPanel();
            this.btnShowRealImage = new System.Windows.Forms.Button();
            this.btnPreprocessingParagraph = new System.Windows.Forms.Button();
            this.tableLayoutPanel17 = new System.Windows.Forms.TableLayoutPanel();
            this.btnShowImageGrayscalling = new System.Windows.Forms.Button();
            this.tableLayoutPanel20 = new System.Windows.Forms.TableLayoutPanel();
            this.tbLengthGaussianFilterParagraph = new System.Windows.Forms.TextBox();
            this.tbWeightGaussianFilterParagraph = new System.Windows.Forms.TextBox();
            this.label37 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.btnShowImageGaussianFiltering = new System.Windows.Forms.Button();
            this.btnShowImageBinary = new System.Windows.Forms.Button();
            this.btnOpenImageParagraph = new System.Windows.Forms.Button();
            this.tabDataTrainingBPNN = new System.Windows.Forms.TabPage();
            this.tlpBPNN = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel21 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel16 = new System.Windows.Forms.TableLayoutPanel();
            this.checkDisplayWeight = new System.Windows.Forms.CheckBox();
            this.label28 = new System.Windows.Forms.Label();
            this.dgViewWeightResult = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel19 = new System.Windows.Forms.TableLayoutPanel();
            this.numMomentum = new System.Windows.Forms.NumericUpDown();
            this.label31 = new System.Windows.Forms.Label();
            this.btnTraining = new System.Windows.Forms.Button();
            this.numLayers = new System.Windows.Forms.NumericUpDown();
            this.label27 = new System.Windows.Forms.Label();
            this.numHiddenNeuron = new System.Windows.Forms.NumericUpDown();
            this.label26 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.numMaxEpochs = new System.Windows.Forms.NumericUpDown();
            this.label30 = new System.Windows.Forms.Label();
            this.numLearningRate = new System.Windows.Forms.NumericUpDown();
            this.tabDataTraining = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.dataFiturTraining = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel12 = new System.Windows.Forms.TableLayoutPanel();
            this.btnFeatureExtractionTraining = new System.Windows.Forms.Button();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.btnPreprocessingTraining = new System.Windows.Forms.Button();
            this.tableLayoutPanel29 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel30 = new System.Windows.Forms.TableLayoutPanel();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.numWeightGaussian = new System.Windows.Forms.NumericUpDown();
            this.numLengthGaussian = new System.Windows.Forms.NumericUpDown();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.listViewGrayscallingTraining = new System.Windows.Forms.ListView();
            this.listViewGaussianFilteringTraining = new System.Windows.Forms.ListView();
            this.listViewBinerisasiTraining = new System.Windows.Forms.ListView();
            this.btnOpenImageTraining = new System.Windows.Forms.Button();
            this.listViewRealImageTraining = new System.Windows.Forms.ListView();
            this.tabHome = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.pbMikroskil = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabBase = new System.Windows.Forms.TabControl();
            this.tabTestingDataParagraph.SuspendLayout();
            this.tlpParagraph.SuspendLayout();
            this.tableLayoutPanel15.SuspendLayout();
            this.tabTesting.SuspendLayout();
            this.tlpPengenalanParagraph.SuspendLayout();
            this.tableLayoutPanel23.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataFiturParagraf)).BeginInit();
            this.tableLayoutPanel24.SuspendLayout();
            this.tableLayoutPanel26.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numHorizontally)).BeginInit();
            this.tableLayoutPanel25.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numVertically)).BeginInit();
            this.tableLayoutPanel22.SuspendLayout();
            this.tableLayoutPanel13.SuspendLayout();
            this.tableLayoutPanel17.SuspendLayout();
            this.tableLayoutPanel20.SuspendLayout();
            this.tabDataTrainingBPNN.SuspendLayout();
            this.tlpBPNN.SuspendLayout();
            this.tableLayoutPanel21.SuspendLayout();
            this.tableLayoutPanel16.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgViewWeightResult)).BeginInit();
            this.tableLayoutPanel19.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMomentum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLayers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHiddenNeuron)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxEpochs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLearningRate)).BeginInit();
            this.tabDataTraining.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataFiturTraining)).BeginInit();
            this.tableLayoutPanel12.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel29.SuspendLayout();
            this.tableLayoutPanel30.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numWeightGaussian)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLengthGaussian)).BeginInit();
            this.tabHome.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMikroskil)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tabBase.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageListReal
            // 
            this.imageListReal.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageListReal.ImageSize = new System.Drawing.Size(16, 16);
            this.imageListReal.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // bwLoadingPreprocessing
            // 
            this.bwLoadingPreprocessing.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwLoadingPreprocessing_DoWork);
            this.bwLoadingPreprocessing.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwLoadingPreprocessing_RunWorkerCompleted);
            // 
            // imageListGrayscale
            // 
            this.imageListGrayscale.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageListGrayscale.ImageSize = new System.Drawing.Size(16, 16);
            this.imageListGrayscale.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // imageListFiltering
            // 
            this.imageListFiltering.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageListFiltering.ImageSize = new System.Drawing.Size(16, 16);
            this.imageListFiltering.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // imageListBinary
            // 
            this.imageListBinary.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageListBinary.ImageSize = new System.Drawing.Size(16, 16);
            this.imageListBinary.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // imageListHorizontalProjector
            // 
            this.imageListHorizontalProjector.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageListHorizontalProjector.ImageSize = new System.Drawing.Size(16, 16);
            this.imageListHorizontalProjector.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // bwExtractionFeature
            // 
            this.bwExtractionFeature.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwExtractionFeature_DoWork);
            this.bwExtractionFeature.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwExtractionFeature_RunWorkerCompleted);
            // 
            // bwBPNN
            // 
            this.bwBPNN.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwBPNN_DoWork);
            this.bwBPNN.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwBPNN_RunWorkerCompleted);
            // 
            // bwParagraph
            // 
            this.bwParagraph.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwParagraph_DoWork);
            this.bwParagraph.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwParagraph_RunWorkerCompleted);
            // 
            // tabTestingDataParagraph
            // 
            this.tabTestingDataParagraph.Controls.Add(this.tlpParagraph);
            this.tabTestingDataParagraph.Location = new System.Drawing.Point(4, 22);
            this.tabTestingDataParagraph.Name = "tabTestingDataParagraph";
            this.tabTestingDataParagraph.Size = new System.Drawing.Size(1312, 670);
            this.tabTestingDataParagraph.TabIndex = 6;
            this.tabTestingDataParagraph.Text = "Pengujian Data Paragraph";
            this.tabTestingDataParagraph.UseVisualStyleBackColor = true;
            // 
            // tlpParagraph
            // 
            this.tlpParagraph.ColumnCount = 1;
            this.tlpParagraph.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpParagraph.Controls.Add(this.listViewParagraph, 0, 1);
            this.tlpParagraph.Controls.Add(this.tableLayoutPanel15, 0, 0);
            this.tlpParagraph.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpParagraph.Enabled = false;
            this.tlpParagraph.Location = new System.Drawing.Point(0, 0);
            this.tlpParagraph.Name = "tlpParagraph";
            this.tlpParagraph.RowCount = 2;
            this.tlpParagraph.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.268657F));
            this.tlpParagraph.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 93.73135F));
            this.tlpParagraph.Size = new System.Drawing.Size(1312, 670);
            this.tlpParagraph.TabIndex = 1;
            // 
            // tableLayoutPanel15
            // 
            this.tableLayoutPanel15.ColumnCount = 2;
            this.tableLayoutPanel15.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel15.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel15.Controls.Add(this.btnTestingDataParagraph, 0, 0);
            this.tableLayoutPanel15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel15.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel15.Name = "tableLayoutPanel15";
            this.tableLayoutPanel15.RowCount = 1;
            this.tableLayoutPanel15.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel15.Size = new System.Drawing.Size(1306, 36);
            this.tableLayoutPanel15.TabIndex = 1;
            // 
            // btnTestingDataParagraph
            // 
            this.btnTestingDataParagraph.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTestingDataParagraph.Location = new System.Drawing.Point(3, 3);
            this.btnTestingDataParagraph.Name = "btnTestingDataParagraph";
            this.btnTestingDataParagraph.Size = new System.Drawing.Size(647, 30);
            this.btnTestingDataParagraph.TabIndex = 0;
            this.btnTestingDataParagraph.Text = "Testing Data";
            this.btnTestingDataParagraph.UseVisualStyleBackColor = true;
            this.btnTestingDataParagraph.Click += new System.EventHandler(this.btnTestingDataParagraph_Click);
            // 
            // listViewParagraph
            // 
            this.listViewParagraph.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewParagraph.Location = new System.Drawing.Point(3, 45);
            this.listViewParagraph.Name = "listViewParagraph";
            this.listViewParagraph.Size = new System.Drawing.Size(1306, 622);
            this.listViewParagraph.TabIndex = 0;
            this.listViewParagraph.UseCompatibleStateImageBehavior = false;
            // 
            // tabTesting
            // 
            this.tabTesting.Controls.Add(this.tlpPengenalanParagraph);
            this.tabTesting.Location = new System.Drawing.Point(4, 22);
            this.tabTesting.Name = "tabTesting";
            this.tabTesting.Size = new System.Drawing.Size(1312, 670);
            this.tabTesting.TabIndex = 2;
            this.tabTesting.Text = "Pengenalan";
            this.tabTesting.UseVisualStyleBackColor = true;
            // 
            // tlpPengenalanParagraph
            // 
            this.tlpPengenalanParagraph.ColumnCount = 1;
            this.tlpPengenalanParagraph.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPengenalanParagraph.Controls.Add(this.tableLayoutPanel13, 0, 0);
            this.tlpPengenalanParagraph.Controls.Add(this.tableLayoutPanel22, 0, 2);
            this.tlpPengenalanParagraph.Controls.Add(this.tableLayoutPanel23, 0, 1);
            this.tlpPengenalanParagraph.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPengenalanParagraph.Enabled = false;
            this.tlpPengenalanParagraph.Location = new System.Drawing.Point(0, 0);
            this.tlpPengenalanParagraph.Name = "tlpPengenalanParagraph";
            this.tlpPengenalanParagraph.RowCount = 3;
            this.tlpPengenalanParagraph.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.19702F));
            this.tlpPengenalanParagraph.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.19702F));
            this.tlpPengenalanParagraph.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.605968F));
            this.tlpPengenalanParagraph.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpPengenalanParagraph.Size = new System.Drawing.Size(1312, 670);
            this.tlpPengenalanParagraph.TabIndex = 1;
            // 
            // tableLayoutPanel23
            // 
            this.tableLayoutPanel23.ColumnCount = 2;
            this.tableLayoutPanel23.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel23.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel23.Controls.Add(this.tableLayoutPanel24, 0, 0);
            this.tableLayoutPanel23.Controls.Add(this.dataFiturParagraf, 1, 0);
            this.tableLayoutPanel23.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel23.Location = new System.Drawing.Point(3, 312);
            this.tableLayoutPanel23.Name = "tableLayoutPanel23";
            this.tableLayoutPanel23.RowCount = 1;
            this.tableLayoutPanel23.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.56106F));
            this.tableLayoutPanel23.Size = new System.Drawing.Size(1306, 303);
            this.tableLayoutPanel23.TabIndex = 4;
            // 
            // dataFiturParagraf
            // 
            this.dataFiturParagraf.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataFiturParagraf.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataFiturParagraf.Location = new System.Drawing.Point(656, 3);
            this.dataFiturParagraf.Name = "dataFiturParagraf";
            this.dataFiturParagraf.Size = new System.Drawing.Size(647, 297);
            this.dataFiturParagraf.TabIndex = 1;
            // 
            // tableLayoutPanel24
            // 
            this.tableLayoutPanel24.ColumnCount = 2;
            this.tableLayoutPanel24.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel24.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel24.Controls.Add(this.listViewHorizontally, 1, 1);
            this.tableLayoutPanel24.Controls.Add(this.listViewVertically, 0, 1);
            this.tableLayoutPanel24.Controls.Add(this.tableLayoutPanel25, 0, 0);
            this.tableLayoutPanel24.Controls.Add(this.tableLayoutPanel26, 1, 0);
            this.tableLayoutPanel24.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel24.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel24.Name = "tableLayoutPanel24";
            this.tableLayoutPanel24.RowCount = 2;
            this.tableLayoutPanel24.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.10101F));
            this.tableLayoutPanel24.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89.89899F));
            this.tableLayoutPanel24.Size = new System.Drawing.Size(647, 297);
            this.tableLayoutPanel24.TabIndex = 0;
            // 
            // tableLayoutPanel26
            // 
            this.tableLayoutPanel26.ColumnCount = 2;
            this.tableLayoutPanel26.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel26.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel26.Controls.Add(this.label39, 0, 0);
            this.tableLayoutPanel26.Controls.Add(this.numHorizontally, 1, 0);
            this.tableLayoutPanel26.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel26.Location = new System.Drawing.Point(326, 3);
            this.tableLayoutPanel26.Name = "tableLayoutPanel26";
            this.tableLayoutPanel26.RowCount = 1;
            this.tableLayoutPanel26.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel26.Size = new System.Drawing.Size(318, 24);
            this.tableLayoutPanel26.TabIndex = 5;
            // 
            // numHorizontally
            // 
            this.numHorizontally.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numHorizontally.Enabled = false;
            this.numHorizontally.Location = new System.Drawing.Point(162, 3);
            this.numHorizontally.Name = "numHorizontally";
            this.numHorizontally.Size = new System.Drawing.Size(153, 20);
            this.numHorizontally.TabIndex = 1;
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label39.Location = new System.Drawing.Point(3, 0);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(153, 24);
            this.label39.TabIndex = 0;
            this.label39.Text = "Threshold Horizontally (%)";
            this.label39.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel25
            // 
            this.tableLayoutPanel25.ColumnCount = 2;
            this.tableLayoutPanel25.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel25.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel25.Controls.Add(this.label38, 0, 0);
            this.tableLayoutPanel25.Controls.Add(this.numVertically, 1, 0);
            this.tableLayoutPanel25.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel25.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel25.Name = "tableLayoutPanel25";
            this.tableLayoutPanel25.RowCount = 1;
            this.tableLayoutPanel25.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel25.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel25.Size = new System.Drawing.Size(317, 24);
            this.tableLayoutPanel25.TabIndex = 4;
            // 
            // numVertically
            // 
            this.numVertically.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numVertically.Enabled = false;
            this.numVertically.Location = new System.Drawing.Point(161, 3);
            this.numVertically.Name = "numVertically";
            this.numVertically.Size = new System.Drawing.Size(153, 20);
            this.numVertically.TabIndex = 1;
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label38.Location = new System.Drawing.Point(3, 0);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(152, 24);
            this.label38.TabIndex = 0;
            this.label38.Text = "Threshold Vertically (%)";
            this.label38.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listViewVertically
            // 
            this.listViewVertically.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewVertically.Location = new System.Drawing.Point(3, 33);
            this.listViewVertically.Name = "listViewVertically";
            this.listViewVertically.Size = new System.Drawing.Size(317, 261);
            this.listViewVertically.TabIndex = 0;
            this.listViewVertically.UseCompatibleStateImageBehavior = false;
            // 
            // listViewHorizontally
            // 
            this.listViewHorizontally.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewHorizontally.Location = new System.Drawing.Point(326, 33);
            this.listViewHorizontally.Name = "listViewHorizontally";
            this.listViewHorizontally.Size = new System.Drawing.Size(318, 261);
            this.listViewHorizontally.TabIndex = 3;
            this.listViewHorizontally.UseCompatibleStateImageBehavior = false;
            // 
            // tableLayoutPanel22
            // 
            this.tableLayoutPanel22.ColumnCount = 2;
            this.tableLayoutPanel22.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel22.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel22.Controls.Add(this.btnFeatureExtractionParagraph, 1, 0);
            this.tableLayoutPanel22.Controls.Add(this.btnProfileProjection, 0, 0);
            this.tableLayoutPanel22.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel22.Location = new System.Drawing.Point(3, 621);
            this.tableLayoutPanel22.Name = "tableLayoutPanel22";
            this.tableLayoutPanel22.RowCount = 1;
            this.tableLayoutPanel22.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel22.Size = new System.Drawing.Size(1306, 46);
            this.tableLayoutPanel22.TabIndex = 3;
            // 
            // btnProfileProjection
            // 
            this.btnProfileProjection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnProfileProjection.Enabled = false;
            this.btnProfileProjection.Location = new System.Drawing.Point(3, 3);
            this.btnProfileProjection.Name = "btnProfileProjection";
            this.btnProfileProjection.Size = new System.Drawing.Size(647, 40);
            this.btnProfileProjection.TabIndex = 3;
            this.btnProfileProjection.Text = "Profile Projection";
            this.btnProfileProjection.UseVisualStyleBackColor = true;
            this.btnProfileProjection.Click += new System.EventHandler(this.btnProfileProjection_Click);
            // 
            // btnFeatureExtractionParagraph
            // 
            this.btnFeatureExtractionParagraph.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFeatureExtractionParagraph.Enabled = false;
            this.btnFeatureExtractionParagraph.Location = new System.Drawing.Point(656, 3);
            this.btnFeatureExtractionParagraph.Name = "btnFeatureExtractionParagraph";
            this.btnFeatureExtractionParagraph.Size = new System.Drawing.Size(647, 40);
            this.btnFeatureExtractionParagraph.TabIndex = 2;
            this.btnFeatureExtractionParagraph.Text = "Extraksi Ciri";
            this.btnFeatureExtractionParagraph.UseVisualStyleBackColor = true;
            this.btnFeatureExtractionParagraph.Click += new System.EventHandler(this.btnFeatureExtractionParagraph_Click);
            // 
            // tableLayoutPanel13
            // 
            this.tableLayoutPanel13.ColumnCount = 2;
            this.tableLayoutPanel13.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.23077F));
            this.tableLayoutPanel13.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 79.76923F));
            this.tableLayoutPanel13.Controls.Add(this.btnOpenImageParagraph, 0, 1);
            this.tableLayoutPanel13.Controls.Add(this.tableLayoutPanel17, 1, 0);
            this.tableLayoutPanel13.Controls.Add(this.btnPreprocessingParagraph, 1, 1);
            this.tableLayoutPanel13.Controls.Add(this.btnShowRealImage, 0, 0);
            this.tableLayoutPanel13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel13.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel13.Name = "tableLayoutPanel13";
            this.tableLayoutPanel13.RowCount = 2;
            this.tableLayoutPanel13.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 82.52427F));
            this.tableLayoutPanel13.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.47573F));
            this.tableLayoutPanel13.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel13.Size = new System.Drawing.Size(1306, 303);
            this.tableLayoutPanel13.TabIndex = 0;
            // 
            // btnShowRealImage
            // 
            this.btnShowRealImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnShowRealImage.Enabled = false;
            this.btnShowRealImage.Location = new System.Drawing.Point(3, 3);
            this.btnShowRealImage.Name = "btnShowRealImage";
            this.btnShowRealImage.Size = new System.Drawing.Size(258, 244);
            this.btnShowRealImage.TabIndex = 7;
            this.btnShowRealImage.Text = "Tampilkan Gambar";
            this.btnShowRealImage.UseVisualStyleBackColor = true;
            this.btnShowRealImage.Click += new System.EventHandler(this.btnShowRealImage_Click);
            // 
            // btnPreprocessingParagraph
            // 
            this.btnPreprocessingParagraph.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPreprocessingParagraph.Enabled = false;
            this.btnPreprocessingParagraph.Location = new System.Drawing.Point(267, 253);
            this.btnPreprocessingParagraph.Name = "btnPreprocessingParagraph";
            this.btnPreprocessingParagraph.Size = new System.Drawing.Size(1036, 47);
            this.btnPreprocessingParagraph.TabIndex = 6;
            this.btnPreprocessingParagraph.Text = "Preprocessing Paragraph";
            this.btnPreprocessingParagraph.UseVisualStyleBackColor = true;
            this.btnPreprocessingParagraph.Click += new System.EventHandler(this.btnPreprocessingParagraph_Click);
            // 
            // tableLayoutPanel17
            // 
            this.tableLayoutPanel17.ColumnCount = 4;
            this.tableLayoutPanel17.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel17.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel17.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel17.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel17.Controls.Add(this.btnShowImageBinary, 3, 0);
            this.tableLayoutPanel17.Controls.Add(this.btnShowImageGaussianFiltering, 2, 0);
            this.tableLayoutPanel17.Controls.Add(this.label32, 0, 1);
            this.tableLayoutPanel17.Controls.Add(this.label33, 0, 1);
            this.tableLayoutPanel17.Controls.Add(this.label34, 1, 1);
            this.tableLayoutPanel17.Controls.Add(this.label35, 2, 1);
            this.tableLayoutPanel17.Controls.Add(this.tableLayoutPanel20, 0, 0);
            this.tableLayoutPanel17.Controls.Add(this.btnShowImageGrayscalling, 1, 0);
            this.tableLayoutPanel17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel17.Location = new System.Drawing.Point(267, 3);
            this.tableLayoutPanel17.Name = "tableLayoutPanel17";
            this.tableLayoutPanel17.RowCount = 2;
            this.tableLayoutPanel17.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 82.20859F));
            this.tableLayoutPanel17.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.79141F));
            this.tableLayoutPanel17.Size = new System.Drawing.Size(1036, 244);
            this.tableLayoutPanel17.TabIndex = 5;
            // 
            // btnShowImageGrayscalling
            // 
            this.btnShowImageGrayscalling.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnShowImageGrayscalling.Enabled = false;
            this.btnShowImageGrayscalling.Location = new System.Drawing.Point(262, 3);
            this.btnShowImageGrayscalling.Name = "btnShowImageGrayscalling";
            this.btnShowImageGrayscalling.Size = new System.Drawing.Size(253, 194);
            this.btnShowImageGrayscalling.TabIndex = 5;
            this.btnShowImageGrayscalling.Text = "Tampilkan Gambar";
            this.btnShowImageGrayscalling.UseVisualStyleBackColor = true;
            this.btnShowImageGrayscalling.Click += new System.EventHandler(this.btnShowImageGrayscalling_Click);
            // 
            // tableLayoutPanel20
            // 
            this.tableLayoutPanel20.ColumnCount = 2;
            this.tableLayoutPanel20.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel20.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 175F));
            this.tableLayoutPanel20.Controls.Add(this.label36, 0, 0);
            this.tableLayoutPanel20.Controls.Add(this.label37, 0, 1);
            this.tableLayoutPanel20.Controls.Add(this.tbWeightGaussianFilterParagraph, 0, 1);
            this.tableLayoutPanel20.Controls.Add(this.tbLengthGaussianFilterParagraph, 1, 0);
            this.tableLayoutPanel20.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel20.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel20.Name = "tableLayoutPanel20";
            this.tableLayoutPanel20.RowCount = 2;
            this.tableLayoutPanel20.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel20.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel20.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel20.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel20.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel20.Size = new System.Drawing.Size(253, 194);
            this.tableLayoutPanel20.TabIndex = 4;
            // 
            // tbLengthGaussianFilterParagraph
            // 
            this.tbLengthGaussianFilterParagraph.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbLengthGaussianFilterParagraph.Enabled = false;
            this.tbLengthGaussianFilterParagraph.Location = new System.Drawing.Point(81, 3);
            this.tbLengthGaussianFilterParagraph.Name = "tbLengthGaussianFilterParagraph";
            this.tbLengthGaussianFilterParagraph.Size = new System.Drawing.Size(169, 20);
            this.tbLengthGaussianFilterParagraph.TabIndex = 6;
            // 
            // tbWeightGaussianFilterParagraph
            // 
            this.tbWeightGaussianFilterParagraph.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbWeightGaussianFilterParagraph.Enabled = false;
            this.tbWeightGaussianFilterParagraph.Location = new System.Drawing.Point(81, 100);
            this.tbWeightGaussianFilterParagraph.Name = "tbWeightGaussianFilterParagraph";
            this.tbWeightGaussianFilterParagraph.Size = new System.Drawing.Size(169, 20);
            this.tbWeightGaussianFilterParagraph.TabIndex = 5;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label37.Location = new System.Drawing.Point(3, 97);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(72, 97);
            this.label37.TabIndex = 3;
            this.label37.Text = "Bobot Gaussian Filter";
            this.label37.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label36.Location = new System.Drawing.Point(3, 0);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(72, 97);
            this.label36.TabIndex = 2;
            this.label36.Text = "Panjang Gaussian Filter";
            this.label36.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label35.Location = new System.Drawing.Point(780, 200);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(253, 44);
            this.label35.TabIndex = 2;
            this.label35.Text = "Binerisasi";
            this.label35.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label34.Location = new System.Drawing.Point(521, 200);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(253, 44);
            this.label34.TabIndex = 1;
            this.label34.Text = "Gaussian Filtering";
            this.label34.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label33.Location = new System.Drawing.Point(262, 200);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(253, 44);
            this.label33.TabIndex = 0;
            this.label33.Text = "Grayscalling";
            this.label33.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label32.Location = new System.Drawing.Point(3, 200);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(253, 44);
            this.label32.TabIndex = 3;
            this.label32.Text = "Parameter Bebas";
            this.label32.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnShowImageGaussianFiltering
            // 
            this.btnShowImageGaussianFiltering.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnShowImageGaussianFiltering.Enabled = false;
            this.btnShowImageGaussianFiltering.Location = new System.Drawing.Point(521, 3);
            this.btnShowImageGaussianFiltering.Name = "btnShowImageGaussianFiltering";
            this.btnShowImageGaussianFiltering.Size = new System.Drawing.Size(253, 194);
            this.btnShowImageGaussianFiltering.TabIndex = 6;
            this.btnShowImageGaussianFiltering.Text = "Tamplikan Gambar";
            this.btnShowImageGaussianFiltering.UseVisualStyleBackColor = true;
            this.btnShowImageGaussianFiltering.Click += new System.EventHandler(this.btnShowImageGaussianFiltering_Click);
            // 
            // btnShowImageBinary
            // 
            this.btnShowImageBinary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnShowImageBinary.Enabled = false;
            this.btnShowImageBinary.Location = new System.Drawing.Point(780, 3);
            this.btnShowImageBinary.Name = "btnShowImageBinary";
            this.btnShowImageBinary.Size = new System.Drawing.Size(253, 194);
            this.btnShowImageBinary.TabIndex = 7;
            this.btnShowImageBinary.Text = "Tampilkan Gambar";
            this.btnShowImageBinary.UseVisualStyleBackColor = true;
            this.btnShowImageBinary.Click += new System.EventHandler(this.btnShowImageBinary_Click);
            // 
            // btnOpenImageParagraph
            // 
            this.btnOpenImageParagraph.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOpenImageParagraph.Location = new System.Drawing.Point(3, 253);
            this.btnOpenImageParagraph.Name = "btnOpenImageParagraph";
            this.btnOpenImageParagraph.Size = new System.Drawing.Size(258, 47);
            this.btnOpenImageParagraph.TabIndex = 4;
            this.btnOpenImageParagraph.Text = "Open Image Paragraph";
            this.btnOpenImageParagraph.UseVisualStyleBackColor = true;
            this.btnOpenImageParagraph.Click += new System.EventHandler(this.btnOpenImageParagraph_Click);
            // 
            // tabDataTrainingBPNN
            // 
            this.tabDataTrainingBPNN.Controls.Add(this.tlpBPNN);
            this.tabDataTrainingBPNN.Location = new System.Drawing.Point(4, 22);
            this.tabDataTrainingBPNN.Name = "tabDataTrainingBPNN";
            this.tabDataTrainingBPNN.Size = new System.Drawing.Size(1312, 670);
            this.tabDataTrainingBPNN.TabIndex = 4;
            this.tabDataTrainingBPNN.Text = "Data Pelatihan (Proses) BPNN";
            this.tabDataTrainingBPNN.UseVisualStyleBackColor = true;
            // 
            // tlpBPNN
            // 
            this.tlpBPNN.ColumnCount = 1;
            this.tlpBPNN.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBPNN.Controls.Add(this.tableLayoutPanel19, 0, 0);
            this.tlpBPNN.Controls.Add(this.tableLayoutPanel21, 0, 1);
            this.tlpBPNN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpBPNN.Enabled = false;
            this.tlpBPNN.Location = new System.Drawing.Point(0, 0);
            this.tlpBPNN.Name = "tlpBPNN";
            this.tlpBPNN.RowCount = 2;
            this.tlpBPNN.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.253732F));
            this.tlpBPNN.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.74627F));
            this.tlpBPNN.Size = new System.Drawing.Size(1312, 670);
            this.tlpBPNN.TabIndex = 0;
            // 
            // tableLayoutPanel21
            // 
            this.tableLayoutPanel21.ColumnCount = 1;
            this.tableLayoutPanel21.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel21.Controls.Add(this.dgViewWeightResult, 0, 1);
            this.tableLayoutPanel21.Controls.Add(this.tableLayoutPanel16, 0, 0);
            this.tableLayoutPanel21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel21.Location = new System.Drawing.Point(3, 65);
            this.tableLayoutPanel21.Name = "tableLayoutPanel21";
            this.tableLayoutPanel21.RowCount = 2;
            this.tableLayoutPanel21.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.637874F));
            this.tableLayoutPanel21.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.36213F));
            this.tableLayoutPanel21.Size = new System.Drawing.Size(1306, 602);
            this.tableLayoutPanel21.TabIndex = 2;
            // 
            // tableLayoutPanel16
            // 
            this.tableLayoutPanel16.ColumnCount = 2;
            this.tableLayoutPanel16.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel16.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel16.Controls.Add(this.label28, 0, 0);
            this.tableLayoutPanel16.Controls.Add(this.checkDisplayWeight, 1, 0);
            this.tableLayoutPanel16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel16.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel16.Name = "tableLayoutPanel16";
            this.tableLayoutPanel16.RowCount = 1;
            this.tableLayoutPanel16.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel16.Size = new System.Drawing.Size(1300, 45);
            this.tableLayoutPanel16.TabIndex = 2;
            // 
            // checkDisplayWeight
            // 
            this.checkDisplayWeight.AutoSize = true;
            this.checkDisplayWeight.Location = new System.Drawing.Point(653, 3);
            this.checkDisplayWeight.Name = "checkDisplayWeight";
            this.checkDisplayWeight.Size = new System.Drawing.Size(190, 17);
            this.checkDisplayWeight.TabIndex = 2;
            this.checkDisplayWeight.Text = "Tampilkan bobot akhir pada table?";
            this.checkDisplayWeight.UseVisualStyleBackColor = true;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(3, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(644, 45);
            this.label28.TabIndex = 1;
            this.label28.Text = "Bobot Akhir BPNN";
            this.label28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgViewWeightResult
            // 
            this.dgViewWeightResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgViewWeightResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgViewWeightResult.Location = new System.Drawing.Point(3, 54);
            this.dgViewWeightResult.Name = "dgViewWeightResult";
            this.dgViewWeightResult.Size = new System.Drawing.Size(1300, 545);
            this.dgViewWeightResult.TabIndex = 1;
            // 
            // tableLayoutPanel19
            // 
            this.tableLayoutPanel19.ColumnCount = 11;
            this.tableLayoutPanel19.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel19.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel19.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel19.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel19.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel19.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel19.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel19.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel19.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel19.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel19.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel19.Controls.Add(this.numLearningRate, 7, 0);
            this.tableLayoutPanel19.Controls.Add(this.label30, 6, 0);
            this.tableLayoutPanel19.Controls.Add(this.numMaxEpochs, 5, 0);
            this.tableLayoutPanel19.Controls.Add(this.label29, 4, 0);
            this.tableLayoutPanel19.Controls.Add(this.label26, 0, 0);
            this.tableLayoutPanel19.Controls.Add(this.numHiddenNeuron, 1, 0);
            this.tableLayoutPanel19.Controls.Add(this.label27, 2, 0);
            this.tableLayoutPanel19.Controls.Add(this.numLayers, 3, 0);
            this.tableLayoutPanel19.Controls.Add(this.btnTraining, 10, 0);
            this.tableLayoutPanel19.Controls.Add(this.label31, 8, 0);
            this.tableLayoutPanel19.Controls.Add(this.numMomentum, 9, 0);
            this.tableLayoutPanel19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel19.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel19.Name = "tableLayoutPanel19";
            this.tableLayoutPanel19.RowCount = 1;
            this.tableLayoutPanel19.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel19.Size = new System.Drawing.Size(1306, 56);
            this.tableLayoutPanel19.TabIndex = 1;
            // 
            // numMomentum
            // 
            this.numMomentum.DecimalPlaces = 5;
            this.numMomentum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numMomentum.Increment = new decimal(new int[] {
            1,
            0,
            0,
            327680});
            this.numMomentum.Location = new System.Drawing.Point(1065, 3);
            this.numMomentum.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numMomentum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            327680});
            this.numMomentum.Name = "numMomentum";
            this.numMomentum.Size = new System.Drawing.Size(112, 20);
            this.numMomentum.TabIndex = 9;
            this.numMomentum.Value = new decimal(new int[] {
            1,
            0,
            0,
            327680});
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label31.Location = new System.Drawing.Point(947, 0);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(112, 56);
            this.label31.TabIndex = 8;
            this.label31.Text = "Momentum";
            // 
            // btnTraining
            // 
            this.btnTraining.Location = new System.Drawing.Point(1183, 3);
            this.btnTraining.Name = "btnTraining";
            this.btnTraining.Size = new System.Drawing.Size(120, 50);
            this.btnTraining.TabIndex = 1;
            this.btnTraining.Text = "Training";
            this.btnTraining.UseVisualStyleBackColor = true;
            this.btnTraining.Click += new System.EventHandler(this.btnTraining_Click);
            // 
            // numLayers
            // 
            this.numLayers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numLayers.Location = new System.Drawing.Point(357, 3);
            this.numLayers.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numLayers.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numLayers.Name = "numLayers";
            this.numLayers.Size = new System.Drawing.Size(112, 20);
            this.numLayers.TabIndex = 0;
            this.numLayers.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label27.Location = new System.Drawing.Point(239, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(112, 56);
            this.label27.TabIndex = 3;
            this.label27.Text = "Jumlah Layer";
            // 
            // numHiddenNeuron
            // 
            this.numHiddenNeuron.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numHiddenNeuron.Location = new System.Drawing.Point(121, 3);
            this.numHiddenNeuron.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numHiddenNeuron.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numHiddenNeuron.Name = "numHiddenNeuron";
            this.numHiddenNeuron.Size = new System.Drawing.Size(112, 20);
            this.numHiddenNeuron.TabIndex = 2;
            this.numHiddenNeuron.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label26.Location = new System.Drawing.Point(3, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(112, 56);
            this.label26.TabIndex = 1;
            this.label26.Text = "Jumlah Hidden Neuron";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label29.Location = new System.Drawing.Point(475, 0);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(112, 56);
            this.label29.TabIndex = 4;
            this.label29.Text = "Maximum Epochs";
            // 
            // numMaxEpochs
            // 
            this.numMaxEpochs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numMaxEpochs.Location = new System.Drawing.Point(593, 3);
            this.numMaxEpochs.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numMaxEpochs.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numMaxEpochs.Name = "numMaxEpochs";
            this.numMaxEpochs.Size = new System.Drawing.Size(112, 20);
            this.numMaxEpochs.TabIndex = 5;
            this.numMaxEpochs.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label30.Location = new System.Drawing.Point(711, 0);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(112, 56);
            this.label30.TabIndex = 6;
            this.label30.Text = "Learning Rate";
            // 
            // numLearningRate
            // 
            this.numLearningRate.DecimalPlaces = 5;
            this.numLearningRate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numLearningRate.Increment = new decimal(new int[] {
            1,
            0,
            0,
            327680});
            this.numLearningRate.Location = new System.Drawing.Point(829, 3);
            this.numLearningRate.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numLearningRate.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            327680});
            this.numLearningRate.Name = "numLearningRate";
            this.numLearningRate.Size = new System.Drawing.Size(112, 20);
            this.numLearningRate.TabIndex = 7;
            this.numLearningRate.Value = new decimal(new int[] {
            1,
            0,
            0,
            327680});
            // 
            // tabDataTraining
            // 
            this.tabDataTraining.Controls.Add(this.tableLayoutPanel6);
            this.tabDataTraining.Location = new System.Drawing.Point(4, 22);
            this.tabDataTraining.Name = "tabDataTraining";
            this.tabDataTraining.Padding = new System.Windows.Forms.Padding(3);
            this.tabDataTraining.Size = new System.Drawing.Size(1312, 670);
            this.tabDataTraining.TabIndex = 1;
            this.tabDataTraining.Text = "Data Pelatihan";
            this.tabDataTraining.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Controls.Add(this.tableLayoutPanel7, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.tableLayoutPanel12, 0, 2);
            this.tableLayoutPanel6.Controls.Add(this.dataFiturTraining, 0, 1);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 3;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.19702F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.19702F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.605968F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(1306, 664);
            this.tableLayoutPanel6.TabIndex = 0;
            // 
            // dataFiturTraining
            // 
            this.dataFiturTraining.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataFiturTraining.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataFiturTraining.Location = new System.Drawing.Point(3, 309);
            this.dataFiturTraining.Name = "dataFiturTraining";
            this.dataFiturTraining.ReadOnly = true;
            this.dataFiturTraining.Size = new System.Drawing.Size(1300, 300);
            this.dataFiturTraining.TabIndex = 4;
            // 
            // tableLayoutPanel12
            // 
            this.tableLayoutPanel12.ColumnCount = 2;
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel12.Controls.Add(this.btnFeatureExtractionTraining, 0, 0);
            this.tableLayoutPanel12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel12.Location = new System.Drawing.Point(3, 615);
            this.tableLayoutPanel12.Name = "tableLayoutPanel12";
            this.tableLayoutPanel12.RowCount = 1;
            this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel12.Size = new System.Drawing.Size(1300, 46);
            this.tableLayoutPanel12.TabIndex = 3;
            // 
            // btnFeatureExtractionTraining
            // 
            this.btnFeatureExtractionTraining.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnFeatureExtractionTraining.Enabled = false;
            this.btnFeatureExtractionTraining.Location = new System.Drawing.Point(572, 3);
            this.btnFeatureExtractionTraining.Name = "btnFeatureExtractionTraining";
            this.btnFeatureExtractionTraining.Size = new System.Drawing.Size(75, 40);
            this.btnFeatureExtractionTraining.TabIndex = 2;
            this.btnFeatureExtractionTraining.Text = "Extraksi Ciri";
            this.btnFeatureExtractionTraining.UseVisualStyleBackColor = true;
            this.btnFeatureExtractionTraining.Click += new System.EventHandler(this.btnFeatureExtractionTraining_Click);
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 2;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.23077F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 79.76923F));
            this.tableLayoutPanel7.Controls.Add(this.listViewRealImageTraining, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.btnOpenImageTraining, 0, 1);
            this.tableLayoutPanel7.Controls.Add(this.tableLayoutPanel29, 1, 0);
            this.tableLayoutPanel7.Controls.Add(this.btnPreprocessingTraining, 1, 1);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 2;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 82.52427F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.47573F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(1300, 300);
            this.tableLayoutPanel7.TabIndex = 0;
            // 
            // btnPreprocessingTraining
            // 
            this.btnPreprocessingTraining.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPreprocessingTraining.Enabled = false;
            this.btnPreprocessingTraining.Location = new System.Drawing.Point(266, 250);
            this.btnPreprocessingTraining.Name = "btnPreprocessingTraining";
            this.btnPreprocessingTraining.Size = new System.Drawing.Size(1031, 47);
            this.btnPreprocessingTraining.TabIndex = 6;
            this.btnPreprocessingTraining.Text = "Preprocessing";
            this.btnPreprocessingTraining.UseVisualStyleBackColor = true;
            this.btnPreprocessingTraining.Click += new System.EventHandler(this.btnPreprocessingTraining_Click);
            // 
            // tableLayoutPanel29
            // 
            this.tableLayoutPanel29.ColumnCount = 4;
            this.tableLayoutPanel29.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel29.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel29.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel29.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel29.Controls.Add(this.listViewBinerisasiTraining, 3, 0);
            this.tableLayoutPanel29.Controls.Add(this.listViewGaussianFilteringTraining, 2, 0);
            this.tableLayoutPanel29.Controls.Add(this.listViewGrayscallingTraining, 1, 0);
            this.tableLayoutPanel29.Controls.Add(this.label17, 0, 1);
            this.tableLayoutPanel29.Controls.Add(this.label14, 0, 1);
            this.tableLayoutPanel29.Controls.Add(this.label15, 1, 1);
            this.tableLayoutPanel29.Controls.Add(this.label16, 2, 1);
            this.tableLayoutPanel29.Controls.Add(this.tableLayoutPanel30, 0, 0);
            this.tableLayoutPanel29.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel29.Location = new System.Drawing.Point(266, 3);
            this.tableLayoutPanel29.Name = "tableLayoutPanel29";
            this.tableLayoutPanel29.RowCount = 2;
            this.tableLayoutPanel29.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 82.20859F));
            this.tableLayoutPanel29.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.79141F));
            this.tableLayoutPanel29.Size = new System.Drawing.Size(1031, 241);
            this.tableLayoutPanel29.TabIndex = 5;
            // 
            // tableLayoutPanel30
            // 
            this.tableLayoutPanel30.ColumnCount = 2;
            this.tableLayoutPanel30.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel30.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 175F));
            this.tableLayoutPanel30.Controls.Add(this.numLengthGaussian, 1, 0);
            this.tableLayoutPanel30.Controls.Add(this.numWeightGaussian, 1, 1);
            this.tableLayoutPanel30.Controls.Add(this.label18, 0, 0);
            this.tableLayoutPanel30.Controls.Add(this.label19, 0, 1);
            this.tableLayoutPanel30.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel30.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel30.Name = "tableLayoutPanel30";
            this.tableLayoutPanel30.RowCount = 2;
            this.tableLayoutPanel30.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel30.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel30.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel30.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel30.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel30.Size = new System.Drawing.Size(251, 192);
            this.tableLayoutPanel30.TabIndex = 4;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label19.Location = new System.Drawing.Point(3, 96);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(70, 96);
            this.label19.TabIndex = 3;
            this.label19.Text = "Bobot Gaussian Filter";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label18.Location = new System.Drawing.Point(3, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(70, 96);
            this.label18.TabIndex = 2;
            this.label18.Text = "Panjang Gaussian Filter";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numWeightGaussian
            // 
            this.numWeightGaussian.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numWeightGaussian.Enabled = false;
            this.numWeightGaussian.Location = new System.Drawing.Point(79, 99);
            this.numWeightGaussian.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numWeightGaussian.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numWeightGaussian.Name = "numWeightGaussian";
            this.numWeightGaussian.Size = new System.Drawing.Size(169, 20);
            this.numWeightGaussian.TabIndex = 1;
            this.numWeightGaussian.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numWeightGaussian.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numWeightGaussian.ValueChanged += new System.EventHandler(this.numWeightGaussian_ValueChanged);
            // 
            // numLengthGaussian
            // 
            this.numLengthGaussian.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numLengthGaussian.Enabled = false;
            this.numLengthGaussian.Location = new System.Drawing.Point(79, 3);
            this.numLengthGaussian.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numLengthGaussian.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numLengthGaussian.Name = "numLengthGaussian";
            this.numLengthGaussian.Size = new System.Drawing.Size(169, 20);
            this.numLengthGaussian.TabIndex = 0;
            this.numLengthGaussian.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numLengthGaussian.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numLengthGaussian.ValueChanged += new System.EventHandler(this.numLengthGaussian_ValueChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label16.Location = new System.Drawing.Point(774, 198);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(254, 43);
            this.label16.TabIndex = 2;
            this.label16.Text = "Binerisasi";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label15.Location = new System.Drawing.Point(517, 198);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(251, 43);
            this.label15.TabIndex = 1;
            this.label15.Text = "Gaussian Filtering";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label14.Location = new System.Drawing.Point(260, 198);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(251, 43);
            this.label14.TabIndex = 0;
            this.label14.Text = "Grayscalling";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label17.Location = new System.Drawing.Point(3, 198);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(251, 43);
            this.label17.TabIndex = 3;
            this.label17.Text = "Parameter Bebas";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listViewGrayscallingTraining
            // 
            this.listViewGrayscallingTraining.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewGrayscallingTraining.Location = new System.Drawing.Point(260, 3);
            this.listViewGrayscallingTraining.Name = "listViewGrayscallingTraining";
            this.listViewGrayscallingTraining.Size = new System.Drawing.Size(251, 192);
            this.listViewGrayscallingTraining.TabIndex = 5;
            this.listViewGrayscallingTraining.UseCompatibleStateImageBehavior = false;
            // 
            // listViewGaussianFilteringTraining
            // 
            this.listViewGaussianFilteringTraining.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewGaussianFilteringTraining.Location = new System.Drawing.Point(517, 3);
            this.listViewGaussianFilteringTraining.Name = "listViewGaussianFilteringTraining";
            this.listViewGaussianFilteringTraining.Size = new System.Drawing.Size(251, 192);
            this.listViewGaussianFilteringTraining.TabIndex = 6;
            this.listViewGaussianFilteringTraining.UseCompatibleStateImageBehavior = false;
            // 
            // listViewBinerisasiTraining
            // 
            this.listViewBinerisasiTraining.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewBinerisasiTraining.Location = new System.Drawing.Point(774, 3);
            this.listViewBinerisasiTraining.Name = "listViewBinerisasiTraining";
            this.listViewBinerisasiTraining.Size = new System.Drawing.Size(254, 192);
            this.listViewBinerisasiTraining.TabIndex = 7;
            this.listViewBinerisasiTraining.UseCompatibleStateImageBehavior = false;
            // 
            // btnOpenImageTraining
            // 
            this.btnOpenImageTraining.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOpenImageTraining.Location = new System.Drawing.Point(3, 250);
            this.btnOpenImageTraining.Name = "btnOpenImageTraining";
            this.btnOpenImageTraining.Size = new System.Drawing.Size(257, 47);
            this.btnOpenImageTraining.TabIndex = 4;
            this.btnOpenImageTraining.Text = "Open Image";
            this.btnOpenImageTraining.UseVisualStyleBackColor = true;
            this.btnOpenImageTraining.Click += new System.EventHandler(this.btnOpenImageTraining_Click);
            // 
            // listViewRealImageTraining
            // 
            this.listViewRealImageTraining.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewRealImageTraining.Location = new System.Drawing.Point(3, 3);
            this.listViewRealImageTraining.Name = "listViewRealImageTraining";
            this.listViewRealImageTraining.Size = new System.Drawing.Size(257, 241);
            this.listViewRealImageTraining.TabIndex = 0;
            this.listViewRealImageTraining.UseCompatibleStateImageBehavior = false;
            // 
            // tabHome
            // 
            this.tabHome.Controls.Add(this.tableLayoutPanel1);
            this.tabHome.Location = new System.Drawing.Point(4, 22);
            this.tabHome.Name = "tabHome";
            this.tabHome.Padding = new System.Windows.Forms.Padding(3);
            this.tabHome.Size = new System.Drawing.Size(1312, 670);
            this.tabHome.TabIndex = 0;
            this.tabHome.Text = "Beranda";
            this.tabHome.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbTitle, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pbMikroskil, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel5, 0, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1306, 664);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.label13, 0, 3);
            this.tableLayoutPanel5.Controls.Add(this.label12, 0, 2);
            this.tableLayoutPanel5.Controls.Add(this.label11, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.label10, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 531);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 4;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(1300, 130);
            this.tableLayoutPanel5.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(3, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(1294, 32);
            this.label10.TabIndex = 0;
            this.label10.Text = "Informasi dari jurusan";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(3, 32);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(1294, 32);
            this.label11.TabIndex = 1;
            this.label11.Text = "Informasi dari sekolah tinggi";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(3, 64);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(1294, 32);
            this.label12.TabIndex = 2;
            this.label12.Text = "Nama Kota";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(3, 96);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(1294, 34);
            this.label13.TabIndex = 3;
            this.label13.Text = "Tahun";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbMikroskil
            // 
            this.pbMikroskil.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbMikroskil.Location = new System.Drawing.Point(3, 399);
            this.pbMikroskil.Name = "pbMikroskil";
            this.pbMikroskil.Size = new System.Drawing.Size(1300, 126);
            this.pbMikroskil.TabIndex = 3;
            this.pbMikroskil.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 135);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.84127F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.15873F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1300, 126);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.label5, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label3, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 28);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1294, 95);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(641, 47);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nama Mahasiswa I";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(650, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(641, 47);
            this.label3.TabIndex = 1;
            this.label3.Text = "NIM Mahasiswa I";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(641, 48);
            this.label4.TabIndex = 2;
            this.label4.Text = "Nama Mahasiswa II";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(650, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(641, 48);
            this.label5.TabIndex = 3;
            this.label5.Text = "NIM Mahasiswa II";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1294, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "CREATED BY :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(3, 0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(1300, 132);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "PATTERN RECOGNITION HANDWRITING CURSIVE USING PROJECTION-BASED SEGMENTATION METHO" +
    "D AND ARTIFICIAL NEURAL NETWORK (ANN)";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.label6, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.label7, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.label8, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.label9, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 267);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1300, 126);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(644, 63);
            this.label9.TabIndex = 0;
            this.label9.Text = "Pembimbing I (titel)";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(653, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(644, 63);
            this.label8.TabIndex = 1;
            this.label8.Text = "Pembimbing II (titel)";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(644, 63);
            this.label7.TabIndex = 2;
            this.label7.Text = "Nama Pembimbing I";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(653, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(644, 63);
            this.label6.TabIndex = 3;
            this.label6.Text = "Nama Pembimbing II";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tabBase
            // 
            this.tabBase.Controls.Add(this.tabHome);
            this.tabBase.Controls.Add(this.tabDataTraining);
            this.tabBase.Controls.Add(this.tabDataTrainingBPNN);
            this.tabBase.Controls.Add(this.tabTesting);
            this.tabBase.Controls.Add(this.tabTestingDataParagraph);
            this.tabBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabBase.Location = new System.Drawing.Point(0, 0);
            this.tabBase.Name = "tabBase";
            this.tabBase.SelectedIndex = 0;
            this.tabBase.Size = new System.Drawing.Size(1320, 696);
            this.tabBase.TabIndex = 0;
            // 
            // FormHandWriting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1320, 696);
            this.Controls.Add(this.tabBase);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormHandWriting";
            this.Text = "Aplikasi Pengenalan Pola Tulisan Tangan Tegak Bersambung";
            this.tabTestingDataParagraph.ResumeLayout(false);
            this.tlpParagraph.ResumeLayout(false);
            this.tableLayoutPanel15.ResumeLayout(false);
            this.tabTesting.ResumeLayout(false);
            this.tlpPengenalanParagraph.ResumeLayout(false);
            this.tableLayoutPanel23.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataFiturParagraf)).EndInit();
            this.tableLayoutPanel24.ResumeLayout(false);
            this.tableLayoutPanel26.ResumeLayout(false);
            this.tableLayoutPanel26.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numHorizontally)).EndInit();
            this.tableLayoutPanel25.ResumeLayout(false);
            this.tableLayoutPanel25.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numVertically)).EndInit();
            this.tableLayoutPanel22.ResumeLayout(false);
            this.tableLayoutPanel13.ResumeLayout(false);
            this.tableLayoutPanel17.ResumeLayout(false);
            this.tableLayoutPanel17.PerformLayout();
            this.tableLayoutPanel20.ResumeLayout(false);
            this.tableLayoutPanel20.PerformLayout();
            this.tabDataTrainingBPNN.ResumeLayout(false);
            this.tlpBPNN.ResumeLayout(false);
            this.tableLayoutPanel21.ResumeLayout(false);
            this.tableLayoutPanel16.ResumeLayout(false);
            this.tableLayoutPanel16.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgViewWeightResult)).EndInit();
            this.tableLayoutPanel19.ResumeLayout(false);
            this.tableLayoutPanel19.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMomentum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLayers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHiddenNeuron)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxEpochs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLearningRate)).EndInit();
            this.tabDataTraining.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataFiturTraining)).EndInit();
            this.tableLayoutPanel12.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel29.ResumeLayout(false);
            this.tableLayoutPanel29.PerformLayout();
            this.tableLayoutPanel30.ResumeLayout(false);
            this.tableLayoutPanel30.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numWeightGaussian)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLengthGaussian)).EndInit();
            this.tabHome.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMikroskil)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tabBase.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList imageListReal;
        private System.ComponentModel.BackgroundWorker bwLoadingPreprocessing;
        private System.Windows.Forms.ImageList imageListGrayscale;
        private System.Windows.Forms.ImageList imageListFiltering;
        private System.Windows.Forms.ImageList imageListBinary;
        private System.Windows.Forms.ImageList imageListHorizontalProjector;
        private System.ComponentModel.BackgroundWorker bwExtractionFeature;
        private System.ComponentModel.BackgroundWorker bwBPNN;
        private System.ComponentModel.BackgroundWorker bwParagraph;
        private System.Windows.Forms.TabPage tabTestingDataParagraph;
        private System.Windows.Forms.TableLayoutPanel tlpParagraph;
        private System.Windows.Forms.ListView listViewParagraph;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel15;
        private System.Windows.Forms.Button btnTestingDataParagraph;
        private System.Windows.Forms.TabPage tabTesting;
        private System.Windows.Forms.TableLayoutPanel tlpPengenalanParagraph;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel13;
        private System.Windows.Forms.Button btnOpenImageParagraph;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel17;
        private System.Windows.Forms.Button btnShowImageBinary;
        private System.Windows.Forms.Button btnShowImageGaussianFiltering;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel20;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.TextBox tbWeightGaussianFilterParagraph;
        private System.Windows.Forms.TextBox tbLengthGaussianFilterParagraph;
        private System.Windows.Forms.Button btnShowImageGrayscalling;
        private System.Windows.Forms.Button btnPreprocessingParagraph;
        private System.Windows.Forms.Button btnShowRealImage;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel22;
        private System.Windows.Forms.Button btnFeatureExtractionParagraph;
        private System.Windows.Forms.Button btnProfileProjection;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel23;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel24;
        private System.Windows.Forms.ListView listViewHorizontally;
        private System.Windows.Forms.ListView listViewVertically;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel25;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.NumericUpDown numVertically;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel26;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.NumericUpDown numHorizontally;
        private System.Windows.Forms.DataGridView dataFiturParagraf;
        private System.Windows.Forms.TabPage tabDataTrainingBPNN;
        private System.Windows.Forms.TableLayoutPanel tlpBPNN;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel19;
        private System.Windows.Forms.NumericUpDown numLearningRate;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.NumericUpDown numMaxEpochs;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.NumericUpDown numHiddenNeuron;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.NumericUpDown numLayers;
        private System.Windows.Forms.Button btnTraining;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.NumericUpDown numMomentum;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel21;
        private System.Windows.Forms.DataGridView dgViewWeightResult;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel16;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.CheckBox checkDisplayWeight;
        private System.Windows.Forms.TabPage tabDataTraining;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.ListView listViewRealImageTraining;
        private System.Windows.Forms.Button btnOpenImageTraining;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel29;
        private System.Windows.Forms.ListView listViewBinerisasiTraining;
        private System.Windows.Forms.ListView listViewGaussianFilteringTraining;
        private System.Windows.Forms.ListView listViewGrayscallingTraining;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel30;
        private System.Windows.Forms.NumericUpDown numLengthGaussian;
        private System.Windows.Forms.NumericUpDown numWeightGaussian;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button btnPreprocessingTraining;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel12;
        private System.Windows.Forms.Button btnFeatureExtractionTraining;
        private System.Windows.Forms.DataGridView dataFiturTraining;
        private System.Windows.Forms.TabPage tabHome;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbMikroskil;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TabControl tabBase;
    }
}

