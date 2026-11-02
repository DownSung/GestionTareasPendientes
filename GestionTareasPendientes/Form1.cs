namespace GestionTareasPendientes;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
        ActualizarContador();
    }

    // Comprueba el texto antes de añadirlo a la lista.
    private void btnAgregarTarea_Click(object? sender, EventArgs e)
    {
        string tarea = txtTarea.Text.Trim();
        if (string.IsNullOrWhiteSpace(tarea))
        {
            MessageBox.Show("Por favor, ingresa una tarea.", "Aviso",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtTarea.Focus();
            return;
        }

        foreach (var elemento in lstTareas.Items)
        {
            if (string.Equals(elemento.ToString(), tarea, StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("Esta tarea ya está en la lista.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTarea.Focus();
                return;
            }
        }

        lstTareas.Items.Add(tarea);
        txtTarea.Clear();
        txtTarea.Focus();
        ActualizarContador();
    }

    // Quita la tarea que se seleccionó en la lista.
    private void btnEliminarTarea_Click(object? sender, EventArgs e)
    {
        if (lstTareas.SelectedIndex == -1)
        {
            MessageBox.Show("Selecciona una tarea para eliminar.", "Aviso",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        lstTareas.Items.RemoveAt(lstTareas.SelectedIndex);
        ActualizarContador();
        MessageBox.Show("Tarea eliminada correctamente.", "Información",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    // Pregunta antes de borrar todas las tareas.
    private void btnLimpiarLista_Click(object? sender, EventArgs e)
    {
        if (lstTareas.Items.Count == 0)
        {
            MessageBox.Show("La lista ya está vacía.", "Aviso",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        DialogResult respuesta = MessageBox.Show(
            "¿Deseas eliminar todas las tareas?", "Confirmar eliminación",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);

        if (respuesta == DialogResult.Yes)
        {
            lstTareas.Items.Clear();
            ActualizarContador();
        }
    }

    private void ActualizarContador()
    {
        lblContador.Text = $"{lstTareas.Items.Count} tarea(s) pendiente(s)";
    }
}
