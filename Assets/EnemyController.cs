using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float Speed = 1f;
    float speed;

    // Start is called before the first frame update
    void Start()
    {
        speed = Speed;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(speed * Time.deltaTime * Vector2.right);
    }

    private void OnTriggerEnter2D(Collider2D otherObject)
    {
        if (otherObject.name == "LeftWall") speed = Speed;
        else if (otherObject.name == "RightWall") speed = -Speed;
    }
}
