using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoPowerUp : MonoBehaviour
{
       [SerializeField] private IntData ammoValue;
   
       private void OnTriggerEnter(Collider other)
       {
           if (other.CompareTag("Player"))
           {
               // Add ammo to the player's weapon
               AddAmmo(other.gameObject);
   
               // Destroy the power-up game object
               Destroy(gameObject);
           }
       }
   
       private void AddAmmo(GameObject player)
       {
           // Retrieve the player's weapon component (e.g., WeaponController script)
           WeaponController weaponController = player.GetComponent<WeaponController>(5);
   
           // Check if the player has a weapon component
           if (weaponController != null)
           {
               // Add the ammo value to the player's current ammo count
               weaponController.AddAmmo(ammoValue.Value);
           }
       }
   }
