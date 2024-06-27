using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float moveSpeed = 5f; // Скорость перемещения персонажа
    
    private void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal"); // Получаем значение горизонтальной оси (A и D или стрелки влево и вправо)

        Vector3 movement = new Vector3(moveHorizontal, 0f); // Создаем вектор движения на основе полученных значений осей
        Vector3 newPosition = transform.position + movement * moveSpeed * Time.deltaTime; // Вычисляем новую позицию персонажа

        transform.position = newPosition; // Применяем новую позицию к персонажу
}}
