using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerFire : MonoBehaviour
{

    public GameObject bulletFactory;
    public GameObject firePosition;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnFire()
    {
        GameObject bullet = Instantiate(bulletFactory);
        bullet.transform.position = firePosition.transform.position;
        
    }

    // Update is called once per frame
    void Update()
    {
    }
}
