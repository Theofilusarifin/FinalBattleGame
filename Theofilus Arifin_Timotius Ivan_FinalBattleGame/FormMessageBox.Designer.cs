
namespace Theofilus_Arifin_Timotius_Ivan_FinalBattleGame
{
    partial class FormMessageBox
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
            this.labelInformation = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonOkay = new System.Windows.Forms.Button();
            this.timerClick = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // labelInformation
            // 
            this.labelInformation.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelInformation.AutoSize = true;
            this.labelInformation.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInformation.Location = new System.Drawing.Point(175, 29);
            this.labelInformation.Name = "labelInformation";
            this.labelInformation.Size = new System.Drawing.Size(183, 29);
            this.labelInformation.TabIndex = 0;
            this.labelInformation.Text = "Our Information";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleGreen;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 172);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(521, 23);
            this.panel1.TabIndex = 2;
            // 
            // buttonOkay
            // 
            this.buttonOkay.BackColor = System.Drawing.Color.Transparent;
            this.buttonOkay.BackgroundImage = global::Theofilus_Arifin_Timotius_Ivan_FinalBattleGame.Properties.Resources.Button_Over;
            this.buttonOkay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonOkay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOkay.FlatAppearance.BorderSize = 0;
            this.buttonOkay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonOkay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonOkay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOkay.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOkay.ForeColor = System.Drawing.Color.LightGreen;
            this.buttonOkay.Location = new System.Drawing.Point(193, 80);
            this.buttonOkay.Name = "buttonOkay";
            this.buttonOkay.Size = new System.Drawing.Size(139, 60);
            this.buttonOkay.TabIndex = 1;
            this.buttonOkay.Text = "Okay";
            this.buttonOkay.UseVisualStyleBackColor = false;
            this.buttonOkay.Click += new System.EventHandler(this.buttonOkay_Click);
            this.buttonOkay.MouseEnter += new System.EventHandler(this.buttonOkay_MouseEnter);
            this.buttonOkay.MouseLeave += new System.EventHandler(this.buttonOkay_MouseLeave);
            // 
            // timerClick
            // 
            this.timerClick.Tick += new System.EventHandler(this.timerClick_Tick);
            // 
            // MessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(521, 195);
            this.Controls.Add(this.buttonOkay);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelInformation);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "MessageBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MessageBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelInformation;
        private System.Windows.Forms.Button buttonOkay;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timerClick;
    }
}