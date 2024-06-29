using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class EnemyAndFriends : MonoBehaviour
{
   [SerializeField] private float forceAmount; // Сила, с которой враг будет отталкиваться
   private float _destroyTime=0.3f; // Задержка перед удалением gameOject
   public static event Action EnemyDisappeared, FriendsSave;

   private void EnemyDestroy()
   {
      EnemyDisappeared?.Invoke();
   }
   private void SaveFriend()
   {
   FriendsSave?.Invoke();
   }


   private void OnTriggerEnter(Collider other)
   {
      if (other.gameObject.layer == LayerMask.NameToLayer("Enemy")) // Проверяем, является ли объект, с которым столкнулся герой, врагом по слою
      {
         Rigidbody enemyRigidbody = other.GetComponent<Rigidbody>(); // Получаем компонент Rigidbody врага
         if (enemyRigidbody != null)
         {
            Vector3 direction = (other.transform.position - transform.position).normalized; // Вычисляем направление отталкивания
            enemyRigidbody.AddForce(direction * forceAmount); // Применяем силу для отталкивания врага
            Destroy(other.gameObject, _destroyTime); // Удаляем врага из сцены через задержку
            EnemyDestroy();
         }
      }
        if (other.gameObject.layer == LayerMask.NameToLayer("Friends")) 
        { 
          Rigidbody friendsRigbody = other.GetComponent<Rigidbody>();
          if (friendsRigbody != null)
           {
            Destroy(other.gameObject, _destroyTime);
            SaveFriend();
           } 
         }
   }
}
