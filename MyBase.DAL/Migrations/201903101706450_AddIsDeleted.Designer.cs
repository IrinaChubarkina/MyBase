// <auto-generated />
namespace MyBase.DAL.Migrations
{
    using System.CodeDom.Compiler;
    using System.Data.Entity.Migrations;
    using System.Data.Entity.Migrations.Infrastructure;
    using System.Resources;
    
    [GeneratedCode("EntityFramework.Migrations", "6.2.0-61023")]
    public sealed partial class AddIsDeleted : IMigrationMetadata
    {
        private readonly ResourceManager Resources = new ResourceManager(typeof(AddIsDeleted));
        
        string IMigrationMetadata.Id
        {
            get { return "201903101706450_AddIsDeleted"; }
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