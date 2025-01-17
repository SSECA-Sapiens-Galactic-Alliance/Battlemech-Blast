using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Weapon : MonoBehaviour
{

    public string weaponName;
    public abstract void Trigger();

}

public interface IWeapon
{
    public void Execute();
    public void Reload();
    public void IncreaseAmmo(int amount);
}
public interface IExplodeable
{
    public float Radius { get; }
    public float Mass { get; }

    public void Explode();



}

public interface IThrowable
{
    public int CurrentAmmo { get; }
    public float Damage { get; }
    public float DamageInterval { get; }
    public float ElapseDuration { get; }
    public float ShootForce { get; }
    public float TorqueSpeed { get; }
    public float TimeToExecute { get; }
    public float TimeToDie { get; }

}
public interface IFireable
{

    public int CurrentAmmo { get; }
    public float Damage { get; }
    public float Accuracy { get; }
    public float Speed { get; }
    public float FireRate { get; }
    public float ReloadTime { get; }
    public bool IsFiring { get; }
    public int Capacity { get; }
    public int MaxCapacity { get; }


}
