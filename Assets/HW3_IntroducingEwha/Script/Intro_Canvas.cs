using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Intro_Canvas : MonoBehaviour
{
    [SerializeField] GameObject intro_canvas;

    private void Start() {
        intro_canvas.gameObject.SetActive(true);
    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.X)) {
            intro_canvas.gameObject.SetActive(false);
        }
    }
}
