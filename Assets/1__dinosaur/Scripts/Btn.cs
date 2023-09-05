using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Btn : MonoBehaviour
{
    public bool canAttack =true ;
    public Animator anim;

    public void Attack()
    {
        canAttack = true;
        
        if(canAttack)
        {
            anim.SetTrigger("ToAttack");
            Invoke("Delay", 2f);

        }
    }

    public void  Title()
    {
        SceneManager.LoadScene("___Title___");
    }
    
    public void Delay()
    {
        canAttack = false;
    }

    public void Next()
    {
        SceneManager.LoadScene("___brontosaurus___");

    }

    public void Next2()
    {
        SceneManager.LoadScene("___carnotaurus___ 1");

    }

    public void Next3()
    {
        SceneManager.LoadScene("___parasaurolophus___ 1");

    }

    public void Next4()
    {
        SceneManager.LoadScene("___Pre___");

    }

    public void Next5()
    {
        SceneManager.LoadScene("___Rap___");

    }

    public void Next6()
    {
        SceneManager.LoadScene("___spinosaurus___ 1");

    }

    public void Next7()
    {
        SceneManager.LoadScene("___triceratops___ 1");

    }

    public void Next8()
    {
        SceneManager.LoadScene("___velociraptor___");

    }

    public void Next9()
    {
        SceneManager.LoadScene("___Stego___");

    }

    public void Next10()
    {
        SceneManager.LoadScene("___tiranosaurus___ 1");

    }

    public void Next11()
    {
        SceneManager.LoadScene("___Ankil___ 1");

    }
//before
    public void Before()
    {
        SceneManager.LoadScene("___tiranosaurus___ 1");
    }

    public void Before1()
    {
        SceneManager.LoadScene("___velociraptor___");
    }

    public void Before2()
    {
        SceneManager.LoadScene("___triceratops___ 1");
    }

    public void Before2_1()
    {
        SceneManager.LoadScene("___Stego___");
    }


    public void Before3()
    {
        SceneManager.LoadScene("___spinosaurus___ 1");
    }

    public void Before4()
    {
        SceneManager.LoadScene("___Rap___");
    }

    public void Before5()
    {
        SceneManager.LoadScene("___Pre___");
    }

    public void Before6()
    {
        SceneManager.LoadScene("___parasaurolophus___ 1");
    }

    public void Before7()
    {
        SceneManager.LoadScene("___carnotaurus___ 1");
    }

    public void Before8()
    {
        SceneManager.LoadScene("___brontosaurus___");
    }

    public void Before9()
    {
        SceneManager.LoadScene("___Ankil___ 1");
    }


    ////

    public void ForPlay1()
    {
        SceneManager.LoadScene("___Ankil_Play___");

    }
    public void ForPlay2()
    {
        SceneManager.LoadScene("___brontosaurus_Play___ 1");

    }

    public void ForPlay3()
    {
        SceneManager.LoadScene("___carnotaurus_Play___");

    }

    public void ForPlay4()
    {
        SceneManager.LoadScene("___parasaurolophus_Play___");

    }

    public void ForPlay5()
    {
        SceneManager.LoadScene("___Pre_Play___");

    }

    public void ForPlay6()
    {
        SceneManager.LoadScene("___Raptop_Play___");

    }

    public void ForPlay7()
    {
        SceneManager.LoadScene("___spinosaurus_Play___");

    }

    public void ForPlay8()
    {
        SceneManager.LoadScene("___stegosaurus_Play___");

    }

    public void ForPlay9()
    {
        SceneManager.LoadScene("___triceratops_Play___");

    }

    public void ForPlay10()
    {
        SceneManager.LoadScene("___velociraptor_Play___");

    }

    public void ForPlay11()
    {
        SceneManager.LoadScene("___Tirano_Play___");

    }

    public void Quit()
    {
        Application.Quit();
    }


    
}
