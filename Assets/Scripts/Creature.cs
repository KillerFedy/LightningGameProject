using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Creature : MonoBehaviour
{
    [SerializeField] private HealthBar healthBar;

    private float _health;
    private float _speed;
    private const int _destroyTimeInSeconds = 15;
    private const int _countTypes = 3; // Количество типов существ
    private const int _maxSpeedPlusCountTypes = _countTypes + _countTypes * _countTypes;

    private void Start()
    {
        int creatureType = Random.Range(1, _countTypes + 1);
        Destroy(gameObject, _destroyTimeInSeconds);
        _health = creatureType * 100;
        healthBar.SetMaxValue(_health);
        int sizeCreature = creatureType * _countTypes;
        _speed = Mathf.Abs(sizeCreature - _maxSpeedPlusCountTypes);
        transform.localScale = new Vector3(sizeCreature, sizeCreature, sizeCreature);
    }

    private void Update()
    {
        transform.Translate(Vector3.right * _speed * Time.deltaTime);
    }

    public void TakeDamage(float damage)
    {
        _health -= damage;
        healthBar.SetHealth(_health);
        float valueMinimizeSize = damage / 100;
        MinimizeSize(valueMinimizeSize);
        if(_health <= 0)
        {
            if (gameObject.tag == "Enemy")
            {
                GameManager.Instance.AddCoins();
            }
            else
            {
                GameManager.Instance.RemoveCoins();
            }
            Destroy(gameObject);
        }
    }

    private void MinimizeSize(float value)
    {
        transform.localScale -= new Vector3(value,value,value);
    }
}
