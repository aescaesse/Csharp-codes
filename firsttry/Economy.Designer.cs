namespace firsttry
{
    partial class Economy
    {
        /// <summary> 
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.allEarnings = new System.Windows.Forms.Label();
            this.allSpendings = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.graph1 = new firsttry.Graph();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(48, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "All earnings";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(228, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 44);
            this.label2.TabIndex = 1;
            this.label2.Text = "All spendings";
            // 
            // allEarnings
            // 
            this.allEarnings.AutoSize = true;
            this.allEarnings.Font = new System.Drawing.Font("Georgia", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.allEarnings.ForeColor = System.Drawing.Color.YellowGreen;
            this.allEarnings.Location = new System.Drawing.Point(45, 55);
            this.allEarnings.Name = "allEarnings";
            this.allEarnings.Size = new System.Drawing.Size(0, 43);
            this.allEarnings.TabIndex = 8;
            // 
            // allSpendings
            // 
            this.allSpendings.AutoSize = true;
            this.allSpendings.Font = new System.Drawing.Font("Georgia", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.allSpendings.ForeColor = System.Drawing.Color.YellowGreen;
            this.allSpendings.Location = new System.Drawing.Point(225, 55);
            this.allSpendings.Name = "allSpendings";
            this.allSpendings.Size = new System.Drawing.Size(0, 43);
            this.allSpendings.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.Gold;
            this.label4.Location = new System.Drawing.Point(5, 58);
            this.label4.MaximumSize = new System.Drawing.Size(40, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 40);
            this.label4.TabIndex = 10;
            this.label4.Text = "$";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.Gold;
            this.label3.Location = new System.Drawing.Point(186, 58);
            this.label3.MaximumSize = new System.Drawing.Size(40, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 40);
            this.label3.TabIndex = 11;
            this.label3.Text = "$";
            // 
            // graph1
            // 
            this.graph1.Location = new System.Drawing.Point(412, 41);
            this.graph1.Name = "graph1";
            this.graph1.Size = new System.Drawing.Size(521, 247);
            this.graph1.TabIndex = 12;
            // 
            // Economy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.graph1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.allSpendings);
            this.Controls.Add(this.allEarnings);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Economy";
            this.Size = new System.Drawing.Size(936, 387);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label allEarnings;
        private System.Windows.Forms.Label allSpendings;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Graph graph1;
    }
}
