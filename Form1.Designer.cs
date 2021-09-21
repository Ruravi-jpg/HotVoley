
namespace hotVoley
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBoxBackground = new System.Windows.Forms.PictureBox();
            this.buttonReturn = new System.Windows.Forms.Button();
            this.buttonGoForward = new System.Windows.Forms.Button();
            this.buttonIndex = new System.Windows.Forms.Button();
            this.labelInfo = new System.Windows.Forms.Label();
            this.labelScoreboard = new System.Windows.Forms.Label();
            this.pictureBoxVs = new System.Windows.Forms.PictureBox();
            this.pictureBoxLogo1 = new System.Windows.Forms.PictureBox();
            this.labelTrainer1 = new System.Windows.Forms.Label();
            this.labelTrainer2 = new System.Windows.Forms.Label();
            this.labelPlayers1 = new System.Windows.Forms.Label();
            this.labelPlayers2 = new System.Windows.Forms.Label();
            this.pictureBoxLogo2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxBackground
            // 
            this.pictureBoxBackground.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxBackground.Name = "pictureBoxBackground";
            this.pictureBoxBackground.Size = new System.Drawing.Size(694, 497);
            this.pictureBoxBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBackground.TabIndex = 0;
            this.pictureBoxBackground.TabStop = false;
            // 
            // buttonReturn
            // 
            this.buttonReturn.Location = new System.Drawing.Point(0, 0);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(175, 43);
            this.buttonReturn.TabIndex = 1;
            this.buttonReturn.Text = "<<";
            this.buttonReturn.UseVisualStyleBackColor = true;
            this.buttonReturn.Click += new System.EventHandler(this.buttonReturn_Click);
            // 
            // buttonGoForward
            // 
            this.buttonGoForward.Location = new System.Drawing.Point(519, 0);
            this.buttonGoForward.Name = "buttonGoForward";
            this.buttonGoForward.Size = new System.Drawing.Size(175, 43);
            this.buttonGoForward.TabIndex = 2;
            this.buttonGoForward.Text = ">>";
            this.buttonGoForward.UseVisualStyleBackColor = true;
            this.buttonGoForward.Click += new System.EventHandler(this.buttonGoForward_Click);
            // 
            // buttonIndex
            // 
            this.buttonIndex.Location = new System.Drawing.Point(267, 0);
            this.buttonIndex.Name = "buttonIndex";
            this.buttonIndex.Size = new System.Drawing.Size(175, 43);
            this.buttonIndex.TabIndex = 3;
            this.buttonIndex.Text = "Ver índice";
            this.buttonIndex.UseVisualStyleBackColor = true;
            this.buttonIndex.Click += new System.EventHandler(this.buttonIndex_Click);
            // 
            // labelInfo
            // 
            this.labelInfo.Location = new System.Drawing.Point(478, 46);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(216, 56);
            this.labelInfo.TabIndex = 4;
            this.labelInfo.Text = "Fecha:\r\nPlaya:";
            this.labelInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelScoreboard
            // 
            this.labelScoreboard.Location = new System.Drawing.Point(478, 115);
            this.labelScoreboard.Name = "labelScoreboard";
            this.labelScoreboard.Size = new System.Drawing.Size(216, 382);
            this.labelScoreboard.TabIndex = 5;
            this.labelScoreboard.Text = "Ganador:\r\nMarcador:\r\n\r\nAnotaciones:";
            // 
            // pictureBoxVs
            // 
            this.pictureBoxVs.Location = new System.Drawing.Point(159, 49);
            this.pictureBoxVs.Name = "pictureBoxVs";
            this.pictureBoxVs.Size = new System.Drawing.Size(169, 435);
            this.pictureBoxVs.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxVs.TabIndex = 6;
            this.pictureBoxVs.TabStop = false;
            // 
            // pictureBoxLogo1
            // 
            this.pictureBoxLogo1.Location = new System.Drawing.Point(15, 92);
            this.pictureBoxLogo1.Name = "pictureBoxLogo1";
            this.pictureBoxLogo1.Size = new System.Drawing.Size(138, 129);
            this.pictureBoxLogo1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo1.TabIndex = 7;
            this.pictureBoxLogo1.TabStop = false;
            // 
            // labelTrainer1
            // 
            this.labelTrainer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTrainer1.Location = new System.Drawing.Point(15, 49);
            this.labelTrainer1.Name = "labelTrainer1";
            this.labelTrainer1.Size = new System.Drawing.Size(138, 40);
            this.labelTrainer1.TabIndex = 9;
            this.labelTrainer1.Text = "DT:";
            this.labelTrainer1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // labelTrainer2
            // 
            this.labelTrainer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTrainer2.Location = new System.Drawing.Point(334, 446);
            this.labelTrainer2.Name = "labelTrainer2";
            this.labelTrainer2.Size = new System.Drawing.Size(138, 40);
            this.labelTrainer2.TabIndex = 10;
            this.labelTrainer2.Text = "DT:";
            this.labelTrainer2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelPlayers1
            // 
            this.labelPlayers1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlayers1.Location = new System.Drawing.Point(15, 224);
            this.labelPlayers1.Name = "labelPlayers1";
            this.labelPlayers1.Size = new System.Drawing.Size(138, 56);
            this.labelPlayers1.TabIndex = 11;
            this.labelPlayers1.Text = "Izq:\r\nDer:";
            this.labelPlayers1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelPlayers2
            // 
            this.labelPlayers2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlayers2.Location = new System.Drawing.Point(334, 255);
            this.labelPlayers2.Name = "labelPlayers2";
            this.labelPlayers2.Size = new System.Drawing.Size(138, 56);
            this.labelPlayers2.TabIndex = 12;
            this.labelPlayers2.Text = "Izq:\r\nDer:";
            this.labelPlayers2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // pictureBoxLogo2
            // 
            this.pictureBoxLogo2.Location = new System.Drawing.Point(334, 314);
            this.pictureBoxLogo2.Name = "pictureBoxLogo2";
            this.pictureBoxLogo2.Size = new System.Drawing.Size(138, 129);
            this.pictureBoxLogo2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo2.TabIndex = 8;
            this.pictureBoxLogo2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 496);
            this.Controls.Add(this.labelPlayers2);
            this.Controls.Add(this.labelPlayers1);
            this.Controls.Add(this.labelTrainer2);
            this.Controls.Add(this.labelTrainer1);
            this.Controls.Add(this.pictureBoxLogo2);
            this.Controls.Add(this.pictureBoxLogo1);
            this.Controls.Add(this.pictureBoxVs);
            this.Controls.Add(this.labelScoreboard);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.buttonIndex);
            this.Controls.Add(this.buttonGoForward);
            this.Controls.Add(this.buttonReturn);
            this.Controls.Add(this.pictureBoxBackground);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxBackground;
        private System.Windows.Forms.Button buttonReturn;
        private System.Windows.Forms.Button buttonGoForward;
        private System.Windows.Forms.Button buttonIndex;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.Label labelScoreboard;
        private System.Windows.Forms.PictureBox pictureBoxVs;
        private System.Windows.Forms.PictureBox pictureBoxLogo1;
        private System.Windows.Forms.Label labelTrainer1;
        private System.Windows.Forms.Label labelTrainer2;
        private System.Windows.Forms.Label labelPlayers1;
        private System.Windows.Forms.Label labelPlayers2;
        private System.Windows.Forms.PictureBox pictureBoxLogo2;
    }
}

