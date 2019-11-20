using UnityEngine;

public class car : MonoBehaviour
{//定義欄位(宣告變數)
    //語法:
    //修飾詞 類型 名稱(指定 值) 結束
    //私人-隱藏private()預設
    //公開-顯示public

    [Header("CC數")][Range(500,10000)]
    public int aa = 2500;  //整數

    [Header("重量"), Range(50f, 500f)]
    public float we = 150.5f;  //浮點數

    [Header("品牌"),Tooltip("這是汽車的品牌品牌名稱~")]
    public string carr = "BBB";//字串

    [Header("煞車"), Tooltip("判斷汽車是否煞車，true煞車中，false沒有煞車")]
    public bool _stop = false; //布林值

}
