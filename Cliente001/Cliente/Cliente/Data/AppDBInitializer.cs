using Cliente.Models;

namespace Cliente.Data
{
    public class AppDBInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppCont>();
                context.Database.EnsureCreated();

                if (!context.Clientes.Any())
                {
                    context.Clientes.AddRange(new List<Cli>()
                    {
                        new Cli()
                        {
                            Nome = "Samuel",
                            Telefone = "215-215",
                            Email = "samuel@samuel.com",
                            Endereco = "casa do samuel"
                        },
                        new Cli()
                        {
                            Nome = "Michael Jackson",
                            Telefone = "111-111",
                            Email = "michael@jackson.com",
                            Endereco = "Inferno"
                        },
                        new Cli()
                        {
                            Nome = "Ethan Winters",
                            Telefone = "512-512",
                            Email = "Ethan@Winters.com",
                            Endereco = "Nova Luisiana"
                        },
                        new Cli()
                        {
                            Nome = "Mark Edward Fischbach",
                            Telefone = "123-321",
                            Email = "Markiplier@Markiplier.com",
                            Endereco = "California"
                        },
                        new Cli()
                        {
                            Nome = "Tyler Joseph",
                            Telefone = "21-21",
                            Email = "Twenty@one.com",
                            Endereco = "Ohio"
                        }
                    });
                    context.SaveChanges();
                }
            }
        }
    }
}
