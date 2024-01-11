using SQLite4Unity3d;

[Table("general")]
public class RefGeneral : SQLDataBase<string, RefGeneral>
{

    [PrimaryKey]
    public string key;

    public string value;

    public static T getData<T>(string key)
    {
        RefGeneral general = GetDataByKey(key);
        object obj = null;
        TypeParse.ParseValue(general.value, typeof(T), ref obj);
        return (T)obj;
    }
}