// <auto-generated />
namespace Bookly.Migrations
{
    using System.CodeDom.Compiler;
    using System.Data.Entity.Migrations;
    using System.Data.Entity.Migrations.Infrastructure;
    using System.Resources;
    
    [GeneratedCode("EntityFramework.Migrations", "6.2.0-61023")]
    public sealed partial class RemovedGuidFromBookStatusAndCustomerIdFromBooks : IMigrationMetadata
    {
        private readonly ResourceManager Resources = new ResourceManager(typeof(RemovedGuidFromBookStatusAndCustomerIdFromBooks));
        
        string IMigrationMetadata.Id
        {
            get { return "201901170943209_RemovedGuidFromBookStatusAndCustomerIdFromBooks"; }
        }
        
        string IMigrationMetadata.Source
        {
            get { return null; }
        }
        
        string IMigrationMetadata.Target
        {
            get { return Resources.GetString("Target"); }
        }
    }
}
