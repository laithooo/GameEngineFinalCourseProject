using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using DialogueDLL;

public class UIDialogue : MonoBehaviour
{
    public TMP_Text dialogueText;
    private Dialogue dialogue;

    void Start() // Start is called before the first frame update
    {
        dialogue = new Dialogue();
        dialogueText.text = dialogue.GetDialogue("Player");
    }

    public void GoblinSpeak()
    {
        dialogueText.text = dialogue.GetDialogue("Goblin");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
