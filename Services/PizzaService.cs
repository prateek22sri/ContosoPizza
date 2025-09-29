using ContosoPizza.Models;

namespace ContosoPizza.Services;

public interface IPizzaService
{
    List<Pizza> GetAll();
}

public class PizzaService : IPizzaService
{
    private readonly List<Pizza> _pizzas = new()
    {
        new Pizza { Id = 1, Name = "Classic Italian", IsGlutenFree = false },
        new Pizza { Id = 2, Name = "Veggie", IsGlutenFree = true }
    };

    private int _nextId = 3;

    public List<Pizza> GetAll() => _pizzas;
}
