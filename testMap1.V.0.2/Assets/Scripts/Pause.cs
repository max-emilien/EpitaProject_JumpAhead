using UnityEngine;
using System.Collections;

public class Pause : MonoBehaviour
{
    public GUISkin skin;
    public Color buttonOutlineAndTextColor = Color.white;
    public Texture[] creditIcons;
    public string[] credits;
    public string loadMainMenu;

    private float savedTimeScale;
    private Page currentPage;
    private int toolbarInt = 0;
    private string[] toolbarStrings = { "Audio", "Graphisme" };

    enum Page
    {
        None, Main, Options
    }

    void LateUpdate()
    {
        if (Input.GetKeyDown("escape") || Input.GetKeyDown("p"))
        {
            switch (currentPage)
            {
                case Page.None:
                    PauseGame();
                    break;

                case Page.Main:
                    UnPauseGame();
                    break;

                default:
                    currentPage = Page.Main;
                    break;
            }
        }
    }

    void OnGUI()
    {
        if (skin != null)
        {
            GUI.skin = skin;
        }
        if (IsGamePaused())
        {
            GUI.color = buttonOutlineAndTextColor;
            //Cursor.visible = true;
            switch (currentPage)
            {
                case Page.Main: PauseMenu();
                    break;

                case Page.Options: ShowToolbar();
                    break;
            }
        }
        else
        {
            //Cursor.visible = false;
        }
    }


    void ShowToolbar()
    {
        GUI.Box(new Rect(0, 0, Screen.width, Screen.height), "");
        GUI.Box(new Rect(0, 0, Screen.width, Screen.height), "");
        GUI.Box(new Rect(0, 0, Screen.width, Screen.height), "");
        GUI.Box(new Rect(0, 0, Screen.width, Screen.height), "");
        GUI.Box(new Rect(0, 0, Screen.width, Screen.height), "");
        GUI.Box(new Rect(0, 0, Screen.width, Screen.height), "");
        GUI.Box(new Rect(0, 0, Screen.width, Screen.height), "");
        GUI.Box(new Rect(0, 0, Screen.width, Screen.height), "");
        GUI.Box(new Rect(0, 0, Screen.width, Screen.height), "");
        GUI.Box(new Rect(0, 0, Screen.width, Screen.height), "");

        BeginPage(400, 200);

        toolbarInt = GUILayout.Toolbar(toolbarInt, toolbarStrings);

        switch (toolbarInt)
        {
            case 0:
                VolumeControl();
                break;

            case 1:
                Qualities();
                QualityControl();
                break;
        }

        if (GUILayout.Button("Retour"))
        {
            currentPage = Page.Main;
        }

        EndPage();
    }


    void Qualities()
    {
        switch (QualitySettings.GetQualityLevel())
        {
            case 0:
                GUILayout.Label("Plus rapide");
                break;

            case 1:
                GUILayout.Label("Rapide");
                break;

            case 2:
                GUILayout.Label("Simple");
                break;

            case 3:
                GUILayout.Label("Bon");
                break;

            case 4:
                GUILayout.Label("Magnifique");
                break;

            case 5:
                GUILayout.Label("Fantastique");
                break;
        }
    }

    void QualityControl()
    {
        GUILayout.BeginHorizontal();

        if (GUILayout.Button("Diminuer"))
        {
            QualitySettings.DecreaseLevel();
        }

        if (GUILayout.Button("Augmenter"))
        {
            QualitySettings.IncreaseLevel();
        }

        GUILayout.EndHorizontal();
    }

    void VolumeControl()
    {
        GUILayout.Label("Utilisez le curseur pour ajuster le volume.");
        AudioListener.volume = GUILayout.HorizontalSlider(AudioListener.volume, 0.0f, 1.0f);
    }


    void BeginPage(int width, int height)
    {
        GUILayout.BeginArea(new Rect((Screen.width - width) / 2, (Screen.height - height) / 2, width, height));
    }


    void EndPage()
    {
        GUILayout.EndArea();
    }

    void PauseMenu()
    {
        GUI.Box(new Rect(0, 0, Screen.width, Screen.height), "");
        GUI.Box(new Rect(0, 0, Screen.width, Screen.height), "");
        GUI.Box(new Rect(0, 0, Screen.width, Screen.height), "");
        GUI.Box(new Rect(0, 0, Screen.width, Screen.height), "");
        GUI.Box(new Rect(0, 0, Screen.width, Screen.height), "");
        GUI.Box(new Rect(0, 0, Screen.width, Screen.height), "");
        GUI.Box(new Rect(0, 0, Screen.width, Screen.height), "");
        GUI.Box(new Rect(0, 0, Screen.width, Screen.height), "");
        GUI.Box(new Rect(0, 0, Screen.width, Screen.height), "");
        GUI.Box(new Rect(0, 0, Screen.width, Screen.height), "");

        BeginPage(400, 200);

        if (GUILayout.Button("Continuer"))
        {
            UnPauseGame();
        }

        if (GUILayout.Button("Retour au CheckPoint"))
        {
            UnPauseGame();
			this.gameObject.transform.position = new Vector3(0f,-25f,0f);
            //Application.LoadLevel("Map1");
        }

		if (GUILayout.Button("Recommencer")) {
			UnPauseGame();
			Application.LoadLevel("Map1");
		}

        if (GUILayout.Button("Paramètres"))
        {
            currentPage = Page.Options;
        }

        if (GUILayout.Button("Revenir au Menu Principal"))
        {
            UnPauseGame();
            Application.LoadLevel("Menu");
        }

        EndPage();
    }

    void PauseGame()
    {
        savedTimeScale = Time.timeScale;
        Time.timeScale = 0;
        AudioListener.pause = true;
        currentPage = Page.Main;
    }

    void UnPauseGame()
    {
        Time.timeScale = savedTimeScale;
        AudioListener.pause = false;
        currentPage = Page.None;
    }

    bool IsGamePaused()
    {
        return Time.timeScale == 0;
    }

    void OnApplicationPause(bool pause)
    {
        if (IsGamePaused())
        {
            AudioListener.pause = true;
        }
    }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
