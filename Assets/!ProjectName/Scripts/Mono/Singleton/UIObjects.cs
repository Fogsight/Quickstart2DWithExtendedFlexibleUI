using TMPro;
using UnityEngine;

public class UIObjects : MonoBehaviour {
    public static UIObjects Instance { get; private set; }

    private void Awake() {
        //Singleton code
        if (Instance != null && Instance != this) Debug.LogError("Trying to instantiate a second singleton", gameObject);
        else Instance = this;
    }

    public Canvas UICanvas;
    public TextMeshProUGUI debugText;

    //Menus
    [Header("Menus")]
    public MainMenu mainMenu;

    private void Start() {
        SetupButtonEvents();
    }

    private void SetupButtonEvents() {
        //Main Menu
        mainMenu.playGame.onClick.AddListener(() => {
            mainMenu.gameObject.SetActive(false);
            InputManager.Instance.GameStart();
        });
        mainMenu.quitGame.onClick.AddListener(() => {
            mainMenu.gameObject.SetActive(false);
            InputManager.Instance.Quit();
        });
    }
}