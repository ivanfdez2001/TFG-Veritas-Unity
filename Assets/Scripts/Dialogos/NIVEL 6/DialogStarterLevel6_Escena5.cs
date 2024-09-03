using cherrydev;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DialogStarterLevel6Escena5 : MonoBehaviour
{
    [SerializeField] private DialogBehaviour dialogBehaviour;
    [SerializeField] private DialogNodeGraph dialogGraphLevel6Escena5;

    private void Start()
    {
        dialogBehaviour.StartDialog(dialogNodeGraph: dialogGraphLevel6Escena5);
    }
}
