using cherrydev;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DialogStarterLevel6Escena6 : MonoBehaviour
{
    [SerializeField] private DialogBehaviour dialogBehaviour;
    [SerializeField] private DialogNodeGraph dialogGraphLevel6Escena6;

    private void Start()
    {
        dialogBehaviour.StartDialog(dialogNodeGraph: dialogGraphLevel6Escena6);
    }

    public void NextScene()
    {
        SceneManager.LoadScene(2);
    }
}
