using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RevealTheKeyAlready : MonoBehaviour
{
    public GameObject key;

    void Start()
    {
        if (System.DateTime.Now.Day.Equals(7) && System.DateTime.Now.Month.Equals(10))
        {
            key.SetActive(true);
        }
    }
}
