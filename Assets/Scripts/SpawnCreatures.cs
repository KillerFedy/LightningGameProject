using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCreatures : MonoBehaviour
{
    private GameObject[] _creatures;
    // Start is called before the first frame update
    void Start()
    {
        _creatures = new GameObject[2];
        _creatures[0] = GameManager.Instance.EnemyCreature;
        _creatures[1] = GameManager.Instance.FriendCreature;
        StartCoroutine(Wait());
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(Random.Range(4f, 10f));
        GameObject obj = Instantiate(_creatures[Random.Range(0, 2)], transform.position, transform.rotation);
        StartCoroutine(Wait());
    }
}
