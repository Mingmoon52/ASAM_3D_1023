using UnityEngine;
using UnityEngine.UI;//引用 介面 API
using UnityEngine.SceneManagement;//引用 場景管理 API

public class EAT : MonoBehaviour
{
    [Header("高麗菜數量介面")]
    public Text textCount;
    [Header("提示畫面")]
    public GameObject ObjTip;

    public int propCont;                //目前高麗菜數量
    public int propTotal = 6;          //高麗菜數量

    public bool finish;

    private void OnCollisionEnter(Collision collision)
    {
        
        // print(collision.gameObject);
        
        if (collision.gameObject.tag == "高麗菜")
        {
            Destroy(collision.gameObject);

            propCont++;                                    //遞增
            textCount.text = "高麗菜:" + propCont + "/6";  //更新介面

            //如果 目前數量 等於 總數 顯示 勝利提示
            if (propCont ==propTotal)
            {
                finish = true;
                ObjTip.SetActive(true);
            }
        }

    }

    private void Update()
    {
        GameOver();
    }

    private void GameOver()
    {
        if (finish)
        {
            //按下 ESC 離開
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                Application.Quit();       //應用程式.離開():
            }
            //按下 R重來
            if (Input.GetKeyDown(KeyCode.R)) 
            {
                //Application.LoadLevel("遊戲場景");  舊版API
                SceneManager.LoadScene("場景"); //新版API
            }

        }
    
    }
}
