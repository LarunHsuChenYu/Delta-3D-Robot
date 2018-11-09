namespace SharpGLWinformsApplication1
{
    partial class SharpGLForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SharpGLForm));
            this.openGLControl = new SharpGL.OpenGLControl();
            this.label14 = new System.Windows.Forms.Label();
            this.lbYCoor = new System.Windows.Forms.Label();
            this.lbXCoor = new System.Windows.Forms.Label();
            this.btYCoorZero = new System.Windows.Forms.Button();
            this.btNegJog = new System.Windows.Forms.Button();
            this.btPosJog = new System.Windows.Forms.Button();
            this.btZPosJog = new System.Windows.Forms.Button();
            this.btZNegJog = new System.Windows.Forms.Button();
            this.btZCoorZero = new System.Windows.Forms.Button();
            this.btYNegJog = new System.Windows.Forms.Button();
            this.btXPosJog = new System.Windows.Forms.Button();
            this.btXCoorSet = new System.Windows.Forms.Button();
            this.btYCoorSet = new System.Windows.Forms.Button();
            this.btXNegJog = new System.Windows.Forms.Button();
            this.btYPosJog = new System.Windows.Forms.Button();
            this.lbZCoor = new System.Windows.Forms.Label();
            this.btGcodeSave = new System.Windows.Forms.Button();
            this.tbGcodeEditTemp = new System.Windows.Forms.TextBox();
            this.lvGcodeDisplay = new System.Windows.Forms.ListView();
            this.gbStepSize = new System.Windows.Forms.GroupBox();
            this.rbStepSize0_001 = new System.Windows.Forms.RadioButton();
            this.rbStepSize10 = new System.Windows.Forms.RadioButton();
            this.rbStepSize1 = new System.Windows.Forms.RadioButton();
            this.rbStepSize0_1 = new System.Windows.Forms.RadioButton();
            this.rbStepSize0_01 = new System.Windows.Forms.RadioButton();
            this.btLoadGcodeFile = new System.Windows.Forms.Button();
            this.btIntBoard = new System.Windows.Forms.Button();
            this.gbJog = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.rbMovingModeRel = new System.Windows.Forms.RadioButton();
            this.btGcodeEdit = new System.Windows.Forms.Button();
            this.lbθ3Coor = new System.Windows.Forms.Label();
            this.lbθ2Coor = new System.Windows.Forms.Label();
            this.lbθ1Coor = new System.Windows.Forms.Label();
            this.btθ2CoorZero = new System.Windows.Forms.Button();
            this.btθ3CoorZero = new System.Windows.Forms.Button();
            this.btθ1CoorSet = new System.Windows.Forms.Button();
            this.btθ1CoorZero = new System.Windows.Forms.Button();
            this.tbYCoor = new System.Windows.Forms.TextBox();
            this.btθ2CoorSet = new System.Windows.Forms.Button();
            this.btθ3CoorSet = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbθ4Coor = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tbθ3Coor = new System.Windows.Forms.TextBox();
            this.tbθ4Coor = new System.Windows.Forms.TextBox();
            this.btθ4CoorZero = new System.Windows.Forms.Button();
            this.tbθ2Coor = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btθ4CoorSet = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.tbθ1Coor = new System.Windows.Forms.TextBox();
            this.button23 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.gbUnits = new System.Windows.Forms.GroupBox();
            this.rbUnitsInch = new System.Windows.Forms.RadioButton();
            this.rbUnitsMm = new System.Windows.Forms.RadioButton();
            this.tbZCoor = new System.Windows.Forms.TextBox();
            this.gbWorkSpace = new System.Windows.Forms.GroupBox();
            this.tbXCoor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btHomePosition = new System.Windows.Forms.Button();
            this.btZCoorSet = new System.Windows.Forms.Button();
            this.btXCoorZero = new System.Windows.Forms.Button();
            this.gbMovingMode = new System.Windows.Forms.GroupBox();
            this.rbMovingModeAbs = new System.Windows.Forms.RadioButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.openGLControl)).BeginInit();
            this.gbStepSize.SuspendLayout();
            this.gbJog.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbUnits.SuspendLayout();
            this.gbWorkSpace.SuspendLayout();
            this.gbMovingMode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // openGLControl
            // 
            this.openGLControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.openGLControl.AutoScroll = true;
            this.openGLControl.AutoSize = true;
            this.openGLControl.BitDepth = 24;
            this.openGLControl.DrawFPS = true;
            this.openGLControl.FrameRate = 20;
            this.openGLControl.Location = new System.Drawing.Point(528, 12);
            this.openGLControl.Name = "openGLControl";
            this.openGLControl.RenderContextType = SharpGL.RenderContextType.FBO;
            this.openGLControl.Size = new System.Drawing.Size(723, 377);
            this.openGLControl.TabIndex = 0;
            this.openGLControl.OpenGLInitialized += new System.EventHandler(this.openGLControl_OpenGLInitialized);
            this.openGLControl.OpenGLDraw += new System.Windows.Forms.PaintEventHandler(this.openGLControl_OpenGLDraw);
            this.openGLControl.Resized += new System.EventHandler(this.openGLControl_Resized);
            this.openGLControl.KeyDown += new System.Windows.Forms.KeyEventHandler(this.openGLControl_KeyDown);
            this.openGLControl.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.openGLControl_MouseWheel);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Blue;
            this.label14.Location = new System.Drawing.Point(409, 18);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(49, 31);
            this.label14.TabIndex = 33;
            this.label14.Text = "Z+";
            // 
            // lbYCoor
            // 
            this.lbYCoor.AutoSize = true;
            this.lbYCoor.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbYCoor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbYCoor.ForeColor = System.Drawing.Color.Yellow;
            this.lbYCoor.Location = new System.Drawing.Point(88, 56);
            this.lbYCoor.Name = "lbYCoor";
            this.lbYCoor.Size = new System.Drawing.Size(29, 24);
            this.lbYCoor.TabIndex = 219;
            this.lbYCoor.Text = "Y:";
            // 
            // lbXCoor
            // 
            this.lbXCoor.AutoSize = true;
            this.lbXCoor.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbXCoor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbXCoor.ForeColor = System.Drawing.Color.Yellow;
            this.lbXCoor.Location = new System.Drawing.Point(88, 32);
            this.lbXCoor.Name = "lbXCoor";
            this.lbXCoor.Size = new System.Drawing.Size(31, 24);
            this.lbXCoor.TabIndex = 218;
            this.lbXCoor.Text = "X:";
            // 
            // btYCoorZero
            // 
            this.btYCoorZero.Location = new System.Drawing.Point(318, 56);
            this.btYCoorZero.Name = "btYCoorZero";
            this.btYCoorZero.Size = new System.Drawing.Size(48, 21);
            this.btYCoorZero.TabIndex = 217;
            this.btYCoorZero.Text = "zero";
            this.btYCoorZero.UseVisualStyleBackColor = true;
            this.btYCoorZero.Click += new System.EventHandler(this.btYCoorZero_Click);
            // 
            // btNegJog
            // 
            this.btNegJog.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btNegJog.BackgroundImage")));
            this.btNegJog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btNegJog.Location = new System.Drawing.Point(334, 176);
            this.btNegJog.Name = "btNegJog";
            this.btNegJog.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btNegJog.Size = new System.Drawing.Size(83, 46);
            this.btNegJog.TabIndex = 39;
            this.btNegJog.UseVisualStyleBackColor = true;
            // 
            // btPosJog
            // 
            this.btPosJog.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btPosJog.BackgroundImage")));
            this.btPosJog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btPosJog.Location = new System.Drawing.Point(434, 176);
            this.btPosJog.Name = "btPosJog";
            this.btPosJog.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btPosJog.Size = new System.Drawing.Size(79, 46);
            this.btPosJog.TabIndex = 38;
            this.btPosJog.UseVisualStyleBackColor = true;
            // 
            // btZPosJog
            // 
            this.btZPosJog.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btZPosJog.BackgroundImage")));
            this.btZPosJog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btZPosJog.Location = new System.Drawing.Point(453, 18);
            this.btZPosJog.Name = "btZPosJog";
            this.btZPosJog.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btZPosJog.Size = new System.Drawing.Size(51, 105);
            this.btZPosJog.TabIndex = 30;
            this.btZPosJog.UseVisualStyleBackColor = true;
            this.btZPosJog.Click += new System.EventHandler(this.btZPosJog_Click);
            // 
            // btZNegJog
            // 
            this.btZNegJog.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btZNegJog.BackgroundImage")));
            this.btZNegJog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btZNegJog.Location = new System.Drawing.Point(13, 124);
            this.btZNegJog.Name = "btZNegJog";
            this.btZNegJog.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btZNegJog.Size = new System.Drawing.Size(57, 92);
            this.btZNegJog.TabIndex = 29;
            this.btZNegJog.UseVisualStyleBackColor = true;
            this.btZNegJog.Click += new System.EventHandler(this.btZNegJog_Click);
            // 
            // btZCoorZero
            // 
            this.btZCoorZero.Location = new System.Drawing.Point(318, 80);
            this.btZCoorZero.Name = "btZCoorZero";
            this.btZCoorZero.Size = new System.Drawing.Size(48, 21);
            this.btZCoorZero.TabIndex = 216;
            this.btZCoorZero.Text = "zero";
            this.btZCoorZero.UseVisualStyleBackColor = true;
            this.btZCoorZero.Click += new System.EventHandler(this.btZCoorZero_Click);
            // 
            // btYNegJog
            // 
            this.btYNegJog.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btYNegJog.BackgroundImage")));
            this.btYNegJog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btYNegJog.Location = new System.Drawing.Point(221, 139);
            this.btYNegJog.Name = "btYNegJog";
            this.btYNegJog.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btYNegJog.Size = new System.Drawing.Size(83, 47);
            this.btYNegJog.TabIndex = 28;
            this.btYNegJog.UseVisualStyleBackColor = true;
            this.btYNegJog.Click += new System.EventHandler(this.btYNegJog_Click);
            // 
            // btXPosJog
            // 
            this.btXPosJog.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btXPosJog.BackgroundImage")));
            this.btXPosJog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btXPosJog.Location = new System.Drawing.Point(309, 97);
            this.btXPosJog.Name = "btXPosJog";
            this.btXPosJog.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btXPosJog.Size = new System.Drawing.Size(79, 46);
            this.btXPosJog.TabIndex = 27;
            this.btXPosJog.UseVisualStyleBackColor = true;
            this.btXPosJog.Click += new System.EventHandler(this.btXPosJog_Click);
            // 
            // btXCoorSet
            // 
            this.btXCoorSet.Location = new System.Drawing.Point(372, 32);
            this.btXCoorSet.Name = "btXCoorSet";
            this.btXCoorSet.Size = new System.Drawing.Size(48, 21);
            this.btXCoorSet.TabIndex = 215;
            this.btXCoorSet.Text = "set";
            this.btXCoorSet.UseVisualStyleBackColor = true;
            this.btXCoorSet.Click += new System.EventHandler(this.btXCoorSet_Click);
            // 
            // btYCoorSet
            // 
            this.btYCoorSet.Location = new System.Drawing.Point(372, 57);
            this.btYCoorSet.Name = "btYCoorSet";
            this.btYCoorSet.Size = new System.Drawing.Size(48, 21);
            this.btYCoorSet.TabIndex = 214;
            this.btYCoorSet.Text = "set";
            this.btYCoorSet.UseVisualStyleBackColor = true;
            this.btYCoorSet.Click += new System.EventHandler(this.btYCoorSet_Click);
            // 
            // btXNegJog
            // 
            this.btXNegJog.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btXNegJog.BackgroundImage")));
            this.btXNegJog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btXNegJog.Location = new System.Drawing.Point(132, 95);
            this.btXNegJog.Name = "btXNegJog";
            this.btXNegJog.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btXNegJog.Size = new System.Drawing.Size(83, 46);
            this.btXNegJog.TabIndex = 26;
            this.btXNegJog.UseVisualStyleBackColor = true;
            this.btXNegJog.Click += new System.EventHandler(this.btXNegJog_Click);
            // 
            // btYPosJog
            // 
            this.btYPosJog.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btYPosJog.BackgroundImage")));
            this.btYPosJog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btYPosJog.Location = new System.Drawing.Point(221, 52);
            this.btYPosJog.Name = "btYPosJog";
            this.btYPosJog.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btYPosJog.Size = new System.Drawing.Size(83, 47);
            this.btYPosJog.TabIndex = 24;
            this.btYPosJog.UseVisualStyleBackColor = true;
            this.btYPosJog.Click += new System.EventHandler(this.btYPosJog_Click);
            // 
            // lbZCoor
            // 
            this.lbZCoor.AutoSize = true;
            this.lbZCoor.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbZCoor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbZCoor.ForeColor = System.Drawing.Color.Yellow;
            this.lbZCoor.Location = new System.Drawing.Point(88, 81);
            this.lbZCoor.Name = "lbZCoor";
            this.lbZCoor.Size = new System.Drawing.Size(29, 24);
            this.lbZCoor.TabIndex = 220;
            this.lbZCoor.Text = "Z:";
            // 
            // btGcodeSave
            // 
            this.btGcodeSave.Location = new System.Drawing.Point(7, 360);
            this.btGcodeSave.Name = "btGcodeSave";
            this.btGcodeSave.Size = new System.Drawing.Size(58, 21);
            this.btGcodeSave.TabIndex = 241;
            this.btGcodeSave.Text = "Save";
            this.btGcodeSave.UseVisualStyleBackColor = true;
            this.btGcodeSave.Click += new System.EventHandler(this.btGcodeSave_Click);
            // 
            // tbGcodeEditTemp
            // 
            this.tbGcodeEditTemp.Location = new System.Drawing.Point(316, 361);
            this.tbGcodeEditTemp.Name = "tbGcodeEditTemp";
            this.tbGcodeEditTemp.Size = new System.Drawing.Size(100, 22);
            this.tbGcodeEditTemp.TabIndex = 240;
            this.tbGcodeEditTemp.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtEdit_KeyUp);
            this.tbGcodeEditTemp.Leave += new System.EventHandler(this.TxtEdit_Leave);
            // 
            // lvGcodeDisplay
            // 
            this.lvGcodeDisplay.LabelEdit = true;
            this.lvGcodeDisplay.Location = new System.Drawing.Point(71, 329);
            this.lvGcodeDisplay.Name = "lvGcodeDisplay";
            this.lvGcodeDisplay.Size = new System.Drawing.Size(349, 260);
            this.lvGcodeDisplay.TabIndex = 239;
            this.lvGcodeDisplay.UseCompatibleStateImageBehavior = false;
            this.lvGcodeDisplay.View = System.Windows.Forms.View.Details;
            this.lvGcodeDisplay.MouseDown += new System.Windows.Forms.MouseEventHandler(this.openGLControl_MouseWheel);
            this.lvGcodeDisplay.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lvGcodeDisplay_MouseUp);
            // 
            // gbStepSize
            // 
            this.gbStepSize.Controls.Add(this.rbStepSize0_001);
            this.gbStepSize.Controls.Add(this.rbStepSize10);
            this.gbStepSize.Controls.Add(this.rbStepSize1);
            this.gbStepSize.Controls.Add(this.rbStepSize0_1);
            this.gbStepSize.Controls.Add(this.rbStepSize0_01);
            this.gbStepSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbStepSize.ForeColor = System.Drawing.Color.Blue;
            this.gbStepSize.Location = new System.Drawing.Point(71, 251);
            this.gbStepSize.Name = "gbStepSize";
            this.gbStepSize.Size = new System.Drawing.Size(135, 71);
            this.gbStepSize.TabIndex = 222;
            this.gbStepSize.TabStop = false;
            this.gbStepSize.Text = "Step Size";
            // 
            // rbStepSize0_001
            // 
            this.rbStepSize0_001.AutoSize = true;
            this.rbStepSize0_001.Location = new System.Drawing.Point(13, 15);
            this.rbStepSize0_001.Name = "rbStepSize0_001";
            this.rbStepSize0_001.Size = new System.Drawing.Size(57, 20);
            this.rbStepSize0_001.TabIndex = 6;
            this.rbStepSize0_001.TabStop = true;
            this.rbStepSize0_001.Text = "0.001";
            this.rbStepSize0_001.UseVisualStyleBackColor = true;
            this.rbStepSize0_001.CheckedChanged += new System.EventHandler(this.rbStepSize0_001_CheckedChanged);
            // 
            // rbStepSize10
            // 
            this.rbStepSize10.AutoSize = true;
            this.rbStepSize10.Location = new System.Drawing.Point(76, 30);
            this.rbStepSize10.Name = "rbStepSize10";
            this.rbStepSize10.Size = new System.Drawing.Size(40, 20);
            this.rbStepSize10.TabIndex = 5;
            this.rbStepSize10.TabStop = true;
            this.rbStepSize10.Text = "10";
            this.rbStepSize10.UseVisualStyleBackColor = true;
            this.rbStepSize10.CheckedChanged += new System.EventHandler(this.rbStepSize10_CheckedChanged);
            // 
            // rbStepSize1
            // 
            this.rbStepSize1.AutoSize = true;
            this.rbStepSize1.Location = new System.Drawing.Point(76, 15);
            this.rbStepSize1.Name = "rbStepSize1";
            this.rbStepSize1.Size = new System.Drawing.Size(33, 20);
            this.rbStepSize1.TabIndex = 4;
            this.rbStepSize1.TabStop = true;
            this.rbStepSize1.Text = "1";
            this.rbStepSize1.UseVisualStyleBackColor = true;
            this.rbStepSize1.CheckedChanged += new System.EventHandler(this.rbStepSize1_CheckedChanged);
            // 
            // rbStepSize0_1
            // 
            this.rbStepSize0_1.AutoSize = true;
            this.rbStepSize0_1.Location = new System.Drawing.Point(13, 48);
            this.rbStepSize0_1.Name = "rbStepSize0_1";
            this.rbStepSize0_1.Size = new System.Drawing.Size(43, 20);
            this.rbStepSize0_1.TabIndex = 3;
            this.rbStepSize0_1.TabStop = true;
            this.rbStepSize0_1.Text = "0.1";
            this.rbStepSize0_1.UseVisualStyleBackColor = true;
            this.rbStepSize0_1.CheckedChanged += new System.EventHandler(this.rbStepSize0_1_CheckedChanged);
            // 
            // rbStepSize0_01
            // 
            this.rbStepSize0_01.AutoSize = true;
            this.rbStepSize0_01.Location = new System.Drawing.Point(13, 30);
            this.rbStepSize0_01.Name = "rbStepSize0_01";
            this.rbStepSize0_01.Size = new System.Drawing.Size(50, 20);
            this.rbStepSize0_01.TabIndex = 2;
            this.rbStepSize0_01.TabStop = true;
            this.rbStepSize0_01.Text = "0.01";
            this.rbStepSize0_01.UseVisualStyleBackColor = true;
            this.rbStepSize0_01.CheckedChanged += new System.EventHandler(this.rbStepSize0_01_CheckedChanged);
            // 
            // btLoadGcodeFile
            // 
            this.btLoadGcodeFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLoadGcodeFile.ForeColor = System.Drawing.Color.Blue;
            this.btLoadGcodeFile.Location = new System.Drawing.Point(263, 594);
            this.btLoadGcodeFile.Name = "btLoadGcodeFile";
            this.btLoadGcodeFile.Size = new System.Drawing.Size(90, 32);
            this.btLoadGcodeFile.TabIndex = 228;
            this.btLoadGcodeFile.Text = "Load";
            this.btLoadGcodeFile.UseVisualStyleBackColor = true;
            this.btLoadGcodeFile.Click += new System.EventHandler(this.btLoadGcodeFile_Click);
            // 
            // btIntBoard
            // 
            this.btIntBoard.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btIntBoard.ForeColor = System.Drawing.Color.Blue;
            this.btIntBoard.Location = new System.Drawing.Point(71, 594);
            this.btIntBoard.Name = "btIntBoard";
            this.btIntBoard.Size = new System.Drawing.Size(90, 32);
            this.btIntBoard.TabIndex = 226;
            this.btIntBoard.Text = "Init";
            this.btIntBoard.UseVisualStyleBackColor = true;
            this.btIntBoard.Click += new System.EventHandler(this.btIntBoard_Click);
            // 
            // gbJog
            // 
            this.gbJog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.gbJog.Controls.Add(this.btNegJog);
            this.gbJog.Controls.Add(this.btPosJog);
            this.gbJog.Controls.Add(this.btZPosJog);
            this.gbJog.Controls.Add(this.btZNegJog);
            this.gbJog.Controls.Add(this.btYNegJog);
            this.gbJog.Controls.Add(this.btXPosJog);
            this.gbJog.Controls.Add(this.label14);
            this.gbJog.Controls.Add(this.btXNegJog);
            this.gbJog.Controls.Add(this.btYPosJog);
            this.gbJog.Controls.Add(this.label13);
            this.gbJog.Controls.Add(this.label15);
            this.gbJog.Controls.Add(this.label16);
            this.gbJog.Controls.Add(this.label17);
            this.gbJog.Controls.Add(this.label19);
            this.gbJog.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbJog.ForeColor = System.Drawing.Color.Blue;
            this.gbJog.Location = new System.Drawing.Point(729, 395);
            this.gbJog.Name = "gbJog";
            this.gbJog.Size = new System.Drawing.Size(522, 231);
            this.gbJog.TabIndex = 225;
            this.gbJog.TabStop = false;
            this.gbJog.Text = "Jog";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Blue;
            this.label13.Location = new System.Drawing.Point(70, 187);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(42, 31);
            this.label13.TabIndex = 32;
            this.label13.Text = "Z-";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Blue;
            this.label15.Location = new System.Drawing.Point(96, 92);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(43, 31);
            this.label15.TabIndex = 34;
            this.label15.Text = "X-";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Blue;
            this.label16.Location = new System.Drawing.Point(382, 92);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(50, 31);
            this.label16.TabIndex = 35;
            this.label16.Text = "X+";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Blue;
            this.label17.Location = new System.Drawing.Point(263, 25);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(50, 31);
            this.label17.TabIndex = 36;
            this.label17.Text = "Y+";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Blue;
            this.label19.Location = new System.Drawing.Point(214, 183);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(43, 31);
            this.label19.TabIndex = 37;
            this.label19.Text = "Y-";
            // 
            // rbMovingModeRel
            // 
            this.rbMovingModeRel.AutoSize = true;
            this.rbMovingModeRel.Location = new System.Drawing.Point(9, 25);
            this.rbMovingModeRel.Name = "rbMovingModeRel";
            this.rbMovingModeRel.Size = new System.Drawing.Size(41, 20);
            this.rbMovingModeRel.TabIndex = 0;
            this.rbMovingModeRel.TabStop = true;
            this.rbMovingModeRel.Text = "rel";
            this.rbMovingModeRel.UseVisualStyleBackColor = true;
            // 
            // btGcodeEdit
            // 
            this.btGcodeEdit.Location = new System.Drawing.Point(6, 329);
            this.btGcodeEdit.Name = "btGcodeEdit";
            this.btGcodeEdit.Size = new System.Drawing.Size(58, 21);
            this.btGcodeEdit.TabIndex = 242;
            this.btGcodeEdit.Text = "Edit";
            this.btGcodeEdit.UseVisualStyleBackColor = true;
            this.btGcodeEdit.Click += new System.EventHandler(this.bbtGcodeEdit_Click);
            // 
            // lbθ3Coor
            // 
            this.lbθ3Coor.AutoSize = true;
            this.lbθ3Coor.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbθ3Coor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbθ3Coor.ForeColor = System.Drawing.Color.Yellow;
            this.lbθ3Coor.Location = new System.Drawing.Point(88, 193);
            this.lbθ3Coor.Name = "lbθ3Coor";
            this.lbθ3Coor.Size = new System.Drawing.Size(38, 24);
            this.lbθ3Coor.TabIndex = 237;
            this.lbθ3Coor.Text = "θ3:";
            // 
            // lbθ2Coor
            // 
            this.lbθ2Coor.AutoSize = true;
            this.lbθ2Coor.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbθ2Coor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbθ2Coor.ForeColor = System.Drawing.Color.Yellow;
            this.lbθ2Coor.Location = new System.Drawing.Point(88, 168);
            this.lbθ2Coor.Name = "lbθ2Coor";
            this.lbθ2Coor.Size = new System.Drawing.Size(38, 24);
            this.lbθ2Coor.TabIndex = 236;
            this.lbθ2Coor.Text = "θ2:";
            // 
            // lbθ1Coor
            // 
            this.lbθ1Coor.AutoSize = true;
            this.lbθ1Coor.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbθ1Coor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbθ1Coor.ForeColor = System.Drawing.Color.Yellow;
            this.lbθ1Coor.Location = new System.Drawing.Point(88, 144);
            this.lbθ1Coor.Name = "lbθ1Coor";
            this.lbθ1Coor.Size = new System.Drawing.Size(38, 24);
            this.lbθ1Coor.TabIndex = 235;
            this.lbθ1Coor.Text = "θ1:";
            // 
            // btθ2CoorZero
            // 
            this.btθ2CoorZero.Location = new System.Drawing.Point(318, 168);
            this.btθ2CoorZero.Name = "btθ2CoorZero";
            this.btθ2CoorZero.Size = new System.Drawing.Size(48, 21);
            this.btθ2CoorZero.TabIndex = 234;
            this.btθ2CoorZero.Text = "zero";
            this.btθ2CoorZero.UseVisualStyleBackColor = true;
            this.btθ2CoorZero.Click += new System.EventHandler(this.btθ2CoorZero_Click);
            // 
            // btθ3CoorZero
            // 
            this.btθ3CoorZero.Location = new System.Drawing.Point(318, 192);
            this.btθ3CoorZero.Name = "btθ3CoorZero";
            this.btθ3CoorZero.Size = new System.Drawing.Size(48, 21);
            this.btθ3CoorZero.TabIndex = 233;
            this.btθ3CoorZero.Text = "zero";
            this.btθ3CoorZero.UseVisualStyleBackColor = true;
            this.btθ3CoorZero.Click += new System.EventHandler(this.btθ3CoorZero_Click);
            // 
            // btθ1CoorSet
            // 
            this.btθ1CoorSet.Location = new System.Drawing.Point(372, 144);
            this.btθ1CoorSet.Name = "btθ1CoorSet";
            this.btθ1CoorSet.Size = new System.Drawing.Size(48, 21);
            this.btθ1CoorSet.TabIndex = 232;
            this.btθ1CoorSet.Text = "set";
            this.btθ1CoorSet.UseVisualStyleBackColor = true;
            this.btθ1CoorSet.Click += new System.EventHandler(this.btθ1CoorSet_Click);
            // 
            // btθ1CoorZero
            // 
            this.btθ1CoorZero.Location = new System.Drawing.Point(318, 144);
            this.btθ1CoorZero.Name = "btθ1CoorZero";
            this.btθ1CoorZero.Size = new System.Drawing.Size(48, 21);
            this.btθ1CoorZero.TabIndex = 229;
            this.btθ1CoorZero.Text = "zero";
            this.btθ1CoorZero.UseVisualStyleBackColor = true;
            this.btθ1CoorZero.Click += new System.EventHandler(this.btθ1CoorZero_Click);
            // 
            // tbYCoor
            // 
            this.tbYCoor.BackColor = System.Drawing.SystemColors.MenuText;
            this.tbYCoor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbYCoor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbYCoor.ForeColor = System.Drawing.Color.Yellow;
            this.tbYCoor.Location = new System.Drawing.Point(104, 54);
            this.tbYCoor.Name = "tbYCoor";
            this.tbYCoor.Size = new System.Drawing.Size(97, 20);
            this.tbYCoor.TabIndex = 167;
            this.tbYCoor.Text = "0";
            this.tbYCoor.TextChanged += new System.EventHandler(this.tbYCoor_TextChanged);
            // 
            // btθ2CoorSet
            // 
            this.btθ2CoorSet.Location = new System.Drawing.Point(372, 169);
            this.btθ2CoorSet.Name = "btθ2CoorSet";
            this.btθ2CoorSet.Size = new System.Drawing.Size(48, 21);
            this.btθ2CoorSet.TabIndex = 231;
            this.btθ2CoorSet.Text = "set";
            this.btθ2CoorSet.UseVisualStyleBackColor = true;
            this.btθ2CoorSet.Click += new System.EventHandler(this.btθ2CoorSet_Click);
            // 
            // btθ3CoorSet
            // 
            this.btθ3CoorSet.Location = new System.Drawing.Point(372, 192);
            this.btθ3CoorSet.Name = "btθ3CoorSet";
            this.btθ3CoorSet.Size = new System.Drawing.Size(48, 21);
            this.btθ3CoorSet.TabIndex = 230;
            this.btθ3CoorSet.Text = "set";
            this.btθ3CoorSet.UseVisualStyleBackColor = true;
            this.btθ3CoorSet.Click += new System.EventHandler(this.btθ3CoorSet_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbθ4Coor);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.tbθ3Coor);
            this.groupBox1.Controls.Add(this.tbθ4Coor);
            this.groupBox1.Controls.Add(this.btθ4CoorZero);
            this.groupBox1.Controls.Add(this.tbθ2Coor);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.btθ4CoorSet);
            this.groupBox1.Controls.Add(this.button22);
            this.groupBox1.Controls.Add(this.tbθ1Coor);
            this.groupBox1.Controls.Add(this.button23);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Blue;
            this.groupBox1.Location = new System.Drawing.Point(75, 117);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(362, 132);
            this.groupBox1.TabIndex = 238;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Join-space";
            // 
            // lbθ4Coor
            // 
            this.lbθ4Coor.AutoSize = true;
            this.lbθ4Coor.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbθ4Coor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbθ4Coor.ForeColor = System.Drawing.Color.Yellow;
            this.lbθ4Coor.Location = new System.Drawing.Point(14, 102);
            this.lbθ4Coor.Name = "lbθ4Coor";
            this.lbθ4Coor.Size = new System.Drawing.Size(38, 24);
            this.lbθ4Coor.TabIndex = 176;
            this.lbθ4Coor.Text = "θ4:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Yellow;
            this.label10.Location = new System.Drawing.Point(63, 211);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 24);
            this.label10.TabIndex = 180;
            this.label10.Text = "θ3:";
            // 
            // tbθ3Coor
            // 
            this.tbθ3Coor.BackColor = System.Drawing.SystemColors.MenuText;
            this.tbθ3Coor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbθ3Coor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbθ3Coor.ForeColor = System.Drawing.Color.Yellow;
            this.tbθ3Coor.Location = new System.Drawing.Point(103, 78);
            this.tbθ3Coor.Name = "tbθ3Coor";
            this.tbθ3Coor.Size = new System.Drawing.Size(98, 20);
            this.tbθ3Coor.TabIndex = 169;
            this.tbθ3Coor.Text = "0.000";
            this.tbθ3Coor.TextChanged += new System.EventHandler(this.tbθ3Coor_TextChanged);
            // 
            // tbθ4Coor
            // 
            this.tbθ4Coor.BackColor = System.Drawing.SystemColors.MenuText;
            this.tbθ4Coor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbθ4Coor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbθ4Coor.ForeColor = System.Drawing.Color.Yellow;
            this.tbθ4Coor.Location = new System.Drawing.Point(103, 102);
            this.tbθ4Coor.Name = "tbθ4Coor";
            this.tbθ4Coor.Size = new System.Drawing.Size(98, 20);
            this.tbθ4Coor.TabIndex = 178;
            this.tbθ4Coor.Text = "0.000";
            // 
            // btθ4CoorZero
            // 
            this.btθ4CoorZero.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btθ4CoorZero.ForeColor = System.Drawing.Color.Black;
            this.btθ4CoorZero.Location = new System.Drawing.Point(243, 102);
            this.btθ4CoorZero.Name = "btθ4CoorZero";
            this.btθ4CoorZero.Size = new System.Drawing.Size(48, 21);
            this.btθ4CoorZero.TabIndex = 170;
            this.btθ4CoorZero.Text = "zero";
            this.btθ4CoorZero.UseVisualStyleBackColor = true;
            // 
            // tbθ2Coor
            // 
            this.tbθ2Coor.BackColor = System.Drawing.SystemColors.MenuText;
            this.tbθ2Coor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbθ2Coor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbθ2Coor.ForeColor = System.Drawing.Color.Yellow;
            this.tbθ2Coor.Location = new System.Drawing.Point(102, 54);
            this.tbθ2Coor.Name = "tbθ2Coor";
            this.tbθ2Coor.Size = new System.Drawing.Size(99, 20);
            this.tbθ2Coor.TabIndex = 167;
            this.tbθ2Coor.Text = "0.000";
            this.tbθ2Coor.TextChanged += new System.EventHandler(this.tbθ2Coor_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(-21, 101);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(222, 25);
            this.label11.TabIndex = 176;
            this.label11.Text = "                                   ";
            // 
            // btθ4CoorSet
            // 
            this.btθ4CoorSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btθ4CoorSet.ForeColor = System.Drawing.Color.Black;
            this.btθ4CoorSet.Location = new System.Drawing.Point(297, 102);
            this.btθ4CoorSet.Name = "btθ4CoorSet";
            this.btθ4CoorSet.Size = new System.Drawing.Size(48, 21);
            this.btθ4CoorSet.TabIndex = 167;
            this.btθ4CoorSet.Text = "set";
            this.btθ4CoorSet.UseVisualStyleBackColor = true;
            // 
            // button22
            // 
            this.button22.Location = new System.Drawing.Point(293, 210);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(48, 21);
            this.button22.TabIndex = 179;
            this.button22.Text = "zero";
            this.button22.UseVisualStyleBackColor = true;
            // 
            // tbθ1Coor
            // 
            this.tbθ1Coor.BackColor = System.Drawing.SystemColors.MenuText;
            this.tbθ1Coor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbθ1Coor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbθ1Coor.ForeColor = System.Drawing.Color.Yellow;
            this.tbθ1Coor.Location = new System.Drawing.Point(104, 30);
            this.tbθ1Coor.Name = "tbθ1Coor";
            this.tbθ1Coor.Size = new System.Drawing.Size(97, 20);
            this.tbθ1Coor.TabIndex = 166;
            this.tbθ1Coor.Text = "0.000";
            this.tbθ1Coor.TextChanged += new System.EventHandler(this.tbθ1Coor_TextChanged);
            // 
            // button23
            // 
            this.button23.Location = new System.Drawing.Point(347, 210);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(48, 21);
            this.button23.TabIndex = 177;
            this.button23.Text = "set";
            this.button23.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(-20, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(222, 25);
            this.label7.TabIndex = 127;
            this.label7.Text = "                                   ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(-20, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(222, 25);
            this.label8.TabIndex = 168;
            this.label8.Text = "                                   ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(-21, 76);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(222, 25);
            this.label9.TabIndex = 129;
            this.label9.Text = "                                   ";
            // 
            // gbUnits
            // 
            this.gbUnits.Controls.Add(this.rbUnitsInch);
            this.gbUnits.Controls.Add(this.rbUnitsMm);
            this.gbUnits.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbUnits.ForeColor = System.Drawing.Color.Blue;
            this.gbUnits.Location = new System.Drawing.Point(209, 252);
            this.gbUnits.Name = "gbUnits";
            this.gbUnits.Size = new System.Drawing.Size(95, 70);
            this.gbUnits.TabIndex = 223;
            this.gbUnits.TabStop = false;
            this.gbUnits.Text = "Units";
            // 
            // rbUnitsInch
            // 
            this.rbUnitsInch.AutoSize = true;
            this.rbUnitsInch.Location = new System.Drawing.Point(6, 43);
            this.rbUnitsInch.Name = "rbUnitsInch";
            this.rbUnitsInch.Size = new System.Drawing.Size(50, 20);
            this.rbUnitsInch.TabIndex = 1;
            this.rbUnitsInch.TabStop = true;
            this.rbUnitsInch.Text = "inch";
            this.rbUnitsInch.UseVisualStyleBackColor = true;
            this.rbUnitsInch.CheckedChanged += new System.EventHandler(this.rbUnitsInch_CheckedChanged);
            // 
            // rbUnitsMm
            // 
            this.rbUnitsMm.AutoSize = true;
            this.rbUnitsMm.Location = new System.Drawing.Point(6, 22);
            this.rbUnitsMm.Name = "rbUnitsMm";
            this.rbUnitsMm.Size = new System.Drawing.Size(48, 20);
            this.rbUnitsMm.TabIndex = 0;
            this.rbUnitsMm.TabStop = true;
            this.rbUnitsMm.Text = "mm";
            this.rbUnitsMm.UseVisualStyleBackColor = true;
            this.rbUnitsMm.CheckedChanged += new System.EventHandler(this.rbUnitsMm_CheckedChanged);
            // 
            // tbZCoor
            // 
            this.tbZCoor.BackColor = System.Drawing.SystemColors.MenuText;
            this.tbZCoor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbZCoor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbZCoor.ForeColor = System.Drawing.Color.Yellow;
            this.tbZCoor.Location = new System.Drawing.Point(103, 78);
            this.tbZCoor.Name = "tbZCoor";
            this.tbZCoor.Size = new System.Drawing.Size(98, 20);
            this.tbZCoor.TabIndex = 169;
            this.tbZCoor.Text = "0";
            this.tbZCoor.TextChanged += new System.EventHandler(this.tbZCoor_TextChanged);
            // 
            // gbWorkSpace
            // 
            this.gbWorkSpace.Controls.Add(this.tbZCoor);
            this.gbWorkSpace.Controls.Add(this.tbYCoor);
            this.gbWorkSpace.Controls.Add(this.tbXCoor);
            this.gbWorkSpace.Controls.Add(this.label1);
            this.gbWorkSpace.Controls.Add(this.label2);
            this.gbWorkSpace.Controls.Add(this.label3);
            this.gbWorkSpace.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbWorkSpace.ForeColor = System.Drawing.Color.Blue;
            this.gbWorkSpace.Location = new System.Drawing.Point(75, 6);
            this.gbWorkSpace.Name = "gbWorkSpace";
            this.gbWorkSpace.Size = new System.Drawing.Size(362, 112);
            this.gbWorkSpace.TabIndex = 221;
            this.gbWorkSpace.TabStop = false;
            this.gbWorkSpace.Text = "Work-space";
            // 
            // tbXCoor
            // 
            this.tbXCoor.BackColor = System.Drawing.SystemColors.MenuText;
            this.tbXCoor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbXCoor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbXCoor.ForeColor = System.Drawing.Color.Yellow;
            this.tbXCoor.Location = new System.Drawing.Point(104, 28);
            this.tbXCoor.Name = "tbXCoor";
            this.tbXCoor.Size = new System.Drawing.Size(97, 20);
            this.tbXCoor.TabIndex = 166;
            this.tbXCoor.Text = "0";
            this.tbXCoor.TextChanged += new System.EventHandler(this.tbXCoor_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-20, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 25);
            this.label1.TabIndex = 127;
            this.label1.Text = "                                   ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-20, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(222, 25);
            this.label2.TabIndex = 168;
            this.label2.Text = "                                   ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(-21, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(222, 25);
            this.label3.TabIndex = 129;
            this.label3.Text = "                                   ";
            // 
            // btHomePosition
            // 
            this.btHomePosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btHomePosition.ForeColor = System.Drawing.Color.Blue;
            this.btHomePosition.Location = new System.Drawing.Point(167, 594);
            this.btHomePosition.Name = "btHomePosition";
            this.btHomePosition.Size = new System.Drawing.Size(90, 32);
            this.btHomePosition.TabIndex = 227;
            this.btHomePosition.Text = "Home";
            this.btHomePosition.UseVisualStyleBackColor = true;
            this.btHomePosition.Click += new System.EventHandler(this.btHomePosition_Click);
            // 
            // btZCoorSet
            // 
            this.btZCoorSet.Location = new System.Drawing.Point(372, 80);
            this.btZCoorSet.Name = "btZCoorSet";
            this.btZCoorSet.Size = new System.Drawing.Size(48, 21);
            this.btZCoorSet.TabIndex = 213;
            this.btZCoorSet.Text = "set";
            this.btZCoorSet.UseVisualStyleBackColor = true;
            this.btZCoorSet.Click += new System.EventHandler(this.btZCoorSet_Click);
            // 
            // btXCoorZero
            // 
            this.btXCoorZero.Location = new System.Drawing.Point(318, 32);
            this.btXCoorZero.Name = "btXCoorZero";
            this.btXCoorZero.Size = new System.Drawing.Size(48, 21);
            this.btXCoorZero.TabIndex = 212;
            this.btXCoorZero.Text = "zero";
            this.btXCoorZero.UseVisualStyleBackColor = true;
            this.btXCoorZero.Click += new System.EventHandler(this.btXCoorZero_Click);
            // 
            // gbMovingMode
            // 
            this.gbMovingMode.Controls.Add(this.rbMovingModeAbs);
            this.gbMovingMode.Controls.Add(this.rbMovingModeRel);
            this.gbMovingMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbMovingMode.ForeColor = System.Drawing.Color.Blue;
            this.gbMovingMode.Location = new System.Drawing.Point(318, 252);
            this.gbMovingMode.Name = "gbMovingMode";
            this.gbMovingMode.Size = new System.Drawing.Size(157, 72);
            this.gbMovingMode.TabIndex = 224;
            this.gbMovingMode.TabStop = false;
            this.gbMovingMode.Text = "Moving mode";
            // 
            // rbMovingModeAbs
            // 
            this.rbMovingModeAbs.AutoSize = true;
            this.rbMovingModeAbs.Location = new System.Drawing.Point(9, 47);
            this.rbMovingModeAbs.Name = "rbMovingModeAbs";
            this.rbMovingModeAbs.Size = new System.Drawing.Size(49, 20);
            this.rbMovingModeAbs.TabIndex = 1;
            this.rbMovingModeAbs.TabStop = true;
            this.rbMovingModeAbs.Text = "abs";
            this.rbMovingModeAbs.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "windy.png");
            this.imageList1.Images.SetKeyName(1, "stop.png");
            this.imageList1.Images.SetKeyName(2, "bolt.png");
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(426, 329);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(68, 68);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 244;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(426, 477);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(68, 68);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 245;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(426, 403);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(68, 68);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 246;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(426, 566);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(68, 23);
            this.button1.TabIndex = 247;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(426, 594);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(68, 23);
            this.button2.TabIndex = 248;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // SharpGLForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1263, 634);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbYCoor);
            this.Controls.Add(this.lbXCoor);
            this.Controls.Add(this.btYCoorZero);
            this.Controls.Add(this.btZCoorZero);
            this.Controls.Add(this.btXCoorSet);
            this.Controls.Add(this.btYCoorSet);
            this.Controls.Add(this.lbZCoor);
            this.Controls.Add(this.btGcodeSave);
            this.Controls.Add(this.tbGcodeEditTemp);
            this.Controls.Add(this.lvGcodeDisplay);
            this.Controls.Add(this.gbStepSize);
            this.Controls.Add(this.btLoadGcodeFile);
            this.Controls.Add(this.btIntBoard);
            this.Controls.Add(this.gbJog);
            this.Controls.Add(this.btGcodeEdit);
            this.Controls.Add(this.lbθ3Coor);
            this.Controls.Add(this.lbθ2Coor);
            this.Controls.Add(this.lbθ1Coor);
            this.Controls.Add(this.btθ2CoorZero);
            this.Controls.Add(this.btθ3CoorZero);
            this.Controls.Add(this.btθ1CoorSet);
            this.Controls.Add(this.btθ1CoorZero);
            this.Controls.Add(this.btθ2CoorSet);
            this.Controls.Add(this.btθ3CoorSet);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbUnits);
            this.Controls.Add(this.btHomePosition);
            this.Controls.Add(this.btZCoorSet);
            this.Controls.Add(this.btXCoorZero);
            this.Controls.Add(this.gbMovingMode);
            this.Controls.Add(this.openGLControl);
            this.Controls.Add(this.gbWorkSpace);
            this.Name = "SharpGLForm";
            this.Text = "SharpGL Form";
            this.Load += new System.EventHandler(this.SharpGLForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.openGLControl)).EndInit();
            this.gbStepSize.ResumeLayout(false);
            this.gbStepSize.PerformLayout();
            this.gbJog.ResumeLayout(false);
            this.gbJog.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbUnits.ResumeLayout(false);
            this.gbUnits.PerformLayout();
            this.gbWorkSpace.ResumeLayout(false);
            this.gbWorkSpace.PerformLayout();
            this.gbMovingMode.ResumeLayout(false);
            this.gbMovingMode.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SharpGL.OpenGLControl openGLControl;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lbYCoor;
        private System.Windows.Forms.Label lbXCoor;
        private System.Windows.Forms.Button btYCoorZero;
        public System.Windows.Forms.Button btNegJog;
        public System.Windows.Forms.Button btPosJog;
        public System.Windows.Forms.Button btZPosJog;
        public System.Windows.Forms.Button btZNegJog;
        private System.Windows.Forms.Button btZCoorZero;
        public System.Windows.Forms.Button btYNegJog;
        public System.Windows.Forms.Button btXPosJog;
        private System.Windows.Forms.Button btXCoorSet;
        private System.Windows.Forms.Button btYCoorSet;
        public System.Windows.Forms.Button btXNegJog;
        public System.Windows.Forms.Button btYPosJog;
        private System.Windows.Forms.Label lbZCoor;
        private System.Windows.Forms.Button btGcodeSave;
        private System.Windows.Forms.TextBox tbGcodeEditTemp;
        private System.Windows.Forms.ListView lvGcodeDisplay;
        private System.Windows.Forms.GroupBox gbStepSize;
        private System.Windows.Forms.RadioButton rbStepSize0_001;
        private System.Windows.Forms.RadioButton rbStepSize10;
        private System.Windows.Forms.RadioButton rbStepSize1;
        private System.Windows.Forms.RadioButton rbStepSize0_1;
        private System.Windows.Forms.RadioButton rbStepSize0_01;
        private System.Windows.Forms.Button btLoadGcodeFile;
        private System.Windows.Forms.Button btIntBoard;
        private System.Windows.Forms.GroupBox gbJog;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.RadioButton rbMovingModeRel;
        private System.Windows.Forms.Button btGcodeEdit;
        private System.Windows.Forms.Label lbθ3Coor;
        private System.Windows.Forms.Label lbθ2Coor;
        private System.Windows.Forms.Label lbθ1Coor;
        private System.Windows.Forms.Button btθ2CoorZero;
        private System.Windows.Forms.Button btθ3CoorZero;
        private System.Windows.Forms.Button btθ1CoorSet;
        private System.Windows.Forms.Button btθ1CoorZero;
        private System.Windows.Forms.TextBox tbYCoor;
        private System.Windows.Forms.Button btθ2CoorSet;
        private System.Windows.Forms.Button btθ3CoorSet;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbθ4Coor;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbθ3Coor;
        private System.Windows.Forms.TextBox tbθ4Coor;
        private System.Windows.Forms.Button btθ4CoorZero;
        private System.Windows.Forms.TextBox tbθ2Coor;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btθ4CoorSet;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.TextBox tbθ1Coor;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox gbUnits;
        private System.Windows.Forms.RadioButton rbUnitsInch;
        private System.Windows.Forms.RadioButton rbUnitsMm;
        private System.Windows.Forms.TextBox tbZCoor;
        private System.Windows.Forms.GroupBox gbWorkSpace;
        private System.Windows.Forms.TextBox tbXCoor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btHomePosition;
        private System.Windows.Forms.Button btZCoorSet;
        private System.Windows.Forms.Button btXCoorZero;
        private System.Windows.Forms.GroupBox gbMovingMode;
        private System.Windows.Forms.RadioButton rbMovingModeAbs;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

