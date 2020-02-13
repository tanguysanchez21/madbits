using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public float baseATK;
    public float baseDEF;

    private float ATK;
    private float DEF;

    //private Rigidbody2D body;

    // Start is called before the first frame update
    void Start()
    {
        ATK = baseATK;
        DEF = baseDEF;

        //body = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
