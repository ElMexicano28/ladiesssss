using UnityEngine;

[CreateAssetMenu(fileName = "NewNPCDialogue", menuName = "NPC Dialogue")]
public class NPCDialogue : ScriptableObject
{
    public string npcName;
    public Sprite npcPortrait;
    public string[] dialogueLines;
    public bool[] autoProgressLines;
    public bool[] endDialogueLines; // marks where dialogue ends
    public float autoProgressDelay = 1.5f;
    public float typingSpeed = 0.05f;
    public AudioClip voiceSound;
    public float voicePitch = 1f;
    
    public DialogueChoice[] choices; // Array of dialogue choices
}

[System.Serializable]
public class DialogueChoice
{
    public int dialogueIndex; //Dialogue liine where choices appear
    public string[] choices; // Player response options
    public int[] nextDialogueIndexes; //Where choice lead
}