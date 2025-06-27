using UnityEngine;
using UnityEngine.UI;

public class TabController : MonoBehaviour
{
    
    public Image[] tabImages; // Array of images for each tab
    public GameObject[] pages; // Array of content GameObjects for each tab
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ActivateTab(0); // Activate the first tab by default
    }

    // Update is called once per frame
    public void ActivateTab(int tabNo)
    {
        for(int i =0; i < pages.Length;i++)
        {
            pages[i].SetActive(false); // Deactivate all pages
        }

        pages[tabNo].SetActive(true); // Activate the selected page
    }
}
