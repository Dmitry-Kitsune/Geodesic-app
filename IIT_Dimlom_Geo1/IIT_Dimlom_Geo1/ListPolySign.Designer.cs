using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using DiplomGeoDLL;
using IIT_Diplom_Geo1;

using System.IO;

namespace IIT_Dimlom_Geo1
{
    partial class ListPolySign : Form
    {

        /// <summary>
        /// Required designer variable.
        /// </summary>
        //private System.ComponentModel.IContainer components = null;


        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        private void FormLoad()
        {
            DllClass1.SetColour(myPol.brColor, myPol.pnColor);
            myPol.PolySymbolLoad(myPol.fsymbPoly, out kPolySymb, out hSymbPoly);
            DllClass1.PolySymbCoord(myPol.ypSign1[1], hSymbPoly, kPolySymb, ref myPol.xpSign1, ref myPol.ypSign1, ref myPol.xpSymb, ref myPol.ypSymb, ref myPol.xpItem, ref myPol.ypItem, ref myPol.xpDescr, ref myPol.ypDescr, ref myPol.xpSign2, ref myPol.ypSign2);
            int num1 = -hSymbPoly / 2;
            for (int index = 1; index <= kPolySymb; ++index)
            {
                num1 += hSymbPoly;
                myPol.ypSign1[index] = num1;
            }
            yTolMin = myPol.ypSign1[1] - hSymbPoly;
            yTolMax = myPol.ypSign1[kPolySymb];
            int num2 = 0;
            if (File.Exists(myPol.fileAdd))
            {
                FileStream input = new FileStream(myPol.fileAdd, FileMode.Open, FileAccess.Read);
                BinaryReader binaryReader = new BinaryReader((Stream)input);
                num2 = binaryReader.ReadInt32();
                binaryReader.Close();
                input.Close();
            }
            if (num2 == 20)
                label6.Text = "";
            if (num2 != 1000)
                return;
            label6.Text = "";
            for (int index1 = 1; index1 <= kPolySymb; ++index1)
            {
                yTolMax = myPol.ypSign1[kPolySymb] + hSymbPoly;
                if (yTolMax < pixHei)
                    break;
                for (int index2 = 1; index2 <= kPolySymb; ++index2)
                    myPol.ypSign1[index2] = myPol.ypSign1[index2] - hSymbPoly;
            }
        }
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        /// 


        private void InitializeComponent()
        {
            panel1 = new System.Windows.Forms.Panel();
            button1 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            button3 = new System.Windows.Forms.Button();
            label6 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.White;
            panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            panel1.Location = new System.Drawing.Point(14, 48);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(327, 574);
            panel1.TabIndex = 0;
            panel1.Paint += new System.Windows.Forms.PaintEventHandler(panel1_Paint);
            panel1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(panel1_MouseDoubleClick);
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.Color.White;
            button1.Location = new System.Drawing.Point(14, 641);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(68, 23);
            button1.TabIndex = 1;
            button1.Text = "Вверх";
            button1.UseVisualStyleBackColor = false;
            button1.Click += new System.EventHandler(Up_Click);
            // 
            // button2
            // 
            button2.BackColor = System.Drawing.Color.White;
            button2.Location = new System.Drawing.Point(144, 641);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(68, 23);
            button2.TabIndex = 2;
            button2.Text = "Вниз";
            button2.UseVisualStyleBackColor = false;
            button2.Click += new System.EventHandler(Down_Click);
            // 
            // button3
            // 
            button3.BackColor = System.Drawing.Color.White;
            button3.Location = new System.Drawing.Point(270, 641);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(61, 23);
            button3.TabIndex = 3;
            button3.Text = "Выход";
            button3.UseVisualStyleBackColor = false;
            button3.Click += new System.EventHandler(Quit_Click);
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = System.Drawing.Color.Black;
            label6.ForeColor = System.Drawing.Color.White;
            label6.Location = new System.Drawing.Point(39, 625);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(276, 13);
            label6.TabIndex = 4;
            label6.Text = "Двойной клик на соответствующем символе";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = System.Drawing.Color.Black;
            label1.Location = new System.Drawing.Point(23, 6);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(42, 39);
            label1.TabIndex = 5;
            label1.Text = "№ \r\nзнака\r\nп/п";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = System.Drawing.Color.Black;
            label2.Location = new System.Drawing.Point(71, 19);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(52, 13);
            label2.TabIndex = 6;
            label2.Text = "Символ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = System.Drawing.Color.Black;
            label3.Location = new System.Drawing.Point(129, 19);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(29, 13);
            label3.TabIndex = 7;
            label3.Text = "Код";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = System.Drawing.Color.Black;
            label4.Location = new System.Drawing.Point(176, 9);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(74, 26);
            label4.TabIndex = 8;
            label4.Text = "Плотность \r\nэлементов";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = System.Drawing.Color.Black;
            label5.Location = new System.Drawing.Point(267, 19);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(65, 13);
            label5.TabIndex = 9;
            label5.Text = "Описание";
            // 
            // ListPolySign
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.Control;
            ClientSize = new System.Drawing.Size(353, 676);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label6);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(panel1);
            Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ListPolySign";
            Text = "Список знаков полигонов";
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
    }
}