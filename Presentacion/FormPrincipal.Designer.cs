namespace Presentacion
{
	partial class FormPrincipal
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
			dataGridViewLibros = new DataGridView();
			((System.ComponentModel.ISupportInitialize)dataGridViewLibros).BeginInit();
			SuspendLayout();
			// 
			// dataGridViewLibros
			// 
			dataGridViewLibros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewLibros.Location = new Point(75, 33);
			dataGridViewLibros.Name = "dataGridViewLibros";
			dataGridViewLibros.Size = new Size(404, 280);
			dataGridViewLibros.TabIndex = 0;
			// 
			// FormPrincipal
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(dataGridViewLibros);
			Name = "FormPrincipal";
			Text = "FormPrincipal";
			Load += FormPrincipal_Load;
			((System.ComponentModel.ISupportInitialize)dataGridViewLibros).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private DataGridView dataGridViewLibros;
	}
}