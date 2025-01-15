using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseControler : MonoBehaviour
{


    // Update is called once per frame
    void Update()
    {
        Vector2 playerPosition = transform.parent.position;
        Vector2 mousePosition  = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        Vector2 directionToMouse = mousePosition - playerPosition;

        directionToMouse.Normalize();

        Vector2 weaponPosition = playerPosition + directionToMouse * 2.0f;

        transform.position = weaponPosition;
        float angle = Mathf.Atan2(directionToMouse.y, directionToMouse.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle));
    }

}
