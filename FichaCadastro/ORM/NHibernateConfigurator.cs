using NHibernate;
using NHibernate.Cfg;
using NHibernate.Dialect;
using NHibernate.Driver;
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
                dbIntegration.ConnectionString = "Server=localhost;Database=FICHA_CADASTRAL;Trusted_Connection=True;";
                dbIntegration.Driver<SqlClientDriver>();
                dbIntegration.Dialect<MsSql2012Dialect>();
                dbIntegration.LogSqlInConsole = true;
            });

           cfg.AddAssembly(Assembly.GetExecutingAssembly());

           return cfg.BuildSessionFactory();

        }
    }
}
