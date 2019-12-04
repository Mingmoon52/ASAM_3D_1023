using UnityEngine;

public class Player : MonoBehaviour
{
    #region 欄位區域
    [Header("動畫參數名稱")]
    public string parRun = "跑步開關";
    public string parJump = "跳耀開關";
    public string parAtK = "攻擊觸發";
    public string parDamage = "受傷觸發";
    public string parDead = "死亡開關";

    [Header("道具")]
    public int countNeed = 10;
    public int countCurrent;
    [Header("數值")]
    public bool isDead;
    [Range(0, 500)]
    public float hp = 100;
    #endregion

    #region 方法區域 
    /// <summary>
    /// 跑步
    /// </summary>
    private void Run()
    { 
    
    }
    /// <summary>
    /// 跳躍
    /// </summary>
    private void Jump()
    { 
    
    }
    /// <summary>
    /// 攻擊
    /// </summary>
    private void Attack()
    { 
    
    }
    /// <summary>
    /// 受傷
    /// </summary>
    /// <param name="damage">damage</param>
    private void Damage(float damage)
    { 
    
    }
    /// <summary>
    /// 死亡
    /// </summary>
    private void Dead()
    { 
    
    }
    /// <summary>
    /// 撿道具
    /// </summary>
    private void EatProp()
    { 
    
    }
    /// <summary>
    /// 過關
    /// </summary>
    private void Pass()
    {

    }
    #endregion
    /* [Header("跑步"), Range(500, 1000)]
     public int run;

     [Header("跳曜"), Range(500, 1000)]
     public int jump;

     [Header("攻擊"), Range(500, 1000)]
     public int attack;

     [Header("受傷"), Range(500, 1000)]
     public int hurt;

     [Header("死亡"), Range(500, 1000)]
     public int dd;

     [Header("道具需求數量")]
     public int want;

     [Header("道具死得數量")]
     public int get;

     [Header("是否死亡")]
     public bool die;

     [Header("血量"), Range(0, 1000)]
     public int blood;*/

}
