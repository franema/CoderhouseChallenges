using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Events;

public class SatuesController : MonoBehaviour
{
    [SerializeField] private Transform[] StatuesPositions;
    [SerializeField] private List<Transform> PlatesPositions;
    private float speed = 0.5f;
    private Dictionary<Transform, bool> statuesDirection = new Dictionary<Transform, bool>();
    private Dictionary<Transform, bool> statuesIndividualMove = new Dictionary<Transform, bool>();
    private Vector3 direction = new Vector3(0f, 0f, 2f);
    private float forwardModifier = 2.65f;
    private float BackwardModifier = 6.1f;
    private bool[] orderToOpen = { true, false, false, true, true, false, true, false };
    private bool[] currentOrder;
    public UnityEvent onStatuesOrderCorrect;



    private void Start()
    {
        CreateStatuesMoveDictionary();
        CreateIndividualMoveDictionary();
    }

    private void Update()
    {
        if (GameManager.instance.statuesAreMoving)
        {
            MoveStatues();
        }
        CheckStatuesOrder();
    }

    private void MoveStatues()
    {
        for (int i = 0; i < StatuesPositions.Length; i++)
        {
            if (i % 2 == GameManager.instance.evenOrOdd && statuesDirection[StatuesPositions[i]] && statuesIndividualMove[PlatesPositions[i]])
            {
                MoveForward(i);
            }

            if (i % 2 == GameManager.instance.evenOrOdd && !statuesDirection[StatuesPositions[i]] && statuesIndividualMove[PlatesPositions[i]])
            {
                MoveBackwards(i);
            }
        }
    }

    private void MoveForward(int index)
    {
        StatuesPositions[index].position += direction * speed * Time.deltaTime;
        if (StatuesPositions[index].position.z >= PlatesPositions[index].position.z - forwardModifier)
        {
            statuesDirection[StatuesPositions[index]] = !statuesDirection[StatuesPositions[index]];
            GameManager.instance.statuesAreMoving = false;
        }
    }

    private void MoveBackwards(int index)
    {
        StatuesPositions[index].position -= direction * speed * Time.deltaTime;
        if (StatuesPositions[index].position.z <= PlatesPositions[index].position.z - BackwardModifier)
        {
            statuesDirection[StatuesPositions[index]] = !statuesDirection[StatuesPositions[index]];
            GameManager.instance.statuesAreMoving = false;
        }
    }
    private void CreateStatuesMoveDictionary()
    {
        foreach (Transform statue in StatuesPositions)
        {
            statuesDirection.Add(statue, true);
        }
    }

    private void CreateIndividualMoveDictionary()
    {
        foreach (Transform plates in PlatesPositions)
        {
            statuesIndividualMove.Add(plates, true);
        }
    }

    public void ChangeStatueState(Transform statue, bool state)
    {
        statuesIndividualMove[statue] = state;
    }

    public void CheckStatuesOrder()
    {
        currentOrder = new bool[StatuesPositions.Length];
        for (int i = StatuesPositions.Length - 1; i >= 0; i--)
        {
            currentOrder[i] = statuesDirection[StatuesPositions[i]];
            Debug.Log($"{i}: {currentOrder[i]}");
        }
        if (Enumerable.SequenceEqual(currentOrder, orderToOpen))
        {
            onStatuesOrderCorrect.Invoke();
        }
    }

}
