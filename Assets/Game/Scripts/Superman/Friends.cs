using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Friends : MonoBehaviour
{
    [SerializeField] private float destroyDelay; // Задержка перед удалением врага

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("Friends")) // Проверяем, является ли объект, с которым столкнулся герой
        {
            Rigidbody friendsRigidbody = other.GetComponent<Rigidbody>(); // Получаем компонент Rigidbody
        }
    }
}
