using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    private string npcName = "聖誕矮人";
    private string npcContent = "可以幫我找三顆高麗菜嗎?";

    [Header("對話系統")]
    public DialogSystem ds;

    private void OnTriggerEnter(Collider other)
    {
        print(other.name);

        if (other.name == "玩家")
        {
            ds.ShowDialog(npcName, npcContent);
        }
                     
    }

    private void OnTriggerExit(Collider other)
    {
        

        if (other.name == "玩家")
        {
            ds.HideDialog();
        }

    }

}
