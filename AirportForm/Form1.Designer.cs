namespace AirportForm
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
            this.components = new System.ComponentModel.Container();
            this.airportA = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.airportB = new System.Windows.Forms.TextBox();
            this.accept = new System.Windows.Forms.Button();
            this.connections = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // airportA
            // 
            this.airportA.Location = new System.Drawing.Point(157, 83);
            this.airportA.Name = "airportA";
            this.airportA.Size = new System.Drawing.Size(100, 20);
            this.airportA.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // airportB
            // 
            this.airportB.Location = new System.Drawing.Point(299, 83);
            this.airportB.Name = "airportB";
            this.airportB.Size = new System.Drawing.Size(100, 20);
            this.airportB.TabIndex = 2;
            // 
            // accept
            // 
            this.accept.Location = new System.Drawing.Point(440, 83);
            this.accept.Name = "accept";
            this.accept.Size = new System.Drawing.Size(75, 23);
            this.accept.TabIndex = 3;
            this.accept.Text = "Accept";
            this.accept.UseVisualStyleBackColor = true;
            this.accept.Click += new System.EventHandler(this.accept_Click);
            // 
            // connections
            // 
            this.connections.AutoSize = true;
            this.connections.Location = new System.Drawing.Point(157, 185);
            this.connections.Name = "connections";
            this.connections.Size = new System.Drawing.Size(0, 13);
            this.connections.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 433);
            this.Controls.Add(this.connections);
            this.Controls.Add(this.accept);
            this.Controls.Add(this.airportB);
            this.Controls.Add(this.airportA);
            this.Name = "Form1";
            this.Text = "Airport";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox airportA;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox airportB;
        private System.Windows.Forms.Button accept;
        private System.Windows.Forms.Label connections;
    }
}

