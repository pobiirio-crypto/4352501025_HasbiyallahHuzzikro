using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameBootstrap : MonoBehaviour
{
    [SerializeField] private string firstScene = "Scn_World";
    private IMoveInput moveInput;

    private IActionInput actionInput; // Tambahkan ini di atas
    
    void Awake()
    {
        moveInput = new InputSystemMoveInput();
        actionInput = new InputSystemActionInput(); // Tambahkan ini
    }

    IEnumerator Start()
    {
        yield return SceneManager.LoadSceneAsync(firstScene, LoadSceneMode.Additive); 
        SceneManager.SetActiveScene(SceneManager.GetSceneByName(firstScene));
        // Perbarui baris di bawah agar menyertakan actionInput
        FindAnyObjectByType<WorldInstaller>().Install(moveInput, actionInput);
    }
}