using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    public Material bgSpace;
    public float bgSpeed = 0.2f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 bgDir = Vector2.up;
        bgSpace.mainTextureOffset += bgDir * bgSpeed * Time.deltaTime;

    }
}
