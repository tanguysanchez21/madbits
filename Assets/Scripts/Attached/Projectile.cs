using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float speed = 0f;

    private Rigidbody2D body;
    //doesnt work
    //private Vector2 screenBounds;

    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        body.velocity = new Vector2(speed, 0);

        //doesnt work
        //screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
    }

    // Update is called once per frame
    void Update()
    {
        //doesnt work
        //if(transform.position.x > screenBounds.x * -2) { Destroy(this.gameObject); }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "ennemy")
        {
            //debug only
            //Destroy(other.gameObject);
            other.gameObject.GetComponent<Animator>().SetBool("DamagedAnimation", true);
            Destroy(this.gameObject);
        }
    }
}
