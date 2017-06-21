namespace NonRadar
{
    partial class frmMapTest
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
            this.txtAirway = new System.Windows.Forms.TextBox();
            this.txtNav1 = new System.Windows.Forms.TextBox();
            this.txtNav2 = new System.Windows.Forms.TextBox();
            this.lblDistance = new System.Windows.Forms.Label();
            this.mtxBearing1 = new System.Windows.Forms.MaskedTextBox();
            this.mtxDistance = new System.Windows.Forms.MaskedTextBox();
            this.mtxBearing2 = new System.Windows.Forms.MaskedTextBox();
            this.lblNav1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAccept = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtAirway
            // 
            this.txtAirway.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAirway.Location = new System.Drawing.Point(300, 13);
            this.txtAirway.Multiline = true;
            this.txtAirway.Name = "txtAirway";
            this.txtAirway.ReadOnly = true;
            this.txtAirway.Size = new System.Drawing.Size(100, 40);
            this.txtAirway.TabIndex = 0;
            this.txtAirway.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNav1
            // 
            this.txtNav1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNav1.Location = new System.Drawing.Point(12, 110);
            this.txtNav1.Name = "txtNav1";
            this.txtNav1.ReadOnly = true;
            this.txtNav1.Size = new System.Drawing.Size(100, 22);
            this.txtNav1.TabIndex = 1;
            // 
            // txtNav2
            // 
            this.txtNav2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNav2.Location = new System.Drawing.Point(572, 110);
            this.txtNav2.Name = "txtNav2";
            this.txtNav2.ReadOnly = true;
            this.txtNav2.Size = new System.Drawing.Size(100, 22);
            this.txtNav2.TabIndex = 5;
            // 
            // lblDistance
            // 
            this.lblDistance.AutoSize = true;
            this.lblDistance.Location = new System.Drawing.Point(297, 94);
            this.lblDistance.Name = "lblDistance";
            this.lblDistance.Size = new System.Drawing.Size(49, 13);
            this.lblDistance.TabIndex = 6;
            this.lblDistance.Text = "Distance";
            // 
            // mtxBearing1
            // 
            this.mtxBearing1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxBearing1.Location = new System.Drawing.Point(118, 110);
            this.mtxBearing1.Mask = "000";
            this.mtxBearing1.Name = "mtxBearing1";
            this.mtxBearing1.Size = new System.Drawing.Size(100, 22);
            this.mtxBearing1.TabIndex = 2;
            this.mtxBearing1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mtxDistance
            // 
            this.mtxDistance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxDistance.Location = new System.Drawing.Point(300, 110);
            this.mtxDistance.Mask = "000";
            this.mtxDistance.Name = "mtxDistance";
            this.mtxDistance.Size = new System.Drawing.Size(100, 22);
            this.mtxDistance.TabIndex = 3;
            this.mtxDistance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mtxBearing2
            // 
            this.mtxBearing2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxBearing2.Location = new System.Drawing.Point(466, 110);
            this.mtxBearing2.Mask = "000";
            this.mtxBearing2.Name = "mtxBearing2";
            this.mtxBearing2.Size = new System.Drawing.Size(100, 22);
            this.mtxBearing2.TabIndex = 4;
            this.mtxBearing2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblNav1
            // 
            this.lblNav1.AutoSize = true;
            this.lblNav1.Location = new System.Drawing.Point(13, 91);
            this.lblNav1.Name = "lblNav1";
            this.lblNav1.Size = new System.Drawing.Size(50, 13);
            this.lblNav1.TabIndex = 7;
            this.lblNav1.Text = "Navaid 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Bearing";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(466, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Bearing";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(569, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Navaid 2";
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(543, 13);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(75, 23);
            this.btnAccept.TabIndex = 11;
            this.btnAccept.Text = "Accept";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // frmMapTest
            // 
            this.AcceptButton = this.btnAccept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 179);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblNav1);
            this.Controls.Add(this.mtxBearing2);
            this.Controls.Add(this.mtxDistance);
            this.Controls.Add(this.mtxBearing1);
            this.Controls.Add(this.lblDistance);
            this.Controls.Add(this.txtNav2);
            this.Controls.Add(this.txtNav1);
            this.Controls.Add(this.txtAirway);
            this.Name = "frmMapTest";
            this.Text = "frmMapTest";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAirway;
        private System.Windows.Forms.TextBox txtNav1;
        private System.Windows.Forms.TextBox txtNav2;
        private System.Windows.Forms.Label lblDistance;
        private System.Windows.Forms.MaskedTextBox mtxBearing1;
        private System.Windows.Forms.MaskedTextBox mtxDistance;
        private System.Windows.Forms.MaskedTextBox mtxBearing2;
        private System.Windows.Forms.Label lblNav1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAccept;
    }
}