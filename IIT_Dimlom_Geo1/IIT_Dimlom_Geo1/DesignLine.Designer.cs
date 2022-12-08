﻿using IIT_Dimlom_Geo1.Properties;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using DiplomGeoDLL;

namespace IIT_Dimlom_Geo1
{
    partial class DesignLine
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        //private IContainer components;
        private Panel panel7;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button button1;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private GroupBox groupBox3;
        private GroupBox groupBox5;
        private Button button8;
        private Button button7;
        private GroupBox groupBox4;
        private Button button6;
        private Button button13;
        private Button button12;
        private Button button11;
        private Button button10;
        private Button button9;
        private Label label4;
        private Label label1;
        private ListBox listBox1;
        private TextBox textBox4;
        private Button button19;
        private Button button18;
        private Button button17;
        private Button button16;
        private Button button15;
        private Button button14;
        private Button button26;
        private Button button25;
        private Button button24;
        private Button button23;
        private Button button22;
        private Button button21;
        private Button button20;
        private Button button29;
        private Button button28;
        private Button button27;
        private GroupBox groupBox7;
        private Button button33;
        private Button button32;
        private Button button34;
        private GroupBox groupBox6;
        private Button button31;
        private Button button30;
        private Button button35;
        private Button button36;
        private Button button37;
        private Button button38;
        private Label label2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox7;
        private PictureBox pictureBox6;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private PictureBox pictureBox10;
        private PictureBox pictureBox9;
        private PictureBox pictureBox8;
        private PictureBox pictureBox11;
        private PictureBox pictureBox15;
        private PictureBox pictureBox14;
        private PictureBox pictureBox13;
        private PictureBox pictureBox12;
        private PictureBox pictureBox19;
        private PictureBox pictureBox18;
        private PictureBox pictureBox17;
        private PictureBox pictureBox16;
        private PictureBox pictureBox20;
        private Button button39;
        private StatusBar statusBar1 = new StatusBar();
        private StatusBarPanel panel1 = new StatusBarPanel();
        private StatusBarPanel panel2 = new StatusBarPanel();
        private StatusBarPanel panel3 = new StatusBarPanel();
        private StatusBarPanel panel4 = new StatusBarPanel();
        private StatusBarPanel panel5 = new StatusBarPanel();
        private StatusBarPanel panel6 = new StatusBarPanel();
        private Rectangle RcDraw;
        private Rectangle RcBox;
        private Point startPoint;
        private Point endPoint;
        //private Rectangle theRectangle = new Rectangle(new Point(0, 0), new Size(0, 0));
        //private Rectangle[] RcPnt = new Rectangle[200];
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
            this.panel7 = new System.Windows.Forms.Panel();
            this.pictureBox20 = new System.Windows.Forms.PictureBox();
            this.pictureBox19 = new System.Windows.Forms.PictureBox();
            this.pictureBox18 = new System.Windows.Forms.PictureBox();
            this.pictureBox17 = new System.Windows.Forms.PictureBox();
            this.pictureBox16 = new System.Windows.Forms.PictureBox();
            this.pictureBox15 = new System.Windows.Forms.PictureBox();
            this.pictureBox14 = new System.Windows.Forms.PictureBox();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.button34 = new System.Windows.Forms.Button();
            this.button33 = new System.Windows.Forms.Button();
            this.button32 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button35 = new System.Windows.Forms.Button();
            this.button29 = new System.Windows.Forms.Button();
            this.button28 = new System.Windows.Forms.Button();
            this.button27 = new System.Windows.Forms.Button();
            this.button26 = new System.Windows.Forms.Button();
            this.button25 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.button39 = new System.Windows.Forms.Button();
            this.button38 = new System.Windows.Forms.Button();
            this.button37 = new System.Windows.Forms.Button();
            this.button36 = new System.Windows.Forms.Button();
            this.button31 = new System.Windows.Forms.Button();
            this.button30 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel7.Controls.Add(this.pictureBox20);
            this.panel7.Controls.Add(this.pictureBox19);
            this.panel7.Controls.Add(this.pictureBox18);
            this.panel7.Controls.Add(this.pictureBox17);
            this.panel7.Controls.Add(this.pictureBox16);
            this.panel7.Controls.Add(this.pictureBox15);
            this.panel7.Controls.Add(this.pictureBox14);
            this.panel7.Controls.Add(this.pictureBox13);
            this.panel7.Controls.Add(this.pictureBox12);
            this.panel7.Controls.Add(this.pictureBox11);
            this.panel7.Controls.Add(this.pictureBox10);
            this.panel7.Controls.Add(this.pictureBox9);
            this.panel7.Controls.Add(this.pictureBox8);
            this.panel7.Controls.Add(this.pictureBox7);
            this.panel7.Controls.Add(this.pictureBox6);
            this.panel7.Controls.Add(this.pictureBox5);
            this.panel7.Controls.Add(this.pictureBox4);
            this.panel7.Controls.Add(this.pictureBox3);
            this.panel7.Controls.Add(this.pictureBox2);
            this.panel7.Controls.Add(this.pictureBox1);
            this.panel7.Location = new System.Drawing.Point(12, 105);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(658, 566);
            this.panel7.TabIndex = 0;
            this.panel7.Paint += new System.Windows.Forms.PaintEventHandler(this.panel7_Paint);
            this.panel7.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel7_MouseDown);
            this.panel7.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel7_MouseMove);
            this.panel7.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel7_MouseUp);
            // 
            // pictureBox20
            // 
            this.pictureBox20.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox20.Image = global::IIT_Dimlom_Geo1.Properties.Resources.LineHelp;
            this.pictureBox20.Location = new System.Drawing.Point(139, 86);
            this.pictureBox20.Name = "pictureBox20";
            this.pictureBox20.Size = new System.Drawing.Size(94, 100);
            this.pictureBox20.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox20.TabIndex = 19;
            this.pictureBox20.TabStop = false;
            // 
            // pictureBox19
            // 
            this.pictureBox19.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox19.Image = global::IIT_Dimlom_Geo1.Properties.Resources.Fillet7;
            this.pictureBox19.Location = new System.Drawing.Point(260, 331);
            this.pictureBox19.Name = "pictureBox19";
            this.pictureBox19.Size = new System.Drawing.Size(86, 92);
            this.pictureBox19.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox19.TabIndex = 18;
            this.pictureBox19.TabStop = false;
            // 
            // pictureBox18
            // 
            this.pictureBox18.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox18.Image = global::IIT_Dimlom_Geo1.Properties.Resources.Fillet6;
            this.pictureBox18.Location = new System.Drawing.Point(4, 229);
            this.pictureBox18.Name = "pictureBox18";
            this.pictureBox18.Size = new System.Drawing.Size(93, 87);
            this.pictureBox18.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox18.TabIndex = 17;
            this.pictureBox18.TabStop = false;
            // 
            // pictureBox17
            // 
            this.pictureBox17.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox17.Image = global::IIT_Dimlom_Geo1.Properties.Resources.Fillet5;
            this.pictureBox17.Location = new System.Drawing.Point(282, 436);
            this.pictureBox17.Name = "pictureBox17";
            this.pictureBox17.Size = new System.Drawing.Size(92, 93);
            this.pictureBox17.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox17.TabIndex = 16;
            this.pictureBox17.TabStop = false;
            // 
            // pictureBox16
            // 
            this.pictureBox16.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox16.Image = global::IIT_Dimlom_Geo1.Properties.Resources.Fillet4;
            this.pictureBox16.Location = new System.Drawing.Point(21, 86);
            this.pictureBox16.Name = "pictureBox16";
            this.pictureBox16.Size = new System.Drawing.Size(95, 100);
            this.pictureBox16.TabIndex = 15;
            this.pictureBox16.TabStop = false;
            // 
            // pictureBox15
            // 
            this.pictureBox15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox15.Image = global::IIT_Dimlom_Geo1.Properties.Resources.Fillet3;
            this.pictureBox15.Location = new System.Drawing.Point(369, 273);
            this.pictureBox15.Name = "pictureBox15";
            this.pictureBox15.Size = new System.Drawing.Size(100, 82);
            this.pictureBox15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox15.TabIndex = 14;
            this.pictureBox15.TabStop = false;
            // 
            // pictureBox14
            // 
            this.pictureBox14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox14.Image = global::IIT_Dimlom_Geo1.Properties.Resources.Fillet2;
            this.pictureBox14.Location = new System.Drawing.Point(21, 331);
            this.pictureBox14.Name = "pictureBox14";
            this.pictureBox14.Size = new System.Drawing.Size(97, 73);
            this.pictureBox14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox14.TabIndex = 13;
            this.pictureBox14.TabStop = false;
            // 
            // pictureBox13
            // 
            this.pictureBox13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox13.Image = global::IIT_Dimlom_Geo1.Properties.Resources.Fillet1;
            this.pictureBox13.Location = new System.Drawing.Point(121, 248);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(102, 73);
            this.pictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox13.TabIndex = 12;
            this.pictureBox13.TabStop = false;
            // 
            // pictureBox12
            // 
            this.pictureBox12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox12.Image = global::IIT_Dimlom_Geo1.Properties.Resources.Blind;
            this.pictureBox12.Location = new System.Drawing.Point(153, 341);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(70, 63);
            this.pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox12.TabIndex = 11;
            this.pictureBox12.TabStop = false;
            // 
            // pictureBox11
            // 
            this.pictureBox11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox11.Image = global::IIT_Dimlom_Geo1.Properties.Resources.Tangent1;
            this.pictureBox11.Location = new System.Drawing.Point(424, 404);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(83, 71);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox11.TabIndex = 10;
            this.pictureBox11.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox10.Image = global::IIT_Dimlom_Geo1.Properties.Resources.Tangent;
            this.pictureBox10.Location = new System.Drawing.Point(282, 564);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(85, 59);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox10.TabIndex = 9;
            this.pictureBox10.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox9.Image = global::IIT_Dimlom_Geo1.Properties.Resources.LineLeng;
            this.pictureBox9.Location = new System.Drawing.Point(507, 76);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(100, 62);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox9.TabIndex = 8;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox8.Image = global::IIT_Dimlom_Geo1.Properties.Resources.LinePnt;
            this.pictureBox8.Location = new System.Drawing.Point(267, 263);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(77, 58);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 7;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox7.Image = global::IIT_Dimlom_Geo1.Properties.Resources.curve;
            this.pictureBox7.Location = new System.Drawing.Point(512, 273);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(95, 78);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 6;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox6.Image = global::IIT_Dimlom_Geo1.Properties.Resources.circ_rad;
            this.pictureBox6.Location = new System.Drawing.Point(398, 110);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(60, 71);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 5;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox5.Image = global::IIT_Dimlom_Geo1.Properties.Resources.circle_3;
            this.pictureBox5.Location = new System.Drawing.Point(513, 151);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(78, 95);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 4;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox4.Image = global::IIT_Dimlom_Geo1.Properties.Resources.arc_3;
            this.pictureBox4.Location = new System.Drawing.Point(29, 410);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(89, 65);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Image = global::IIT_Dimlom_Geo1.Properties.Resources.arc_lng2;
            this.pictureBox3.Location = new System.Drawing.Point(45, 485);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(73, 79);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Image = global::IIT_Dimlom_Geo1.Properties.Resources.arc_sh2;
            this.pictureBox2.Location = new System.Drawing.Point(139, 485);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 62);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = global::IIT_Dimlom_Geo1.Properties.Resources.br_line;
            this.pictureBox1.Location = new System.Drawing.Point(265, 86);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(102, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.groupBox7);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(680, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(343, 671);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Опции";
            // 
            // groupBox7
            // 
            this.groupBox7.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox7.Controls.Add(this.button34);
            this.groupBox7.Controls.Add(this.button33);
            this.groupBox7.Controls.Add(this.button32);
            this.groupBox7.ForeColor = System.Drawing.Color.Black;
            this.groupBox7.Location = new System.Drawing.Point(6, 589);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(329, 76);
            this.groupBox7.TabIndex = 4;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Построение и коррекция линейной топологии";
            // 
            // button34
            // 
            this.button34.BackColor = System.Drawing.Color.White;
            this.button34.Location = new System.Drawing.Point(6, 14);
            this.button34.Name = "button34";
            this.button34.Size = new System.Drawing.Size(101, 56);
            this.button34.TabIndex = 2;
            this.button34.Text = "Построение линейной топологии";
            this.button34.UseVisualStyleBackColor = false;
            this.button34.Click += new System.EventHandler(this.LinearTopology_Click);
            // 
            // button33
            // 
            this.button33.BackColor = System.Drawing.Color.White;
            this.button33.Location = new System.Drawing.Point(216, 14);
            this.button33.Name = "button33";
            this.button33.Size = new System.Drawing.Size(107, 56);
            this.button33.TabIndex = 1;
            this.button33.Text = "Перестроить топологию";
            this.button33.UseVisualStyleBackColor = false;
            this.button33.Click += new System.EventHandler(this.RebuildTopology_Click);
            // 
            // button32
            // 
            this.button32.BackColor = System.Drawing.Color.White;
            this.button32.Location = new System.Drawing.Point(113, 14);
            this.button32.Name = "button32";
            this.button32.Size = new System.Drawing.Size(94, 56);
            this.button32.TabIndex = 0;
            this.button32.Text = "Выбрать и удалить линию";
            this.button32.UseVisualStyleBackColor = false;
            this.button32.Click += new System.EventHandler(this.SelectRemove_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.ForeColor = System.Drawing.Color.Black;
            this.groupBox3.Location = new System.Drawing.Point(6, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(329, 564);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Построение линий по точкам";
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox5.Controls.Add(this.textBox4);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Controls.Add(this.listBox1);
            this.groupBox5.Controls.Add(this.button8);
            this.groupBox5.Controls.Add(this.button7);
            this.groupBox5.ForeColor = System.Drawing.Color.Black;
            this.groupBox5.Location = new System.Drawing.Point(6, 455);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(323, 109);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Новая линия";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(210, 53);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(36, 20);
            this.textBox4.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Location = new System.Drawing.Point(141, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Радиус ,м";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Выбранные точки";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(7, 33);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(94, 69);
            this.listBox1.TabIndex = 2;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.White;
            this.button8.Location = new System.Drawing.Point(229, 79);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 1;
            this.button8.Text = "Отмена";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(120, 79);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(81, 23);
            this.button7.TabIndex = 0;
            this.button7.Text = "Сохранить";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.Save_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox4.Controls.Add(this.button35);
            this.groupBox4.Controls.Add(this.button29);
            this.groupBox4.Controls.Add(this.button28);
            this.groupBox4.Controls.Add(this.button27);
            this.groupBox4.Controls.Add(this.button26);
            this.groupBox4.Controls.Add(this.button25);
            this.groupBox4.Controls.Add(this.button24);
            this.groupBox4.Controls.Add(this.button23);
            this.groupBox4.Controls.Add(this.button22);
            this.groupBox4.Controls.Add(this.button21);
            this.groupBox4.Controls.Add(this.button20);
            this.groupBox4.Controls.Add(this.button19);
            this.groupBox4.Controls.Add(this.button18);
            this.groupBox4.Controls.Add(this.button17);
            this.groupBox4.Controls.Add(this.button16);
            this.groupBox4.Controls.Add(this.button15);
            this.groupBox4.Controls.Add(this.button14);
            this.groupBox4.Controls.Add(this.button13);
            this.groupBox4.Controls.Add(this.button12);
            this.groupBox4.Controls.Add(this.button11);
            this.groupBox4.Controls.Add(this.button10);
            this.groupBox4.Controls.Add(this.button9);
            this.groupBox4.Controls.Add(this.button6);
            this.groupBox4.Location = new System.Drawing.Point(6, 16);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(323, 433);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            // 
            // button35
            // 
            this.button35.BackColor = System.Drawing.Color.White;
            this.button35.Location = new System.Drawing.Point(7, 384);
            this.button35.Name = "button35";
            this.button35.Size = new System.Drawing.Size(92, 43);
            this.button35.TabIndex = 22;
            this.button35.Text = "Удалить все точки";
            this.button35.UseVisualStyleBackColor = false;
            this.button35.Click += new System.EventHandler(this.AllPointsDelete_Click);
            // 
            // button29
            // 
            this.button29.BackColor = System.Drawing.Color.White;
            this.button29.Location = new System.Drawing.Point(205, 384);
            this.button29.Name = "button29";
            this.button29.Size = new System.Drawing.Size(110, 43);
            this.button29.TabIndex = 21;
            this.button29.Text = "Удалить все линии";
            this.button29.UseVisualStyleBackColor = false;
            this.button29.Click += new System.EventHandler(this.AllDelete_Click);
            // 
            // button28
            // 
            this.button28.BackColor = System.Drawing.Color.White;
            this.button28.Location = new System.Drawing.Point(105, 384);
            this.button28.Name = "button28";
            this.button28.Size = new System.Drawing.Size(96, 43);
            this.button28.TabIndex = 20;
            this.button28.Text = "Удалить линию";
            this.button28.UseVisualStyleBackColor = false;
            this.button28.Click += new System.EventHandler(this.LineDelete_Click);
            // 
            // button27
            // 
            this.button27.BackColor = System.Drawing.Color.White;
            this.button27.Location = new System.Drawing.Point(205, 328);
            this.button27.Name = "button27";
            this.button27.Size = new System.Drawing.Size(110, 50);
            this.button27.TabIndex = 19;
            this.button27.Text = "Скругление по расстоянию биссектрисы";
            this.button27.UseVisualStyleBackColor = false;
            this.button27.Click += new System.EventHandler(this.FilletBisect_Click);
            // 
            // button26
            // 
            this.button26.BackColor = System.Drawing.Color.White;
            this.button26.Location = new System.Drawing.Point(105, 328);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(94, 50);
            this.button26.TabIndex = 18;
            this.button26.Text = "Скругление обратное R>0";
            this.button26.UseVisualStyleBackColor = false;
            this.button26.Click += new System.EventHandler(this.FilletInverseR_Click);
            // 
            // button25
            // 
            this.button25.BackColor = System.Drawing.Color.White;
            this.button25.Location = new System.Drawing.Point(7, 328);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(92, 50);
            this.button25.TabIndex = 17;
            this.button25.Text = "Скругление прямое R>0";
            this.button25.UseVisualStyleBackColor = false;
            this.button25.Click += new System.EventHandler(this.FilletDirectR_Click);
            // 
            // button24
            // 
            this.button24.BackColor = System.Drawing.Color.White;
            this.button24.Location = new System.Drawing.Point(205, 259);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(110, 63);
            this.button24.TabIndex = 16;
            this.button24.Text = "Скругление длинное обратное R=0";
            this.button24.UseVisualStyleBackColor = false;
            this.button24.Click += new System.EventHandler(this.FilletLongInverse_Click);
            // 
            // button23
            // 
            this.button23.BackColor = System.Drawing.Color.White;
            this.button23.Location = new System.Drawing.Point(105, 259);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(94, 63);
            this.button23.TabIndex = 15;
            this.button23.Text = "Скругление длинное прямое R=0";
            this.button23.UseVisualStyleBackColor = false;
            this.button23.Click += new System.EventHandler(this.FilletLongDirect_Click);
            // 
            // button22
            // 
            this.button22.BackColor = System.Drawing.Color.White;
            this.button22.Location = new System.Drawing.Point(7, 259);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(92, 63);
            this.button22.TabIndex = 14;
            this.button22.Text = "Обратное короткое скругление R=0";
            this.button22.UseVisualStyleBackColor = false;
            this.button22.Click += new System.EventHandler(this.FilletShortInverse_Click);
            // 
            // button21
            // 
            this.button21.BackColor = System.Drawing.Color.White;
            this.button21.Location = new System.Drawing.Point(206, 202);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(109, 51);
            this.button21.TabIndex = 13;
            this.button21.Text = "Скругление короткое прямое R=0";
            this.button21.UseVisualStyleBackColor = false;
            this.button21.Click += new System.EventHandler(this.FilletShortDirect_Click);
            // 
            // button20
            // 
            this.button20.BackColor = System.Drawing.Color.White;
            this.button20.Location = new System.Drawing.Point(105, 148);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(94, 48);
            this.button20.TabIndex = 12;
            this.button20.Text = "Тупиковый (линии)";
            this.button20.UseVisualStyleBackColor = false;
            this.button20.Click += new System.EventHandler(this.BlindAlley_Click);
            // 
            // button19
            // 
            this.button19.BackColor = System.Drawing.Color.White;
            this.button19.Location = new System.Drawing.Point(105, 202);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(94, 51);
            this.button19.TabIndex = 11;
            this.button19.Text = "Касательная дуга, обратная";
            this.button19.UseVisualStyleBackColor = false;
            this.button19.Click += new System.EventHandler(this.TangentInverse_Click);
            // 
            // button18
            // 
            this.button18.BackColor = System.Drawing.Color.White;
            this.button18.Location = new System.Drawing.Point(7, 202);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(92, 51);
            this.button18.TabIndex = 10;
            this.button18.Text = "Прямая касательная дуга";
            this.button18.UseVisualStyleBackColor = false;
            this.button18.Click += new System.EventHandler(this.TangentDirect_Click);
            // 
            // button17
            // 
            this.button17.BackColor = System.Drawing.Color.White;
            this.button17.Location = new System.Drawing.Point(210, 107);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(105, 36);
            this.button17.TabIndex = 9;
            this.button17.Text = "Удлинить линию";
            this.button17.UseVisualStyleBackColor = false;
            this.button17.Click += new System.EventHandler(this.Lengthen_Click);
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.Color.White;
            this.button16.Location = new System.Drawing.Point(99, 107);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(109, 36);
            this.button16.TabIndex = 8;
            this.button16.Text = "Перпендикуляр Точка - линия";
            this.button16.UseVisualStyleBackColor = false;
            this.button16.Click += new System.EventHandler(this.PointLine_Click);
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.Color.White;
            this.button15.Location = new System.Drawing.Point(208, 148);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(107, 48);
            this.button15.TabIndex = 7;
            this.button15.Text = "Параллельная линия";
            this.button15.UseVisualStyleBackColor = false;
            this.button15.Click += new System.EventHandler(this.Parallel_Click);
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.White;
            this.button14.Location = new System.Drawing.Point(5, 148);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(94, 48);
            this.button14.TabIndex = 6;
            this.button14.Text = "Кривая больше > 2 точек";
            this.button14.UseVisualStyleBackColor = false;
            this.button14.Click += new System.EventHandler(this.Curve_Click);
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.White;
            this.button13.Location = new System.Drawing.Point(105, 65);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(210, 35);
            this.button13.TabIndex = 5;
            this.button13.Text = "Окружность с помощью Центра и Радиуса";
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.CircleCentre_Click);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.White;
            this.button12.Location = new System.Drawing.Point(5, 107);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(88, 36);
            this.button12.TabIndex = 4;
            this.button12.Text = "Круг по 3 точкам";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.Circle3Pnt_Click);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.White;
            this.button11.Location = new System.Drawing.Point(7, 65);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(92, 36);
            this.button11.TabIndex = 3;
            this.button11.Text = "Дуга по 3 точкам";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.Arc3Pnt_Click);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.White;
            this.button10.Location = new System.Drawing.Point(205, 6);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(110, 52);
            this.button10.TabIndex = 2;
            this.button10.Text = "Длина дуги > 2 точек";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.ArcLong_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.White;
            this.button9.Location = new System.Drawing.Point(91, 6);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(108, 52);
            this.button9.TabIndex = 1;
            this.button9.Text = "Короткая дуга > 2 точек";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.ArcShort_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(5, 6);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(80, 52);
            this.button6.TabIndex = 0;
            this.button6.Text = "Линия больше > 1 Точек";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.Line_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(414, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 42);
            this.button1.TabIndex = 1;
            this.button1.Text = "Закрыть окно";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Exit_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox6.Controls.Add(this.button39);
            this.groupBox6.Controls.Add(this.button38);
            this.groupBox6.Controls.Add(this.button1);
            this.groupBox6.Controls.Add(this.button37);
            this.groupBox6.Controls.Add(this.button36);
            this.groupBox6.Controls.Add(this.button31);
            this.groupBox6.Controls.Add(this.button30);
            this.groupBox6.ForeColor = System.Drawing.Color.Black;
            this.groupBox6.Location = new System.Drawing.Point(135, 0);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(530, 99);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Опции графического окна";
            // 
            // button39
            // 
            this.button39.Location = new System.Drawing.Point(6, 57);
            this.button39.Name = "button39";
            this.button39.Size = new System.Drawing.Size(130, 36);
            this.button39.TabIndex = 5;
            this.button39.Text = "Справка по строению линий Вкл/Выкл";
            this.button39.UseVisualStyleBackColor = true;
            this.button39.Click += new System.EventHandler(this.AllTypeLines_Click);
            // 
            // button38
            // 
            this.button38.BackColor = System.Drawing.Color.White;
            this.button38.Location = new System.Drawing.Point(277, 56);
            this.button38.Name = "button38";
            this.button38.Size = new System.Drawing.Size(95, 37);
            this.button38.TabIndex = 4;
            this.button38.Text = "Исходные узлы Вкл/Выкл";
            this.button38.UseVisualStyleBackColor = false;
            this.button38.Click += new System.EventHandler(this.SourceNodeOnOff_Click);
            // 
            // button37
            // 
            this.button37.BackColor = System.Drawing.Color.White;
            this.button37.Location = new System.Drawing.Point(142, 57);
            this.button37.Name = "button37";
            this.button37.Size = new System.Drawing.Size(121, 36);
            this.button37.TabIndex = 3;
            this.button37.Text = "Исходные линии Вкл/Выкл";
            this.button37.UseVisualStyleBackColor = false;
            this.button37.Click += new System.EventHandler(this.SourceLinesOnOff_Click);
            // 
            // button36
            // 
            this.button36.BackColor = System.Drawing.Color.White;
            this.button36.Location = new System.Drawing.Point(242, 18);
            this.button36.Name = "button36";
            this.button36.Size = new System.Drawing.Size(130, 35);
            this.button36.TabIndex = 2;
            this.button36.Text = "Топографические модели Вкл/Выкл";
            this.button36.UseVisualStyleBackColor = false;
            this.button36.Click += new System.EventHandler(this.TopologyOnOff_Click);
            // 
            // button31
            // 
            this.button31.BackColor = System.Drawing.Color.White;
            this.button31.Location = new System.Drawing.Point(78, 17);
            this.button31.Name = "button31";
            this.button31.Size = new System.Drawing.Size(158, 37);
            this.button31.TabIndex = 1;
            this.button31.Text = "Исходные линии моделирования Вкл/Выкл";
            this.button31.UseVisualStyleBackColor = false;
            this.button31.Click += new System.EventHandler(this.ProjectOnOff_Click);
            // 
            // button30
            // 
            this.button30.BackColor = System.Drawing.Color.White;
            this.button30.Location = new System.Drawing.Point(6, 17);
            this.button30.Name = "button30";
            this.button30.Size = new System.Drawing.Size(66, 37);
            this.button30.TabIndex = 0;
            this.button30.Text = "Точки вкл/выкл";
            this.button30.UseVisualStyleBackColor = false;
            this.button30.Click += new System.EventHandler(this.PointsOnnOff_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(12, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(123, 99);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Панель навигации";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.White;
            this.button5.BackgroundImage = global::IIT_Dimlom_Geo1.Properties.Resources.MoveIcon1;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button5.Location = new System.Drawing.Point(56, 19);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(44, 32);
            this.button5.TabIndex = 3;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.Move_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.BackgroundImage = global::IIT_Dimlom_Geo1.Properties.Resources.ZoomOutIcon;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button4.Location = new System.Drawing.Point(56, 57);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(43, 30);
            this.button4.TabIndex = 2;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.ZoomOut_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.BackgroundImage = global::IIT_Dimlom_Geo1.Properties.Resources.zoomIn;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.Location = new System.Drawing.Point(6, 57);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(44, 30);
            this.button3.TabIndex = 1;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.ZoomIn_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.BackgroundImage = global::IIT_Dimlom_Geo1.Properties.Resources.SelectBoX1;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Location = new System.Drawing.Point(6, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(43, 32);
            this.button2.TabIndex = 0;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.SelectBox_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(12, 671);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "-";
            // 
            // DesignLine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 697);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.groupBox2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DesignLine";
            this.Text = "Молеирование и создание линий";
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
    }
}