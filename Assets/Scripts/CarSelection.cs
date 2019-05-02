using UnityEngine;

public class CarSelection : MonoBehaviour
{
    // We create an empty list of gameObjects
    private GameObject[] carList;
    private int currentCar = 0;

    // Start is called before the first frame update
    void Start()
    {
        // Count the child gameObjects from the cars transform
        carList = new GameObject[transform.childCount];

        // Loop through the child items and fill the list in the current slots
        for (int i = 0; i < transform.childCount; i++)
            carList[i] = transform.GetChild(i).gameObject;

        // Deactivate all the gameObjects in the list
        foreach (GameObject gameObj in carList)
            gameObj.SetActive(false);

        // Set the initial GO to be active
        if (carList[0])
            carList[0].SetActive(true);
    }

    public void toggleCars(string direction)
    {
        carList[currentCar].SetActive(false);
        if (direction == "Right")
        {
            currentCar++;
            if (currentCar > carList.Length - 1)
                currentCar = 0;
        }
        else if (direction == "Left")
        {
            currentCar--;
            if (currentCar < 0)
                currentCar = carList.Length - 1;
        }

        // Set the current car to be active from the list
        carList[currentCar].SetActive(true);
        GameController.CurrentSelectedCar = carList[currentCar].name;
        GameObject cloudSystem = (GameObject)Instantiate(Resources.Load("CloudParticle"));
        ParticleSystem cloudPuff = cloudSystem.GetComponent<ParticleSystem>();
        cloudPuff.Play();
        cloudPuff.transform.position = new Vector3(0f, -2f, 2f);
        Destroy(cloudSystem, 4f);
    }
}
