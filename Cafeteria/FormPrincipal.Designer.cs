using System.Drawing;
using System.Windows.Forms;

namespace Cafeteria;

partial class FormPrincipal
{
    private System.ComponentModel.IContainer? components = null;
    private Label titulo = null!;
    private Label descricao = null!;
    private Button botaoProdutos = null!;
    private Button botaoVendas = null!;
    private Button botaoRelatorios = null!;

    protected override void Dispose(bool disposing)
    {
        if (disposing)
        {
            components?.Dispose();
        }

        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        titulo = new Label();
        descricao = new Label();
        botaoProdutos = new Button();
        botaoVendas = new Button();
        botaoRelatorios = new Button();
        SuspendLayout();
        // titulo
        titulo.AutoSize = true;
        titulo.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
        titulo.Location = new Point(32, 28);
        titulo.Name = "titulo";
        titulo.Size = new Size(226, 37);
        titulo.Text = "Cafeteria";
        // descricao
        descricao.AutoSize = true;
        descricao.Location = new Point(35, 76);
        descricao.Name = "descricao";
        descricao.Size = new Size(330, 15);
        descricao.Text = "Projeto base para desenvolvimento colaborativo.";
        // botaoProdutos
        botaoProdutos.Location = new Point(35, 121);
        botaoProdutos.Name = "botaoProdutos";
        botaoProdutos.Size = new Size(160, 48);
        botaoProdutos.Text = "Produtos";
        botaoProdutos.UseVisualStyleBackColor = true;
        botaoProdutos.Click += BotaoProdutos_Click;
        // botaoVendas
        botaoVendas.Location = new Point(207, 121);
        botaoVendas.Name = "botaoVendas";
        botaoVendas.Size = new Size(160, 48);
        botaoVendas.Text = "Vendas";
        botaoVendas.UseVisualStyleBackColor = true;
        botaoVendas.Click += BotaoVendas_Click;
        // botaoRelatorios
        botaoRelatorios.Location = new Point(379, 121);
        botaoRelatorios.Name = "botaoRelatorios";
        botaoRelatorios.Size = new Size(160, 48);
        botaoRelatorios.Text = "Relatórios";
        botaoRelatorios.UseVisualStyleBackColor = true;
        botaoRelatorios.Click += BotaoRelatorios_Click;
        // FormPrincipal
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(576, 211);
        Controls.Add(titulo);
        Controls.Add(descricao);
        Controls.Add(botaoProdutos);
        Controls.Add(botaoVendas);
        Controls.Add(botaoRelatorios);
        Font = new Font("Segoe UI", 9F);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        MinimumSize = new Size(592, 250);
        Name = "FormPrincipal";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Cafeteria";
        ResumeLayout(false);
        PerformLayout();
    }
}
