using System;
using UnityEngine;

// Bukan MonoBehaviour, tidak bisa ditempel ke GameObject
public class MonsterInstance : IDamageable // Pastikan IDamageable disalin dari Kode_P4
{
    public MonsterData Data { get; private set; }
    public int Level { get; private set; }
    public int CurrentHP { get; private set; }
    public event Action Changed; // Memberi sinyal jika ada perubahan data (untuk UI)

    // Constructor untuk membuat instance baru
    public MonsterInstance(MonsterData data, int level)
    {
        Data = data;
        Level = level;
        CurrentHP = MaxHP; // Saat pertama dibuat, HP penuh
    }

    // Rumus status berdasarkan level
    private float Scale => 1f + (Level - 1) * 0.1f;
    public int MaxHP => Mathf.RoundToInt(Data.BaseHP * Scale) + Level * 2;
    public int Attack => Mathf.RoundToInt(Data.BaseATK * Scale);
    public int ExpToNext => Level * 10;

    public void TakeDamage(int amount)
    {
        CurrentHP = Mathf.Max(0, CurrentHP - amount);
        Changed?.Invoke();
    }
    
    // GainExp dan evolusi akan ditulis secara lengkap di paket kode
}