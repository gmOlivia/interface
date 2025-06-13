using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace WindowsFormsApp1
{
    public partial class cardapio : Form
    {
        public class produtos
        {
            public string nome { get; set; }
            public string categoria { get; set; }
            public string preco { get; set; }

            public override string ToString()
            {
                return $" {nome} {categoria} - {preco}";
            }
        }
        private List<produtos> Listaprodutos;

        private List<string> categoriaSelecionadas = new List<string>();
        public cardapio()
        {
            InitializeComponent();
            Listaprodutos = new List<produtos>() {

            new produtos { nome = "Espresso", categoria = "Bebidas", preco = "4.50" },
            new produtos { nome = "Americano", categoria = "Bebidas", preco = "4.00" },
            new produtos { nome = "Latte", categoria = "Bebidas", preco = "6.50" },
            new produtos { nome = "Cappuccino", categoria = "Bebidas", preco = "8.00" },
            new produtos { nome = "Mocha", categoria = "Bebidas", preco = "8.00" },
            new produtos { nome = "Café gelado", categoria = "Bebidas", preco = "6.50" },
            new produtos { nome = "Chás (sabor à escolha)", categoria = "Bebidas", preco = "5.00" },
            new produtos { nome = "Chai", categoria = "Bebidas", preco = "6.50" },
            new produtos { nome = "Chocolate quente", categoria = "Bebidas", preco = "8.00" },
            new produtos { nome = "Matcha latte", categoria = "Bebidas", preco = "10.00" },
            new produtos { nome = "Sucos naturais", categoria = "Bebidas", preco = "9.00" },
            new produtos { nome = "Macchiato", categoria = "Bebidas", preco = "5.00" },
            new produtos { nome = "Água com gás e sem gás", categoria = "Bebidas", preco = "4.00" },
            new produtos { nome = "Cookies", categoria = "Doces", preco = "10.00" },
            new produtos { nome = "Brownies", categoria = "Doces", preco = "12.00" },
            new produtos { nome = "Muffin", categoria = "Doces", preco = "6.00" },
            new produtos { nome = "Croissant doce", categoria = "Doces", preco = "12.50" },
            new produtos { nome = "Fatia de bolo", categoria = "Doces", preco = "8.00" },
            new produtos { nome = "Mini cheesecake", categoria = "Doces", preco = "12.00" },
            new produtos { nome = "Pastel de Belém", categoria = "Doces", preco = "7.50" },
            new produtos { nome = "Banana bread", categoria = "Doces", preco = "6.50" },
            new produtos { nome = "Dango", categoria = "Doces", preco = "8.50" },
            new produtos { nome = "Choux", categoria = "Doces", preco = "10.00" },
            new produtos { nome = "Pão de queijo", categoria = "Salgado", preco = "6.00" },
            new produtos { nome = "Croissant salgado", categoria = "Salgado", preco = "12.50" },
            new produtos { nome = "Sanduíches naturais", categoria = "Salgado", preco = "8.00" },
            new produtos { nome = "Wraps", categoria = "Salgado", preco = "8.00" },
            new produtos { nome = "Quiches individuais", categoria = "Salgado", preco = "6.00" },
            new produtos { nome = "Empanadas argentinas", categoria = "Salgado", preco = "10.00" },
            new produtos { nome = "Focaccias individuais", categoria = "Salgado", preco = "12.00" },
            new produtos { nome = "Mini tapiocas recheadas", categoria = "Salgado", preco = "4.00" },
            new produtos { nome = "Porção coxinha", categoria = "Salgado", preco = "12.00" },
        };

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            categoriaSelecionadas.Add("Pão de queijo"); // salgado
            categoriaSelecionadas.Add("Croissant salgado"); // salgado
            categoriaSelecionadas.Add("Sanduíches naturais"); // salgado
            categoriaSelecionadas.Add("Wraps"); // salgado
            categoriaSelecionadas.Add("Quiches individuais"); // salgado
            categoriaSelecionadas.Add("Empanadas argentinas"); // salgado
            categoriaSelecionadas.Add("Focaccias individuais"); // salgado
            categoriaSelecionadas.Add("Mini tapiocas recheadas"); // salgado
            categoriaSelecionadas.Add("Porção coxinha"); //salgado
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            categoriaSelecionadas.Add("Doces"); // doce
           
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            categoriaSelecionadas.Add("Bebidas"); // bebida
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Produtos.Items.Clear();

            if (checkBox1.Checked == false)
            {
                categoriaSelecionadas.Remove("Salgados");

            }
            if (checkBox2.Checked == false)
            {
                categoriaSelecionadas.Remove("Doces");
            }
            if (checkBox3.Checked == false)
            {
                categoriaSelecionadas.Remove("Bebidas");
            }

            if (categoriaSelecionadas.Count == 0)
            {
                Produtos.Items.Add("Nenhuma categoria selecionada!");
            }
            else
            {
                var produtosfiltrados = Listaprodutos.Where(
                    p => categoriaSelecionadas.Contains(p.categoria)).ToList();
                if (produtosfiltrados.Any())
                {
                    foreach (var produtos in produtosfiltrados)
                    {
                        Produtos.Items.Add(produtos);
                    }
                }
                else
                {
                    Produtos.Items.Add("nenhum produto encontrado");
                }
            }
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            categoriaSelecionadas.Add("Salgado"); // salgado
           
        }
    }
    }
    

