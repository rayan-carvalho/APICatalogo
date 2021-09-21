using Microsoft.EntityFrameworkCore.Migrations;

namespace APICatalogo.Migrations
{
    public partial class Popiladb : Migration
    {
        protected override void Up(MigrationBuilder mb)
        {
            mb.Sql("INSERT INTO Categorias(Nome,ImagemUrl) VALUES('Bibidas','http://www.marcoratti.net/imagens/1.jpg')");


            mb.Sql("INSERT INTO Produtos(Nome,Descricao, Preco, ImagemUrl, Estoque, DataCadastro, CategoriaId) VALUES('Coca-Cola','Refrigerante de Cola',5.50,'http://www.marcoratti.net/imagens/1.jpg',50,now(),1)");

        }

        protected override void Down(MigrationBuilder mb)
        {

        }
    }
}
