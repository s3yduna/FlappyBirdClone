using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{

    public Bird BirdScript;
    public GameObject Pipes;
    [SerializeField]
    float height;
    [SerializeField]
    float time;

    private void Start()
    {
        StartCoroutine(SpawnObject(time));
    }

    public IEnumerator SpawnObject (float time)
    {
        while (!BirdScript.isDead)
        { 
            Instantiate(Pipes, new Vector3(3, Random.Range(-height, height), 0), Quaternion.identity);

            yield return new WaitForSeconds(time);
        }
    }
}
