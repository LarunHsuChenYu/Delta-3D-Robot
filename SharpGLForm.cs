using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SharpGL;
using System.Runtime.InteropServices;
using System.IO;
using System.Threading;

namespace SharpGLWinformsApplication1
{
    public partial class SharpGLForm : Form
    {
        public vec3 vRotAngle, vDrawOriginal;
        public static float fWorkMaxAngle = 81.92f;
        public static float fWorkMinAngle = -37.18f;

        public static float fWorkRadio = 250f;
        public static float fWorkMaxZ = -371f;
        public static float fWorkMinZ = -521f;

        //public static float fWork
        public float fFovy = 75f;
        public vec3 MovePlatePos = new vec3(0, 0, -340.51800f);
        ListViewItem.ListViewSubItem SelectedLSI;               //Object when select List view Gcode
        double[] ThetaMotor = new double[3];
        double[] PositionAbs = new double[3];
        double[] ThetaPassiveRx = new double[3];
        double[] ThetaPassiveRy = new double[3];

        float UnitFactor=1;
        InverseKinematic IK1 = new InverseKinematic();
        float StepSize=1;

        public SharpGLForm()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            vDrawOriginal = new vec3(-15, 5, -15);
            //initial list view Gcode
            InitialGcodeDispaly();
        }
        private void SharpGLForm_Load(object sender, EventArgs e)
        {
            tbXCoor.Text = Math.Round(MovePlatePos.x,4).ToString();
            tbYCoor.Text = Math.Round(MovePlatePos.y,4).ToString();
            tbZCoor.Text = Math.Round(MovePlatePos.z,4).ToString();
            UpdateCoorRv();
            rbStepSize1.Checked = true;
            rbUnitsMm.Checked = true;
            rbMovingModeRel.Checked = true;
        }
        private void openGLControl_OpenGLDraw(object sender, PaintEventArgs e)
        {
            OpenGL gl = openGLControl.OpenGL;
            gl.Clear(OpenGL.GL_COLOR_BUFFER_BIT | OpenGL.GL_DEPTH_BUFFER_BIT);

            gl.LoadIdentity();

            gl.Perspective(fFovy, (double)Width / (double)Height, 0.01, 400.0);
            gl.LookAt(vDrawOriginal.x, vDrawOriginal.y, vDrawOriginal.z, 0, 0, 0, 0, 1, 0);

            gl.Rotate(vRotAngle.x, 1.0f, 0.0f, 0.0f);
            gl.Rotate(vRotAngle.y, 0.0f, 1.0f, 0.0f);
            gl.Rotate(vRotAngle.z, 0.0f, 0.0f, 1.0f);
            
            drawGrid(gl);
            Delta_3_Robot D3R = new Delta_3_Robot(new vec3(MovePlatePos.x, MovePlatePos.y, MovePlatePos.z));
            D3R.DrawDelta3Robot(ref gl);
            double[] ThetaMotor = new double[3];
            double[] ThetaPassiveRx = new double[3];
            double[] ThetaPassiveRy = new double[3];
            InverseKinematic IK = new InverseKinematic();
            IK.delta_calcInverse(MovePlatePos.x, MovePlatePos.y, MovePlatePos.z, ref ThetaMotor, ref ThetaPassiveRx, ref ThetaPassiveRy);
            /* label6.Text = "Leg1 Theta 1: " + ThetaMotor[0];
            label5.Text = "Leg2 Theta 1: " + ThetaMotor[1];
            label4.Text = "Leg3 Theta 1: " + ThetaMotor[2];

            label9.Text = "Leg1 Theta 2 Rx: " + ThetaPassiveRx[0];
            label8.Text = "Leg2 Theta 2 Rx: " + ThetaPassiveRx[1];
            label7.Text = "Leg3 Theta 2 Rx: " + ThetaPassiveRx[2];

            label12.Text = "Leg1 Theta 2 Ry: " + ThetaPassiveRy[0];
            label11.Text = "Leg2 Theta 2 Ry: " + ThetaPassiveRy[1];
            label10.Text = "Leg3 Theta 2 Ry: " + ThetaPassiveRy[2]; */
            tbXCoor.Text = Math.Round(MovePlatePos.x, 4).ToString();
            tbYCoor.Text = Math.Round(MovePlatePos.y, 4).ToString();
            tbZCoor.Text = Math.Round(MovePlatePos.z, 4).ToString();
            UpdateCoorRv();
            tbθ1Coor.Text = Math.Round(ThetaMotor[0], 4).ToString();
            tbθ2Coor.Text = Math.Round(ThetaMotor[1], 4).ToString();
            tbθ3Coor.Text = Math.Round(ThetaMotor[2], 4).ToString();

        }

