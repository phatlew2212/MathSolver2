namespace MathSolver2
{
    partial class FormCalc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCalc));
            this.txtBot = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnSub = new System.Windows.Forms.Button();
            this.btnMulti = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.btnAC = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnAns = new System.Windows.Forms.Button();
            this.btnPercent = new System.Windows.Forms.Button();
            this.btnSin = new System.Windows.Forms.Button();
            this.btnCos = new System.Windows.Forms.Button();
            this.btnLn = new System.Windows.Forms.Button();
            this.btnSqrt = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.btnEqual = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.lblOp = new System.Windows.Forms.Label();
            this.rtbHistory = new System.Windows.Forms.RichTextBox();
            this.lblHis = new System.Windows.Forms.Label();
            this.btnCLearHistory = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.btnEq2 = new System.Windows.Forms.Button();
            this.btnEq1 = new System.Windows.Forms.Button();
            this.btnCalc = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBot
            // 
            this.txtBot.BackColor = System.Drawing.SystemColors.Menu;
            this.txtBot.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBot.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBot.Location = new System.Drawing.Point(167, 138);
            this.txtBot.Multiline = true;
            this.txtBot.Name = "txtBot";
            this.txtBot.Size = new System.Drawing.Size(670, 73);
            this.txtBot.TabIndex = 2;
            this.txtBot.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBot.TextChanged += new System.EventHandler(this.txtBot_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.MenuBar;
            this.panel2.Controls.Add(this.btnPlus);
            this.panel2.Controls.Add(this.btnSub);
            this.panel2.Controls.Add(this.btnMulti);
            this.panel2.Controls.Add(this.btnDiv);
            this.panel2.Controls.Add(this.btnAC);
            this.panel2.Controls.Add(this.btnDel);
            this.panel2.Controls.Add(this.btnAns);
            this.panel2.Controls.Add(this.btnPercent);
            this.panel2.Controls.Add(this.btnSin);
            this.panel2.Controls.Add(this.btnCos);
            this.panel2.Controls.Add(this.btnLn);
            this.panel2.Controls.Add(this.btnSqrt);
            this.panel2.Controls.Add(this.button17);
            this.panel2.Controls.Add(this.button18);
            this.panel2.Controls.Add(this.button19);
            this.panel2.Controls.Add(this.btnEqual);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.button6);
            this.panel2.Controls.Add(this.button7);
            this.panel2.Controls.Add(this.button8);
            this.panel2.Controls.Add(this.button14);
            this.panel2.Controls.Add(this.button11);
            this.panel2.Controls.Add(this.button12);
            this.panel2.Controls.Add(this.button13);
            this.panel2.Location = new System.Drawing.Point(167, 217);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(671, 308);
            this.panel2.TabIndex = 3;
            // 
            // btnPlus
            // 
            this.btnPlus.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPlus.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnPlus.Location = new System.Drawing.Point(335, 13);
            this.btnPlus.Margin = new System.Windows.Forms.Padding(4);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(110, 70);
            this.btnPlus.TabIndex = 85;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = false;
            this.btnPlus.Click += new System.EventHandler(this.btnOper);
            // 
            // btnSub
            // 
            this.btnSub.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSub.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSub.Location = new System.Drawing.Point(335, 84);
            this.btnSub.Margin = new System.Windows.Forms.Padding(4);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(110, 70);
            this.btnSub.TabIndex = 84;
            this.btnSub.Text = "-";
            this.btnSub.UseVisualStyleBackColor = false;
            this.btnSub.Click += new System.EventHandler(this.btnOper);
            // 
            // btnMulti
            // 
            this.btnMulti.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMulti.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnMulti.Location = new System.Drawing.Point(335, 155);
            this.btnMulti.Margin = new System.Windows.Forms.Padding(4);
            this.btnMulti.Name = "btnMulti";
            this.btnMulti.Size = new System.Drawing.Size(110, 70);
            this.btnMulti.TabIndex = 83;
            this.btnMulti.Text = "x";
            this.btnMulti.UseVisualStyleBackColor = false;
            this.btnMulti.Click += new System.EventHandler(this.btnOper);
            // 
            // btnDiv
            // 
            this.btnDiv.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDiv.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDiv.Location = new System.Drawing.Point(335, 226);
            this.btnDiv.Margin = new System.Windows.Forms.Padding(4);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(110, 70);
            this.btnDiv.TabIndex = 82;
            this.btnDiv.Text = "/";
            this.btnDiv.UseVisualStyleBackColor = false;
            this.btnDiv.Click += new System.EventHandler(this.btnOper);
            // 
            // btnAC
            // 
            this.btnAC.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAC.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnAC.Location = new System.Drawing.Point(554, 13);
            this.btnAC.Margin = new System.Windows.Forms.Padding(4);
            this.btnAC.Name = "btnAC";
            this.btnAC.Size = new System.Drawing.Size(110, 70);
            this.btnAC.TabIndex = 81;
            this.btnAC.Text = "AC";
            this.btnAC.UseVisualStyleBackColor = false;
            this.btnAC.Click += new System.EventHandler(this.btnAC_Click);
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDel.Location = new System.Drawing.Point(554, 155);
            this.btnDel.Margin = new System.Windows.Forms.Padding(4);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(110, 70);
            this.btnDel.TabIndex = 80;
            this.btnDel.Text = "⌫";
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnAns
            // 
            this.btnAns.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAns.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnAns.Location = new System.Drawing.Point(554, 225);
            this.btnAns.Margin = new System.Windows.Forms.Padding(4);
            this.btnAns.Name = "btnAns";
            this.btnAns.Size = new System.Drawing.Size(110, 70);
            this.btnAns.TabIndex = 79;
            this.btnAns.Text = "Ans";
            this.btnAns.UseVisualStyleBackColor = false;
            this.btnAns.Click += new System.EventHandler(this.btnAns_Click);
            // 
            // btnPercent
            // 
            this.btnPercent.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPercent.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnPercent.Location = new System.Drawing.Point(554, 84);
            this.btnPercent.Margin = new System.Windows.Forms.Padding(4);
            this.btnPercent.Name = "btnPercent";
            this.btnPercent.Size = new System.Drawing.Size(110, 70);
            this.btnPercent.TabIndex = 78;
            this.btnPercent.Text = "C";
            this.btnPercent.UseVisualStyleBackColor = false;
            this.btnPercent.Click += new System.EventHandler(this.C);
            // 
            // btnSin
            // 
            this.btnSin.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSin.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSin.Location = new System.Drawing.Point(444, 13);
            this.btnSin.Margin = new System.Windows.Forms.Padding(4);
            this.btnSin.Name = "btnSin";
            this.btnSin.Size = new System.Drawing.Size(110, 70);
            this.btnSin.TabIndex = 77;
            this.btnSin.Text = "Sin";
            this.btnSin.UseVisualStyleBackColor = false;
            this.btnSin.Click += new System.EventHandler(this.btnSin_Click);
            // 
            // btnCos
            // 
            this.btnCos.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCos.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnCos.Location = new System.Drawing.Point(444, 84);
            this.btnCos.Margin = new System.Windows.Forms.Padding(4);
            this.btnCos.Name = "btnCos";
            this.btnCos.Size = new System.Drawing.Size(110, 70);
            this.btnCos.TabIndex = 76;
            this.btnCos.Text = "Cos";
            this.btnCos.UseVisualStyleBackColor = true;
            this.btnCos.Click += new System.EventHandler(this.btnCos_Click);
            // 
            // btnLn
            // 
            this.btnLn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLn.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLn.Location = new System.Drawing.Point(444, 155);
            this.btnLn.Margin = new System.Windows.Forms.Padding(4);
            this.btnLn.Name = "btnLn";
            this.btnLn.Size = new System.Drawing.Size(110, 70);
            this.btnLn.TabIndex = 75;
            this.btnLn.Text = "ln";
            this.btnLn.UseVisualStyleBackColor = false;
            this.btnLn.Click += new System.EventHandler(this.btnLn_Click);
            // 
            // btnSqrt
            // 
            this.btnSqrt.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSqrt.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSqrt.Location = new System.Drawing.Point(444, 226);
            this.btnSqrt.Margin = new System.Windows.Forms.Padding(4);
            this.btnSqrt.Name = "btnSqrt";
            this.btnSqrt.Size = new System.Drawing.Size(110, 70);
            this.btnSqrt.TabIndex = 74;
            this.btnSqrt.Text = " √";
            this.btnSqrt.UseVisualStyleBackColor = false;
            this.btnSqrt.Click += new System.EventHandler(this.btnSqrt_Click);
            // 
            // button17
            // 
            this.button17.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button17.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button17.Location = new System.Drawing.Point(226, 13);
            this.button17.Margin = new System.Windows.Forms.Padding(4);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(110, 70);
            this.button17.TabIndex = 73;
            this.button17.Text = "9";
            this.button17.UseVisualStyleBackColor = false;
            this.button17.Click += new System.EventHandler(this.btnNUM);
            // 
            // button18
            // 
            this.button18.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button18.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button18.Location = new System.Drawing.Point(226, 84);
            this.button18.Margin = new System.Windows.Forms.Padding(4);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(110, 70);
            this.button18.TabIndex = 72;
            this.button18.Text = "6";
            this.button18.UseVisualStyleBackColor = false;
            this.button18.Click += new System.EventHandler(this.btnNUM);
            // 
            // button19
            // 
            this.button19.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button19.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button19.Location = new System.Drawing.Point(226, 155);
            this.button19.Margin = new System.Windows.Forms.Padding(4);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(110, 70);
            this.button19.TabIndex = 71;
            this.button19.Text = "3";
            this.button19.UseVisualStyleBackColor = false;
            this.button19.Click += new System.EventHandler(this.btnNUM);
            // 
            // btnEqual
            // 
            this.btnEqual.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEqual.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnEqual.Location = new System.Drawing.Point(226, 226);
            this.btnEqual.Margin = new System.Windows.Forms.Padding(4);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(110, 70);
            this.btnEqual.TabIndex = 70;
            this.btnEqual.Text = "=";
            this.btnEqual.UseVisualStyleBackColor = false;
            this.btnEqual.Click += new System.EventHandler(this.btnEqual_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button5.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button5.Location = new System.Drawing.Point(117, 13);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(110, 70);
            this.button5.TabIndex = 69;
            this.button5.Text = "8";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.btnNUM);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button6.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button6.Location = new System.Drawing.Point(117, 84);
            this.button6.Margin = new System.Windows.Forms.Padding(4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(110, 70);
            this.button6.TabIndex = 68;
            this.button6.Text = "5";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.btnNUM);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button7.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button7.Location = new System.Drawing.Point(117, 155);
            this.button7.Margin = new System.Windows.Forms.Padding(4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(110, 70);
            this.button7.TabIndex = 67;
            this.button7.Text = "2";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.btnNUM);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button8.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button8.Location = new System.Drawing.Point(117, 226);
            this.button8.Margin = new System.Windows.Forms.Padding(4);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(110, 70);
            this.button8.TabIndex = 66;
            this.button8.Text = ".";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.btnNUM);
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button14.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button14.Location = new System.Drawing.Point(7, 13);
            this.button14.Margin = new System.Windows.Forms.Padding(4);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(110, 70);
            this.button14.TabIndex = 65;
            this.button14.Text = "7";
            this.button14.UseVisualStyleBackColor = false;
            this.button14.Click += new System.EventHandler(this.btnNUM);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button11.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button11.Location = new System.Drawing.Point(7, 84);
            this.button11.Margin = new System.Windows.Forms.Padding(4);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(110, 70);
            this.button11.TabIndex = 64;
            this.button11.Text = "4";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.btnNUM);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button12.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button12.Location = new System.Drawing.Point(7, 155);
            this.button12.Margin = new System.Windows.Forms.Padding(4);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(110, 70);
            this.button12.TabIndex = 63;
            this.button12.Text = "1";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.btnNUM);
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button13.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button13.Location = new System.Drawing.Point(7, 226);
            this.button13.Margin = new System.Windows.Forms.Padding(4);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(110, 70);
            this.button13.TabIndex = 62;
            this.button13.Text = "0";
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.btnNUM);
            // 
            // lblOp
            // 
            this.lblOp.AutoSize = true;
            this.lblOp.BackColor = System.Drawing.Color.Transparent;
            this.lblOp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOp.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lblOp.Location = new System.Drawing.Point(786, 96);
            this.lblOp.Name = "lblOp";
            this.lblOp.Size = new System.Drawing.Size(0, 24);
            this.lblOp.TabIndex = 4;
            // 
            // rtbHistory
            // 
            this.rtbHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbHistory.Location = new System.Drawing.Point(172, 8);
            this.rtbHistory.Name = "rtbHistory";
            this.rtbHistory.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rtbHistory.Size = new System.Drawing.Size(619, 96);
            this.rtbHistory.TabIndex = 6;
            this.rtbHistory.Text = "";
            // 
            // lblHis
            // 
            this.lblHis.AutoSize = true;
            this.lblHis.BackColor = System.Drawing.SystemColors.Window;
            this.lblHis.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHis.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lblHis.Location = new System.Drawing.Point(182, 10);
            this.lblHis.Name = "lblHis";
            this.lblHis.Size = new System.Drawing.Size(120, 22);
            this.lblHis.TabIndex = 8;
            this.lblHis.Text = "History clear!";
            // 
            // btnCLearHistory
            // 
            this.btnCLearHistory.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCLearHistory.BackgroundImage")));
            this.btnCLearHistory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCLearHistory.Location = new System.Drawing.Point(788, 52);
            this.btnCLearHistory.Name = "btnCLearHistory";
            this.btnCLearHistory.Size = new System.Drawing.Size(38, 34);
            this.btnCLearHistory.TabIndex = 7;
            this.btnCLearHistory.UseVisualStyleBackColor = true;
            this.btnCLearHistory.Click += new System.EventHandler(this.btnCLearHistory_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(788, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(38, 34);
            this.button1.TabIndex = 5;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PeachPuff;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.btnEq2);
            this.panel1.Controls.Add(this.btnEq1);
            this.panel1.Controls.Add(this.btnCalc);
            this.panel1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(1, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(165, 526);
            this.panel1.TabIndex = 0;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.AntiqueWhite;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button4.Location = new System.Drawing.Point(0, 484);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(165, 42);
            this.button4.TabIndex = 3;
            this.button4.Text = "Đăng xuất";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnEq2
            // 
            this.btnEq2.BackColor = System.Drawing.Color.Peru;
            this.btnEq2.FlatAppearance.BorderSize = 0;
            this.btnEq2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEq2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnEq2.ForeColor = System.Drawing.SystemColors.Info;
            this.btnEq2.Location = new System.Drawing.Point(0, 292);
            this.btnEq2.Name = "btnEq2";
            this.btnEq2.Size = new System.Drawing.Size(165, 62);
            this.btnEq2.TabIndex = 2;
            this.btnEq2.Text = "Giải phương trình bậc 2";
            this.btnEq2.UseVisualStyleBackColor = false;
            this.btnEq2.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnEq1
            // 
            this.btnEq1.BackColor = System.Drawing.Color.Peru;
            this.btnEq1.FlatAppearance.BorderSize = 0;
            this.btnEq1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEq1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnEq1.ForeColor = System.Drawing.SystemColors.Info;
            this.btnEq1.Location = new System.Drawing.Point(0, 211);
            this.btnEq1.Name = "btnEq1";
            this.btnEq1.Size = new System.Drawing.Size(165, 62);
            this.btnEq1.TabIndex = 1;
            this.btnEq1.Text = "Giải phương trình bậc 1";
            this.btnEq1.UseVisualStyleBackColor = false;
            this.btnEq1.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnCalc
            // 
            this.btnCalc.BackColor = System.Drawing.Color.Brown;
            this.btnCalc.FlatAppearance.BorderSize = 0;
            this.btnCalc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalc.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnCalc.ForeColor = System.Drawing.SystemColors.Info;
            this.btnCalc.Location = new System.Drawing.Point(0, 149);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(165, 41);
            this.btnCalc.TabIndex = 0;
            this.btnCalc.Text = "Máy tính";
            this.btnCalc.UseVisualStyleBackColor = false;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // FormCalc
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(838, 525);
            this.Controls.Add(this.lblHis);
            this.Controls.Add(this.btnCLearHistory);
            this.Controls.Add(this.rtbHistory);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblOp);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtBot);
            this.MaximumSize = new System.Drawing.Size(854, 564);
            this.MinimumSize = new System.Drawing.Size(854, 564);
            this.Name = "FormCalc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCalc";
            this.Load += new System.EventHandler(this.FormCalc_Load);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnEq2;
        private System.Windows.Forms.Button btnEq1;
        private System.Windows.Forms.TextBox txtBot;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.Button btnMulti;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Button btnAC;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnAns;
        private System.Windows.Forms.Button btnPercent;
        private System.Windows.Forms.Button btnSin;
        private System.Windows.Forms.Button btnCos;
        private System.Windows.Forms.Button btnLn;
        private System.Windows.Forms.Button btnSqrt;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button btnEqual;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Label lblOp;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox rtbHistory;
        private System.Windows.Forms.Button btnCLearHistory;
        private System.Windows.Forms.Label lblHis;
    }
}