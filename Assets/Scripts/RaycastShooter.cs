using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;
using UnityEngine.UI;

public class RaycastShooter : MonoBehaviour
{
    public ParticleSystem flashEffect;

    public int magazineCapacity = 30;
    private int currentAmmo;

    public TextMeshProUGUI ammoUI;

    public Image reloadingUI;
    public float reloadTime = 2f;
    private float timer = 0;
    private bool isReloading = false;

    public AudioSource audioSoure;
    public AudioClip audioClip;


    // Start is called before the first frame update
    void Start()
    {
        currentAmmo = magazineCapacity;
        ammoUI.text = $"{currentAmmo}/{magazineCapacity}";
        reloadingUI.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0) && currentAmmo > 0 && isReloading == false)
        {
            audioSoure.PlayOneShot(audioClip);
            currentAmmo--;
            flashEffect.Play();
            ammoUI.text = $"{currentAmmo}/{magazineCapacity}";
            ShootRay();
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            isReloading = true;
            reloadingUI.gameObject.SetActive(true);
        }

        if(isReloading == true)
        {
            Reloading();
        }
    }

    void ShootRay()
    {
        Ray ray = new Ray(transform.position, transform.forward);
        RaycastHit hit;

        if(Physics.Raycast(ray, out hit))
        {
            Destroy(hit.collider.gameObject);
        }

        
    }

    void Reloading()
    {
        timer += Time.deltaTime;
        reloadingUI.fillAmount = timer / reloadTime;

        if(timer >= reloadTime)
        {
            timer = 0;
            isReloading = false;
            currentAmmo = magazineCapacity;
            ammoUI.text = $"{currentAmmo}/{magazineCapacity}";
            reloadingUI.gameObject.SetActive(false);
        }
    }
}
