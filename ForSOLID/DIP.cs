public interface IRepository
{
    void Save(object data);
}

public class SqlRepository : IRepository
{
    public void Save(object data)
    {
    }
}

public class DataManager
{
    private readonly IRepository _repository;

    public DataManager(IRepository repository)
    {
        _repository = repository;
    }

    public void SaveData(object data)
    {
        _repository.Save(data);
    }
}