        private void openGLControl_OpenGLInitialized(object sender, EventArgs e)
        {
            OpenGL gl = openGLControl.OpenGL;
            gl.ClearColor(0, 0, 0, 0);
        }

        private void openGLControl_Resized(object sender, EventArgs e)
        {
            OpenGL gl = openGLControl.OpenGL;
            gl.MatrixMode(OpenGL.GL_PROJECTION);
            gl.LoadIdentity();          
            gl.MatrixMode(OpenGL.GL_MODELVIEW);
        }
    
        //测试例子
        public void rtest(ref OpenGL gl)
        {
            //RobotComponent rc = new RobotComponent();

            //rc.DrawGroundPlane(ref gl);
            //rc.DrawRobotArm(ref gl);
        }
        
        private void openGLControl_KeyDown(object sender, KeyEventArgs e)
        {
            int t = e.KeyValue;
            switch (e.KeyCode)
            {   
                case Keys.NumPad6:
                    vDrawOriginal.x += 5f;
                    break;
                case Keys.NumPad4:
                    vDrawOriginal.x -= 5f;
                    break;
                case Keys.NumPad2:
                    vDrawOriginal.y -= 5f;
                    break;
                case Keys.NumPad8:
                    vDrawOriginal.y += 5f;
                    break;
                case Keys.Q:
                    vRotAngle.x += 5;
                    break;
                case Keys.A:
                    vRotAngle.x -= 5;
                    break;
                case Keys.W:
                    vRotAngle.y += 5;
                    break;
                case Keys.S:
                    vRotAngle.y -= 5;
                    break;
                case Keys.E:
                    vRotAngle.z += 5;
                    break;
                case Keys.D:
                    vRotAngle.z -= 5;
                    break;
                case Keys.Escape:
                    vRotAngle = new vec3(0, 0, 0);
                    break;
                default:
                    break;
            }
        }

        private void openGLControl_MouseWheel(object sender, MouseEventArgs e)
        {
            OpenGL gl = openGLControl.OpenGL;
            int tWheelCount = e.Delta / 120;
            if (tWheelCount > 0)
            {
                // Close
                fFovy -= 5f;
            }
            else if (tWheelCount < 0)
            {
                // Far
                fFovy += 5f;
            }
            
        }

        void drawGrid(OpenGL gl)
        {
            //绘制过程
            gl.PushAttrib(OpenGL.GL_CURRENT_BIT);  //保存当前属性
            gl.PushMatrix();                        //压入堆栈
            gl.Translate(0f, 0f, 0f);
            gl.Color(0f, 0f, 1f);

            //在X,Z平面上绘制网格
            for (float i = -50; i <= 50; i += 1)
            {
                //绘制线
                gl.Begin(OpenGL.GL_LINES);
                {
                    if (i == 0)
                        gl.Color(0f, 1f, 0f);
                    else
                        gl.Color(0f, 0f, 1f);

                    //X轴方向
                    gl.Vertex(-50f, 0f, i);
                    gl.Vertex(50f, 0f, i);
                    //Z轴方向 
                    gl.Vertex(i, 0f, -50f);
                    gl.Vertex(i, 0f, 50f);

                }
                gl.End();
            }
            gl.PopMatrix();
            gl.PopAttrib();
        }
        //start h
        public void InitialGcodeDispaly()
        {
            lvGcodeDisplay.View = View.Details;
            lvGcodeDisplay.Columns.Add("Code");
            lvGcodeDisplay.Columns.Add("X");
            lvGcodeDisplay.Columns.Add("Y");
            lvGcodeDisplay.Columns.Add("Z");
            //lvGcodeDisplay.Columns.Add("θ1");
            //lvGcodeDisplay.Columns.Add("θ2");
            //lvGcodeDisplay.Columns.Add("θ3");
            //lvGcodeDisplay.Columns.Add("θ4");
            // Auto-size the columns
            for (int i = 0; i < lvGcodeDisplay.Columns.Count; i++)
            {
                lvGcodeDisplay.Columns[i].Width = -2;
            }
            //For temporary tb
            tbGcodeEditTemp.Visible = false;
            tbGcodeEditTemp.Enabled = false;
        }

