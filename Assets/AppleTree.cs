using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleTree : MonoBehaviour 
{
    [Header("Set in inspector")]
    // Шаблон для создания яблок
    public GameObject appleTrefab;

    // Скорость движения яблони
    public float speed = 1f;

    // Расстояние, на котором должно измениться направление движения яблони
    public float leftAndRightEdge = 10f;

    // Вероятность случайного изменения направления движения
    public float chanceToChangeDirections = 0.1f;

    // Частота создания экземпляров яблок
    public float secondsBetweenAppleDrops = 1f;

    // Start is called before the first frame update
    void Start()
    {
        // Сбрасывать яблоки раз в секунду
    }

    // Update is called once per frame
    void Update()
    {
        // Простое перемещение
        Vector3 pos = transform.position;
        pos.x += speed * Time.deltaTime;
        transform.position = pos;

        // Изменение направления
    }
}
