namespace Solitaire350
{
    partial class SolitaireGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SolitaireGame));
            this.StockPile = new System.Windows.Forms.PictureBox();
            this.LeftFoundation = new System.Windows.Forms.PictureBox();
            this.CenterLeftFoundation = new System.Windows.Forms.PictureBox();
            this.CenterRightFoundation = new System.Windows.Forms.PictureBox();
            this.RightFoundation = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.StockPile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftFoundation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CenterLeftFoundation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CenterRightFoundation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightFoundation)).BeginInit();
            this.SuspendLayout();
            // 
            // StockPile
            // 
            this.StockPile.Image = ((System.Drawing.Image)(resources.GetObject("StockPile.Image")));
            this.StockPile.Location = new System.Drawing.Point(12, 12);
            this.StockPile.Name = "StockPile";
            this.StockPile.Size = new System.Drawing.Size(109, 167);
            this.StockPile.TabIndex = 0;
            this.StockPile.TabStop = false;
            // 
            // LeftFoundation
            // 
            this.LeftFoundation.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LeftFoundation.Location = new System.Drawing.Point(354, 12);
            this.LeftFoundation.Name = "LeftFoundation";
            this.LeftFoundation.Size = new System.Drawing.Size(109, 167);
            this.LeftFoundation.TabIndex = 1;
            this.LeftFoundation.TabStop = false;
            // 
            // CenterLeftFoundation
            // 
            this.CenterLeftFoundation.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.CenterLeftFoundation.Location = new System.Drawing.Point(469, 12);
            this.CenterLeftFoundation.Name = "CenterLeftFoundation";
            this.CenterLeftFoundation.Size = new System.Drawing.Size(109, 167);
            this.CenterLeftFoundation.TabIndex = 2;
            this.CenterLeftFoundation.TabStop = false;
            // 
            // CenterRightFoundation
            // 
            this.CenterRightFoundation.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.CenterRightFoundation.Location = new System.Drawing.Point(584, 12);
            this.CenterRightFoundation.Name = "CenterRightFoundation";
            this.CenterRightFoundation.Size = new System.Drawing.Size(109, 167);
            this.CenterRightFoundation.TabIndex = 3;
            this.CenterRightFoundation.TabStop = false;
            // 
            // RightFoundation
            // 
            this.RightFoundation.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.RightFoundation.Location = new System.Drawing.Point(699, 12);
            this.RightFoundation.Name = "RightFoundation";
            this.RightFoundation.Size = new System.Drawing.Size(109, 167);
            this.RightFoundation.TabIndex = 4;
            this.RightFoundation.TabStop = false;
            // 
            // SolitaireGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(816, 517);
            this.Controls.Add(this.RightFoundation);
            this.Controls.Add(this.CenterRightFoundation);
            this.Controls.Add(this.CenterLeftFoundation);
            this.Controls.Add(this.LeftFoundation);
            this.Controls.Add(this.StockPile);
            this.Name = "SolitaireGame";
            this.Text = "Solitaire350";
            ((System.ComponentModel.ISupportInitialize)(this.StockPile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftFoundation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CenterLeftFoundation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CenterRightFoundation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightFoundation)).EndInit();
            this.ResumeLayout(false);

        }

        public System.Windows.Forms.PictureBox StockPile;
        public System.Windows.Forms.PictureBox LeftFoundation;
        public System.Windows.Forms.PictureBox CenterLeftFoundation;
        public System.Windows.Forms.PictureBox CenterRightFoundation;
        public System.Windows.Forms.PictureBox RightFoundation;

        //public virtual System.Drawing.Color BackColor { get; set; }
        public static System.ConsoleColor BackgroundColor
        {
            get;
            set;
        }

        #endregion


    }
}

