using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lightning : MonoBehaviour
{
    private const int _damage = 5;
    private void OnTriggerStay2D(Collider2D collision)
    {
        Creature _creature = collision.gameObject.GetComponent<Creature>();
        if (_creature != null)
        {
            _creature.TakeDamage(_damage);
        }
    }
}
