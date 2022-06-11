using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeController : MonoBehaviour
{

    public float speed = 1.5f;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector2(-speed * Time.deltaTime, 0f));
        DestroyPipes();
    }

    public void DestroyPipes()
    {
        if(transform.position.x <= -4f)
        {
            Destroy(gameObject);
        }
    }
}
