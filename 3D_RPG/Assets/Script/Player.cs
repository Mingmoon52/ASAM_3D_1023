using UnityEngine;

public class Player : MonoBehaviour
{


    [Header("跑步"), Range(500, 1000)]
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
    public int blood;

}
