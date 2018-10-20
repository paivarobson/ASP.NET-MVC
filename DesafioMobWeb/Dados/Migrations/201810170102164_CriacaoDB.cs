namespace Dados.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class CriacaoDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clientes",
                c => new
                    {
                        ClienteID = c.Int(nullable: false, identity: true),
                        RazaoSocialCliente = c.String(),
                        FantasiaCliente = c.String(),
                        CnpjCliente = c.String(),
                        RuaCliente = c.String(),
                        NumeroRuaCliente = c.Int(nullable: false),
                        BairroCliente = c.String(),
                        ComplementoCliente = c.String(),
                        MunicipioCliente = c.String(),
                        CepCliente = c.String(),
                    })
                .PrimaryKey(t => t.ClienteID);
            
            CreateTable(
                "dbo.Usuarios",
                c => new
                    {
                        UsuarioID = c.Int(nullable: false, identity: true),
                        NomeUsuario = c.String(),
                        ApelidoUsuario = c.String(),
                        SenhaUsuario = c.String(),
                        ConfirmarSenhaUsuario = c.String(),
                        EmailUsuario = c.String(),
                        TelefoneUsuario = c.String(),
                    })
                .PrimaryKey(t => t.UsuarioID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Usuarios");
            DropTable("dbo.Clientes");
        }
    }
}
