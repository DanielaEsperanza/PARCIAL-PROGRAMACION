
namespace proyecto
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.saludoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.caluladoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lenguajeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.conversorDePesoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaParteIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaParteLlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaParteLllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saludoToolStripMenuItem,
            this.caluladoraToolStripMenuItem,
            this.lenguajeToolStripMenuItem,
            this.acercadeToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1289, 35);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // saludoToolStripMenuItem
            // 
            this.saludoToolStripMenuItem.Name = "saludoToolStripMenuItem";
            this.saludoToolStripMenuItem.Size = new System.Drawing.Size(83, 29);
            this.saludoToolStripMenuItem.Text = "Saludo";
            this.saludoToolStripMenuItem.Click += new System.EventHandler(this.saludoToolStripMenuItem_Click);
            // 
            // caluladoraToolStripMenuItem
            // 
            this.caluladoraToolStripMenuItem.Name = "caluladoraToolStripMenuItem";
            this.caluladoraToolStripMenuItem.Size = new System.Drawing.Size(112, 29);
            this.caluladoraToolStripMenuItem.Text = "Caluladora";
            this.caluladoraToolStripMenuItem.Click += new System.EventHandler(this.caluladoraToolStripMenuItem_Click);
            // 
            // lenguajeToolStripMenuItem
            // 
            this.lenguajeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.conversorDePesoToolStripMenuItem});
            this.lenguajeToolStripMenuItem.Name = "lenguajeToolStripMenuItem";
            this.lenguajeToolStripMenuItem.Size = new System.Drawing.Size(178, 29);
            this.lenguajeToolStripMenuItem.Text = "Conversor de peso";
            this.lenguajeToolStripMenuItem.Click += new System.EventHandler(this.lenguajeToolStripMenuItem_Click);
            // 
            // conversorDePesoToolStripMenuItem
            // 
            this.conversorDePesoToolStripMenuItem.Name = "conversorDePesoToolStripMenuItem";
            this.conversorDePesoToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.conversorDePesoToolStripMenuItem.Text = "Conversor de peso";
            // 
            // acercadeToolStripMenuItem
            // 
            this.acercadeToolStripMenuItem.Name = "acercadeToolStripMenuItem";
            this.acercadeToolStripMenuItem.Size = new System.Drawing.Size(105, 29);
            this.acercadeToolStripMenuItem.Text = "Acerca de";
            this.acercadeToolStripMenuItem.Click += new System.EventHandler(this.acercadeToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ayudaParteIToolStripMenuItem,
            this.ayudaParteLlToolStripMenuItem,
            this.ayudaParteLllToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(79, 29);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            this.ayudaToolStripMenuItem.Click += new System.EventHandler(this.ayudaToolStripMenuItem_Click);
            // 
            // ayudaParteIToolStripMenuItem
            // 
            this.ayudaParteIToolStripMenuItem.Name = "ayudaParteIToolStripMenuItem";
            this.ayudaParteIToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.ayudaParteIToolStripMenuItem.Text = "Ayuda parte I";
            this.ayudaParteIToolStripMenuItem.Click += new System.EventHandler(this.ayudaParteIToolStripMenuItem_Click);
            // 
            // ayudaParteLlToolStripMenuItem
            // 
            this.ayudaParteLlToolStripMenuItem.Name = "ayudaParteLlToolStripMenuItem";
            this.ayudaParteLlToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.ayudaParteLlToolStripMenuItem.Text = "Ayuda Parte ll";
            this.ayudaParteLlToolStripMenuItem.Click += new System.EventHandler(this.ayudaParteLlToolStripMenuItem_Click);
            // 
            // ayudaParteLllToolStripMenuItem
            // 
            this.ayudaParteLllToolStripMenuItem.Name = "ayudaParteLllToolStripMenuItem";
            this.ayudaParteLllToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.ayudaParteLllToolStripMenuItem.Text = "Ayuda Parte lll";
            this.ayudaParteLllToolStripMenuItem.Click += new System.EventHandler(this.ayudaParteLllToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1289, 750);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem saludoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem caluladoraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lenguajeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaParteIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaParteLlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaParteLllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem conversorDePesoToolStripMenuItem;
    }
}

