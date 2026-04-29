using UnityEngine;

public class KnifeBehaviour : ProjectileWeaponBehaviour
{
    KnifeController kc;
    protected override void Start()
    {
        base.Start();
        kc = FindFirstObjectByType<KnifeController>();
    }

    void Update()
    {
        transform.position += direction * kc.speed * Time.deltaTime;
    }
}
