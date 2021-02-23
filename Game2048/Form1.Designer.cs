namespace Game2048
{
    partial class Form1
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
            this.newGame = new System.Windows.Forms.Button();
            this.b00 = new System.Windows.Forms.RichTextBox();
            this.b01 = new System.Windows.Forms.RichTextBox();
            this.b21 = new System.Windows.Forms.RichTextBox();
            this.b22 = new System.Windows.Forms.RichTextBox();
            this.b33 = new System.Windows.Forms.RichTextBox();
            this.b23 = new System.Windows.Forms.RichTextBox();
            this.b30 = new System.Windows.Forms.RichTextBox();
            this.b20 = new System.Windows.Forms.RichTextBox();
            this.b13 = new System.Windows.Forms.RichTextBox();
            this.b12 = new System.Windows.Forms.RichTextBox();
            this.b11 = new System.Windows.Forms.RichTextBox();
            this.b10 = new System.Windows.Forms.RichTextBox();
            this.b03 = new System.Windows.Forms.RichTextBox();
            this.b02 = new System.Windows.Forms.RichTextBox();
            this.b31 = new System.Windows.Forms.RichTextBox();
            this.b32 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // newGame
            // 
            this.newGame.Location = new System.Drawing.Point(81, 13);
            this.newGame.Name = "newGame";
            this.newGame.Size = new System.Drawing.Size(75, 23);
            this.newGame.TabIndex = 0;
            this.newGame.Text = "New Game";
            this.newGame.UseVisualStyleBackColor = true;
            this.newGame.Click += new System.EventHandler(this.newGame_Click);
            // 
            // b00
            // 
            this.b00.Font = new System.Drawing.Font("Algerian", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b00.Location = new System.Drawing.Point(81, 87);
            this.b00.Name = "b00";
            this.b00.Size = new System.Drawing.Size(100, 100);
            this.b00.TabIndex = 1;
            this.b00.Text = "";
            // 
            // b01
            // 
            this.b01.Font = new System.Drawing.Font("Algerian", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b01.Location = new System.Drawing.Point(187, 87);
            this.b01.Name = "b01";
            this.b01.Size = new System.Drawing.Size(100, 100);
            this.b01.TabIndex = 2;
            this.b01.Text = "";
            // 
            // b21
            // 
            this.b21.Font = new System.Drawing.Font("Algerian", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b21.Location = new System.Drawing.Point(187, 291);
            this.b21.Name = "b21";
            this.b21.Size = new System.Drawing.Size(100, 100);
            this.b21.TabIndex = 3;
            this.b21.Text = "";
            // 
            // b22
            // 
            this.b22.Font = new System.Drawing.Font("Algerian", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b22.Location = new System.Drawing.Point(293, 291);
            this.b22.Name = "b22";
            this.b22.Size = new System.Drawing.Size(100, 100);
            this.b22.TabIndex = 4;
            this.b22.Text = "";
            // 
            // b33
            // 
            this.b33.Font = new System.Drawing.Font("Algerian", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b33.Location = new System.Drawing.Point(399, 393);
            this.b33.Name = "b33";
            this.b33.Size = new System.Drawing.Size(100, 100);
            this.b33.TabIndex = 5;
            this.b33.Text = "";
            // 
            // b23
            // 
            this.b23.Font = new System.Drawing.Font("Algerian", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b23.Location = new System.Drawing.Point(399, 291);
            this.b23.Name = "b23";
            this.b23.Size = new System.Drawing.Size(100, 100);
            this.b23.TabIndex = 6;
            this.b23.Text = "";
            // 
            // b30
            // 
            this.b30.Font = new System.Drawing.Font("Algerian", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b30.Location = new System.Drawing.Point(81, 393);
            this.b30.Name = "b30";
            this.b30.Size = new System.Drawing.Size(100, 100);
            this.b30.TabIndex = 7;
            this.b30.Text = "";
            // 
            // b20
            // 
            this.b20.Font = new System.Drawing.Font("Algerian", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b20.Location = new System.Drawing.Point(81, 291);
            this.b20.Name = "b20";
            this.b20.Size = new System.Drawing.Size(100, 100);
            this.b20.TabIndex = 8;
            this.b20.Text = "";
            // 
            // b13
            // 
            this.b13.Font = new System.Drawing.Font("Algerian", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b13.Location = new System.Drawing.Point(399, 189);
            this.b13.Name = "b13";
            this.b13.Size = new System.Drawing.Size(100, 100);
            this.b13.TabIndex = 9;
            this.b13.Text = "";
            // 
            // b12
            // 
            this.b12.Font = new System.Drawing.Font("Algerian", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b12.Location = new System.Drawing.Point(293, 189);
            this.b12.Name = "b12";
            this.b12.Size = new System.Drawing.Size(100, 100);
            this.b12.TabIndex = 10;
            this.b12.Text = "";
            // 
            // b11
            // 
            this.b11.Font = new System.Drawing.Font("Algerian", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b11.Location = new System.Drawing.Point(187, 189);
            this.b11.Name = "b11";
            this.b11.Size = new System.Drawing.Size(100, 100);
            this.b11.TabIndex = 11;
            this.b11.Text = "";
            // 
            // b10
            // 
            this.b10.Font = new System.Drawing.Font("Algerian", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b10.Location = new System.Drawing.Point(81, 189);
            this.b10.Name = "b10";
            this.b10.Size = new System.Drawing.Size(100, 100);
            this.b10.TabIndex = 12;
            this.b10.Text = "";
            // 
            // b03
            // 
            this.b03.Font = new System.Drawing.Font("Algerian", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b03.Location = new System.Drawing.Point(399, 87);
            this.b03.Name = "b03";
            this.b03.Size = new System.Drawing.Size(100, 100);
            this.b03.TabIndex = 13;
            this.b03.Text = "";
            // 
            // b02
            // 
            this.b02.Font = new System.Drawing.Font("Algerian", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b02.Location = new System.Drawing.Point(293, 87);
            this.b02.Name = "b02";
            this.b02.Size = new System.Drawing.Size(100, 100);
            this.b02.TabIndex = 14;
            this.b02.Text = "";
            // 
            // b31
            // 
            this.b31.Font = new System.Drawing.Font("Algerian", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b31.Location = new System.Drawing.Point(187, 393);
            this.b31.Name = "b31";
            this.b31.Size = new System.Drawing.Size(100, 100);
            this.b31.TabIndex = 15;
            this.b31.Text = "";
            // 
            // b32
            // 
            this.b32.Font = new System.Drawing.Font("Algerian", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b32.Location = new System.Drawing.Point(293, 393);
            this.b32.Name = "b32";
            this.b32.Size = new System.Drawing.Size(100, 100);
            this.b32.TabIndex = 16;
            this.b32.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.b32);
            this.Controls.Add(this.b31);
            this.Controls.Add(this.b02);
            this.Controls.Add(this.b03);
            this.Controls.Add(this.b10);
            this.Controls.Add(this.b11);
            this.Controls.Add(this.b12);
            this.Controls.Add(this.b13);
            this.Controls.Add(this.b20);
            this.Controls.Add(this.b30);
            this.Controls.Add(this.b23);
            this.Controls.Add(this.b33);
            this.Controls.Add(this.b22);
            this.Controls.Add(this.b21);
            this.Controls.Add(this.b01);
            this.Controls.Add(this.b00);
            this.Controls.Add(this.newGame);
            this.Name = "Form1";
            this.Text = "2048";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button newGame;
        private System.Windows.Forms.RichTextBox b00;
        private System.Windows.Forms.RichTextBox b01;
        private System.Windows.Forms.RichTextBox b21;
        private System.Windows.Forms.RichTextBox b22;
        private System.Windows.Forms.RichTextBox b33;
        private System.Windows.Forms.RichTextBox b23;
        private System.Windows.Forms.RichTextBox b30;
        private System.Windows.Forms.RichTextBox b20;
        private System.Windows.Forms.RichTextBox b13;
        private System.Windows.Forms.RichTextBox b12;
        private System.Windows.Forms.RichTextBox b11;
        private System.Windows.Forms.RichTextBox b10;
        private System.Windows.Forms.RichTextBox b03;
        private System.Windows.Forms.RichTextBox b02;
        private System.Windows.Forms.RichTextBox b31;
        private System.Windows.Forms.RichTextBox b32;
    }
}

