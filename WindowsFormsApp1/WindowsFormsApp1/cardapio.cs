using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

            new produtos { nome = "Espresso", categoria = "bebida", preco = "4.50" },
            new produtos { nome = "Americano", categoria = "bebida", preco = "4.00" },
            new produtos { nome = "Latte", categoria = "bebida", preco = "6.50" },
            new produtos { nome = "Cappuccino", categoria = "bebida", preco = "8.00" },
            new produtos { nome = "Mocha", categoria = "bebida", preco = "8.00" },
            new produtos { nome = "Café gelado", categoria = "bebida", preco = "6.50" },
            new produtos { nome = "Chás (sabor à escolha)", categoria = "bebida", preco = "5.00" },
            new produtos { nome = "Chai", categoria = "bebida", preco = "6.50" },
            new produtos { nome = "Chocolate quente", categoria = "bebida", preco = "8.00" },
            new produtos { nome = "Matcha latte", categoria = "bebida", preco = "10.00" },
            new produtos { nome = "Sucos naturais", categoria = "bebida", preco = "9.00" },
            new produtos { nome = "Macchiato", categoria = "bebida", preco = "5.00" },
            new produtos { nome = "Água com gás e sem gás", categoria = "bebida", preco = "4.00" },
            new produtos { nome = "Cookies", categoria = "doce", preco = "10.00" },
            new produtos { nome = "Brownies", categoria = "doce", preco = "12.00" },
            new produtos { nome = "Muffin", categoria = "doce", preco = "6.00" },
            new produtos { nome = "Croissant doce", categoria = "doce", preco = "12.50" },
            new produtos { nome = "Fatia de bolo", categoria = "doce", preco = "8.00" },
            new produtos { nome = "Mini cheesecake", categoria = "doce", preco = "12.00" },
            new produtos { nome = "Pastel de Belém", categoria = "doce", preco = "7.50" },
            new produtos { nome = "Banana bread", categoria = "doce", preco = "6.50" },
            new produtos { nome = "Dango", categoria = "doce", preco = "8.50" },
            new produtos { nome = "Choux", categoria = "doce", preco = "10.00" },
            new produtos { nome = "Pão de queijo", categoria = "salgado", preco = "6.00" },
            new produtos { nome = "Croissant salgado", categoria = "salgado", preco = "12.50" },
            new produtos { nome = "Sanduíches naturais", categoria = "salgado", preco = "8.00" },
            new produtos { nome = "Wraps", categoria = "salgado", preco = "8.00" },
            new produtos { nome = "Quiches individuais", categoria = "salgado", preco = "6.00" },
            new produtos { nome = "Empanadas argentinas", categoria = "salgado", preco = "10.00" },
            new produtos { nome = "Focaccias individuais", categoria = "salgado", preco = "12.00" },
            new produtos { nome = "Mini tapiocas recheadas", categoria = "salgado", preco = "4.00" },
            new produtos { nome = "Porção coxinha", categoria = "salgado", preco = "12.00" },
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
            categoriaSelecionadas.Add("Cookies"); // doce
            categoriaSelecionadas.Add("Brownies"); // doce
            categoriaSelecionadas.Add("Muffin"); // doce
            categoriaSelecionadas.Add("Croissant doce"); // doce
            categoriaSelecionadas.Add("Fatia de bolo"); // doce
            categoriaSelecionadas.Add("Mini cheesecake"); // doce
            categoriaSelecionadas.Add("Pastel de Belém"); // doce
            categoriaSelecionadas.Add("Banana bread"); // doce
            categoriaSelecionadas.Add("Dango"); // doce
            categoriaSelecionadas.Add("Choux"); // doce
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            categoriaSelecionadas.Add("Espresso"); // bebida
            categoriaSelecionadas.Add("Americano"); // bebida
            categoriaSelecionadas.Add("Latte"); // bebida
            categoriaSelecionadas.Add("Cappuccino"); // bebida
            categoriaSelecionadas.Add("Mocha"); // bebida
            categoriaSelecionadas.Add("Café gelado"); // bebida
            categoriaSelecionadas.Add("Chás (sabor à escolha)"); // bebida
            categoriaSelecionadas.Add("Chai"); // bebida
            categoriaSelecionadas.Add("Chocolate quente"); // bebida
            categoriaSelecionadas.Add("Matcha latte"); // bebida
            categoriaSelecionadas.Add("Sucos naturais"); // bebida
            categoriaSelecionadas.Add("Macchiato"); // bebida
            categoriaSelecionadas.Add("Água com gás e sem gás"); // bebida
        }
    }
    }

