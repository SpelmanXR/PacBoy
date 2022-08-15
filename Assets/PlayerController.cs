using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float Speed = 1f;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Speed * Time.deltaTime * Vector2.right);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Speed * Time.deltaTime * Vector2.left);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Speed * Time.deltaTime * Vector2.up);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(Speed * Time.deltaTime * Vector2.down);
        }
    }

    private void OnTriggerEnter2D(Collider2D otherObject)
    {
        if (otherObject.gameObject.tag == "cookie")
        {
            Destroy(otherObject.gameObject);
        }
    }

}
