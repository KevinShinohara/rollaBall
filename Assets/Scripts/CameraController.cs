using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class CameraController : MonoBehaviour
{

    public GameObject player;
    private Vector3 offset;
    private float mouseX, mouseY;
    private float sensebility = -1f;
    private Vector3 rotate;
    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - player.transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }

    void Update()
    {
        mouseX = Input.GetAxis("Mouse X");
        mouseY = Input.GetAxis("Mouse Y") ;
        rotate = new Vector3(mouseY, mouseX * sensebility, 0);
        transform.eulerAngles = transform.eulerAngles - rotate;
    }
}
