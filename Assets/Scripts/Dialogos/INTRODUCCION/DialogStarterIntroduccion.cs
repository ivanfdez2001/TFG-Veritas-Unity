using cherrydev;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DialogStarterIntroduccion : MonoBehaviour
{
    [SerializeField] private DialogBehaviour dialogBehaviour;
    [SerializeField] private DialogNodeGraph dialogGraphIntroduccion;

    private void Start()
    {
        dialogBehaviour.StartDialog(dialogNodeGraph: dialogGraphIntroduccion);
    }

    public void NextScene()
    {
        SceneManager.LoadScene(1);
    }
}
