using NHibernate;
using NHibernate.Cfg;
using NHibernate.Cfg.MappingSchema;
using NHibernate.Dialect;
using NHibernate.Driver;
using NHibernate.Mapping.ByCode;
using System.Reflection;

namespace FichaCadastro.ORM
{
    public class NHibernateConfigurator
    {
        public static ISessionFactory Configure()
        {
            var cfg = new Configuration();

            cfg.DataBaseIntegration(dbIntegration =>
            {
                dbIntegration.ConnectionString = "Server=srvbdficha.database.windows.net;Database=FICHA_CADASTRO;User ID=Administrador;Password=@Ficha2022;";
                dbIntegration.Driver<SqlClientDriver>();
                dbIntegration.Dialect<MsSql2012Dialect>();
                dbIntegration.LogSqlInConsole = true;
            });

            //cfg.AddAssembly(Assembly.GetExecutingAssembly());

            var mapper = new ModelMapper();
            mapper.AddMappings(Assembly.GetExecutingAssembly().GetExportedTypes());

            HbmMapping mapping = mapper.CompileMappingForAllExplicitlyAddedEntities();
            cfg.AddMapping(mapping);

            return cfg.BuildSessionFactory();

        }
    }
}
