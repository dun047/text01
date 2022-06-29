using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class EffectCreater : MonoBehaviour
{
    public Effecting[] player;  //�s��S�Ī���player�}�C

    public void PlayEffect(string Effectname)
    {
        Effecting s = Array.Find(player, Effecting => Effecting.Effectname == Effectname);  //�bplayer�}�C�̥H�W��(Effectname)�M��}�C�̪��S�ĸ귽(Effecting)
        if (s == null)
        {
            Debug.LogWarning("Effect" + Effectname + "not found");  //�p�G�S�����W�١A�^��not found
            return;
        }

   
        Instantiate(s.Effect,transform.position + new Vector3(s.SpawnPosition.x, s.SpawnPosition.y, s.SpawnPosition.z), Quaternion.Euler(s.SpawnRotaion.x, s.SpawnRotaion.y, s.SpawnRotaion.z) , this.gameObject.transform);
        //���h���ӯS�ĸ귽���e�A�ͦ����S��

    }
}

[System.Serializable]
public class Effecting    //�S�ĸ귽
{
    public string Effectname;       //�W��

    public GameObject Effect;       //�S��Prefab
    public Vector3 SpawnPosition;   //��m
    public Vector3 SpawnRotaion;    //����


}


