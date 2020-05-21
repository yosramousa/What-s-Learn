namespace ModelD4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class iNit : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Department",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 250),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.School",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        DepartmentID = c.Int(),
                        Name = c.String(nullable: false, maxLength: 250),
                        Type = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Department", t => t.DepartmentID)
                .Index(t => t.DepartmentID);
            
            CreateTable(
                "dbo.Teacher",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        SchoolId = c.Int(nullable: false),
                        Name = c.String(nullable: false, maxLength: 250),
                        BirthDate = c.DateTime(nullable: false),
                        Code = c.Int(nullable: false),
                        job = c.String(nullable: false, maxLength: 50),
                        Phone = c.String(nullable: false, maxLength: 250),
                        Qualification = c.String(nullable: false, maxLength: 250),
                        QualficationDate = c.DateTime(nullable: false),
                        HiringDate = c.DateTime(nullable: false),
                        Address = c.String(nullable: false),
                        Notes = c.String(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.School", t => t.SchoolId)
                .Index(t => t.SchoolId);
            
            CreateTable(
                "dbo.TeacherTransfer",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        TeacherID = c.Int(),
                        FromSchoolID = c.Int(),
                        ToSchoolID = c.Int(),
                        Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Teacher", t => t.TeacherID)
                .ForeignKey("dbo.School", t => t.FromSchoolID)
                .ForeignKey("dbo.School", t => t.ToSchoolID)
                .Index(t => t.TeacherID)
                .Index(t => t.FromSchoolID)
                .Index(t => t.ToSchoolID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TeacherTransfer", "ToSchoolID", "dbo.School");
            DropForeignKey("dbo.TeacherTransfer", "FromSchoolID", "dbo.School");
            DropForeignKey("dbo.TeacherTransfer", "TeacherID", "dbo.Teacher");
            DropForeignKey("dbo.Teacher", "SchoolId", "dbo.School");
            DropForeignKey("dbo.School", "DepartmentID", "dbo.Department");
            DropIndex("dbo.TeacherTransfer", new[] { "ToSchoolID" });
            DropIndex("dbo.TeacherTransfer", new[] { "FromSchoolID" });
            DropIndex("dbo.TeacherTransfer", new[] { "TeacherID" });
            DropIndex("dbo.Teacher", new[] { "SchoolId" });
            DropIndex("dbo.School", new[] { "DepartmentID" });
            DropTable("dbo.TeacherTransfer");
            DropTable("dbo.Teacher");
            DropTable("dbo.School");
            DropTable("dbo.Department");
        }
    }
}
