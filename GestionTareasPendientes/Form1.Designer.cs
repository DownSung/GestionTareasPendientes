namespace GestionTareasPendientes;

partial class Form1
{
    private System.ComponentModel.IContainer? components = null;
    private Label lblTitulo = null!;
    private Label lblSubtitulo = null!;
    private Label lblNuevaTarea = null!;
    private Label lblLista = null!;
    private Label lblContador = null!;
    private TextBox txtTarea = null!;
    private Button btnAgregarTarea = null!;
    private ListBox lstTareas = null!;
    private Button btnEliminarTarea = null!;
    private Button btnLimpiarLista = null!;

    protected override void Dispose(bool disposing)
    {
        if (disposing) components?.Dispose();
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        lblTitulo = new Label();
        lblSubtitulo = new Label();
        lblNuevaTarea = new Label();
        lblLista = new Label();
        lblContador = new Label();
        txtTarea = new TextBox();
        btnAgregarTarea = new Button();
        lstTareas = new ListBox();
        btnEliminarTarea = new Button();
        btnLimpiarLista = new Button();
        SuspendLayout();

        // Formulario
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(247, 247, 244);
        ClientSize = new Size(520, 510);
        Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        Name = "Form1";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Gestor de tareas académicas";
        AcceptButton = btnAgregarTarea;

        lblTitulo.AutoSize = true;
        lblTitulo.Font = new Font("Segoe UI", 19F, FontStyle.Bold, GraphicsUnit.Point);
        lblTitulo.ForeColor = Color.FromArgb(36, 65, 78);
        lblTitulo.Location = new Point(25, 22);
        lblTitulo.Name = "lblTitulo";
        lblTitulo.Text = "Mis actividades académicas";

        lblSubtitulo.AutoSize = true;
        lblSubtitulo.ForeColor = Color.FromArgb(96, 108, 123);
        lblSubtitulo.Location = new Point(27, 65);
        lblSubtitulo.Name = "lblSubtitulo";
        lblSubtitulo.Text = "Anota aquí tus trabajos y recordatorios";

        lblNuevaTarea.AutoSize = true;
        lblNuevaTarea.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
        lblNuevaTarea.ForeColor = Color.FromArgb(42, 57, 76);
        lblNuevaTarea.Location = new Point(27, 105);
        lblNuevaTarea.Name = "lblNuevaTarea";
        lblNuevaTarea.Text = "Nueva tarea:";

        txtTarea.Location = new Point(27, 132);
        txtTarea.Name = "txtTarea";
        txtTarea.PlaceholderText = "Escribe una tarea pendiente...";
        txtTarea.Size = new Size(464, 25);
        txtTarea.TabIndex = 0;

        btnAgregarTarea.BackColor = Color.FromArgb(45, 105, 126);
        btnAgregarTarea.FlatAppearance.BorderSize = 0;
        btnAgregarTarea.FlatStyle = FlatStyle.Flat;
        btnAgregarTarea.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
        btnAgregarTarea.ForeColor = Color.White;
        btnAgregarTarea.Location = new Point(27, 175);
        btnAgregarTarea.Name = "btnAgregarTarea";
        btnAgregarTarea.Size = new Size(464, 39);
        btnAgregarTarea.TabIndex = 1;
        btnAgregarTarea.Text = "Agregar Tarea";
        btnAgregarTarea.UseVisualStyleBackColor = false;
        btnAgregarTarea.Click += btnAgregarTarea_Click;

        lblLista.AutoSize = true;
        lblLista.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
        lblLista.ForeColor = Color.FromArgb(42, 57, 76);
        lblLista.Location = new Point(27, 236);
        lblLista.Name = "lblLista";
        lblLista.Text = "Lista de tareas:";

        lblContador.AutoSize = false;
        lblContador.TextAlign = ContentAlignment.MiddleRight;
        lblContador.ForeColor = Color.FromArgb(96, 108, 123);
        lblContador.Location = new Point(286, 236);
        lblContador.Name = "lblContador";
        lblContador.Size = new Size(205, 24);
        lblContador.Text = "0 tarea(s) pendiente(s)";

        lstTareas.BackColor = Color.White;
        lstTareas.BorderStyle = BorderStyle.FixedSingle;
        lstTareas.FormattingEnabled = true;
        lstTareas.HorizontalScrollbar = true;
        lstTareas.ItemHeight = 17;
        lstTareas.Location = new Point(27, 270);
        lstTareas.Name = "lstTareas";
        lstTareas.Size = new Size(464, 138);
        lstTareas.TabIndex = 2;

        btnEliminarTarea.BackColor = Color.FromArgb(168, 75, 62);
        btnEliminarTarea.FlatAppearance.BorderSize = 0;
        btnEliminarTarea.FlatStyle = FlatStyle.Flat;
        btnEliminarTarea.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
        btnEliminarTarea.ForeColor = Color.White;
        btnEliminarTarea.Location = new Point(27, 426);
        btnEliminarTarea.Name = "btnEliminarTarea";
        btnEliminarTarea.Size = new Size(223, 39);
        btnEliminarTarea.TabIndex = 3;
        btnEliminarTarea.Text = "Eliminar Tarea";
        btnEliminarTarea.UseVisualStyleBackColor = false;
        btnEliminarTarea.Click += btnEliminarTarea_Click;

        btnLimpiarLista.BackColor = Color.FromArgb(224, 230, 237);
        btnLimpiarLista.FlatAppearance.BorderSize = 0;
        btnLimpiarLista.FlatStyle = FlatStyle.Flat;
        btnLimpiarLista.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
        btnLimpiarLista.ForeColor = Color.FromArgb(42, 57, 76);
        btnLimpiarLista.Location = new Point(268, 426);
        btnLimpiarLista.Name = "btnLimpiarLista";
        btnLimpiarLista.Size = new Size(223, 39);
        btnLimpiarLista.TabIndex = 4;
        btnLimpiarLista.Text = "Limpiar Lista";
        btnLimpiarLista.UseVisualStyleBackColor = false;
        btnLimpiarLista.Click += btnLimpiarLista_Click;

        Controls.Add(lblTitulo);
        Controls.Add(lblSubtitulo);
        Controls.Add(lblNuevaTarea);
        Controls.Add(txtTarea);
        Controls.Add(btnAgregarTarea);
        Controls.Add(lblLista);
        Controls.Add(lblContador);
        Controls.Add(lstTareas);
        Controls.Add(btnEliminarTarea);
        Controls.Add(btnLimpiarLista);
        ResumeLayout(false);
        PerformLayout();
    }
}
