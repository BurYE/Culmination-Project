using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarryOverMusic : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        DontDestroyOnLoad(gameObject);
    }
}
