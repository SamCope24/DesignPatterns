namespace DesignPatterns.Repository;

public interface IPeopleRepository
{
    public Person GetById(Guid id);
    public IEnumerable<Person> Get();
    public void Add(Person person);
    public void Remove(Person person);
}