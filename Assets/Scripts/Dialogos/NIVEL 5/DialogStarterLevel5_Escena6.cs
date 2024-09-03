using cherrydev;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DialogStarterLevel5Escena6 : MonoBehaviour
{
    [SerializeField] private DialogBehaviour dialogBehaviour;
    [SerializeField] private DialogNodeGraph dialogGraphLevel5Escena6;

    private void Start()
    {
        dialogBehaviour.StartDialog(dialogNodeGraph: dialogGraphLevel5Escena6);
    }

    public void NextScene()
    {
        SceneManager.LoadScene(2);
    }
}
