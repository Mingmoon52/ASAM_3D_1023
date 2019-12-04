using UnityEngine;


public class LearnIf : MonoBehaviour
{
    public bool openDoor;
    public int score;
    public int Attack;

    private void Start()
    {
        // if (布林值) {陳述式或演算法}
        // () 內的布林值為 true 會執行 {}
        if  (true)
        {
            print("測試");
        }
    }

    private void Update()
    {
        if (openDoor)
        {
            //if () 內的布林值為 true 會執行{}
            print("開門");
        }
        else
        {
            //if()內的布林值為false 會執行else{}
            print("關門");
        }

        if (score >= 60)
        {
            print("及格");
        }
        else if (score >= 50)
        {
            print("可以補考");
        }
        else if (score >= 40)
        {
            print("付錢來補考~");
        }
        else 
        {
            print("被當惹");
        }

        if (Attack < 50)
        {
            print("攻擊無倍數");
        }
        else if(Attack <= 50)
        {
            print("攻擊2倍");
        }
        else if (Attack <= 100)
        {
            print("攻擊5倍");
        }
        else if (Attack <= 150)
        {
            print("攻擊10倍");
        }
    }

}
