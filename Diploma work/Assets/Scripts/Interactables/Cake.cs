using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cake : Interactable
{
    private const float _GAME_FINISH_DUREATION = 3.0f;

    [SerializeField] private Animator _anim;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    protected override void Interact()
    {
        //Destroy(gameObject, 5.0f);
        //gameObject.SetActive(false);    
        StartCoroutine(OnGameFinished());
    }

    private IEnumerator OnGameFinished()
    {
        _anim.SetBool("is_finished", true);
        yield return new WaitForSeconds(_GAME_FINISH_DUREATION);
        Application.Quit();
    }
}
