using System.Windows.Forms;

namespace Cafeteria;

public partial class FormPrincipal : Form
{
    public FormPrincipal()
    {
        InitializeComponent();
    }

    private void BotaoProdutos_Click(object? sender, EventArgs e)
    {
        MostrarFuncionalidadePendente("Produtos");
    }

    private void BotaoVendas_Click(object? sender, EventArgs e)
    {
        MostrarFuncionalidadePendente("Vendas");
    }

    private void BotaoRelatorios_Click(object? sender, EventArgs e)
    {
        MostrarFuncionalidadePendente("Relatórios");
    }

    private void MostrarFuncionalidadePendente(string nome)
    {
        MessageBox.Show(
            this,
            $"A funcionalidade de {nome} será desenvolvida em uma feature branch.",
            "Cafeteria",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information);
    }
}
