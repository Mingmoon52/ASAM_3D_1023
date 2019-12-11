using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearnAPIStatic : MonoBehaviour
{
    
    private void Start()
    {
        //使用靜態成員
        //成員:屬性 Properties (類似欄位fields)
        //成員:方法 methods

        //取得靜態屬性語法 : 類型.屬性
        //設定靜態屬性語法 : 類型.屬性=值

        print(Random.value);
        //使用靜態方法語法 : 類型.方法(對應引數)
        print(Random.Range(1,11));

        int r = Random.Range(100, 201);
        print(r);

        //使用API 輸出PI
        //使用API 把-10去負數

        print(Mathf.PI);
        print(Mathf.Abs(-10));
    }
    //輸入 使用 更新事件 Update
    private void Update()
    {
        //print(Input.mousePosition);   //滑鼠位置
        //print(Input.anyKeyDown);     //按鍵按了什麼

       // print(Input.GetKeyDown("mouse 0"));
        print(Input.GetKeyDown(KeyCode.D));

    }


}
