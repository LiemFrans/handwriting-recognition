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
            this.tabBase = new System.Windows.Forms.TabControl();
            this.tabHome = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pbMikroskil = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tabTraining = new System.Windows.Forms.TabPage();
            this.tabTesting = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.imageListReal = new System.Windows.Forms.ImageList(this.components);
            this.bwLoadingPreprocessing = new System.ComponentModel.BackgroundWorker();
            this.listViewRealImage = new System.Windows.Forms.ListView();
            this.listViewGrayscaleImage = new System.Windows.Forms.ListView();
            this.listViewFilteringImage = new System.Windows.Forms.ListView();
            this.listViewBinaryImage = new System.Windows.Forms.ListView();
            this.imageListGrayscale = new System.Windows.Forms.ImageList(this.components);
            this.imageListFiltering = new System.Windows.Forms.ImageList(this.components);
            this.imageListBinary = new System.Windows.Forms.ImageList(this.components);
            this.btnOpenImage = new System.Windows.Forms.Button();
            this.btnProcessGrayscale = new System.Windows.Forms.Button();
            this.btnProcessFiltering = new System.Windows.Forms.Button();
            this.btnProcessBinary = new System.Windows.Forms.Button();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel10 = new System.Windows.Forms.TableLayoutPanel();
            this.listViewHorizontalProjectorImage = new System.Windows.Forms.ListView();
            this.imageListHorizontalProjector = new System.Windows.Forms.ImageList(this.components);
            this.tableLayoutPanel11 = new System.Windows.Forms.TableLayoutPanel();
            this.btnHPPProcessing = new System.Windows.Forms.Button();
            this.listViewVerticalProjectorImage = new System.Windows.Forms.ListView();
            this.btnProcessVPP = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.tableLayoutPanel12 = new System.Windows.Forms.TableLayoutPanel();
            this.btnFeatureExtraction = new System.Windows.Forms.Button();
            this.btnClassification = new System.Windows.Forms.Button();
            this.tabBase.SuspendLayout();
            this.tabHome.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMikroskil)).BeginInit();
            this.tableLayoutPanel5.SuspendLayout();
            this.tabTraining.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            this.tableLayoutPanel10.SuspendLayout();
            this.tableLayoutPanel11.SuspendLayout();
            this.tableLayoutPanel12.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabBase
            // 
            this.tabBase.Controls.Add(this.tabHome);
            this.tabBase.Controls.Add(this.tabTraining);
            this.tabBase.Controls.Add(this.tabTesting);
            this.tabBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabBase.Location = new System.Drawing.Point(0, 0);
            this.tabBase.Name = "tabBase";
            this.tabBase.SelectedIndex = 0;
            this.tabBase.Size = new System.Drawing.Size(1320, 696);
            this.tabBase.TabIndex = 0;
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
            this.label3.Click += new System.EventHandler(this.label3_Click);
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
            // pbMikroskil
            // 
            this.pbMikroskil.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbMikroskil.Location = new System.Drawing.Point(3, 399);
            this.pbMikroskil.Name = "pbMikroskil";
            this.pbMikroskil.Size = new System.Drawing.Size(1300, 126);
            this.pbMikroskil.TabIndex = 3;
            this.pbMikroskil.TabStop = false;
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
            // tabTraining
            // 
            this.tabTraining.Controls.Add(this.tableLayoutPanel6);
            this.tabTraining.Location = new System.Drawing.Point(4, 22);
            this.tabTraining.Name = "tabTraining";
            this.tabTraining.Padding = new System.Windows.Forms.Padding(3);
            this.tabTraining.Size = new System.Drawing.Size(1312, 670);
            this.tabTraining.TabIndex = 1;
            this.tabTraining.Text = "Pelatihan";
            this.tabTraining.UseVisualStyleBackColor = true;
            // 
            // tabTesting
            // 
            this.tabTesting.Location = new System.Drawing.Point(4, 22);
            this.tabTesting.Name = "tabTesting";
            this.tabTesting.Size = new System.Drawing.Size(1312, 670);
            this.tabTesting.TabIndex = 2;
            this.tabTesting.Text = "Pengenalan";
            this.tabTesting.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Controls.Add(this.tableLayoutPanel7, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.tableLayoutPanel8, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.tableLayoutPanel11, 0, 2);
            this.tableLayoutPanel6.Controls.Add(this.tableLayoutPanel12, 0, 3);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 4;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.01543F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.01543F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.87349F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.271084F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(1306, 664);
            this.tableLayoutPanel6.TabIndex = 0;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 4;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel7.Controls.Add(this.btnProcessBinary, 3, 1);
            this.tableLayoutPanel7.Controls.Add(this.btnProcessFiltering, 2, 1);
            this.tableLayoutPanel7.Controls.Add(this.btnProcessGrayscale, 1, 1);
            this.tableLayoutPanel7.Controls.Add(this.listViewBinaryImage, 3, 0);
            this.tableLayoutPanel7.Controls.Add(this.listViewFilteringImage, 2, 0);
            this.tableLayoutPanel7.Controls.Add(this.listViewGrayscaleImage, 1, 0);
            this.tableLayoutPanel7.Controls.Add(this.listViewRealImage, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.btnOpenImage, 0, 1);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 2;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 82.52427F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.47573F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(1300, 206);
            this.tableLayoutPanel7.TabIndex = 0;
            // 
            // imageListReal
            // 
            this.imageListReal.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageListReal.ImageSize = new System.Drawing.Size(16, 16);
            this.imageListReal.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // listViewRealImage
            // 
            this.listViewRealImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewRealImage.Location = new System.Drawing.Point(3, 3);
            this.listViewRealImage.Name = "listViewRealImage";
            this.listViewRealImage.Size = new System.Drawing.Size(319, 163);
            this.listViewRealImage.TabIndex = 0;
            this.listViewRealImage.UseCompatibleStateImageBehavior = false;
            // 
            // listViewGrayscaleImage
            // 
            this.listViewGrayscaleImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewGrayscaleImage.Location = new System.Drawing.Point(328, 3);
            this.listViewGrayscaleImage.Name = "listViewGrayscaleImage";
            this.listViewGrayscaleImage.Size = new System.Drawing.Size(319, 163);
            this.listViewGrayscaleImage.TabIndex = 1;
            this.listViewGrayscaleImage.UseCompatibleStateImageBehavior = false;
            // 
            // listViewFilteringImage
            // 
            this.listViewFilteringImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewFilteringImage.Location = new System.Drawing.Point(653, 3);
            this.listViewFilteringImage.Name = "listViewFilteringImage";
            this.listViewFilteringImage.Size = new System.Drawing.Size(319, 163);
            this.listViewFilteringImage.TabIndex = 2;
            this.listViewFilteringImage.UseCompatibleStateImageBehavior = false;
            // 
            // listViewBinaryImage
            // 
            this.listViewBinaryImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewBinaryImage.Location = new System.Drawing.Point(978, 3);
            this.listViewBinaryImage.Name = "listViewBinaryImage";
            this.listViewBinaryImage.Size = new System.Drawing.Size(319, 163);
            this.listViewBinaryImage.TabIndex = 3;
            this.listViewBinaryImage.UseCompatibleStateImageBehavior = false;
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
            // btnOpenImage
            // 
            this.btnOpenImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOpenImage.Location = new System.Drawing.Point(3, 172);
            this.btnOpenImage.Name = "btnOpenImage";
            this.btnOpenImage.Size = new System.Drawing.Size(319, 31);
            this.btnOpenImage.TabIndex = 4;
            this.btnOpenImage.Text = "Open Image";
            this.btnOpenImage.UseVisualStyleBackColor = true;
            // 
            // btnProcessGrayscale
            // 
            this.btnProcessGrayscale.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnProcessGrayscale.Enabled = false;
            this.btnProcessGrayscale.Location = new System.Drawing.Point(328, 172);
            this.btnProcessGrayscale.Name = "btnProcessGrayscale";
            this.btnProcessGrayscale.Size = new System.Drawing.Size(319, 31);
            this.btnProcessGrayscale.TabIndex = 5;
            this.btnProcessGrayscale.Text = "Proses Grayscale";
            this.btnProcessGrayscale.UseVisualStyleBackColor = true;
            // 
            // btnProcessFiltering
            // 
            this.btnProcessFiltering.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnProcessFiltering.Enabled = false;
            this.btnProcessFiltering.Location = new System.Drawing.Point(653, 172);
            this.btnProcessFiltering.Name = "btnProcessFiltering";
            this.btnProcessFiltering.Size = new System.Drawing.Size(319, 31);
            this.btnProcessFiltering.TabIndex = 6;
            this.btnProcessFiltering.Text = "Proses Filtering";
            this.btnProcessFiltering.UseVisualStyleBackColor = true;
            // 
            // btnProcessBinary
            // 
            this.btnProcessBinary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnProcessBinary.Enabled = false;
            this.btnProcessBinary.Location = new System.Drawing.Point(978, 172);
            this.btnProcessBinary.Name = "btnProcessBinary";
            this.btnProcessBinary.Size = new System.Drawing.Size(319, 31);
            this.btnProcessBinary.TabIndex = 7;
            this.btnProcessBinary.Text = "Process Binarisasi";
            this.btnProcessBinary.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 2;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.923077F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 93.07692F));
            this.tableLayoutPanel8.Controls.Add(this.tableLayoutPanel10, 1, 0);
            this.tableLayoutPanel8.Controls.Add(this.tableLayoutPanel9, 0, 0);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(3, 215);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 1;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(1300, 206);
            this.tableLayoutPanel8.TabIndex = 1;
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.ColumnCount = 1;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel9.Controls.Add(this.btnHelp, 0, 0);
            this.tableLayoutPanel9.Controls.Add(this.btnReset, 0, 1);
            this.tableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel9.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 2;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(84, 200);
            this.tableLayoutPanel9.TabIndex = 0;
            // 
            // tableLayoutPanel10
            // 
            this.tableLayoutPanel10.ColumnCount = 1;
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel10.Controls.Add(this.listViewHorizontalProjectorImage, 0, 0);
            this.tableLayoutPanel10.Controls.Add(this.btnHPPProcessing, 0, 1);
            this.tableLayoutPanel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel10.Location = new System.Drawing.Point(93, 3);
            this.tableLayoutPanel10.Name = "tableLayoutPanel10";
            this.tableLayoutPanel10.RowCount = 2;
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tableLayoutPanel10.Size = new System.Drawing.Size(1204, 200);
            this.tableLayoutPanel10.TabIndex = 1;
            // 
            // listViewHorizontalProjectorImage
            // 
            this.listViewHorizontalProjectorImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewHorizontalProjectorImage.Location = new System.Drawing.Point(3, 3);
            this.listViewHorizontalProjectorImage.Name = "listViewHorizontalProjectorImage";
            this.listViewHorizontalProjectorImage.Size = new System.Drawing.Size(1198, 162);
            this.listViewHorizontalProjectorImage.TabIndex = 4;
            this.listViewHorizontalProjectorImage.UseCompatibleStateImageBehavior = false;
            // 
            // imageListHorizontalProjector
            // 
            this.imageListHorizontalProjector.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageListHorizontalProjector.ImageSize = new System.Drawing.Size(16, 16);
            this.imageListHorizontalProjector.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // tableLayoutPanel11
            // 
            this.tableLayoutPanel11.ColumnCount = 2;
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.846154F));
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 93.15385F));
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel11.Controls.Add(this.btnProcessVPP, 0, 0);
            this.tableLayoutPanel11.Controls.Add(this.listViewVerticalProjectorImage, 1, 0);
            this.tableLayoutPanel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel11.Location = new System.Drawing.Point(3, 427);
            this.tableLayoutPanel11.Name = "tableLayoutPanel11";
            this.tableLayoutPanel11.RowCount = 1;
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel11.Size = new System.Drawing.Size(1300, 198);
            this.tableLayoutPanel11.TabIndex = 2;
            // 
            // btnHPPProcessing
            // 
            this.btnHPPProcessing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnHPPProcessing.Enabled = false;
            this.btnHPPProcessing.Location = new System.Drawing.Point(3, 171);
            this.btnHPPProcessing.Name = "btnHPPProcessing";
            this.btnHPPProcessing.Size = new System.Drawing.Size(1198, 26);
            this.btnHPPProcessing.TabIndex = 5;
            this.btnHPPProcessing.Text = "Proses HPP";
            this.btnHPPProcessing.UseVisualStyleBackColor = true;
            // 
            // listViewVerticalProjectorImage
            // 
            this.listViewVerticalProjectorImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewVerticalProjectorImage.Location = new System.Drawing.Point(91, 3);
            this.listViewVerticalProjectorImage.Name = "listViewVerticalProjectorImage";
            this.listViewVerticalProjectorImage.Size = new System.Drawing.Size(1206, 192);
            this.listViewVerticalProjectorImage.TabIndex = 0;
            this.listViewVerticalProjectorImage.UseCompatibleStateImageBehavior = false;
            // 
            // btnProcessVPP
            // 
            this.btnProcessVPP.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProcessVPP.Location = new System.Drawing.Point(3, 3);
            this.btnProcessVPP.Name = "btnProcessVPP";
            this.btnProcessVPP.Size = new System.Drawing.Size(82, 23);
            this.btnProcessVPP.TabIndex = 4;
            this.btnProcessVPP.Text = "Proses VPP";
            this.btnProcessVPP.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            this.btnReset.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReset.Location = new System.Drawing.Point(3, 103);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(78, 23);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // btnHelp
            // 
            this.btnHelp.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHelp.Location = new System.Drawing.Point(3, 3);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(78, 23);
            this.btnHelp.TabIndex = 4;
            this.btnHelp.Text = "Bantuan";
            this.btnHelp.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel12
            // 
            this.tableLayoutPanel12.ColumnCount = 2;
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel12.Controls.Add(this.btnClassification, 1, 0);
            this.tableLayoutPanel12.Controls.Add(this.btnFeatureExtraction, 0, 0);
            this.tableLayoutPanel12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel12.Location = new System.Drawing.Point(3, 631);
            this.tableLayoutPanel12.Name = "tableLayoutPanel12";
            this.tableLayoutPanel12.RowCount = 1;
            this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel12.Size = new System.Drawing.Size(1300, 30);
            this.tableLayoutPanel12.TabIndex = 3;
            // 
            // btnFeatureExtraction
            // 
            this.btnFeatureExtraction.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnFeatureExtraction.Location = new System.Drawing.Point(572, 3);
            this.btnFeatureExtraction.Name = "btnFeatureExtraction";
            this.btnFeatureExtraction.Size = new System.Drawing.Size(75, 24);
            this.btnFeatureExtraction.TabIndex = 2;
            this.btnFeatureExtraction.Text = "Extraksi Ciri";
            this.btnFeatureExtraction.UseVisualStyleBackColor = true;
            // 
            // btnClassification
            // 
            this.btnClassification.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnClassification.Location = new System.Drawing.Point(653, 3);
            this.btnClassification.Name = "btnClassification";
            this.btnClassification.Size = new System.Drawing.Size(75, 24);
            this.btnClassification.TabIndex = 3;
            this.btnClassification.Text = "Pengenalan";
            this.btnClassification.UseVisualStyleBackColor = true;
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
            this.tabBase.ResumeLayout(false);
            this.tabHome.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMikroskil)).EndInit();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tabTraining.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel9.ResumeLayout(false);
            this.tableLayoutPanel10.ResumeLayout(false);
            this.tableLayoutPanel11.ResumeLayout(false);
            this.tableLayoutPanel12.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabBase;
        private System.Windows.Forms.TabPage tabHome;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabTraining;
        private System.Windows.Forms.TabPage tabTesting;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pbMikroskil;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.Button btnProcessBinary;
        private System.Windows.Forms.Button btnProcessFiltering;
        private System.Windows.Forms.Button btnProcessGrayscale;
        private System.Windows.Forms.ListView listViewBinaryImage;
        private System.Windows.Forms.ListView listViewFilteringImage;
        private System.Windows.Forms.ListView listViewGrayscaleImage;
        private System.Windows.Forms.ListView listViewRealImage;
        private System.Windows.Forms.Button btnOpenImage;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel10;
        private System.Windows.Forms.ListView listViewHorizontalProjectorImage;
        private System.Windows.Forms.Button btnHPPProcessing;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel11;
        private System.Windows.Forms.Button btnProcessVPP;
        private System.Windows.Forms.ListView listViewVerticalProjectorImage;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel12;
        private System.Windows.Forms.Button btnClassification;
        private System.Windows.Forms.Button btnFeatureExtraction;
        private System.Windows.Forms.ImageList imageListReal;
        private System.ComponentModel.BackgroundWorker bwLoadingPreprocessing;
        private System.Windows.Forms.ImageList imageListGrayscale;
        private System.Windows.Forms.ImageList imageListFiltering;
        private System.Windows.Forms.ImageList imageListBinary;
        private System.Windows.Forms.ImageList imageListHorizontalProjector;
    }
}

