namespace DesignPatterns.Repository;

public class PeopleRepository : IPeopleRepository
{
    private readonly PeopleContext _context;

    public PeopleRepository(PeopleContext context) => 
        _context = context ?? throw new ArgumentNullException(nameof(context)); 

    public void Add(Person person)
    {
        _context.Add(person);
        _context.SaveChanges();
    }

    public IEnumerable<Person> Get()
    {
        return _context.People!.ToList();
    }

    public Person GetById(Guid id)
    {
        return _context.People!.FirstOrDefault(x => x.Id == id) 
            ?? throw new KeyNotFoundException();
    }

    public void Remove(Person person)
    {
        _context.Remove(person);
        _context.SaveChanges();
    }
}