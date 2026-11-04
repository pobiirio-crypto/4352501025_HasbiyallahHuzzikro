using UnityEngine;

public class WorldInstaller : MonoBehaviour
{
    [SerializeField] private PlayerMovement player;
    public void Install(IMoveInput moveInput) => player.Construct(moveInput);

[SerializeField] private PlayerInteractor interactor; // Tambahkan ini

    public void Install (IMoveInput moveInput, IActionInput actionInput)
    {
        player.Construct(moveInput);
        interactor.Construct(actionInput); // Tambahkan ini
    }
}