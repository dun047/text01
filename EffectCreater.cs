using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class EffectCreater : MonoBehaviour
{
    public Effecting[] player;  //存放特效物件的player陣列

    public void PlayEffect(string Effectname)
    {
        Effecting s = Array.Find(player, Effecting => Effecting.Effectname == Effectname);  //在player陣列裡以名稱(Effectname)尋找陣列裡的特效資源(Effecting)
        if (s == null)
        {
            Debug.LogWarning("Effect" + Effectname + "not found");  //如果沒有此名稱，回傳not found
            return;
        }

   
        Instantiate(s.Effect,transform.position + new Vector3(s.SpawnPosition.x, s.SpawnPosition.y, s.SpawnPosition.z), Quaternion.Euler(s.SpawnRotaion.x, s.SpawnRotaion.y, s.SpawnRotaion.z) , this.gameObject.transform);
        //找到則按照特效資源內容，生成此特效

    }
}

[System.Serializable]
public class Effecting    //特效資源
{
    public string Effectname;       //名稱

    public GameObject Effect;       //特效Prefab
    public Vector3 SpawnPosition;   //位置
    public Vector3 SpawnRotaion;    //旋轉


}


