using cherrydev;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DialogStarterLevel12Escena6 : MonoBehaviour
{
    [SerializeField] private DialogBehaviour dialogBehaviour;
    [SerializeField] private DialogNodeGraph dialogGraphLevel12Escena6;

    private void Start()
    {
        dialogBehaviour.StartDialog(dialogNodeGraph: dialogGraphLevel12Escena6);
    }

    public void NextScene()
    {
        SceneManager.LoadScene(2);
    }
}
