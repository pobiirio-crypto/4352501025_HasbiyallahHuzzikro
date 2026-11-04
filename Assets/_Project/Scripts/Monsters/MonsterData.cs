using UnityEngine;

// enum Element { Pyro, Aqua, Sprout, Volt } // Pastikan file Element.cs sudah disalin dari paket Kode_P4

[CreateAssetMenu(fileName = "Mon_", menuName = "Pulau Monster/Monster Data")]
public class MonsterData : ScriptableObject
{
    [SerializeField] private string id;
    [SerializeField] private string displayName;
    [SerializeField] private Element element;
    
    // Frames: Index 0=Idle, 1=Idle1, 2=Attack, 3=Hurt
    [SerializeField] private Sprite[] frames;
    
    [SerializeField] private int baseHP, baseATK, baseDEF, baseSPD;
    [SerializeField] private string skillName = "Semburan Api";
    
    [SerializeField] private MonsterData evolvesTo;
    [SerializeField] private int evolveLevel;

    // Property read-only agar variabel di atas aman dan hanya bisa dibaca oleh script lain
    public string Id => id;
    public string DisplayName => displayName;
    public Element Element => element;
    public Sprite[] Frames => frames;
    public int BaseHP => baseHP;
    public int BaseATK => baseATK;
    public int BaseDEF => baseDEF;
    public int BaseSPD => baseSPD;
    public string SkillName => skillName;
    public MonsterData EvolvesTo => evolvesTo;
    public int EvolveLevel => evolveLevel;
}   