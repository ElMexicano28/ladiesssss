using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DialogueController : MonoBehaviour
{
    public static DialogueController Instance { get; private set; } // Singleton instance

    public GameObject dialoguePanel;
    public TMP_Text dialogueText, nameText;
    public Image portaitImage;
    public Transform choiceContainer;
    public GameObject choiceButtonPrefab;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        if (Instance == null) Instance = this;
        else Destroy(gameObject); // Ensure only one instance exists
    }

    // Update is called once per frame
    public void ShowDialogueUI(bool show)
    {
        dialoguePanel.SetActive(show); // Show or hide the dialogue panel
    }

    public void SetNPCInfo(string npcName, Sprite portrait)
    {
        nameText.text = npcName; // Set the NPC's name
        portaitImage.sprite = portrait; // Set the NPC's portrait
    }

    public void SetDialogueText(string text)
    {
        dialogueText.text = text; // Set the dialogue text
    }

    public void ClearChoices()
    {
        foreach (Transform child in choiceContainer) Destroy(child.gameObject); // Remove all existing choice buttons
    }

    public GameObject CreateChoiceButton(string choiceText, UnityEngine.Events.UnityAction onClick)
    {
        GameObject choiceButton = Instantiate(choiceButtonPrefab, choiceContainer); // Create a new choice button
        choiceButton.GetComponentInChildren<TMP_Text>().text = choiceText; // Set the button text
        choiceButton.GetComponent<Button>().onClick.AddListener(onClick); // Add the click event listener
        return choiceButton; // Return the created button
    }
}
