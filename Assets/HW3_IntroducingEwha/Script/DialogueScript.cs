using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using TMPro;

[System.Serializable]
public class Dialogue
{
    [TextArea]
    public string dialogue;
}

public class DialogueScript : MonoBehaviour
{
    [SerializeField] private GameObject UI_canvas;
    [SerializeField] private TMP_Text text;
    public static bool isDialogue = false;
    private int cnt = 0;

    [SerializeField] private Dialogue[] dialogues;

    private void StartDialogue()
    {
        UI_canvas.gameObject.SetActive(true);
        isDialogue = true;
        cnt = 0;
        NextDialogue();
    }

    public void EndDialogue()
    {
        UI_canvas.gameObject.SetActive(false);
        isDialogue = false;
    }

    public void NextDialogue()
    {
        if(cnt < dialogues.Length) {
            text.text = dialogues[cnt].dialogue;
            cnt++;
        } else {
            EndDialogue();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(isDialogue && Input.GetKeyDown(KeyCode.Space)) {
            NextDialogue();
        }
        
        if(isDialogue && Input.GetKeyDown(KeyCode.X)) {
            EndDialogue();
        }

        if(Input.GetKeyDown(KeyCode.B)) {
            SceneManager.LoadScene("IntroducingEwha");
        }
    }

    private void OnTriggerEnter(Collider other) {
        if(other.tag == "Player") {
            StartDialogue();
        }
    }
}
