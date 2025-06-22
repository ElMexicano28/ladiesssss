using UnityEngine;

public class MenuStart : MonoBehaviour
{
    public Transform box;
    public CanvasGroup background;


    public void OnEnable()
    {
        background.alpha = 0;
        background.LeanAlpha(1, 0.5f);

        box.localPosition = new Vector2(0, -Screen.height);
        box.LeanMoveLocalY(0, 0.5f).setEaseInOutBack().delay = 0.1f;
    }

    public void CloseMenu()
    {
        background.LeanAlpha(0, 0.5f);
        box.LeanMoveLocalY(-Screen.height, 0.5f).setEaseInOutBack().setEaseInExpo();
    }
}
