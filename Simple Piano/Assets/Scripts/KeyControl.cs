using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyControl : MonoBehaviour
{
    //Low keys

    [SerializeField] GameObject lowC;
    [SerializeField] GameObject lowD;
    [SerializeField] GameObject lowE;
    [SerializeField] GameObject lowF;
    [SerializeField] GameObject lowG;
    [SerializeField] GameObject lowA;
    [SerializeField] GameObject lowB;
    [SerializeField] GameObject lowCs;
    [SerializeField] GameObject lowDs;
    [SerializeField] GameObject lowFs;
    [SerializeField] GameObject lowGs;
    [SerializeField] GameObject lowAs;


    //High Keys

    [SerializeField] GameObject highC;
    [SerializeField] GameObject highD;
    [SerializeField] GameObject highE;
    [SerializeField] GameObject highF;
    [SerializeField] GameObject highG;
    [SerializeField] GameObject highA;
    [SerializeField] GameObject highB;
    [SerializeField] GameObject highCs;
    [SerializeField] GameObject highDs;
    [SerializeField] GameObject highFs;
    [SerializeField] GameObject highGs;
    [SerializeField] GameObject highAs;

    


    /// touch methods
    
    public void LowC()
    {
        lowC.SetActive(false);
        lowC.SetActive(true);
    }
    public void LowD()
    {
        lowD.SetActive(false);
        lowD.SetActive(true);
    }
    
    public void LowE()
    {
        lowE.SetActive(false);
        lowE.SetActive(true);
    }
    public void LowF()
    {
        lowF.SetActive(false);
        lowF.SetActive(true);
    }
    public void LowG()
    {
        lowG.SetActive(false);
        lowG.SetActive(true);
    }
    public void LowA()
    {
        lowA.SetActive(false);
        lowA.SetActive(true);
    }
    public void LowB()
    {
        lowB.SetActive(false);
        lowB.SetActive(true);
    }
    public void LowCs()
    {
        lowCs.SetActive(false);
        lowCs.SetActive(true);
    }
    public void LowDs()
    {
        lowDs.SetActive(false);
        lowDs.SetActive(true);
    }
    public void LowFs()
    {
        lowFs.SetActive(false);
        lowFs.SetActive(true);
    }
    public void LowGs()
    {
        lowGs.SetActive(false);
        lowGs.SetActive(true);
    }
    public void LowAs()
    {
        lowAs.SetActive(false);
        lowAs.SetActive(true);
    }
    public void HighC()
    {
        highC.SetActive(false);
        highC.SetActive(true);
    }
    public void HighD() { 
        highC.SetActive(false);
        highC.SetActive(true);
    }
    public void HighE()
    {
        highE.SetActive(false);
        highE.SetActive(true);
    }
    public void HighF() { 
        highF.SetActive(false);
        highF.SetActive(true);
    }
    public void HighG()
    {
        highG.SetActive(false);
        highG.SetActive(true);
    }
    public void HighA()
    {
        highA.SetActive(false);
        highA.SetActive(true);
    }
    public void HighB()
    {
        highB.SetActive(false);
        highB.SetActive(true);
    }
    public void HighCs()
    {
        highCs.SetActive(false);
        highCs.SetActive(true);
    }
    public void HighDs()
    {
        highDs.SetActive(false);
        highDs.SetActive(true);
    }
    public void HighFs()
    {
        highFs.SetActive(false);
        highFs.SetActive(true);
    }
    public void HighGs()
    {
        highGs.SetActive(false);
        highGs.SetActive(true);
    }
    public void HighAs() { 
        highAs.SetActive(false);
        highAs.SetActive(true); 
    }

    // auto songs

    public void StartSong()
    {
        StartCoroutine(AutoSong());
    }


    IEnumerator AutoSong()
    {
        yield return new WaitForSeconds(0.3f);
        lowC.SetActive(false);
        lowC.SetActive(true);
        yield return new WaitForSeconds(0.3f);
        lowG.SetActive(false);
        lowG.SetActive(true);
        yield return new WaitForSeconds(0.3f);
        highC.SetActive(false);
        highC.SetActive(true);
        yield return new WaitForSeconds(0.3f);
        highG.SetActive(false);
        highG.SetActive(true);
        yield return new WaitForSeconds(0.3f);
        highG.SetActive(false);
        highG.SetActive(true);
        yield return new WaitForSeconds(0.3f);
        highF.SetActive(false);
        highF.SetActive(true);
        yield return new WaitForSeconds(0.3f);
        highE.SetActive(false);
        highE.SetActive(true);
        yield return new WaitForSeconds(0.3f);
        highD.SetActive(false);
        highD.SetActive(true);
        yield return new WaitForSeconds(0.3f);
        lowD.SetActive(false);
        lowD.SetActive(true);
        yield return new WaitForSeconds(0.3f);
        lowG.SetActive(false);
        lowG.SetActive(true);
        yield return new WaitForSeconds(0.3f);
        highC.SetActive(false);
        highC.SetActive(true);
        yield return new WaitForSeconds(0.3f);
        highD.SetActive(false);
        highD.SetActive(true);
        yield return new WaitForSeconds(0.3f);
        highD.SetActive(false);
        highD.SetActive(true);
        yield return new WaitForSeconds(0.3f);
        highE.SetActive(false);
        highE.SetActive(true);
        yield return new WaitForSeconds(0.3f);
        highF.SetActive(false);
        highF.SetActive(true);
        yield return new WaitForSeconds(0.3f);
        highE.SetActive(false);
        highE.SetActive(true);
        yield return new WaitForSeconds(0.3f);
        lowE.SetActive(false);
        lowE.SetActive(true);
        yield return new WaitForSeconds(0.3f);
        lowA.SetActive(false);
        lowA.SetActive(true);
        yield return new WaitForSeconds(0.3f);
        lowB.SetActive(false);
        lowB.SetActive(true);
        yield return new WaitForSeconds(0.3f);
        highC.SetActive(false);
        highC.SetActive(true);
        yield return new WaitForSeconds(0.3f);
        highD.SetActive(false);
        highD.SetActive(true);
        yield return new WaitForSeconds(0.3f);
        highE.SetActive(false);
        highE.SetActive(true);
        yield return new WaitForSeconds(0.3f);
        highF.SetActive(false);
        highF.SetActive(true);
        yield return new WaitForSeconds(0.3f);
        highE.SetActive(false);
        highE.SetActive(true);
        yield return new WaitForSeconds(0.3f);
        highD.SetActive(false);
        highD.SetActive(true);
        yield return new WaitForSeconds(0.3f);
        highC.SetActive(false);
        highC.SetActive(true);
        yield return new WaitForSeconds(0.3f);
        lowB.SetActive(false);
        lowB.SetActive(true);
        yield return new WaitForSeconds(0.3f);
        highC.SetActive(false);
        highC.SetActive(true);
    }
    #if UNITY_EDITOR 
     // keyboard controls
        ///Low Keys Controls
        if (Input.GetKeyDown(KeyCode.Q))
        {
            lowC.SetActive(false);
            lowC.SetActive(true);
        } 
        //end keys
        if (Input.GetKeyDown(KeyCode.W))
        {
            lowD.SetActive(false);
            lowD.SetActive(true);
        }
        //end keys
        if (Input.GetKeyDown(KeyCode.E))
        {
            lowE.SetActive(false);
            lowE.SetActive(true);
        }
        //end keys
        if (Input.GetKeyDown(KeyCode.R))
        {
            lowF.SetActive(false);
            lowF.SetActive(true);
        }
        //end keys
        if (Input.GetKeyDown(KeyCode.T))
        {
            lowG.SetActive(false);
            lowG.SetActive(true);
        }
        //end keys
        if (Input.GetKeyDown(KeyCode.Y))
        {
            lowA.SetActive(false);
            lowA.SetActive(true);
        }
        //end keys
        if (Input.GetKeyDown(KeyCode.U))
        {
            lowB.SetActive(false);
            lowB.SetActive(true);
        }
        //end keys
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            lowCs.SetActive(false);
            lowCs.SetActive(true);
        }
        //end keys
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            lowDs.SetActive(false);
            lowDs.SetActive(true);
        }
        //end keys
        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            lowFs.SetActive(false);
            lowFs.SetActive(true);
       }
        //end keys
        if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            lowGs.SetActive(false);
            lowGs.SetActive(true);
        }
        //end keys
        if (Input.GetKeyDown(KeyCode.Alpha7))
        {
            lowAs.SetActive(false);
            lowAs.SetActive(true);
        }
        //end keys
        // High keys controls
        if (Input.GetKeyDown(KeyCode.D))
        {
            highC.SetActive(false);
            highC.SetActive(true);
        }
        //end keys
        if (Input.GetKeyDown(KeyCode.F))
        {
            highD.SetActive(false);
            highD.SetActive(true);
        }
        //end keys
        if (Input.GetKeyDown(KeyCode.G))
        {
            highE.SetActive(false);
            highE.SetActive(true);
        }
        //end keys
        if (Input.GetKeyDown(KeyCode.H))
        {
            highF.SetActive(false);
            highF.SetActive(true);
        }
        //end keys
        if (Input.GetKeyDown(KeyCode.J))
        {
            highG.SetActive(false);
            highG.SetActive(true);
        }
        //end keys
        if (Input.GetKeyDown(KeyCode.K))
        {
            highA.SetActive(false);
            highA.SetActive(true);
        }
        //end keys
        if (Input.GetKeyDown(KeyCode.L))
        {
            highB.SetActive(false);
            highB.SetActive(true);
        }
        //end keys
        ////////////////////////////////////////////
        if (Input.GetKeyDown(KeyCode.O))
        {
            highCs.SetActive(false);
            highCs.SetActive(true);
        }
        //end keys
        if (Input.GetKeyDown(KeyCode.Equals))
        {
            highDs.SetActive(false);
            highDs.SetActive(true);
        }
        //end keys
        if (Input.GetKeyDown(KeyCode.Minus))
        {
            highFs.SetActive(false);
            highFs.SetActive(true);
        }
        //end keys
        if (Input.GetKeyDown(KeyCode.Alpha0))
        {
            highGs.SetActive(false);
            highGs.SetActive(true);
        }
        //end keys
        if (Input.GetKeyDown(KeyCode.Alpha9))
        {
            highAs.SetActive(false);
            highAs.SetActive(true);
        }
        //end keys
    #endif
}
