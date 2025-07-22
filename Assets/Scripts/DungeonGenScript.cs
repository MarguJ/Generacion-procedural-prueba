using UnityEngine;

public class DungeonGenScript : MonoBehaviour
{
    public Room1 room1;
    public Room2 room2;
    public Room3 room3;
    public Room4 room4;
    public Room5 room5;
    public Room6 room6;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        room1 = GetComponent<Room1>();
        room2 = GetComponent<Room2>();
        room3 = GetComponent<Room3>();
        room4 = GetComponent<Room4>();
        room5 = GetComponent<Room5>();
        room6 = GetComponent<Room6>();
        room1.GenerateRoom(room1.room1Data);
        room2.GenerateRoom(room2.room2Data);
        room3.GenerateRoom(room3.room3Data);
        room4.GenerateRoom(room4.room4Data);
        room5.GenerateRoom(room5.room5Data);
        room6.GenerateRoom(room6.room6Data);

        Debug.Log("Room1 position: " + room1.transform.position);
        Debug.Log("Room2 position: " + room2.transform.position);
        Debug.Log("Room3 position: " + room3.transform.position);
        Debug.Log("Room4 position: " + room4.transform.position);
        Debug.Log("Room5 position: " + room5.transform.position);
        Debug.Log("Room6 position: " + room6.transform.position);
    }

    // Update is called once per frame
    
}
