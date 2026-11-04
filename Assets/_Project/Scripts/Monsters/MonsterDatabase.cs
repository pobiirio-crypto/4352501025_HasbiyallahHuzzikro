using UnityEngine;
using System.Collections.Generic;

[CreateAssetMenu(fileName = "MonsterDatabase", menuName = "Pulau Monster/Monster Database")]
public class MonsterDatabase : ScriptableObject
{
    [SerializeField] private List<MonsterData> monsters;
    public List<MonsterData> Monsters => monsters;
}