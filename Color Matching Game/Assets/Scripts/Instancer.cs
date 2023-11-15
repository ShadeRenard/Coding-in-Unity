using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

[CreateAssetMenu]
public class Instancer : ScriptableObject
{
    public GameObject prefab;
    private int num;
   public void CreateInstance()
   {
        Instantiate(prefab);
   }
    public void CreateInstance (Vector3Data obj)
    {
        Instantiate(prefab, obj.value, Quaternion.identity);
    }

    public void CreateInstanceFromList(Vector3DataList obj)
    {
        foreach (var t in obj.vector3DList)
        {
            Instantiate(prefab, t.value, Quaternion.identity);
        }
    }

    public void CreateInstanceFromListCounting(Vector3DataList obj)
    {
        Instantiate(original:prefab, position:obj.vector3DList[num].value, rotation:Quaternion.identity);
       num++;
       if (num == obj.vector3DList.Count)
       {
            num = 0;
       }
    }

     public void CreateInstanceListRandomly(Vector3DataList obj)
    {
        num = UnityEngine.Random.Range(0, obj.vector3DList.Count -1);
        Instantiate(original:prefab, position:obj.vector3DList[num].value, rotation:Quaternion.identity);
    }
}
