using FluentMigrator;

namespace MultiTenancy.Migrations.DefaultDB
{
    [Migration(20180430134800)]
    public class DefaultDB_20180430_134800_MultiTenant
        : AutoReversingMigration
    {
        public override void Up()
        {
            this.CreateTableWithId32("Tenants", "TenantId", s => s
                .WithColumn("TenantName").AsString(100)
                    .NotNullable());

            Insert.IntoTable("Tenants")
                .Row(new
                {
                    TenantName = "Emprea RCO"
                });

            Insert.IntoTable("Tenants")
                .Row(new
                {
                    TenantName = "Second XPTO"
                });

            Insert.IntoTable("Tenants")
                .Row(new
                {
                    TenantName = "Third ABC"
                });

            Alter.Table("Users")
                .AddColumn("TenantId").AsInt32()
                    .NotNullable().WithDefaultValue(1);

            Alter.Table("Roles")
                .AddColumn("TenantId").AsInt32()
                    .NotNullable().WithDefaultValue(1);

            Alter.Table("Languages")
                .AddColumn("TenantId").AsInt32()
                    .NotNullable().WithDefaultValue(1);
        }
    }
}
