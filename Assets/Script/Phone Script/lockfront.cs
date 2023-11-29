using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class lockfront : MonoBehaviour
{
    bool isDragging = false;
    Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void OnMouseDown()
    {
        isDragging = true;
        offset = transform.position - Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }

    void OnMouseUp()
    {
        isDragging = false;
        transform.position = new Vector3(-1.0f, -2.15f, 0.0f);
    }

    void Update()
    {
        if (isDragging)
        {
            Vector3 newPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition) + offset;
            transform.position = new Vector3(Mathf.Clamp(newPosition.x, -1f, 1.1f), transform.position.y, transform.position.z);
        }

        if (transform.position.x >= 1f)
        {
            // x가 1을 넘어가면 MainScene을 로드합니다.
            SceneManager.LoadScene("ScreenScene");
        }
    }
}