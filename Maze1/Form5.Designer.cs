namespace Maze1
{
    partial class Form5
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
            this.finish = new System.Windows.Forms.PictureBox();
            this.horse1 = new System.Windows.Forms.PictureBox();
            this.horse2 = new System.Windows.Forms.PictureBox();
            this.horse3 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.finish)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.horse1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.horse2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.horse3)).BeginInit();
            this.SuspendLayout();
            // 
            // finish
            // 
            this.finish.Location = new System.Drawing.Point(701, 12);
            this.finish.Name = "finish";
            this.finish.Size = new System.Drawing.Size(47, 426);
            this.finish.TabIndex = 0;
            this.finish.TabStop = false;
            // 
            // horse1
            // 
            this.horse1.BackColor = System.Drawing.Color.Transparent;
            this.horse1.Image = global::Maze1.Properties.Resources.horse_running_large_gray;
            this.horse1.Location = new System.Drawing.Point(30, 48);
            this.horse1.Name = "horse1";
            this.horse1.Size = new System.Drawing.Size(105, 68);
            this.horse1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.horse1.TabIndex = 1;
            this.horse1.TabStop = false;
            // 
            // horse2
            // 
            this.horse2.BackColor = System.Drawing.Color.Transparent;
            this.horse2.Image = global::Maze1.Properties.Resources.horse_running_large_gray;
            this.horse2.Location = new System.Drawing.Point(30, 194);
            this.horse2.Name = "horse2";
            this.horse2.Size = new System.Drawing.Size(105, 68);
            this.horse2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.horse2.TabIndex = 2;
            this.horse2.TabStop = false;
            // 
            // horse3
            // 
            this.horse3.BackColor = System.Drawing.Color.Transparent;
            this.horse3.Image = global::Maze1.Properties.Resources.horse_running_large_gray;
            this.horse3.Location = new System.Drawing.Point(30, 330);
            this.horse3.Name = "horse3";
            this.horse3.Size = new System.Drawing.Size(105, 68);
            this.horse3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.horse3.TabIndex = 3;
            this.horse3.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Maze1.Properties.Resources.unnamed;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.horse3);
            this.Controls.Add(this.horse2);
            this.Controls.Add(this.horse1);
            this.Controls.Add(this.finish);
            this.Name = "Form5";
            this.Text = "Form5";
            ((System.ComponentModel.ISupportInitialize)(this.finish)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.horse1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.horse2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.horse3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox finish;
        private System.Windows.Forms.PictureBox horse1;
        private System.Windows.Forms.PictureBox horse2;
        private System.Windows.Forms.PictureBox horse3;
        private System.Windows.Forms.Timer timer1;
    }
}