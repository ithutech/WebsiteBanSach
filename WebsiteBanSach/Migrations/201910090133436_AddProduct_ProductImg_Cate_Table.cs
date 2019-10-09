namespace WebsiteBanSach.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddProduct_ProductImg_Cate_Table : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        CategoryId = c.Int(nullable: false, identity: true),
                        CateName = c.String(),
                    })
                .PrimaryKey(t => t.CategoryId);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ProductId = c.Int(nullable: false, identity: true),
                        ProductName = c.String(),
                        Price = c.Single(nullable: false),
                        Description = c.String(),
                        CategoryId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ProductId)
                .ForeignKey("dbo.Categories", t => t.CategoryId, cascadeDelete: true)
                .Index(t => t.CategoryId);
            
            CreateTable(
                "dbo.ProductImages",
                c => new
                    {
                        ProductImageId = c.Int(nullable: false, identity: true),
                        ImagePath = c.String(),
                        ProductId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ProductImageId)
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .Index(t => t.ProductId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProductImages", "ProductId", "dbo.Products");
            DropForeignKey("dbo.Products", "CategoryId", "dbo.Categories");
            DropIndex("dbo.ProductImages", new[] { "ProductId" });
            DropIndex("dbo.Products", new[] { "CategoryId" });
            DropTable("dbo.ProductImages");
            DropTable("dbo.Products");
            DropTable("dbo.Categories");
        }
    }
}
