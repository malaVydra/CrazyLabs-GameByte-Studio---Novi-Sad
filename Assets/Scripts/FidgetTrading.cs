using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FidgetTrading : MonoBehaviour
{
    public GameObject _tradeOffer, _tradeOffer2, _fidget1, _fidget2, _scamTxt;

    private void OnTriggerEnter(Collider collision)
    {
        if(collision.tag == "yestrade")
        {
            Destroy(collision);
            if (_tradeOffer.tag == "scam")
            {

                Destroy(_fidget2);

                _scamTxt.SetActive(true);
                Destroy(collision.gameObject);
                Scam();
            }
            else if(_tradeOffer.tag == "goodtrade")
            {

                Destroy(_fidget1);
                Destroy(collision.gameObject);
                GoodTrade();
            }
        }
        else if(collision.tag == "notrade")
        {
            if(_tradeOffer.tag == "scam")
            {

                Destroy(_fidget2);
                Destroy(collision.gameObject);
                GoodTrade();
            }
            else if(_tradeOffer.tag == "goodtrade")
            {
                Destroy(_fidget1);

                Invoke("ChangeTrade", 2f);
                Destroy(collision.gameObject);
                Scam();
            }
        }
    }

    private void Scam()
    {
        //text scam
        gameObject.GetComponent<GloblesAdding>()._globles -= 4;
        switch (gameObject.GetComponent<GloblesAdding>()._globles)
        {
            case -4:
                Destroy(gameObject.GetComponent<GloblesAdding>()._first);
                break;
            case -3:
                Destroy(gameObject.GetComponent<GloblesAdding>()._first);
                Destroy(gameObject.GetComponent<GloblesAdding>()._new);
                break;
            case -2:
                Destroy(gameObject.GetComponent<GloblesAdding>()._first);
                Destroy(gameObject.GetComponent<GloblesAdding>()._new);
                Destroy(gameObject.GetComponent<GloblesAdding>()._new1);
                break;
            case -1:
                Destroy(gameObject.GetComponent<GloblesAdding>()._first);
                Destroy(gameObject.GetComponent<GloblesAdding>()._new);
                Destroy(gameObject.GetComponent<GloblesAdding>()._new1);
                Destroy(gameObject.GetComponent<GloblesAdding>()._new2);
                break;
            case 0:
                Destroy(gameObject.GetComponent<GloblesAdding>()._new);
                Destroy(gameObject.GetComponent<GloblesAdding>()._new1);
                Destroy(gameObject.GetComponent<GloblesAdding>()._new2);
                Destroy(gameObject.GetComponent<GloblesAdding>()._new3);
                gameObject.GetComponent<GloblesAdding>()._first.transform.position = new Vector3(0, 0, 0);
                gameObject.GetComponent<GloblesAdding>()._transform.localScale = new Vector3(0, 0, 0);
                gameObject.GetComponent<GloblesAdding>()._controllerCollider.radius = 0.26f;

                break;
            case 1:
                Destroy(gameObject.GetComponent<GloblesAdding>()._new1);
                Destroy(gameObject.GetComponent<GloblesAdding>()._new2);
                Destroy(gameObject.GetComponent<GloblesAdding>()._new3);
                Destroy(gameObject.GetComponent<GloblesAdding>()._new4);
              
                gameObject.GetComponent<GloblesAdding>()._controllerCollider.radius = 0.3f;
                break;
            case 2:
                Destroy(gameObject.GetComponent<GloblesAdding>()._new2);
                Destroy(gameObject.GetComponent<GloblesAdding>()._new3);
                Destroy(gameObject.GetComponent<GloblesAdding>()._new4);
                Destroy(gameObject.GetComponent<GloblesAdding>()._new5);
 
                gameObject.GetComponent<GloblesAdding>()._controllerCollider.radius = 0.32f;
                break;
            case 3:
                Destroy(gameObject.GetComponent<GloblesAdding>()._new3);
                Destroy(gameObject.GetComponent<GloblesAdding>()._new4);
                Destroy(gameObject.GetComponent<GloblesAdding>()._new5);
                Destroy(gameObject.GetComponent<GloblesAdding>()._new6);
                gameObject.GetComponent<GloblesAdding>()._transform.localScale = new Vector3(1.1f, 1.1f, 1.1f);
      
                gameObject.GetComponent<GloblesAdding>()._controllerCollider.radius = 0.32f;
                break;
            case 4:
                Destroy(gameObject.GetComponent<GloblesAdding>()._new4);
                Destroy(gameObject.GetComponent<GloblesAdding>()._new5);
                Destroy(gameObject.GetComponent<GloblesAdding>()._new6);
                Destroy(gameObject.GetComponent<GloblesAdding>()._new7);
         
                gameObject.GetComponent<GloblesAdding>()._controllerCollider.radius = 0.33f;
                break;
            case 5:
                Destroy(gameObject.GetComponent<GloblesAdding>()._new5);
                Destroy(gameObject.GetComponent<GloblesAdding>()._new6);
                Destroy(gameObject.GetComponent<GloblesAdding>()._new7);
                Destroy(gameObject.GetComponent<GloblesAdding>()._new8);
            
                gameObject.GetComponent<GloblesAdding>()._controllerCollider.radius = 0.34f;
                break;
            case 6:
                Destroy(gameObject.GetComponent<GloblesAdding>()._new6);
                Destroy(gameObject.GetComponent<GloblesAdding>()._new7);
                Destroy(gameObject.GetComponent<GloblesAdding>()._new8);
                gameObject.GetComponent<GloblesAdding>()._transform.localScale = new Vector3(1.2f, 1.2f, 1.2f);
                gameObject.GetComponent<GloblesAdding>()._controllerCollider.radius = 0.37f;
           
                break;
            case 7:
                Destroy(gameObject.GetComponent<GloblesAdding>()._new7);
                Destroy(gameObject.GetComponent<GloblesAdding>()._new8);
                gameObject.GetComponent<GloblesAdding>()._transform.localScale = new Vector3(1.3f, 1.3f, 1.3f);
                gameObject.GetComponent<GloblesAdding>()._controllerCollider.radius = 0.38f;
                
                break;
            case 8:
                Destroy(gameObject.GetComponent<GloblesAdding>()._new8);
                gameObject.GetComponent<GloblesAdding>()._transform.localScale = new Vector3(1.35f, 1.35f, 1.35f);
                gameObject.GetComponent<GloblesAdding>()._controllerCollider.radius = 0.4f;
                
                break;
        }
    }

    private void GoodTrade()
    {
        //text Great/amazing/good
        gameObject.GetComponent<GloblesAdding>()._globles += 1;
        switch (gameObject.GetComponent<GloblesAdding>()._globles)
        {
            case 1:
                gameObject.GetComponent<GloblesAdding>()._first.GetComponent<Transform>().localPosition = new Vector3(-0.125f, 0f, 0f);
                gameObject.GetComponent<GloblesAdding>()._new = Instantiate(gameObject.GetComponent<GloblesAdding>()._loptica, gameObject.GetComponent<GloblesAdding>()._transform);
                gameObject.GetComponent<GloblesAdding>()._new.GetComponent<Transform>().localPosition = new Vector3(0.125f, 0f, 0f);
                gameObject.GetComponent<GloblesAdding>()._new.GetComponent<MeshRenderer>().material.color =
                    Random.ColorHSV();
                gameObject.GetComponent<GloblesAdding>()._controllerCollider.radius = 0.3f;
                break;
            case 2:
                gameObject.GetComponent<GloblesAdding>()._first.GetComponent<Transform>().localPosition = new Vector3(0f, 0f, 0f);
                gameObject.GetComponent<GloblesAdding>()._new1 = Instantiate(gameObject.GetComponent<GloblesAdding>()._loptica, gameObject.GetComponent<GloblesAdding>()._transform);
                gameObject.GetComponent<GloblesAdding>()._new.GetComponent<Transform>().localPosition = new Vector3(0.25f, 0f, 0f);
                gameObject.GetComponent<GloblesAdding>()._new1.GetComponent<Transform>().localPosition = new Vector3(-0.25f, 0f, 0f);
                gameObject.GetComponent<GloblesAdding>()._new1.GetComponent<MeshRenderer>().material.color =
                    Random.ColorHSV();
                gameObject.GetComponent<GloblesAdding>()._controllerCollider.radius = 0.32f;
                break;
            case 3:
                gameObject.GetComponent<GloblesAdding>()._first.GetComponent<Transform>().localPosition = new Vector3(0f, -0.125f, 0f);
                gameObject.GetComponent<GloblesAdding>()._new2 = Instantiate(gameObject.GetComponent<GloblesAdding>()._loptica, gameObject.GetComponent<GloblesAdding>()._transform);
                gameObject.GetComponent<GloblesAdding>()._new.GetComponent<Transform>().localPosition = new Vector3(-0.175f, 0.1f, 0f);
                gameObject.GetComponent<GloblesAdding>()._new1.GetComponent<Transform>().localPosition = new Vector3(0.1f, 0.1f, 0f);
                gameObject.GetComponent<GloblesAdding>()._new2.GetComponent<Transform>().localPosition = new Vector3(0f, 0f, 0.15f);
                gameObject.GetComponent<GloblesAdding>()._new2.GetComponent<MeshRenderer>().material.color =
                    Random.ColorHSV();
                gameObject.GetComponent<GloblesAdding>()._transform.localScale = new Vector3(1.1f, 1.1f, 1.1f);
                gameObject.GetComponent<GloblesAdding>()._controllerCollider.radius = 0.32f;
                break;
            case 4:
                gameObject.GetComponent<GloblesAdding>()._new3 = Instantiate(gameObject.GetComponent<GloblesAdding>()._loptica, gameObject.GetComponent<GloblesAdding>()._transform);
                gameObject.GetComponent<GloblesAdding>()._new3.GetComponent<Transform>().localPosition = new Vector3(0f, 0f, -0.15f);
                gameObject.GetComponent<GloblesAdding>()._new3.GetComponent<MeshRenderer>().material.color =
                    Random.ColorHSV();
                gameObject.GetComponent<GloblesAdding>()._controllerCollider.radius = 0.33f;
                break;
            case 5:
                gameObject.GetComponent<GloblesAdding>()._new4 = Instantiate(gameObject.GetComponent<GloblesAdding>()._loptica, gameObject.GetComponent<GloblesAdding>()._transform);
                gameObject.GetComponent<GloblesAdding>()._new4.GetComponent<Transform>().localPosition = new Vector3(-0.188f, -0.122f, 0f);
                gameObject.GetComponent<GloblesAdding>()._new4.GetComponent<MeshRenderer>().material.color =
                    Random.ColorHSV();
                gameObject.GetComponent<GloblesAdding>()._controllerCollider.radius = 0.34f;
                break;
            case 6:
                gameObject.GetComponent<GloblesAdding>()._new5 = Instantiate(gameObject.GetComponent<GloblesAdding>()._loptica, gameObject.GetComponent<GloblesAdding>()._transform);
                gameObject.GetComponent<GloblesAdding>()._new5.GetComponent<Transform>().localPosition = new Vector3(0.18f, 0f, -0.06f);
                gameObject.GetComponent<GloblesAdding>()._new5.GetComponent<MeshRenderer>().material.color =
                    Random.ColorHSV();
                gameObject.GetComponent<GloblesAdding>()._transform.localScale = new Vector3(1.2f, 1.2f, 1.2f);
                gameObject.GetComponent<GloblesAdding>()._controllerCollider.radius = 0.37f;
                break;
            case 7:
                gameObject.GetComponent<GloblesAdding>()._new6 = Instantiate(gameObject.GetComponent<GloblesAdding>()._loptica, gameObject.GetComponent<GloblesAdding>()._transform);
                gameObject.GetComponent<GloblesAdding>()._new6.GetComponent<Transform>().localPosition = new Vector3(0.182f, -0.085f, 0.1f);
                gameObject.GetComponent<GloblesAdding>()._new6.GetComponent<MeshRenderer>().material.color =
                    Random.ColorHSV();
                gameObject.GetComponent<GloblesAdding>()._transform.localScale = new Vector3(1.3f, 1.3f, 1.3f);
                gameObject.GetComponent<GloblesAdding>()._controllerCollider.radius = 0.38f;
                break;
            case 8:
                gameObject.GetComponent<GloblesAdding>()._new7 = Instantiate(gameObject.GetComponent<GloblesAdding>()._loptica, gameObject.GetComponent<GloblesAdding>()._transform);
                gameObject.GetComponent<GloblesAdding>()._new7.GetComponent<Transform>().localPosition = new Vector3(-0.195f, -0.068f, -0.144f);
                gameObject.GetComponent<GloblesAdding>()._new7.GetComponent<MeshRenderer>().material.color =
                    Random.ColorHSV();
                gameObject.GetComponent<GloblesAdding>()._transform.localScale = new Vector3(1.35f, 1.35f, 1.35f);
                gameObject.GetComponent<GloblesAdding>()._controllerCollider.radius = 0.40f;
                break;
            case 9:
                gameObject.GetComponent<GloblesAdding>()._new8 = Instantiate(gameObject.GetComponent<GloblesAdding>()._loptica, gameObject.GetComponent<GloblesAdding>()._transform);
                gameObject.GetComponent<GloblesAdding>()._new8.GetComponent<Transform>().localPosition = new Vector3(-0.221f, 0.025f, 0.127f);
                gameObject.GetComponent<GloblesAdding>()._new8.GetComponent<MeshRenderer>().material.color =
                    Random.ColorHSV();
                gameObject.GetComponent<GloblesAdding>()._transform.localScale = new Vector3(1.5f, 1.5f, 1.5f);
                gameObject.GetComponent<GloblesAdding>()._controllerCollider.radius = 0.43f;
                break;

        }

        Invoke("ChangeTrade", 2f);

    }

    private void TradeFail()
    {
        //text fail

        _tradeOffer = _tradeOffer2;
    }

    private void ChangeTrade()
    {


        _tradeOffer = _tradeOffer2;
    }
}
