using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private PlayerConfig config;
    [SerializeField] private Rigidbody2D rb;
    
    private IMoveInput input;
    public Vector2 Velocity { get; private set; } // Variabel baru menyimpan kecepatan aktual
    public Vector2 Facing { get; private set; } = Vector2.down; // Variabel baru menyimpan arah hadap (default bawah)

    public void Construct(IMoveInput moveInput) => input = moveInput;

    void Update()
    {
        if (input == null) return;
        
        Vector2 move = input.Move;
        float speed = input.IsRunning ? config.RunSpeed : config.WalkSpeed;
        Velocity = move * speed;
        
        // Cek jika tombol sedang ditekan, maka simpan arah hadap
        if (move.sqrMagnitude > 0.01f) 
        {
            Facing = ToCardinal(move);
        }
    }

    // Fungsi tambahan untuk membulatkan arah miring menjadi atas, bawah, kiri, atau kanan mutlak
    private static Vector2 ToCardinal(Vector2 v) => 
        Mathf.Abs(v.x) > Mathf.Abs(v.y) 
            ? new Vector2(Mathf.Sign(v.x), 0f) 
            : new Vector2(0f, Mathf.Sign(v.y));

    void FixedUpdate() => rb.linearVelocity = Velocity;
}