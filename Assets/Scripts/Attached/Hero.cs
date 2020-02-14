using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero : MonoBehaviour
{
    private float spawnX;
    private float spawnY;
    private float spawnZ;

    public float baseATK;
    public float baseDEF;

    private float ATK;
    private float DEF;

    private GameObject self;
    private GameObject camera;

    private float width;
    private float height;

    // Start is called before the first frame update
    void Start()
    {
        ATK = baseATK;
        DEF = baseDEF;

        self = GameObject.Find("hero");
        camera = GameObject.Find("camera");

        width = self.transform.TransformPoint(0, 0, 0).x - self.transform.TransformPoint(1, 1, 0).x;
        height = self.transform.TransformPoint(0, 0, 0).y - self.transform.TransformPoint(1, 1, 0).y;

        spawnX = self.transform.position.x + ((width * 1)/2);
        spawnY = self.transform.position.y;
        spawnZ = self.transform.position.z;

        self.transform.position = new Vector3(spawnX, spawnY, spawnZ);
    }

    // Update is called once per frame
    void Update()
    {
        //...
    }
}
