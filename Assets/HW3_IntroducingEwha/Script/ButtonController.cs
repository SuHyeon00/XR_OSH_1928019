using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonController : MonoBehaviour
{
    public void OnClick_LoadEcc()
    {
        SceneManager.LoadScene("ECC");
    }

    public void OnClick_LoadAuditorium()
    {
        SceneManager.LoadScene("Auditorium");
    }
}
