using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LreanOperator : MonoBehaviour
{
    public int A = 10, B = 3;

    public int C = 1;

    public int prop = 1;

    public int D = 9;

    public float E = 99.9f , F = 10.5f;

    public float hp = 100;

    public bool key;
    public int enemy;

    // Start is called before the first frame update
    public void Start()
    {
        #region 數學運算子
        //加減乘除餘 + - * / %
        print(A + B);
        print(A - B);
        print(A * B);
        print(A / B);
        print(A % B);

        //指派:先運算指派符號右邊再傳回左邊
        C = 9 + 1;
        print("C運算結果:"+ C);

        // prop = prop + 1;原本寫法 
        print(prop++);//後置遞增:先輸出在運算-輸出結果為1,記憶體內存於3
        print(++prop);//前置遞增:先運算在輸出-輸出結果為3,記憶體內存於1
        //遞減--

        //D = D +10;
        D += 10 ;
        #endregion

        #region 比較運算子
        print(E > F);                 //true
        print(E < F);                 //false
        print(E >= F);              //t
        print(E <= F);              //f
        print(E == F);              //f
        print(E != F);              //t

        #endregion

        #region 邏輯運算子
        //並且 && 只要有一個 false 結果就是false
        print(true && true); //true
        print(true && false); //false
        print(false && true); //false
        print(false && false); //false

        //並且 || 只要有一個 true 結果就是true
        print(true || true); //true
        print(true || false); //true
        print(false || true); //true
        print(false || false); //false

        //相反
        print(!true); //false
        print(!false); //true
        #endregion


    }

    // Update is called once per frame
    private void Update()
    {
        print("死亡:" + (hp <= 0));
        print("過關判定:" + (key && enemy >= 5));

    }
}
