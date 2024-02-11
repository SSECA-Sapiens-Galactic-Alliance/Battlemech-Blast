using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MachineGun : Fire, IFireable
{

    [SerializeField] private float m_Damage;
    [SerializeField] private float m_Accuracy;
    [SerializeField] private float m_Speed;
    [SerializeField] private float m_ReloadTime; 
    [SerializeField] private float m_FireRate;
    [SerializeField] private int m_MaxCapacity;
    [SerializeField] private int m_Capacity;
    [SerializeField] private bool m_isFiring;
    private int m_CurrentAmmo;
     

    #region Interface_Variables

    public float Damage => m_Damage;
    public float Accuracy => m_Accuracy;
    public float Speed => m_Speed;
    public float FireRate => m_FireRate;
    public float ReloadTime => m_ReloadTime; 
    public bool IsFiring => m_isFiring;
    public int MaxCapacity => m_MaxCapacity;
    public int Capacity => m_Capacity;
    public int CurrentAmmo { get => m_CurrentAmmo; }


    #endregion


    private void Start()
    {
        client = this;
        m_isFiring = true;
        Trigger();
    }

    private void Update()
    {
        
    }


    public override void Trigger()
    {
        if (client.IsFiring)
        {
            Debug.Log("Is firing a Machine gun");
        }
    }

}
