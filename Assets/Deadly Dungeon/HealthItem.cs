using System;
using UnityEngine;

public class HealthItem : MonoBehaviour
{
    public int healAmount = 1;
    public static event Action<int> OnHealthCollect;
    public void Collect()
    {
        OnHealthCollect.Invoke(healAmount);
        //destory burger once collected
        Destroy(gameObject);
    }
}
