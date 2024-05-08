using WebApplication2.Models;

namespace WebApplication2.Repositories;

public class Procedure_Repository
{
    private readonly IConfiguration _configuration;

    public Procedure_Repository (IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public AnimalDTO? getAnimal(int id)
    {
        return null;
    }
}