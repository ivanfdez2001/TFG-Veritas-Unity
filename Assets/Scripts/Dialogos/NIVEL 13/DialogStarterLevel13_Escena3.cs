using cherrydev;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DialogStarterLevel13Escena3 : MonoBehaviour
{
    [SerializeField] private DialogBehaviour dialogBehaviour;
    [SerializeField] private DialogNodeGraph dialogGraphLevel13Escena3;

    private void Start()
    {
        dialogBehaviour.StartDialog(dialogNodeGraph: dialogGraphLevel13Escena3);
    }
}
