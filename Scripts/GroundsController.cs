using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundsController : MonoBehaviour
{

    public float speed;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector2(-speed * Time.deltaTime, 0f));
        ChangeBackgroundPosition();
    }

    public void ChangeBackgroundPosition()
    {
        if(transform.position.x <= -5.61f)
        {
            transform.position = new Vector2(5.61f, transform.position.y);
        }
    }

}
