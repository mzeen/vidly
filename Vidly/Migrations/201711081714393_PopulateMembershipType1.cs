namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMembershipType1 : DbMigration
    {
        public override void Up()
        {
            Sql("Update MembershipTypes Set Name ='Pay as You Go' Where Id =1");
            Sql("Update MembershipTypes Set Name ='Monthly' Where Id =2");
            Sql("Update MembershipTypes Set Name ='Monthly' Where Id =3");
            Sql("Update MembershipTypes Set Name ='Yearly' Where Id =4");
        }
        
        public override void Down()
        {
        }
    }
}
