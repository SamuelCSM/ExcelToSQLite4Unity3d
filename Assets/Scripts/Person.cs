using SQLite4Unity3d;

public class Person
{

    [PrimaryKey, AutoIncrement]
    public int Id;

    public string Name;
    public string Surname;
    public int Age;

	public override string ToString ()
	{
		return string.Format ("[Person: Id={0}, Name={1},  Surname={2}, Age={3}]", Id, Name, Surname, Age);
	}
}
