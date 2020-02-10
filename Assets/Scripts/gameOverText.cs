using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameOverText : MonoBehaviour
{
    private bool shown;
    GameObject text;
    TextMesh t;

    void Start()
    {
        text = new GameObject();
        t = text.AddComponent<TextMesh>();
        t.text = "Game Over";
        t.fontSize = 160;
        t.color = Color.black;
        t.transform.position = new Vector3(
            gameObject.transform.position.x - 40,
            gameObject.transform.position.y + 5,
            gameObject.transform.position.z + 8);
        t.transform.rotation = Quaternion.Euler(90, 0, 0);
    }

    void Update()
    {
        if (!playerMove.playerAlive && !shown)
        {
            gameObject.transform.position = new Vector3(
                gameObject.transform.position.x,
                gameObject.transform.position.y - 45,
                gameObject.transform.position.z
            );

            Debug.Log("meghalt");
            shown = true;
        }

        t.transform.position = new Vector3(
            gameObject.transform.position.x - 40,
            gameObject.transform.position.y + 5,
            gameObject.transform.position.z + 8);
    }
}