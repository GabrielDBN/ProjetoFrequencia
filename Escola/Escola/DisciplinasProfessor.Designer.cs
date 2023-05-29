namespace Escola
{
    partial class DisciplinasProfessor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DisciplinasProfessor));
            txtIdProfessor = new TextBox();
            label1 = new Label();
            LBDisciplinaP = new ListBox();
            btnMostrarDP = new Button();
            btnSair = new Button();
            SuspendLayout();
            // 
            // txtIdProfessor
            // 
            txtIdProfessor.Location = new Point(73, 74);
            txtIdProfessor.Name = "txtIdProfessor";
            txtIdProfessor.Size = new Size(125, 27);
            txtIdProfessor.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 77);
            label1.Name = "label1";
            label1.Size = new Size(25, 20);
            label1.TabIndex = 1;
            label1.Text = "Id:";
            // 
            // LBDisciplinaP
            // 
            LBDisciplinaP.FormattingEnabled = true;
            LBDisciplinaP.ItemHeight = 20;
            LBDisciplinaP.Location = new Point(241, 45);
            LBDisciplinaP.Name = "LBDisciplinaP";
            LBDisciplinaP.Size = new Size(414, 264);
            LBDisciplinaP.TabIndex = 2;
            // 
            // btnMostrarDP
            // 
            btnMostrarDP.Location = new Point(83, 161);
            btnMostrarDP.Name = "btnMostrarDP";
            btnMostrarDP.Size = new Size(94, 34);
            btnMostrarDP.TabIndex = 3;
            btnMostrarDP.Text = "Mostrar";
            btnMostrarDP.UseVisualStyleBackColor = true;
            btnMostrarDP.Click += btnMostrarDP_Click;
            // 
            // btnSair
            // 
            btnSair.Location = new Point(83, 219);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(94, 34);
            btnSair.TabIndex = 4;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // DisciplinasProfessor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(683, 346);
            Controls.Add(btnSair);
            Controls.Add(btnMostrarDP);
            Controls.Add(LBDisciplinaP);
            Controls.Add(label1);
            Controls.Add(txtIdProfessor);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "DisciplinasProfessor";
            Text = "Disciplina por professor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtIdProfessor;
        private Label label1;
        private ListBox LBDisciplinaP;
        private Button btnMostrarDP;
        private Button btnSair;
    }
}