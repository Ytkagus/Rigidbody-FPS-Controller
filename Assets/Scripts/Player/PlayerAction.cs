using UnityEngine;

public class PlayerAction : Gun3
{
    [SerializeField]
    private Gun Gun;

    public void OnShoot()
    {
        Gun.Shoot();
    }
}
