using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour {
    public float m_speed = 5f;

    // Update is called once per frame
    void Update()
    {
        var h = Input.GetAxisRaw("Horizontal");
        var v = Input.GetAxisRaw("Vertical");

        if (h != 0 || v != 0)
        {
            var position = transform.position;
            var cameraTransform = Camera.main.transform;
            var addValue = (cameraTransform.forward * v + cameraTransform.right * h).normalized * Time.deltaTime * m_speed;
            addValue.y = 0;
            position += addValue;
            transform.position = position;
        }
    }

}
