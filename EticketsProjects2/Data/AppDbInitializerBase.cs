namespace EticketsProjects2.Data
{
    public class AppDbInitializerBase
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            applicationBuilder.UseDeveloperExceptionPage();
        }
    }
}