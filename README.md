1、 定义配表数据

[Table("general")]

public class RefGeneral : SQLDataBase<string, RefGeneral>

{

    [PrimaryKey]
    
    public string key;

    public string value;
    
}

特性[Table]定义表名， [PrimaryKey] 定义主键字段。缺一不可


2、Excel配表

新增excel表格的表名及键值需要与定义的数据一致。

![image](https://github.com/SamuelCSM/ExcelToSQLite4Unity3d/assets/130014669/ee51fb96-af77-4491-b30f-ba0b119f35b5)


3、将Excel数据导成sql数据库

打开UNITY菜单，Tool -> RefData2SqliteToolEx, 点击按钮Export Sqlite Data 即可一键导出所有配表

4、代码使用数据

RefGeneral.GetDataByKey(key); 使用上面代码即可获取当前key对应的一列数据
