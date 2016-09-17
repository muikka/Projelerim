namespace MvcLearning.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMembershipTypes : DbMigration
    {
        public override void Up()
        {
            Sql("insert into MembershipTypes (Id,SignUpFee,DurationInMonths,DiscountRate,Name) Values(1,0,0,0,'Pay As You Go')");
            Sql("insert into MembershipTypes (Id,SignUpFee,DurationInMonths,DiscountRate,Name) Values(2,30,1,10,'Montly')");
            Sql("insert into MembershipTypes (Id,SignUpFee,DurationInMonths,DiscountRate,Name) Values(3,90,3,15,'For 3 Months')");
            Sql("insert into MembershipTypes (Id,SignUpFee,DurationInMonths,DiscountRate,Name) Values(4,300,12,20,'Yearly')");

        }
        
        public override void Down()
        {

        }
    }
}
