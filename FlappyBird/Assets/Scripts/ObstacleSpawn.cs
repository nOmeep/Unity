using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawn : MonoBehaviour
{
    public GameObject obstacle;

    private void Start()
    {
        StartCoroutine(Spawner());
    }

    public IEnumerator Spawner()
    {
        while(true)
        {
            yield return new WaitForSeconds(2);
            GameObject _obstacle = Instantiate(obstacle, new Vector3(2, Random.Range(-2f, 2f), 0), Quaternion.identity);
            Destroy(_obstacle, 5);
        }
    }
}
