using cherrydev;
using UnityEngine;

public class DialogStarter : MonoBehaviour
{
    [SerializeField] private DialogBehaviour dialogBehaviour_Escena1;
    [SerializeField] private DialogNodeGraph dialogGraph_Escena1;
    [SerializeField] private DialogBehaviour dialogBehaviour_Escena2;
    [SerializeField] private DialogNodeGraph dialogGraph_Escena2;

    private void Start()
    {
        dialogBehaviour_Escena1.StartDialog(dialogNodeGraph: dialogGraph_Escena1);
        dialogBehaviour_Escena2.StartDialog(dialogNodeGraph: dialogGraph_Escena2);
    }
}
