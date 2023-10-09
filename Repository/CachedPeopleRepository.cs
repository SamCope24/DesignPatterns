using Microsoft.Extensions.Caching.Memory;

namespace DesignPatterns.Repository;

public class CachedPeopleRepository : IPeopleRepository
{
    private readonly PeopleRepository _repository;
    private readonly IMemoryCache _memoryCache;

    public CachedPeopleRepository(PeopleRepository repository, IMemoryCache memoryCache)
    {
        _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        _memoryCache = memoryCache ?? throw new ArgumentNullException(nameof(memoryCache));
    }
        

    public void Add(Person person)
    {
        _repository.Add(person);
    }

    public IEnumerable<Person> Get()
    {
        string key = "people";

        return _memoryCache.GetOrCreate(
            key,
            entry =>
            {
                entry.SetAbsoluteExpiration(TimeSpan.FromSeconds(20));

                return _repository.Get();
            }
        )!;
    }

    public Person GetById(Guid id)
    {
        string key = $"person-{id}";

        return _memoryCache.GetOrCreate(
            key,
            entry =>
            {
                entry.SetAbsoluteExpiration(TimeSpan.FromSeconds(20));

                return _repository.GetById(id);
            }
        )!;
    }

    public void Remove(Person person)
    {
        _repository.Remove(person);
    }
}
