using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ItemData_", menuName ="Datasheet/Item")]
public class ItemData : ScriptableObject
{
    [SerializeField]
    private string _name = "...";

    [SerializeField]
    private ItemType _typeOfItem = ItemType.None;

    [SerializeField]
    [TextArea(1, 4)]
    private string _description = "...";

    [SerializeField]
    private int _baseMagazineSize = 1;
    [SerializeField]
    private int _basePelletsPerShot = 1;
    [SerializeField]
    private int _baseBulletsPerShot = 1;
    [Tooltip("Number of time the weapon can fire a bullet in a minute")]
    [SerializeField]
    private float _rateOfFire = 1;
    [SerializeField]
    private float _firingCooldown = 1;
    [SerializeField]
    private float _spread = 1;
    [SerializeField]
    private float _reloadSpeed = 1;

    public string Name { get => _name; set => _name = value; }
    public ItemType TypeOfItem { get => _typeOfItem; set => _typeOfItem = value; }
    public string Description { get => _description; set => _description = value; }
    public int BaseMagazineSize { get => _baseMagazineSize; set => _baseMagazineSize = value; }
    public int BasePelletsPerShot { get => _basePelletsPerShot; set => _basePelletsPerShot = value; }
    public int BaseBulletsPerShot { get => _baseBulletsPerShot; set => _baseBulletsPerShot = value; }
    public float RateOfFire { get => _rateOfFire; set => _rateOfFire = value; }
    public float FiringCooldown { get => _firingCooldown; set => _firingCooldown = value; }
    public float Spread { get => _spread; set => _spread = value; }
    public float ReloadSpeed { get => _reloadSpeed; set => _reloadSpeed = value; }
}
