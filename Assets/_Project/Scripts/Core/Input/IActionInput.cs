using UnityEngine;

public interface IActionInput 
{ 
    bool InteractPressed { get; } 
}

public interface IInteractable 
{ 
    void Interact(PlayerInteractor who); 
}