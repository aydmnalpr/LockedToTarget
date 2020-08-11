using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockToTarget : MonoBehaviour
{
    public Transform target;
    

    // Update is called once per frame
    void Update()
    {
        Vector3 dir = target.position - transform.position;
        Quaternion lookRotation = Quaternion.LookRotation(dir);
        //transform.rotation - lookRotation;
        //biz sadece ye eksininde donmesini istedigimiz icin asagida tekrar euler e cevirip y eksenini dondurduk
        
        //burada slerp de kullanilabilir
        Vector3 rotation = lookRotation.eulerAngles;
        transform.rotation = Quaternion.Euler(0f,rotation.y, 0f);
    }
}