        private void btLoadGcodeFile_Click(object sender, EventArgs e)
        {
            ReadInTimeSheet();
        }

        private void ReadInTimeSheet()
        {
            var fileLines = File.ReadAllLines(@"IntersectionPoints1.ngc");
            string[] StringArray = new string[3];
            string line;
            lvGcodeDisplay.Items.Clear();
            for (int i = 0; i < fileLines.Length; i++)
            {
                line = fileLines[i];
                StringArray = line.Split(' ');
                switch (StringArray.Length)
                {
                    case 1:
                        lvGcodeDisplay.Items.Add(new ListViewItem(new[]
                        {
                        StringArray[0],
                        }));
                        break;
                    case 2:
                        lvGcodeDisplay.Items.Add(new ListViewItem(new[]
                        {
                        StringArray[0],
                        StringArray[0 + 1],
                        }));
                        break;
                    case 3:
                        lvGcodeDisplay.Items.Add(new ListViewItem(new[]
                        {
                        StringArray[0],
                        StringArray[0 + 1],
                        StringArray[0 + 2],
                        }));
                        break;
                    case 4:
                        lvGcodeDisplay.Items.Add(new ListViewItem(new[]
                        {
                        StringArray[0],
                        StringArray[0 + 1],
                        StringArray[0 + 2],
                        StringArray[0 + 3],
                        }));
                        break;
                    default:
                        break;
                }
            }

            // Resize the columns
            for (int i = 0; i < lvGcodeDisplay.Columns.Count; i++)
            {
                lvGcodeDisplay.Columns[i].Width = -2;
            }
        }

