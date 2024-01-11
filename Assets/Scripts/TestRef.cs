using System.Collections;
using System.Collections.Generic;
using SQLite4Unity3d;
using UnityEngine;

public class TestRef : MonoBehaviour
{
    public interface _iA
    {
        
    }

    public class A : _iA
    {

    }


    // Start is called before the first frame update
    void Start()
    {
        CustomSerializerMgr.Instance.initCustomSerializer();
        SQLDataMgr.Instance.LoadDatabase();

        RefPerson p = SQLDataMgr.Instance.SQL.Table<RefPerson>().Where(x => x.Id == 2).FirstOrDefault();

        RefPerson person1 = RefPerson.GetDataByKey(1);
        RefPerson person2 = RefPerson.GetDataByKey(2);
        RefPerson person3 = RefPerson.GetDataByKey(3);
        RefEmail email3 = RefEmail.GetDataByKey(3);
        RefEmail email4 = RefEmail.GetDataByKey(4);
        RefEmail email5 = RefEmail.GetDataByKey(5);
        int general_num = RefGeneral.getData<int>("int_num");
        string generalString = RefGeneral.getData<string>("string_name");
        CommonItem generalItem = RefGeneral.getData<CommonItem>("common_item");
        List<CommonItem> generalItemList = RefGeneral.getData<List<CommonItem>>("common_item_list");
        Debug.LogError(person1);
        Debug.LogError(person2);
        Debug.LogError(person3);
        Debug.LogError(email3);
        Debug.LogError(email4);
        Debug.LogError(email5);
        Debug.LogError(general_num);
        Debug.LogError(generalString);
        Debug.LogError(generalItem);

        if (generalItemList != null)
        {
            string generalItemListString = "";
            for (int i = 0, count = generalItemList.Count; i < count; i++)
            {
                generalItemListString += generalItemList[i];

                if (i != count - 1)
                    generalItemListString += ";";
            }

            Debug.LogError(generalItemListString);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
