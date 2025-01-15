using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "EnemyData_", menuName = "Datasheet/Enemy")]
public class EnemyData : ScriptableObject
{
    #region Enemy Identity
    [SerializeField]
    private string _name = "...";

    [SerializeField]
    private EnemyType _typeOfEnemy = EnemyType.None;

    [SerializeField]
    [Tooltip("Put the finished animator object here")]
    private Animator _animator;

    [SerializeField]
    [Tooltip("Put the script that handle the transition of the enemy if in 2D")]
    private AnimatorController _animatorController;

    [SerializeField]
    [Tooltip("Idle sprite for the enemy if in 2D")]
    private Sprite _sprite;
    #endregion

    #region Enemy Stats
    [SerializeField]
    private float _speed = 1.0f;

    [SerializeField]
    [Tooltip("From 0 to 500, no negative value")]
    [Range(0, 500)]
    private int _life = 0;

    [SerializeField]
    [Tooltip("Right now the idea is normal enemy do 1 damage, Boss/Elite do 2")]
    private int _damage = 1;

    [SerializeField]
    [Tooltip("% chance for an item to drop")]
    [Range(0, 100)]
    private float _dropChance = 0;

    [SerializeField]
    [Tooltip("0 means the enemy deals damage by contact, otherwise it's the distance the player needs to be for the enemy to start shooting")]
    private float _range = 0;

    [SerializeField]
    [Tooltip("0 means the enemy will flee the player, 1 attacks him in range, 2 activaly pursue him")]
    [Range(0, 2)]
    private int _aggresivness = 1;
    //TODO Item Pool and all that shit
    #endregion

    #region Properties
    public string Name { get => _name; set => _name = value; }
    public EnemyType TypeOfEnemy { get => _typeOfEnemy; set => _typeOfEnemy = value; }
    public Animator Animator { get => _animator; set => _animator = value; }
    public AnimatorController AnimatorController { get => _animatorController; set => _animatorController = value; }
    public Sprite Sprite { get => _sprite; set => _sprite = value; }
    public float Speed { get => _speed; set => _speed = value; }
    public int Life { get => _life; set => _life = value; }
    public int Damage { get => _damage; set => _damage = value; }
    public float DropChance { get => _dropChance; set => _dropChance = value; }
    public float Range { get => _range; set => _range = value; }
    public int Aggresivness { get => _aggresivness; set => _aggresivness = value; }
    #endregion
}
