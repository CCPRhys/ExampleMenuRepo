using UnityEngine;

public class ExampleMenu : MonoBehaviour
{
    public GameObject mainMenu;
    [SerializeField]
    GameObject settingsMenu;

    public void OpenSettingsMenu()
    {
        settingsMenu.SetActive(true);
        mainMenu.SetActive(false);
    }

    public void OpenMainMenu()
    {
        mainMenu.SetActive(true);
        settingsMenu.SetActive(false);
    }
}
