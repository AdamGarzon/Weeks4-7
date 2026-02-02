using UnityEngine;

public class Toggle : MonoBehaviour
{
    public void ToggleBird()
    {
        Debug.Log("Toggle the bird please!");
        //gameObject.SetActive(false); //SetActive sets the value
        //gameObject.activeInHierarchy //this tells us if the box is ticked

        //if bird is active, call SetActive and pass false.
        //if(gameObject.activeInHierarchy == true)
        //{
        //    gameObject.SetActive(false);
        //}
        //else if(gameObject.activeInHierarchy == false)
        //{
        //gameObject.SetActive(true);
        //}
        //(otherwise) if the bird is not active, call SetActive and pass true

        gameObject.SetActive(!gameObject.activeInHierarchy);
    }

}
