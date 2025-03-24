using UnityEngine;
using DialogueEditor;

public class ConversationStarter : MonoBehaviour, IInteractable
{
    [SerializeField] private NPCConversation myConversation;
   public void Interact()
    {
        Debug.Log(Random.Range(0, 100)); 
        ConversationManager.Instance.StartConversation(myConversation);
    }
}