        //editable listview
        private void lvGcodeDisplay_MouseUp(object sender, MouseEventArgs e)
        {
            ListViewHitTestInfo i = lvGcodeDisplay.HitTest(e.X, e.Y);
            SelectedLSI = i.SubItem;
            if (SelectedLSI == null)
                return;
            else if (i.Item.Index > 2 & i.Item.Index < lvGcodeDisplay.Items.Count - 2)
            {
                tbXCoor.Text = lvGcodeDisplay.Items[i.Item.Index].SubItems[1].Text.Substring(1);
                tbYCoor.Text = lvGcodeDisplay.Items[i.Item.Index].SubItems[2].Text.Substring(1);
                tbZCoor.Text = lvGcodeDisplay.Items[i.Item.Index].SubItems[3].Text.Substring(1);
                UpdateCoorRv();
                MovePlatePos.x = Convert.ToSingle(tbXCoor.Text.ToString());
                MovePlatePos.y = Convert.ToSingle(tbYCoor.Text.ToString());
                MovePlatePos.z = Convert.ToSingle(tbZCoor.Text.ToString());
            }
            int border = 0;
            switch (lvGcodeDisplay.BorderStyle)
            {
                case BorderStyle.FixedSingle:
                    border = 1;
                    break;
                case BorderStyle.Fixed3D:
                    border = 2;
                    break;
            }

            int CellWidth = SelectedLSI.Bounds.Width;
            int CellHeight = SelectedLSI.Bounds.Height;
            int CellLeft = border + lvGcodeDisplay.Left + i.SubItem.Bounds.Left;
            int CellTop = lvGcodeDisplay.Top + i.SubItem.Bounds.Top;
            // First Column
            if (i.SubItem == i.Item.SubItems[0])
                CellWidth = lvGcodeDisplay.Columns[0].Width;

            tbGcodeEditTemp.Location = new Point(CellLeft, CellTop);
            tbGcodeEditTemp.Size = new Size(CellWidth, CellHeight);
            tbGcodeEditTemp.Visible = true;
            tbGcodeEditTemp.BringToFront();
            tbGcodeEditTemp.Text = i.SubItem.Text;
            tbGcodeEditTemp.Select();
            tbGcodeEditTemp.SelectAll();
        }
        private void lvGcodeDisplay_MouseDown(object sender, MouseEventArgs e)
        {
            HideTextEditor();
        }
        private void lvGcodeDisplay_Scroll(object sender, EventArgs e)
        {
            HideTextEditor();
        }
        private void TxtEdit_Leave(object sender, EventArgs e)
        {
            HideTextEditor();
        }
        private void TxtEdit_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
                HideTextEditor();
        }
        private void HideTextEditor()
        {
            tbGcodeEditTemp.Visible = false;
            if (SelectedLSI != null)
                SelectedLSI.Text = tbGcodeEditTemp.Text;
            SelectedLSI = null;
            tbGcodeEditTemp.Text = "";
        }
        private void bbtGcodeEdit_Click(object sender, EventArgs e)
        {
            if (btGcodeEdit.Text == "Edit")
            {
                tbGcodeEditTemp.Enabled = true;
                btGcodeEdit.Text = "Done";
                btGcodeSave.Enabled = false;
            }
            else if (btGcodeEdit.Text == "Done")
            {
                tbGcodeEditTemp.Enabled = false;
                btGcodeEdit.Text = "Edit";
                btGcodeSave.Enabled = true;
            }
        }
        // End editable listview

        // Save data from listview
        private void btGcodeSave_Click(object sender, EventArgs e)
        {
            TextWriter tw = new StreamWriter("IntersectionPoints1.ngc");
            StringBuilder listViewContent = new StringBuilder();
            for (int item = 0; item < this.lvGcodeDisplay.Items.Count; item++)
            {
                //3 line Header of file
                if (item == 0)
                {
                    for (int subitem = 0; subitem < 2; subitem++) //2: first line have 2 subitems
                    {
                        listViewContent.Append(this.lvGcodeDisplay.Items[item].SubItems[subitem].Text);
                        if (subitem < 2 - 1) //2: subitems
                            listViewContent.Append(" ");
                    }
                }
                else if (item == 1)
                {
                    for (int subitem = 0; subitem < 4; subitem++) //2: second line have 2 subitems
                    {
                        listViewContent.Append(this.lvGcodeDisplay.Items[item].SubItems[subitem].Text);
                        if (subitem < 4 - 1) //2: subitems
                            listViewContent.Append(" ");
                    }
                }
                else if (item == 2)
                {
                    for (int subitem = 0; subitem < 2; subitem++) //2: 3th line have 2 subitems
                    {
                        listViewContent.Append(this.lvGcodeDisplay.Items[item].SubItems[subitem].Text);
                        if (subitem < 2 - 1) //2: subitems
                            listViewContent.Append(" ");
                    }
                }
                //2 line of footer of file
                else if (item == this.lvGcodeDisplay.Items.Count - 2)
                {
                    for (int subitem = 0; subitem < 1; subitem++) //
                    {
                        listViewContent.Append(this.lvGcodeDisplay.Items[item].SubItems[subitem].Text);
                        if (subitem < 1 - 1) //1: subitems
                            listViewContent.Append(" ");
                    }
                }
                else if (item == this.lvGcodeDisplay.Items.Count - 1)
                {
                    for (int subitem = 0; subitem < 1; subitem++) //2: first line have 2 subitems
                    {
                        listViewContent.Append(this.lvGcodeDisplay.Items[item].SubItems[subitem].Text);
                        if (subitem < 1 - 1) //1: subitems
                            listViewContent.Append(" ");
                    }
                }
                //Body content process
                else
                {
                    for (int subitem = 0; subitem < this.lvGcodeDisplay.Columns.Count; subitem++)
                    {
                        listViewContent.Append(this.lvGcodeDisplay.Items[item].SubItems[subitem].Text);
                        if (subitem < this.lvGcodeDisplay.Columns.Count - 1)
                            listViewContent.Append(" ");
                    }
                }
                tw.WriteLine(listViewContent);
                listViewContent = new StringBuilder();
            }
            tw.Close();
        }

        private void btZPosJog_Click(object sender, EventArgs e)
        {
            MovePlatePos.z += 1 * StepSize * UnitFactor;
            tbZCoor.Text = Math.Round((MovePlatePos.z / UnitFactor),4).ToString();
            UpdateCoorRv();
        }

        private void btZNegJog_Click(object sender, EventArgs e)
        {
            MovePlatePos.z -= 1 * StepSize * UnitFactor;
            tbZCoor.Text = Math.Round((MovePlatePos.z / UnitFactor),4).ToString();
            UpdateCoorRv();
        }

        private void btXNegJog_Click(object sender, EventArgs e)
        {
            MovePlatePos.x -= 1 * StepSize * UnitFactor;
            tbXCoor.Text = Math.Round((MovePlatePos.x / UnitFactor),4).ToString();
            UpdateCoorRv();
        }

        private void btXPosJog_Click(object sender, EventArgs e)
        {
            
            MovePlatePos.x += 1 * StepSize*UnitFactor;
            tbXCoor.Text = Math.Round((MovePlatePos.x/ UnitFactor),4).ToString();
            UpdateCoorRv();
        }

        private void btYNegJog_Click(object sender, EventArgs e)
        {
            MovePlatePos.y -= 1 * StepSize * UnitFactor;
            tbYCoor.Text = Math.Round((MovePlatePos.y / UnitFactor),4).ToString();
            UpdateCoorRv();
        }

        private void btYPosJog_Click(object sender, EventArgs e)
        {
            MovePlatePos.y += 1 * StepSize * UnitFactor;
            tbYCoor.Text = Math.Round((MovePlatePos.y / UnitFactor),4).ToString();
            UpdateCoorRv();
        }

        private void tbθ2Coor_TextChanged(object sender, EventArgs e)
        {
            double parsedValue;
            if (!double.TryParse(tbθ2Coor.Text, out parsedValue))
            {
                tbθ2Coor.Text = "0";
            }
        }

        private void btHomePosition_Click(object sender, EventArgs e)
        {
            MovePlatePos.x = 0;
            MovePlatePos.y = 0;
            MovePlatePos.z = -340.518f;
            tbXCoor.Text = Math.Round((MovePlatePos.x/UnitFactor),4).ToString();
            tbYCoor.Text = Math.Round((MovePlatePos.y/ UnitFactor),4).ToString();
            tbZCoor.Text = Math.Round((MovePlatePos.z / UnitFactor),4).ToString();
            UpdateCoorRv();
        }

        private void btIntBoard_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Initial parameters for Motion Board successful.","Info"); //it will load C program to initial parameters for KFlop board
        }

        private void rbStepSize1_CheckedChanged(object sender, EventArgs e)
        {
            if (rbStepSize1.Checked == true)
                StepSize = 1;
        }

        private void rbStepSize0_001_CheckedChanged(object sender, EventArgs e)
        {
            if (rbStepSize0_001.Checked == true)
                StepSize = 0.001f;
        }

        private void rbStepSize0_01_CheckedChanged(object sender, EventArgs e)
        {
            if (rbStepSize0_01.Checked == true)
                StepSize = 0.01f;
        }

        private void rbStepSize0_1_CheckedChanged(object sender, EventArgs e)
        {
            if (rbStepSize0_1.Checked == true)
                StepSize = 0.1f;
        }

        private void rbStepSize10_CheckedChanged(object sender, EventArgs e)
        {
            if (rbStepSize10.Checked == true)
                StepSize = 10;
        }

        private void btXCoorSet_Click(object sender, EventArgs e)
        {
            UpdateCoorRv();
            MovePlatePos.x = Convert.ToSingle(tbXCoor.Text.ToString())*UnitFactor;
        }

        private void btYCoorSet_Click(object sender, EventArgs e)
        {
            UpdateCoorRv();
            MovePlatePos.y = Convert.ToSingle(tbYCoor.Text.ToString()) * UnitFactor;
        }

        private void btZCoorSet_Click(object sender, EventArgs e)
        {
            UpdateCoorRv();
            MovePlatePos.z = Convert.ToSingle(tbZCoor.Text.ToString()) * UnitFactor;
        }

        private void btθ1CoorSet_Click(object sender, EventArgs e)
        {
            UpdateCoorFw();
            MovePlatePos.x = Convert.ToSingle(tbXCoor.Text.ToString()) * UnitFactor;
            MovePlatePos.y = Convert.ToSingle(tbYCoor.Text.ToString()) * UnitFactor;
            MovePlatePos.z = Convert.ToSingle(tbZCoor.Text.ToString()) * UnitFactor;
        }

        private void btXCoorZero_Click(object sender, EventArgs e)
        {
            tbXCoor.Text = "0";
            MovePlatePos.x = Convert.ToSingle(tbXCoor.Text.ToString());
            UpdateCoorRv();
        }

        private void btYCoorZero_Click(object sender, EventArgs e)
        {
            tbYCoor.Text = "0";
            MovePlatePos.y = Convert.ToSingle(tbYCoor.Text.ToString());
            UpdateCoorRv();
        }

        private void btZCoorZero_Click(object sender, EventArgs e)
        {
            tbZCoor.Text = "0";
            MovePlatePos.z = Convert.ToSingle(tbZCoor.Text.ToString());
            UpdateCoorRv();
        }

        private void tbXCoor_TextChanged(object sender, EventArgs e)
        {
            double parsedValue;
            if (!double.TryParse(tbXCoor.Text, out parsedValue))
            {
                tbXCoor.Text = "0";
            }
        }

        private void btθ2CoorSet_Click(object sender, EventArgs e)
        {
            UpdateCoorFw();
            MovePlatePos.x = Convert.ToSingle(tbXCoor.Text.ToString()) * UnitFactor;
            MovePlatePos.y = Convert.ToSingle(tbYCoor.Text.ToString()) * UnitFactor;
            MovePlatePos.z = Convert.ToSingle(tbZCoor.Text.ToString()) * UnitFactor;
        }

        private void btθ3CoorSet_Click(object sender, EventArgs e)
        {
            UpdateCoorFw();
            MovePlatePos.x = Convert.ToSingle(tbXCoor.Text.ToString()) * UnitFactor;
            MovePlatePos.y = Convert.ToSingle(tbYCoor.Text.ToString()) * UnitFactor;
            MovePlatePos.z = Convert.ToSingle(tbZCoor.Text.ToString()) * UnitFactor;
        }

        private void btθ1CoorZero_Click(object sender, EventArgs e)
        {
            tbθ1Coor.Text = "0";
            UpdateCoorFw();
            MovePlatePos.x = Convert.ToSingle(tbXCoor.Text.ToString());
            MovePlatePos.y = Convert.ToSingle(tbYCoor.Text.ToString());
            MovePlatePos.z = Convert.ToSingle(tbZCoor.Text.ToString());
        }

        private void btθ2CoorZero_Click(object sender, EventArgs e)
        {
            tbθ2Coor.Text = "0";
            UpdateCoorFw();
            MovePlatePos.x = Convert.ToSingle(tbXCoor.Text.ToString());
            MovePlatePos.y = Convert.ToSingle(tbYCoor.Text.ToString());
            MovePlatePos.z = Convert.ToSingle(tbZCoor.Text.ToString());
        }

        private void btθ3CoorZero_Click(object sender, EventArgs e)
        {
            tbθ3Coor.Text = "0";
            UpdateCoorFw();
            MovePlatePos.x = Convert.ToSingle(tbXCoor.Text.ToString());
            MovePlatePos.y = Convert.ToSingle(tbYCoor.Text.ToString());
            MovePlatePos.z = Convert.ToSingle(tbZCoor.Text.ToString());
        }

        private void tbθ1Coor_TextChanged(object sender, EventArgs e)
        {
            double parsedValue;
            if (!double.TryParse(tbθ1Coor.Text, out parsedValue))
            {
                tbθ1Coor.Text = "0";
            }
        }

        private void tbθ3Coor_TextChanged(object sender, EventArgs e)
        {
            double parsedValue;
            if (!double.TryParse(tbθ3Coor.Text, out parsedValue))
            {
                tbθ3Coor.Text = "0";
            }
        }

        private void rbUnitsMm_CheckedChanged(object sender, EventArgs e)
        {
            if (rbUnitsMm.Checked == true)
            {
                UnitFactor = 1;
                tbXCoor.Text = (MovePlatePos.x / UnitFactor).ToString();
                tbYCoor.Text = (MovePlatePos.y / UnitFactor).ToString();
                tbZCoor.Text = (MovePlatePos.z / UnitFactor).ToString();
            }
        }

        private void rbUnitsInch_CheckedChanged(object sender, EventArgs e)
        {
            if (rbUnitsInch.Checked == true)
            {
                UnitFactor = 25.4f;
                tbXCoor.Text = (MovePlatePos.x / UnitFactor).ToString();
                tbYCoor.Text = (MovePlatePos.y / UnitFactor).ToString();
                tbZCoor.Text = (MovePlatePos.z / UnitFactor).ToString();
            }
        }

        private void tbYCoor_TextChanged(object sender, EventArgs e)
        {
            double parsedValue;
            if (!double.TryParse(tbYCoor.Text, out parsedValue))
            {
                tbYCoor.Text = "0";
            }
        }

        private void tbZCoor_TextChanged(object sender, EventArgs e)
        {
            double parsedValue;
            if (!double.TryParse(tbZCoor.Text, out parsedValue))
            {
                tbZCoor.Text = "0";
            }
        }

        public void UpdateCoorRv()
        {
            int Status;
            Status = IK1.delta_calcInverse(Convert.ToSingle(tbXCoor.Text)*UnitFactor, Convert.ToSingle(tbYCoor.Text) * UnitFactor, Convert.ToSingle(tbZCoor.Text) * UnitFactor, ref ThetaMotor, ref ThetaPassiveRx, ref ThetaPassiveRy);
            if (Status == 0)
            {
                tbθ1Coor.Text = Math.Round(ThetaMotor[0], 4).ToString();
                tbθ2Coor.Text = Math.Round(ThetaMotor[1], 4).ToString();
                tbθ3Coor.Text = Math.Round(ThetaMotor[2], 4).ToString();
            }
            else
            {
                tbθ1Coor.Text = "NaN";
                tbθ2Coor.Text = "NaN";
                tbθ3Coor.Text = "NaN";
                
            }
            if ((tbθ1Coor.Text == "NaN") | (tbθ2Coor.Text == "NaN") | (tbθ3Coor.Text == "NaN"))
            {
                MessageBox.Show("Eror code xxx");
            }
        }

        public void UpdateCoorFw()
        {
            int Status = 0;
            Status = IK1.delta_calcForward(Convert.ToSingle(tbθ1Coor.Text), Convert.ToSingle(tbθ2Coor.Text), Convert.ToSingle(tbθ3Coor.Text), ref PositionAbs);
            
            if (Status == 0)
            {
                tbXCoor.Text = (Math.Round(PositionAbs[0],4) * UnitFactor).ToString();
                tbYCoor.Text = (Math.Round(PositionAbs[1],4) * UnitFactor).ToString();
                tbZCoor.Text = (Math.Round(PositionAbs[2],4) * UnitFactor).ToString();
            }
            else
            {
                tbXCoor.Text = "NaN";
                tbYCoor.Text = "NaN";
                tbZCoor.Text = "NaN";
            }
            if ((tbXCoor.Text == "NaN") | (tbXCoor.Text == "NaN" )| (tbXCoor.Text == "NaN"))
            {
                MessageBox.Show("Eror code xxx");
            }
        }


        #region Auto Thread Test

        //private Thread Thread_AutoRun;
        private object locker = new object();
        private CancellationTokenSource cts;
        private int iListIndex = 0;

        private List<vec3> list = new List<vec3>();

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
            if (iListIndex == 0)
            {
                for (int i = 3; i < lvGcodeDisplay.Items.Count; i++)
                {
                    if (lvGcodeDisplay.Items[i].SubItems[0].Text == "G1")
                    {
                        vec3 p = new vec3(
                            float.Parse(lvGcodeDisplay.Items[i].SubItems[1].Text.Substring(1, lvGcodeDisplay.Items[i].SubItems[1].Text.Length - 1)),
                            float.Parse(lvGcodeDisplay.Items[i].SubItems[2].Text.Substring(1, lvGcodeDisplay.Items[i].SubItems[2].Text.Length - 1)),
                            float.Parse(lvGcodeDisplay.Items[i].SubItems[3].Text.Substring(1, lvGcodeDisplay.Items[i].SubItems[3].Text.Length - 1)));
                        list.Add(p);
                    }

                }
                cts = new CancellationTokenSource();
                ThreadPool.QueueUserWorkItem(state => AutoMove(cts.Token));
            }
            else
            {
                cts = new CancellationTokenSource();
                ThreadPool.QueueUserWorkItem(state => AutoMove(cts.Token));
            }
            

            //Thread_AutoRun = new Thread(AutoMove);
            //Thread_AutoRun.IsBackground = true;
            //Thread_AutoRun.Start();

        }
        
        private void AutoMove(CancellationToken token)
        {
            float fDistance = 0;
            string tmp = string.Empty;
            
            //foreach (vec3 p in list)
            while(iListIndex < list.Count)
            {
                vec3 p = list[iListIndex];
                if (!token.IsCancellationRequested)
                {
                    fDistance = (p - MovePlatePos).length();
                    PlateMove(p);
                    iListIndex++;
                }
                else
                {
                    tmp = " ---> Cancel Moving Process!!!";
                    MessageBox.Show(tmp);
                    return;
                }
            }

            if (iListIndex >= list.Count)
            {
                MessageBox.Show("Done" + tmp);
                iListIndex = 0;
                list.Clear();
            }
                
        }

        public void PlateMove(object states, vec3 vDestination)
        {
            if (JudgementWorkspace(vDestination))
            {
                var cts = states as CancellationTokenSource;
                float fUnit = 0;
                vec3 unitMove = (vDestination - MovePlatePos).normalize();
                fUnit = unitMove.length();
                while (!MovePlatePos.Equals(vDestination) && !cts.IsCancellationRequested)
                {
                    if ((MovePlatePos - vDestination).length() - fUnit > StepSize)
                        MovePlatePos += unitMove * StepSize;
                    else
                    {
                        MovePlatePos = vDestination;
                        Thread.Sleep(1000);
                    }
                    Thread.Sleep(50);
                }
            }
            else
            {
                MessageBox.Show(string.Format("the points:\r\nX:{0},Y:{1},Z:{2}\r\nis not in the workplace!!!", vDestination.x, vDestination.y, vDestination.z));
                return;
            }
           
        }

        public void PlateMove(vec3 vDestination)
        {
            if (JudgementWorkspace(vDestination))
            {
                float fUnit = 0;
                vec3 unitMove = (vDestination - MovePlatePos).normalize();
                fUnit = unitMove.length();
                while (!MovePlatePos.Equals(vDestination))
                {
                    if ((MovePlatePos - vDestination).length() - fUnit > StepSize)
                        MovePlatePos += unitMove * StepSize;
                    else
                    {
                        MovePlatePos = vDestination;
                        Thread.Sleep(1000);
                    }
                    Thread.Sleep(50);
                }

            }
            else
            {
                MessageBox.Show(string.Format("the points:\r\nX:{0},Y:{1},Z:{2}\r\nis not in the workplace!!!", vDestination.x,vDestination.y, vDestination.z));
                return;
            }
        }


        public bool JudgementWorkspace(vec3 p)
        {
            bool bResult = true;

            if (p.z < -526f || p.z > -376)
            {
                bResult = false;
            }

            if (p.x * p.x + p.y * p.y > fWorkRadio * fWorkRadio)
            {
                bResult = false;
            }

            if (!bResult)
                MessageBox.Show("The Next Position will OVER WORKSPACE");

            return bResult;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            vec3 p = new vec3(0, 0, -376);

            CancellationTokenSource TmpCts = new CancellationTokenSource();
            ThreadPool.QueueUserWorkItem(state => PlateMove(TmpCts, p));
        }

        //Stop
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            cts.Cancel();
            iListIndex = 0;
            list.Clear();
            PlateMove(new vec3(0, 0, -340.51800f));
        }

        //Pause
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            cts.Cancel();
        }

        #endregion

    }

}
