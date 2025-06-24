using UnityEngine;

public class MenuController : MonoBehaviour
{
    public GameObject menuCanvas;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        menuCanvas.SetActive(false); // Hide the menu canvas at the start
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            if(!menuCanvas.activeSelf && PauseController.isPaused)
            {
                return; // If the menu is not active and the game is paused, do nothing
            }
            menuCanvas.SetActive(!menuCanvas.activeSelf); // Toggle the menu canvas visibility
            PauseController.SetPause(menuCanvas.activeSelf); // Pause or unpause the game based on menu visibility
        }

    }
}
