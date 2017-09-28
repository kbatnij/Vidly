namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UPDATEMembershipType : DbMigration
    {
        public override void Up()
        {
            // Pay As You Go, Discount 0
            // Monthly, Discount 10
            // Quarterly, Discount 15
            // Annual, Discount 20
            Sql("UPDATE MembershipTypes SET Name = 'Pay As You Go' WHERE DiscountRate = 0");
            Sql("UPDATE MembershipTypes SET Name = 'Monthly' WHERE DiscountRate = 10");
            Sql("UPDATE MembershipTypes SET Name = 'Quarterly' WHERE DiscountRate = 15");
            Sql("UPDATE MembershipTypes SET Name = 'Annual' WHERE DiscountRate = 20");
        }

        public override void Down()
        {
        }
    }
}
