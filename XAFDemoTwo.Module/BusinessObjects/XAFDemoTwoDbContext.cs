using System;
using System.Data;
using System.Linq;
using System.Data.Entity;
using System.Data.Common;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.ComponentModel;
using DevExpress.ExpressApp.EF.Updating;
using DevExpress.Persistent.BaseImpl.EF;
using DevExpress.ExpressApp.Design;
using DevExpress.ExpressApp.EF.DesignTime;
using DevExpress.Persistent.BaseImpl.EF.PermissionPolicy;
using XAFDemoTwo.Module.BusinessObjects.Marketing;

namespace XAFDemoTwo.Module.BusinessObjects {
	public class XAFDemoTwoContextInitializer : DbContextTypesInfoInitializerBase {
		protected override DbContext CreateDbContext() {
			DbContextInfo contextInfo = new DbContextInfo(typeof(XAFDemoTwoDbContext), new DbProviderInfo(providerInvariantName: "System.Data.SqlClient", providerManifestToken: "2008"));
            return contextInfo.CreateInstance();
		}
	}
	[TypesInfoInitializer(typeof(XAFDemoTwoContextInitializer))]
	public class XAFDemoTwoDbContext : DbContext {
		public XAFDemoTwoDbContext(String connectionString)
			: base(connectionString) {
		}
		public XAFDemoTwoDbContext(DbConnection connection)
			: base(connection, false) {
		}
		public XAFDemoTwoDbContext() {
		}
		public DbSet<ModuleInfo> ModulesInfo { get; set; }
		public DbSet<Customer> Customer { get; set; }
		public DbSet<Testimonial> Testimonial { get; set; }


	}
}
