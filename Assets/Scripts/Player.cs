using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{

    [SerializeField] private GameObject _lightning;

    private void Update()
    {
        if (Input.touchCount > 0)
        {
            _lightning.SetActive(true);
            Vector3 touchpos;
            if (Input.touchCount == 1)
            {
                Touch touch = Input.GetTouch(0);
         
                touchpos = Camera.main.ScreenToWorldPoint(touch.position);
                touchpos.z = 0;
                _lightning.transform.position = touchpos;
            }
            else if (Input.touchCount >= 2)
            {
                Touch touch_1 = Input.GetTouch(0);
                Touch touch_2 = Input.GetTouch(1);
                Vector3 touch_pos1 = Camera.main.ScreenToWorldPoint(touch_1.position);
                Vector3 touch_pos2 = Camera.main.ScreenToWorldPoint(touch_2.position);
                touch_pos1.z = 0;
                touch_pos2.z = 0;
                touchpos = (touch_pos2 - touch_pos1) / 2;
                touchpos.z = 0;
                _lightning.transform.position = touch_pos1 + touchpos;
            }
        }
        else
        {
            _lightning.SetActive(false);
        }
    }
}
