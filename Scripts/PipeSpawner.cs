using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    [SerializeField]
    GameObject pipes;

    private void Start()
    {
        InvokeRepeating("SpawnPipes", 1f, 2.5f);
    }

    public void SpawnPipes()
    {
        Instantiate(pipes, new Vector2(5.15f, Random.Range(-1.1f, 3.1f)), Quaternion.identity);
    }

    //IEnumerator SpawnerRoutine()
    //{
    //    if (!BirdController.isDead)
    //    {
    //        yield return new WaitForSeconds(.1f);

    //        Instantiate(pipes, new Vector2(5.15f, Random.Range(-1.1f, 3.1f)), Quaternion.identity);

    //        yield return new WaitForSeconds(4f);
    //    }
    //}

}
