namespace DesafioMobWeb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CriacaoBD : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clientes",
                c => new
                    {
                        clienteID = c.Int(nullable: false, identity: true),
                        razaoSocialCliente = c.String(),
                        fantasiaCliente = c.String(),
                        cnpjCliente = c.String(),
                        ruaCliente = c.String(),
                        numeroRuaCliente = c.Int(nullable: false),
                        bairroCliente = c.String(),
                        complementoCliente = c.String(),
                        municipioCliente = c.String(),
                        cepCliente = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.clienteID);
            
            CreateTable(
                "dbo.Usuarios",
                c => new
                    {
                        usuarioID = c.Int(nullable: false, identity: true),
                        nomeUsuario = c.String(),
                        apelidoUsuario = c.String(),
                        emailUsuario = c.String(),
                        telefoneUsuario = c.String(),
                    })
                .PrimaryKey(t => t.usuarioID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Usuarios");
            DropTable("dbo.Clientes");
        }
    }
}
